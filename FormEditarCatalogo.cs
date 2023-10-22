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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Gestao_Catalogos
{
    public partial class FormEditarCatalogo : Form
    {
        private Proprietario p;
        private List<Catalogo> listaCatalogos = new List<Catalogo>();
        private BaseDados bd = new BaseDados();
        private List<Freguesia> listaFreguesia = new List<Freguesia>();
        private List<Provincia> listaProvincia = new List<Provincia>();
        public FormEditarCatalogo()
        {
            InitializeComponent();
            groupBox1.Show();
            groupBox2.Hide();
            atualizaDuasDrops();
            atualizaDrop();
            listBox1.Items.Clear();
            pnlComarcaNao.Hide();
            pnlComarcaSim.Hide();
            pnlFregNao.Hide();
            pnlFregSim.Hide();
            pnlProvSim.Hide();
            p = new Proprietario();
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int doc = int.Parse(txtNumero.Text);
            List<Catalogo> listaCatalogos = new List<Catalogo>();
            List<Proprietario> listaProprietario = new List<Proprietario>();
            try
            {
                listaCatalogos = bd.obterCatalogo(doc);
                listaProprietario = bd.obterProprietariosComNumeroDoc(doc);
            }
            catch (SqlException et)
            {
                throw new Exception("Erro na leitura dos registos da base de dados. " + et.Message);
            }
            foreach (Catalogo item in listaCatalogos)
            {
                listBox1.Items.Add("Numero do documento: " + item.getNumeroDocumento() + "  - Id: " + item.getId());
            }
            if (listaProprietario.Count > 0)
            {
                foreach (Proprietario item in listaProprietario)
                {
                    listBox2.Items.Add("Id: " + item.getId() + " - Nome do Proprietário: " + item.getNome() + " - Id do Catálogo: " + item.getCatalogoId());
                }
            }
            else
            {
                listBox2.Items.Add("Não há proprietário cadastrado neste documento.");
            }
        }
        private int idCatalogo()
        {
            int id = -1;
            if (listBox1.SelectedIndex > -1)
            {
                string selecao = listBox1.Text.ToString();
                List<int> numeros = new List<int>();
                MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
                foreach (Match match in semelhante)
                {
                    int numero = int.Parse(match.Value);
                    numeros.Add(numero);
                }
                id = numeros[1];
            }
            if (listBox2.SelectedIndex > -1)
            {
                string selecao = listBox2.Text.ToString();
                List<int> numeros = new List<int>();
                MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
                foreach (Match match in semelhante)
                {
                    int numero = int.Parse(match.Value);
                    numeros.Add(numero);
                }
                id = numeros[1];
            }
            return id;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            p = new Proprietario();
            bd = new BaseDados();
            int idFreguesia = -1;
            Proprietario completo = completarBoxes();
            int idProp = completo.getId();
            //     int idProprietario = -1;
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Obrigatório preencher o nome do proprietário. Operação recusada.");
            }
            else
            {
                //Extrair o Id do catálogo
                int idCat = idCatalogo();
                if (idCat == -1)
                {
                    MessageBox.Show("Falha ao obter o ID do Catálogo. Operação recusada");
                    groupBox2.Hide();
                }
                else
                {
                    p.setId(idProp);
                    p.setCatalogoId(idCat);
                    //atribuir os valores das textBox
                    p.setObs(txtObs.Text);
                    p.setNome(txtNome.Text);
                    p.setOcupacao(txtOcupacao.Text);
                    p.setQualificacao(txtQualifica.Text);
                    p.setDescricao(txtLocal.Text);
                    p.setFreguesiaID(gravarFreguesia());
                }
            }
            Hide();
        }
        public Proprietario getPrp() { return p; }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            p = new Proprietario();
            p = completarBoxes();
            int id = p.getId();
            bd.excluirProprietario(id);
            MessageBox.Show("Excluído com sucesso.");
            Hide();
        }
        private void bntCancelar_Click(object sender, EventArgs e) { Hide(); }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                groupBox2.Show();
                atualizaDuasDrops();
                atualizaDrop();
                bd = new BaseDados();
                Proprietario completo = new Proprietario();
                string selecao = listBox1.SelectedItem.ToString();
                List<int> numeros = new List<int>();
                MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
                foreach (Match match in semelhante)
                {
                    int numero = int.Parse(match.Value);
                    numeros.Add(numero);
                }
                int id = numeros[1];
                try
                {
                    completo = bd.obterProprietarioIdCatalogo(id);
                }
                catch (SqlException et)
                {
                    throw new Exception("Erro na leitura do registo do propritário. " + et.Message);
                }
                txtNome.Text = completo.getNome();
                txtLocal.Text = completo.getDescricaoLocalizacao();
                txtObs.Text = completo.getObs();
                txtOcupacao.Text = completo.getOcupacao();
                txtQualifica.Text = completo.getQualificacao();
                int idFreg = completo.getFreguesiaId();

                List<(string freguesia, string comarca)> resultados = new List<(string, string)>();
                try
                {
                    resultados = bd.obterNomeFreguesia(idFreg);
                }
                catch (SqlException et)
                {
                    throw new Exception("Erro na leitura do registo do propritário. " + et.Message);
                }
                if (resultados.Count > 0)
                {
                    string pfreguesia = resultados[0].freguesia;
                    string pcomarca = resultados[0].comarca;
                    drop.Text = (pfreguesia + ", Comarca: " + pcomarca);
                }
            }
            else
            {
                MessageBox.Show("Seleciona um catalogo.");
                txtNumero.Clear();
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                string selecao = listBox2.SelectedItem.ToString();

                if (selecao == "Não há proprietário cadastrado neste documento.")
                {
                    MessageBox.Show("Operação inválida");
                    Hide();
                }
                else
                {
                    groupBox2.Show();
                    atualizaDrop();
                    atualizaDuasDrops();
                    bd = new BaseDados();
                    Proprietario completo = new Proprietario();
                    List<int> numeros = new List<int>();
                    MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
                    foreach (Match match in semelhante)
                    {
                        int numero = int.Parse(match.Value);
                        numeros.Add(numero);
                    }
                    int idC = numeros[1];
                    try
                    {
                        completo = bd.obterProprietarioIdCatalogo(idC);
                    }
                    catch (SqlException et)
                    {
                        throw new Exception("Erro na leitura do registo do propritário. " + et.Message);
                    }
                    txtNome.Text = completo.getNome();
                    txtLocal.Text = completo.getDescricaoLocalizacao();
                    txtObs.Text = completo.getObs();
                    txtOcupacao.Text = completo.getOcupacao();
                    txtQualifica.Text = completo.getQualificacao();
                    int idFreg = completo.getFreguesiaId();
                    List<(string freguesia, string comarca)> resultados = new List<(string, string)>();
                    try
                    {
                        resultados = bd.obterNomeFreguesia(idFreg);
                    }
                    catch (SqlException et)
                    {
                        throw new Exception("Erro na leitura da Freguesia. " + et.Message);
                    }
                    if (resultados.Count > 0)
                    {
                        string pfreguesia = resultados[0].freguesia;
                        string pcomarca = resultados[0].comarca;
                        drop.Text = (pfreguesia + ", Comarca: " + pcomarca);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleciona um catalogo.");
                txtNumero.Clear();
            }
        }
        private Proprietario completarBoxes()
        {
            bd = new BaseDados();
            Proprietario completo = new Proprietario();
            int id = idCatalogo();
            completo = bd.obterProprietarioIdCatalogo(id);
            return completo;
        }
        private void bntFreguesia_Click(object sender, EventArgs e)
        {
            FormCadastrarFreguesia formCadastrarFreguesia = new FormCadastrarFreguesia();
            if (formCadastrarFreguesia.ShowDialog() == DialogResult.Yes)
            {
                drop.Items.Clear();
                atualizaDuasDrops();
                atualizaDrop();
            }
        }
        private int gravarFreguesia()
        {
            bd = new BaseDados();
            int idFreguesia = -1;
            int idProprietario = -1;
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
                    //  idProprietario = bd.obterIdProprietario();
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
                            //    freguesia.setComarcaId(bd.obterIdComarca(comarca, provincia));
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Hide();
        }
              

       
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}
