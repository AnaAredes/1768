using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Catalogos
{
    public partial class FormAlterarFregCat : Form
    {
        private Freguesia novaFreguesia = new Freguesia();
        private Comarca novaComarca = new Comarca();
        private Provincia novaProvincia = new Provincia();
        private List<Provincia> provincias = new List<Provincia>();
        private BaseDados bd = new BaseDados();
        private List<Comarca> listaComarcas = new List<Comarca>();
        public FormAlterarFregCat()
        {
            InitializeComponent();
            iniciarLista();
            povoarBox();
            grp1.Hide();
        }
        private void iniciarLista()
        {
            try
            {
                provincias = bd.obterProvincias();
                foreach (Provincia item in provincias)
                {
                    novaProvincia = item;
                    checkProvincia.Items.Add(novaProvincia.getDescricaoProvincia());
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao carregar as provincias da base de dados");
            }
        }
        private void checkProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkProvincia.SelectedIndex > -1)
            {
                checkComarca.Items.Clear();
                int selectedProvinciaIndex = checkProvincia.SelectedIndex + 1;
                bd = new BaseDados();
                try
                {
                    listaComarcas = bd.obterComarcas(selectedProvinciaIndex);
                    foreach (Comarca comarca in listaComarcas)
                    {
                        checkComarca.Items.Add(comarca.getDescricao_Comarca());
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao carregar as comarcas da BD");
                }
            }
            else
            {
                checkComarca.Items.Clear();
            }
        }
        private void bntGravarComarca_Click(object sender, EventArgs e)
        {
            FormGravarProvCom formGravar = new FormGravarProvCom();
            if (formGravar.ShowDialog() == DialogResult.Yes)
            {
                iniciarLista();
                //   povoarBox();
            }
        }
        private void povoarBox()
        {
            bd = new BaseDados();
            List<(string freguesia, string comarca)> listaDrop = new List<(string, string)>();
            try
            {
                listaDrop = bd.obterProvinciaComarca();
            }
            catch (SqlException et)
            {
                MessageBox.Show("Erro ao carregar Freguesias" + et.Message);
            }
            string comparacao = "Sem informação";
            cmbFreguesia.Items.Clear();
            foreach (var item in listaDrop)
            {
                if (item.freguesia != comparacao)
                {
                    cmbFreguesia.Items.Add(item.freguesia + ", Comarca: " + item.comarca);
                }
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            string selecaoDrop = "";
            string[] parts;
            int idFreguesia = -1;
            if (cmbFreguesia.SelectedIndex > -1)
            {
                selecaoDrop = cmbFreguesia.Text.ToString();
                parts = selecaoDrop.Split(new string[] { ", Comarca: " }, StringSplitOptions.RemoveEmptyEntries);
                string freguesia = parts[0];
                string comarca = parts[1];
                try
                {
                    idFreguesia = bd.obterUmaFreguesia(freguesia, comarca);
                }
                catch (SqlException et)
                {
                    MessageBox.Show("Erro ao carregar a comarca da base de dados" + et.Message);
                }

                if (checkComarca.SelectedIndex > -1)
                {
                    novaFreguesia = new Freguesia();
                    novaComarca = new Comarca();

                    string comarcaSelecionada = checkComarca.Text;
                    int provinciaSelecionada = checkProvincia.SelectedIndex + 1;
                    novaFreguesia.setDescricaoFreguesia(txtNomFreguesia.Text);
                    novaFreguesia.setId(idFreguesia);
                    try
                    {
                        novaFreguesia.setComarcaId(bd.idUmaComarca(comarcaSelecionada, provinciaSelecionada));

                        bd.alterarFreguesia(novaFreguesia);

                        MessageBox.Show("A freguesia guardada é: " + novaFreguesia.getDescricao_freguesia()
                            + ". Id da Comarca: " + novaFreguesia.getComarcaId());
                    }
                    catch (SqlException et)
                    {
                        MessageBox.Show("Erro ao carregar o Id da base de dados: " + et.Message);
                    }
                    catch (ArgumentOutOfRangeException et)
                    {
                        MessageBox.Show("Erro ao extrair o id da Comarca: " + et.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Seleciona uma Comarca. Alteração inválida");
                }
            }
            else
            {
                MessageBox.Show("Seleciona uma freguesia. Alteração inválida");
            }
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmbFreguesia_SelectedIndexChanged(object sender, EventArgs e)
        {
            grp1.Show();
        }
    }
}
