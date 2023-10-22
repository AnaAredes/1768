using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Catalogos
{
    public partial class FormCadastrarProp : Form
    {
        private Proprietario p;
        private List<Catalogo> listaCatalogos = new List<Catalogo>();
        private BaseDados bd = new BaseDados();
        private List<Freguesia> listaFreguesia = new List<Freguesia>();
        private List<Provincia> listaProvincia = new List<Provincia>();
        public FormCadastrarProp()
        {
            InitializeComponent();
            groupBox2.Hide();
            groupBox1.Show();
            listBox1.Items.Clear();
            p = new Proprietario();
            pnlComarcaNao.Hide();
            pnlComarcaSim.Hide();
            pnlFregNao.Hide();
            pnlFregSim.Hide();
            pnlProvSim.Hide();
        }
        private void atualizaDuasDrops()
        {
            bd = new BaseDados();
            List<(string freguesia, string comarca)> listaDrop = new List<(string, string)>();

            List<(string comarca, string provincia)> listaDropComarcas = new List<(string, string)>();
            try
            {
                listaDrop = bd.obterProvinciaComarca();
                listaDropComarcas = bd.conjuntoComarcaProv();
            }
            catch (SqlException et)
            {
                MessageBox.Show("Erro ao carregar Freguesias" + et.Message);
            }
            string comparacao = "Sem informação";
            drop.Items.Clear();
            cmbComarca.Items.Clear();
            foreach (var item in listaDrop)
            {
                if (item.freguesia != comparacao)
                {
                    drop.Items.Add(item.freguesia + ", Comarca: " + item.comarca);
                }
            }
            foreach (var it in listaDropComarcas)
            {
                if (it.comarca != comparacao)
                {
                    cmbComarca.Items.Add(it.comarca + ", Província: " + it.provincia);
                }
            }
        }
        private void atualizaDrop()
        {
            string comparacao = "Sem informação";
            listaProvincia = new List<Provincia>();
            try
            {
                listaProvincia = bd.obterProvincias();
                foreach (Provincia item in listaProvincia)
                {
                    if (item.getDescricaoProvincia() != comparacao)
                    {
                        cmbProvincia.Items.Add(item.getDescricaoProvincia());
                    }
                }
            }
            catch (SqlException et)
            {
                MessageBox.Show("Erro ao carregar as provincias da base de dados" + et.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona um catálogo válido.");
                txtNumero.Clear();
            }
            else
            {
                if (listBox1.Items[listBox1.SelectedIndex].ToString().Contains("Há proprietário cadastrado: "))
                {
                    listBox1.ClearSelected();
                    MessageBox.Show("Existe proprietário cadastrado. Não é possível gravar, somente alterar.");
                }
                else
                {
                    groupBox2.Show();
                    atualizaDuasDrops();
                    atualizaDrop();
                }
            }
        }
        private void btnProprietario_Click(object sender, EventArgs e) { }
        private void bntCancelar1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaCatalogos = new List<Catalogo>();
            bd = new BaseDados();
            listBox1.Items.Clear();
            int doc = 0;
            if (txtNumero.Text.Length < 0)
            {
                MessageBox.Show("Insere um valor numérico válido na caixa de texto.");
            }
            if (int.TryParse(txtNumero.Text, out doc))
            {
                try
                {
                    listaCatalogos = bd.obterCatalogo(doc);
                }
                catch (SqlException et)
                {
                    throw new Exception("Erro na leitura dos registos da base de dados. " + et.Message);
                }
                foreach (Catalogo item in listaCatalogos)
                {
                    try
                    {
                        p = new Proprietario();
                        p = bd.obterProprietarioIdCatalogo(item.getId());
                    }
                    catch (SqlException et)
                    {
                        throw new Exception("Erro na leitura dos proprietários. " + et.Message);
                    }
                    //Proprietario obterProprietarioIdCatalogo(int id)
                    if (p.getId() == 0)
                    {
                        listBox1.Items.Add("Caixa: " + item.getCaixa() + ", Nº do documento: "
                        + item.getNumeroDocumento() + ", Id: " + item.getId() + "---" + "Não há proprietário cadastrado.");
                    }
                    else
                    {
                        listBox1.Items.Add("Caixa: " + item.getCaixa() + ", Nº do documento: "
                        + item.getNumeroDocumento() + ", Id: " + item.getId() + "---" + "Há proprietário cadastrado: " + p.getNome());
                    }
                }
            }
            else
            {
                MessageBox.Show("Insere um valor numérico válido na caixa de texto.");
            }
        }


        private int gravarFreguesia()
        {
            bd = new BaseDados();
            int idFreguesia = -1;
            string selecaoDrop = "";
            string[] parts;

            if (drop.SelectedIndex > -1)
            {
                selecaoDrop = drop.Text.ToString();
                parts = selecaoDrop.Split(new string[] { ", Comarca: " }, StringSplitOptions.RemoveEmptyEntries);
                string freguesia = parts[0];
                string comarca = parts[1];
                try
                {
                    idFreguesia = bd.obterUmaFreguesia(freguesia, comarca);
                }
                catch (SqlException et)
                {
                    MessageBox.Show("Erro ao carregar as provincias da base de dados" + et.Message);
                }
            }
            else
            {
                if (cmbComarca.SelectedIndex > -1)
                {
                    selecaoDrop = cmbComarca.Text.ToString();
                    parts = selecaoDrop.Split(new string[] { ", Província: " }, StringSplitOptions.RemoveEmptyEntries);
                    string comarca = parts[0];
                    string provincia = parts[1];
                    try
                    {
                        idFreguesia = bd.obterIdFreguesiaPelaComarca(comarca, provincia);
                    }
                    catch (SqlException et)
                    {
                        MessageBox.Show("Erro ao carregar a comarca da base de dados" + et.Message);
                    }
                    if (idFreguesia == 0 || idFreguesia == -1)
                    {
                        Freguesia freguesia = new Freguesia();
                        string descricao = "Sem informação";
                        freguesia.setDescricaoFreguesia(descricao);
                        try
                        {
                            bd.guardarFreguesia(freguesia);
                        }
                        catch (SqlException et)
                        {
                            MessageBox.Show("Erro ao gravar local na base de dados" + et.Message);
                        }
                        idFreguesia = freguesia.getId();
                    }
                }
                else
                {
                    if (cmbProvincia.SelectedIndex > -1)
                    {
                        try
                        {
                            idFreguesia = bd.idFreguesiaSemInfo(cmbProvincia.Text);
                        }
                        catch (SqlException et)
                        {
                            MessageBox.Show("Erro ao carregar as provincias da base de dados" + et.Message);
                        }
                    }
                    else
                    {
                        if (rbProvNao.Checked == true)
                        {
                            idFreguesia = 21;
                        }
                        else
                        {
                            MessageBox.Show("Seleciona opções válidas referentes à freguesia, comarca ou província.");
                        }
                    }
                }
            }
            return idFreguesia;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            int idFreguesia = gravarFreguesia();
            int idProprietario = -1;

            if ((string.IsNullOrWhiteSpace(txtNome.Text)) || (idFreguesia == -1))
            {
                MessageBox.Show("Operação recusada. É necessário preencher o nome do proprietário e selecionar uma opção relativa à freguesia.");
            }
            else
            {
                p.setFreguesiaID(idFreguesia);
                //Extrair o Id do catálogo
                string selecao = listBox1.Text.ToString();
                List<int> numeros = new List<int>();
                MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
                foreach (Match match in semelhante)
                {
                    int numero = int.Parse(match.Value);
                    numeros.Add(numero);
                }
                int id = numeros[2];
                p.setCatalogoId(id);
                //atribuir os valores das textBox
                p.setObs(txtObs.Text);
                p.setNome(txtNome.Text);
                p.setOcupacao(txtOcupacao.Text);
                p.setQualificacao(txtQualifica.Text);
                p.setDescricao(txtLocal.Text);
            }
            Hide();
        }
        public Proprietario getPrp() { return p; }
        private void bntFreguesia_Click(object sender, EventArgs e)
        {
            FormCadastrarFreguesia formCadastrarFreguesia = new FormCadastrarFreguesia();
            if (formCadastrarFreguesia.ShowDialog() == DialogResult.Yes)
            {
                drop.Items.Clear();
                atualizaDuasDrops();
            }
        }

        private void rbSim1_CheckedChanged(object sender, EventArgs e)
        {
            pnlFregSim.Show();
            pnlFregNao.Hide();
            rbNao1.Checked = false;
        }
        private void rbNao1_CheckedChanged(object sender, EventArgs e)
        {
            pnlFregNao.Show();
            pnlFregSim.Hide();
            rbSim1.Checked = false;
        }
        private void rdComarcaSim_CheckedChanged(object sender, EventArgs e)
        {
            pnlComarcaSim.Show();
            pnlComarcaNao.Hide();
            rbComarcaNao.Checked = false;
        }
        private void rbComarcaNao_CheckedChanged(object sender, EventArgs e)
        {
            pnlComarcaNao.Show();
            pnlComarcaSim.Hide();
            rdComarcaSim.Checked = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pnlProvSim.Show();
            rbProvNao.Checked = false;
        }
        private void rbProvNao_CheckedChanged(object sender, EventArgs e)
        {
            pnlProvSim.Hide();
            radioButton2.Checked = false;

        }

        private void btnComarca_Click(object sender, EventArgs e)
        {
            FormGravarProvCom formGravar = new FormGravarProvCom();
            if (formGravar.ShowDialog() == DialogResult.Yes)
            {
                atualizaDuasDrops();
            }
        }
    }
}
