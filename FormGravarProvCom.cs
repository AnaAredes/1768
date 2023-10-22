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
    public partial class FormGravarProvCom : Form
    {
        private Comarca comarca = new Comarca();
        private List<Provincia> listaProvincia = new List<Provincia>();
        private BaseDados bd = new BaseDados();

        public FormGravarProvCom()
        {
            InitializeComponent();
            atualizaDrop();
        }

        private void atualizaDrop()
        {
            listaProvincia = new List<Provincia>();
            try
            {
                listaProvincia = bd.obterProvincias();
                foreach (Provincia item in listaProvincia)
                {
                    cmbProvincia.Items.Add(item.getDescricaoProvincia());
                }
            }
            catch (SqlException et)
            {
                MessageBox.Show("Erro ao carregar as provincias da base de dados" + et.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            comarca = new Comarca();
            bd = new BaseDados();
            int idProvincia = 0;

            if (cmbProvincia.SelectedIndex <= -1)
            {
                MessageBox.Show("Obrigatório selecionar o nome da Província. Operação recusada.");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtComarca.Text))
                {
                    MessageBox.Show("Obrigatório preencher o nome da Comarca. Operação recusada.");
                }
                else
                {
                    comarca.setDescricaoComarca(txtComarca.Text);
                    try
                    {
                        idProvincia = bd.lerIdProvincia(cmbProvincia.Text);
                    }
                    catch (SqlException et)
                    {
                        MessageBox.Show("Erro ao carregar o Id da Província: " + et.Message);
                    }
                    if (idProvincia == -1)
                    {
                        MessageBox.Show("Erro ao localizar o Id da Província.");
                    }
                    else
                    {
                        comarca.setProvinciaId(idProvincia);
                       try
                        {
                            bd.guardarComarca(comarca);
                            MessageBox.Show("Gravado com sucesso.");
                        }
                        catch (SqlException et)
                        {
                            MessageBox.Show("Erro ao guardar a Comarca na base de dados: " + et.Message);
                        }
                    }
                }
            }
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
