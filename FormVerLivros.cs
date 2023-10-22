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
    public partial class FormVerLivros : Form
    {
        public FormVerLivros()
        {
            InitializeComponent();
            lstLivrosProp.Items.Clear();
            drop();
            drop2();
            drop3();
            grp1.Hide();
            grp2.Hide();
            grp3.Hide();
            grp4.Hide();
            grp5.Hide();
        }

        private List<Livro> listaLivros = new List<Livro>();
        private List<Livro> listaTempLivros = new List<Livro>();
        private Livro livro = new Livro();
        private List<Proprietario> listaProprietarios = new List<Proprietario>();
        private List<Proprietario> listaTempProp = new List<Proprietario>();
        private BaseDados bd = new BaseDados();
        private List<Provincia> listaProvincias = new List<Provincia>();
        private List<Comarca> listaComarcas = new List<Comarca>();

        private string extrairUltimoNome(string nome)
        {
            string[] nomeAutor = nome.Split(' ');
            int posicao = nomeAutor.Length;
            string ultimoNome = nomeAutor[posicao - 1];
            return ultimoNome;
        }
        //Método que será usado para retirar o último nome do autor
        private string extrairPrimeirosNomes(string nome)
        {
            string[] nomeAutor = nome.Split(' ');
            nomeAutor = nomeAutor.SkipLast(1).ToArray();
            string primeirosNomes = string.Join(" ", nomeAutor);
            return primeirosNomes;
        }

        //Métodos para povoar as drops
        private void drop()
        {
            listaProprietarios = new List<Proprietario>();
            bd = new BaseDados();
            listaProprietarios = bd.levarTodosProprietarios();
            foreach (var item in listaProprietarios)
            {
                cmbProp.Items.Add(item.getNome());
            }
        }
        private void drop2()
        {
            cmbCategoria.Items.Clear();
            List<string> listaDrop = new List<string>();
            listaDrop.Add("Teologia");
            listaDrop.Add("Jurisprudência");
            listaDrop.Add("Medicina");
            listaDrop.Add("Filosofia");
            listaDrop.Add("Matemática");
            listaDrop.Add("Histórias");
            listaDrop.Add("Livros Políticos");
            listaDrop.Add("Humanidades e Antiguidades Gregas e Romanas");
            listaDrop.Add("Manuscritos");
            listaDrop.Add("Belas Letras");
            listaDrop.Add("Outra");
            foreach (var item in listaDrop)
            {
                cmbCategoria.Items.Add(item);
            }
        }
        private void drop3()
        {
            try
            {
                listaProvincias = bd.obterProvincias();
                foreach (Provincia provincia in listaProvincias)
                {
                    cmbProvincia.Items.Add(provincia.getDescricaoProvincia());
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao carregar as provincias da base de dados");
            }
        }

        //Métodos dos botões iniciais
        private void btn1_Click(object sender, EventArgs e)
        {
            grp2.Hide();
            grp3.Hide();
            grp4.Hide();
            grp5.Hide();
            grp1.Show();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            grp1.Hide();
            grp3.Hide();
            grp4.Hide();
            grp5.Hide();
            grp2.Show();
            txtInfo.Hide();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            grp1.Hide();
            grp2.Hide();
            grp4.Hide();
            grp5.Hide();
            grp3.Show();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            grp1.Hide();
            grp2.Hide();
            grp3.Hide();
            grp5.Hide();
            grp4.Show();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            grp1.Hide();
            grp2.Hide();
            grp3.Hide();
            grp4.Hide();
            grp5.Show();
        }
        private void btn6_Click(object sender, EventArgs e) { /*grp6.Hide();*/ }

        //Método que retorna a lista de proprietários de uma província
        private List<Proprietario> listaProprietariosPorProvincia()
        {
            listaProprietarios = new List<Proprietario>();
            bd = new BaseDados();
            List<int> idComarca = new List<int>();
            int id = -1;
            string nomeProvincia = cmbProvincia.Text;
            try
            {
                listaComarcas = bd.obterComarcasUmaProvincia(nomeProvincia);
                foreach (Comarca item in listaComarcas)
                {
                    id = item.getId();
                    idComarca.Add(id);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao carregar as comarcas da BD");
            }
            try
            {
                foreach (int i in idComarca)
                {
                    listaTempProp = bd.obterProprietarios(i);
                    foreach (var item in listaTempProp)
                    {
                        listaProprietarios.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao carregar Proprietarios da BD");
            }
            return listaProprietarios;
        }

        //Métodos de cada groupBox (cada uma corresponde a um botão do menu inicial,
        //sendo os números indicados nos nomes dos métodos correspondentes ao botão)
        private void button1_Click(object sender, EventArgs e)
        {
            lstLivrosProp.Items.Clear();
            bd = new BaseDados();
            int id = 0;

            if (cmbProp.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona o nome de um proprietário. ");
            }
            else
            {
                try
                {
                    id = bd.extrairIdProp(cmbProp.SelectedItem.ToString());
                }
                catch (SqlException et)
                {
                    MessageBox.Show("Erro ao carregar ao buscar o Id do proprietário: " + et.Message);
                }
                if (id == -1) //método extrairIdProp: define -1 antes da leitura e, se ler, muda.
                {
                    MessageBox.Show("Não encontrado.");
                }
                else
                {
                    try
                    {
                        listaLivros = bd.livrosDeUmProp(id);
                    }
                    catch (SqlException et)
                    {
                        MessageBox.Show("Erro ao carregar a lista de livros: " + et.Message);
                    }
                    if (listaLivros.Count <= 0)
                    {
                        lstLivrosProp.Items.Add("Não há livro cadastrado para este proprietário.");
                    }
                    else
                    {
                        foreach (Livro livro in listaLivros)
                        {
                            string ultimoNome = extrairUltimoNome(livro.getAutor());
                            string primeirosNomes = extrairPrimeirosNomes(livro.getAutor());
                            string nome;
                            if (primeirosNomes.Length == 0)
                            {
                                nome = ultimoNome + ". ";
                            }
                            else
                            {
                                nome = ultimoNome + ", " + primeirosNomes + ". ";
                            }
                            lstLivrosProp.Items.Add(nome + " (" + livro.getAno() + ") - " + livro.getTitulo() + ". Ed." + livro.getEdicao() + ". " + livro.getLocal() + " [" + livro.getFormato() + "].");
                        }
                    }
                }
            }
        }
        private void btnContarLivro1_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            int id = 0;

            if (cmbProp.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona o nome de um proprietário. ");
            }
            else
            {
                try
                {
                    id = bd.extrairIdProp(cmbProp.SelectedItem.ToString());
                }
                catch (SqlException et)
                {
                    MessageBox.Show("Erro ao buscar o Id do proprietário: " + et.Message);
                }
                if (id == -1)
                {
                    MessageBox.Show("Não encontrado.");
                }
                else
                {
                    try
                    {
                        listaLivros = bd.livrosDeUmProp(id);
                    }
                    catch (SqlException et)
                    {
                        MessageBox.Show("Erro ao buscar a lista de livros do proprietário: " + et.Message);
                    }
                    txtContar1.Text = listaLivros.Count().ToString();
                }
            }
        }
        private void bntBuscar2_Click(object sender, EventArgs e)
        {
            lst2.Items.Clear();
            txtInfo.Clear();
            txtInfo.Show();

            bd = new BaseDados();
            listaLivros = new List<Livro>();
            listaProprietarios = new List<Proprietario>();
            List<Proprietario> listaTemp = new List<Proprietario>();
            List<int> listaId = new List<int>();
            int idLivro = -1;

            if (txtTitulo2.Text.Length < 1 || txtAutor2.Text.Length < 1)
            {
                MessageBox.Show("Título e nome do autor são necessários para distinguir as edições.");
            }
            else
            {
                // lista com livros que correpondam aos dados inseridos (pode existir mais de uma edição)
                try
                {
                    listaLivros = bd.lerLivrosMesmoAutorTitulo(txtTitulo2.Text, txtAutor2.Text);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao carregar livro." + ex.Message);
                }
                //lista de ids dos livros
                foreach (Livro item in listaLivros)
                {
                    idLivro = item.getId();
                    listaId.Add(idLivro);
                }
            }
            if (listaLivros.Count <= 0)
            {
                lst2.Items.Add("Não há livros cadastrados que correspondam ao título e ao autor informados.");
            }
            else
            {
                //lista de proprietários a partir dos ids da lista (o método chamado usa a tabela Interação, que possui IdProprietário e IdLivro) 
                foreach (int id in listaId)
                {
                    try
                    {
                        listaTemp = bd.proprietariosUmLivro(id);
                        foreach (Proprietario proprietario in listaTemp)
                        {
                            listaProprietarios.Add(proprietario);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao carregar livro." + ex.Message);
                    }
                }
                foreach (Proprietario item in listaProprietarios)
                {
                    lst2.Items.Add(item.getId() + "- " + item.getQualificacao() + " " + item.getNome() +
                        ", " + item.getOcupacao());
                }
                txtInfo.Text = listaLivros.Count().ToString() + " edições e " + listaProprietarios.Count().ToString() + " proprietários.";
            }
        }
        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            lst3.Items.Clear();
            bd = new BaseDados();
            listaLivros = new List<Livro>();

            if (cmbCategoria.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona categoria.");
            }
            else
            {
                try
                {
                    listaLivros = bd.livrosCategoria(cmbCategoria.Text.ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao carregar livro. " + ex.Message);
                }
                foreach (Livro livro in listaLivros)
                {
                    string ultimoNome = extrairUltimoNome(livro.getAutor());
                    string primeirosNomes = extrairPrimeirosNomes(livro.getAutor());
                    string nome;
                    if (primeirosNomes.Length == 0)
                    {
                        nome = ultimoNome + ". ";
                    }
                    else
                    {
                        nome = ultimoNome + ", " + primeirosNomes + ". ";
                    }
                    lst3.Items.Add(nome + " (" + livro.getAno() + ") - " + livro.getTitulo() + ". Ed." + livro.getEdicao() + ". " + livro.getLocal() + " [" + livro.getFormato() + "].");
                }
                if (listaLivros.Count <= 0)
                {
                    lst3.Items.Add("Não há livros cadastrados nesta categoria.");
                }
            }
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            listaLivros = new List<Livro>();
            if (cmbCategoria.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona categoria.");
            }
            else
            {
                try
                {
                    listaLivros = bd.livrosCategoria(cmbCategoria.Text.ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao carregar livro." + ex.Message);
                }
            }
            txtContagem.Text = listaLivros.Count().ToString();
        }
        private void btnBuscar4_Click(object sender, EventArgs e)
        {
            lst4.Items.Clear();
            listaProprietarios = new List<Proprietario>();
            bd = new BaseDados();
            List<int> idComarca = new List<int>();

            if (cmbProvincia.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona Província.");
            }
            else
            {
                listaProprietarios = listaProprietariosPorProvincia();
                foreach (var item in listaProprietarios)
                {
                    lst4.Items.Add(item.getId() + " - " + item.getQualificacao() + " " + item.getNome() +
                                       ", " + item.getOcupacao());
                }
            }
        }
        private void btnContarProp_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            listaProprietarios = new List<Proprietario>();
            if (cmbProvincia.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona categoria.");
            }
            else
            {
                listaProprietarios = listaProprietariosPorProvincia();
                txtContaProp4.Text = cmbProvincia.Text + ": " + listaProprietarios.Count.ToString();
            }
        }
        private void btnContarLivros_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            listaProprietarios = new List<Proprietario>();
            listaLivros = new List<Livro>();
            listaTempLivros = new List<Livro>();
            int id = -1;
            List<int> listaId = new List<int>();
            if (cmbProvincia.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona categoria.");
            }
            else
            {
                listaProprietarios = listaProprietariosPorProvincia();
                foreach (Proprietario item in listaProprietarios)
                {
                    id = item.getId();
                    listaId.Add(id);
                }
                try
                {
                    foreach (int item in listaId)
                    {
                        listaTempLivros = bd.livrosDeUmProp(item);
                        foreach (var it in listaTempLivros)
                        {
                            listaLivros.Add(it);
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao carregar Proprietarios da BD");
                }
                txtContaLivros4.Text = cmbProvincia.Text + ": " + listaLivros.Count.ToString();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void btnTitulo_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            listaLivros = new List<Livro>();
            if (txtAutor.Text.Length > 0)
            {
                listaLivros = bd.obterLivrosMesmoAutor(txtAutor.Text);
                if (listaLivros.Count > 0)
                {
                    txtContarEd.Text = listaLivros.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Não há livros com a autoria indicada.");
                }
            }
        }
        private void btnAutor_Click(object sender, EventArgs e)
        {
            lst5.Items.Clear();
            bd = new BaseDados();
            listaProprietarios = new List<Proprietario>();
            List<Proprietario> listaTempProp = new List<Proprietario>();
            listaLivros = new List<Livro>();
            if (txtAutor.Text.Length > 0)
            {
                listaLivros = bd.obterLivrosMesmoAutor(txtAutor.Text);
                foreach (Livro livro in listaLivros)
                {
                    listaTempProp = bd.obterProprietariosMesmoAutor(livro.getId());
                    foreach (Proprietario item in listaTempProp)
                    {
                        listaProprietarios.Add(item);
                    }
                }
                if (listaProprietarios.Count > 0)
                {
                    foreach (Proprietario item in listaProprietarios)
                    {
                        lst5.Items.Add(item.getId() + " - " + item.getQualificacao() + " " + item.getNome() +
                                       ", " + item.getOcupacao());
                    }
                }
                else
                {
                    MessageBox.Show("Não há livros com a autoria indicada.");
                }
            }
            else
            {
                MessageBox.Show("Informa o nome do autor.");
            }
        }
        private void btnBuscar5_Click(object sender, EventArgs e)
        {
            lst5.Items.Clear();
            bd = new BaseDados();
            listaLivros = new List<Livro>();
            if (txtAutor.Text.Length > 0)
            {
                listaLivros = bd.obterLivrosMesmoAutor(txtAutor.Text);
                if (listaLivros.Count > 0)
                {
                    foreach (Livro livro in listaLivros)
                    {
                        lst5.Items.Add(livro.getId() + " - (" + livro.getAno() + ") - " + livro.getTitulo() + ". Ed." + livro.getEdicao() + ". " + livro.getLocal() + " [" + livro.getFormato() + "].");
                    }
                }
                else
                {
                    MessageBox.Show("Não há livros com a autoria indicada.");
                }
            }
            else
            { MessageBox.Show("Informa o nome do autor ou o título do livro."); }
        }
    }
}