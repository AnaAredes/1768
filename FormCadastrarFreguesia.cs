using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Catalogos
{
    public partial class FormCadastrarFreguesia : Form
    {
        private Freguesia novaFreguesia = new Freguesia();
        private Comarca novaComarca = new Comarca();
        private Provincia novaProvincia = new Provincia();
        private List<Provincia> provincias = new List<Provincia>();
        private BaseDados bd = new BaseDados();
        private List<Comarca> listaComarcas = new List<Comarca>();
        public FormCadastrarFreguesia()
        {
            InitializeComponent();
            iniciarLista();
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (checkComarca.SelectedIndex > -1)
            {
                novaFreguesia = new Freguesia();
                novaComarca = new Comarca();
                string comarcaSelecionada = checkComarca.Text;
                MessageBox.Show(comarcaSelecionada);
                int provinciaSelecionada = checkProvincia.SelectedIndex + 1;
                novaFreguesia.setDescricaoFreguesia(txtNomeFreguesia.Text);
                try
                {
                    novaFreguesia.setComarcaId(bd.idUmaComarca(comarcaSelecionada, provinciaSelecionada));

                    bd.guardarFreguesia(novaFreguesia);

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
                MessageBox.Show("Seleciona uma Comarca. Gravação inválida");
            }
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void checkComarca_SelectedIndexChanged(object sender, EventArgs e) { }

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
            }
        }
    }
}
