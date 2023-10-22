using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Neste Form, a única opção válida é apagar e alterar todos os livros. O botão "Apagar ou Editar Livros registados em um Catálogo" (button1)
//não está visivél ao utilizador, pois as ações que ele desencadeia não funcionam de modo satisfatório.  

namespace Gestao_Catalogos
{
    public partial class FormApagarEditarLivros : Form
    {
        private Livro l = new Livro();
        private List<Catalogo> listaCatalogos = new List<Catalogo>();
        private BaseDados bd = new BaseDados();
        private List<Livro> listaLivros = new List<Livro>();
        private Catalogo catalogo = new Catalogo();
        private Interacao interacao = new Interacao();
        private Proprietario proprietario = new Proprietario();
        private Livro livroCompleto = new Livro();
        private List<Proprietario> listaProprietario = new List<Proprietario>();

        public FormApagarEditarLivros()
        {
            InitializeComponent();
            grp1.Show();
            grp2.Hide();
            grp3.Hide();
            grp4.Hide();
            grp5.Hide();
            drop();
            drop2();
            drop3();
            button1.Hide();
        }

        //Métodos para povoar as comboBoxes
        private void drop()
        {
            cmbFormato.Items.Clear();
            List<string> listaDrop = new List<string>();
            listaDrop.Add("folio");
            listaDrop.Add("4to");
            listaDrop.Add("8to");
            listaDrop.Add("12to");
            listaDrop.Add("manuscrito");
            foreach (var item in listaDrop)
            {
                cmbFormato.Items.Add(item);
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
            listaProprietario = new List<Proprietario>();
            bd = new BaseDados();
            listaProprietario = bd.levarTodosProprietarios();
            foreach (var item in listaProprietario)
            {
                cmbProp.Items.Add(item.getNome());
            }
        }
        private List<Livro> dropTitulos(int id)
        {
            listaLivros = new List<Livro>();
            bd = new BaseDados();
            listaLivros = bd.livrosDeUmProp(id);
            return listaLivros;
        }
        //Métodos para os botões do menu principal
        private void btnApEdLivro_Click(object sender, EventArgs e)
        {
            grp1.Show();
            grp2.Show();
            grp3.Hide();
            grp4.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grp1.Show();
            grp2.Hide();
            grp3.Hide();
            grp4.Show();
        }
        private void btnCancelar1_Click(object sender, EventArgs e) { Hide(); }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            bd = new BaseDados();
            listaLivros = new List<Livro>();
            if (txtTitulo.Text.Length > 0)
            {
                try { listaLivros = bd.obterLivrosMesmoTitulo(txtTitulo.Text); }
                catch (SqlException et) { MessageBox.Show("Erro ao obter o Título na Base de Dados." + et.Message); }

                if (listaLivros.Count > 0)
                {
                    MessageBox.Show("Foi encontrado um ou mais títulos correspondentes ao informado. Verifique se há correspondência entre as edições.");
                    foreach (Livro livro in listaLivros)
                    {
                        listBox1.Items.Add(livro.getId() + " - Autor: " + livro.getAutor() + ". Ano: " + livro.getAno()
                           + ". Local: " + livro.getLocal() + ". Edição: " + livro.getEdicao() + ". Formato: " + livro.getFormato() + ".");
                    }
                }
                else
                {
                    MessageBox.Show("Não foi encontrado título correspondente. Informa outro título.");
                }
            }
            else
            {
                MessageBox.Show("É preciso inserir um título.");
            }
        }
        private int selecaoListBox()
        {
            int id = -1;
            string selecao = listBox1.SelectedItem.ToString();
            List<int> numeros = new List<int>();
            MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
            foreach (Match match in semelhante)
            {
                int numero = int.Parse(match.Value);
                numeros.Add(numero);
            }
            id = numeros[0];
            return id;
        }
        private int selecaoListBoxLivro()
        {
            int id = -1;
            string selecao = listBox2.SelectedItem.ToString();
            List<int> numeros = new List<int>();
            MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
            foreach (Match match in semelhante)
            {
                int numero = int.Parse(match.Value);
                numeros.Add(numero);
            }
            id = numeros[0];
            return id;
        }
        private void btnEditarLivro_Click(object sender, EventArgs e)
        {
            int id = selecaoListBox();
            bd = new BaseDados();
            livroCompleto = new Livro();

            if (listBox1.SelectedIndex > -1)
            {
                MessageBox.Show("Este livro será modificado em todos os catálogos que o listam.");
                grp3.Show();
                grp4.Hide();
                grp5.Hide();
                btnGravar.Show();
                try
                {
                    livroCompleto = bd.obterLivroComId(id);
                }
                catch (SqlException et) { throw new Exception("Erro na leitura do registo do propritário. " + et.Message); }
                txtTitulo2.Text = livroCompleto.getTitulo();
                txtAno.Text = livroCompleto.getAno().ToString();
                txtAutor.Text = livroCompleto.getAutor();
                txtEdicao.Text = livroCompleto.getEdicao().ToString();
                txtLocal.Text = livroCompleto.getLocal();
                cmbFormato.Text = livroCompleto.getFormato();
            }
            else
            {
                MessageBox.Show("Seleciona uma edição na lista ao lado.");
            }
        }
        private void btnCancel2_Click(object sender, EventArgs e) { Hide(); }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            int id = selecaoListBox();

            int ano = 0;
            int ed = 0;
            bd = new BaseDados();
            l = new Livro();
            l.setId(id);
            l.setLocal(txtLocal.Text);
            l.setAutor(txtAutor.Text);
            l.setFormato(cmbFormato.SelectedText.ToString());
            l.setTitulo(txtTitulo2.Text);

            try
            {
                l.setAno(Int32.Parse(txtAno.Text));
                l.setEdicao(Int32.Parse(txtEdicao.Text));
            }
            catch (ArgumentNullException et)
            {
                MessageBox.Show("Ano ou Edição em branco. É preciso preencher estes campos." + et.Message);
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Ano e Edição devem ser preenchidos com um valor inteiro." + ee.Message);
            }
            catch (OverflowException ef)
            {
                MessageBox.Show("Ano e Edição devem ser preenchidos com um valor inteiro válido." + ef.Message);
            }
            try
            {
                bd.alterarLivro(l);
                MessageBox.Show("Livro alterado com sucesso.");
                grp3.Hide();
            }
            catch (SqlException eg)
            {
                throw new Exception("Erro ao alterar livro na Base de Dados." + eg.Message);
            }
            listBox1.Items.Clear();

        }
        private void btnApagarLivro_Click(object sender, EventArgs e)
        {
            int id = selecaoListBox();
            bd = new BaseDados();
            try
            {
                bd.excluirInteracao(id);
                bd.excluirLivro(id);
                MessageBox.Show("Livro excluído com sucesso.");
                grp3.Hide();
                listBox1.Items.Clear();
                txtTitulo.Clear();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar livro na Base de Dados." + ex.Message);
            }
            listBox1.Items.Clear();
        }
        private void btnOk1_Click(object sender, EventArgs e)
        {
            lstProp.Items.Clear();
            listaProprietario = new List<Proprietario>();
            listaCatalogos = new List<Catalogo>();
            listaLivros = new List<Livro>();
            bd = new BaseDados();

            if (cmbProp.SelectedItem == null)
            {
                MessageBox.Show("É necessário selecionar o nome do proprietario.");
            }
            else
            {

                string nomeSelecionado = cmbProp.SelectedItem.ToString();
                try
                {
                    listaProprietario = bd.buscaProprietarioNome(nomeSelecionado);

                    foreach (Proprietario item in listaProprietario)
                    {
                        listaLivros = new List<Livro>();
                        listaLivros = bd.livrosDeUmProp(item.getId());
                        int nlivros = listaLivros.Count();
                        if (nlivros > 0)
                        {
                            MessageBox.Show("Caso o proprietário tenha livros cadastrados, os seus dados serão exibidos na lista a seguir.");
                            lstProp.Items.Add("Id do Proprietário: " + item.getId() + ". Proprietario: " + item.getQualificacao()
                                                      + " " + item.getNome() + " " + item.getOcupacao() + "." + "Id do Catálogo: " + item.getCatalogoId());
                        }
                    }
                }
                catch (SqlException et)
                {
                    throw new Exception("Erro na leitura dos catálogos. " + et.Message);
                }
            }
        }

        private int selecaoListBoxProp()
        {
            int id = -1;
            string selecao = lstProp.SelectedItem.ToString();
            List<int> numeros = new List<int>();
            MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
            foreach (Match match in semelhante)
            {
                int numero = int.Parse(match.Value);
                numeros.Add(numero);
            }
            id = numeros[0];
            return id;
        }
        private void lstProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTitulo.Items.Clear();
            int id = selecaoListBoxProp();
            listaLivros = new List<Livro>();
            if (lstProp.SelectedItems.Count > -1)
            {
                listaLivros = dropTitulos(id);
            }
            foreach (Livro item in listaLivros)
            {
                cmbTitulo.Items.Add(item.getTitulo());
            }
        }
        private void btnbtnBuscarT(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            bd = new BaseDados();
            listaLivros = new List<Livro>();
            int idProprietario = selecaoListBoxProp();
            if (cmbTitulo.Text.Length > 0)
            {
                try
                {
                    listaLivros = bd.obterLivroUmProprietario(cmbTitulo.Text, idProprietario);
                }
                catch (SqlException et)
                { MessageBox.Show("Erro ao obter o Título na Base de Dados." + et.Message); }
                if (listaLivros.Count > 0)
                {
                    foreach (Livro livro in listaLivros)
                    {
                        listBox2.Items.Add(livro.getId() + " - Autor: " + livro.getAutor() + ". Ano: " + livro.getAno()
                           + ". Local: " + livro.getLocal() + ". Edição: " + livro.getEdicao() + ". Formato: " + livro.getFormato());
                    }
                }
                else
                {
                    MessageBox.Show("Não foi encontrado título correspondente. Informa as características do livro.");
                }
            }
            else
            {
                MessageBox.Show("É preciso inserir um título.");
            }
        }
        private void btnApagarLivroCatalogo_Click(object sender, EventArgs e)
        {
            int idproprietario = selecaoListBoxProp();
            int idlivro = selecaoListBoxLivro();

            bd = new BaseDados();
            try
            {
// FALTA
              // método bd que exclua as interações com o Id do livro e o Id do proprietário 
              //
                MessageBox.Show("Excluído com sucesso.");
                listBox2.Items.Clear();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar livro na Base de Dados." + ex.Message);
            }
        }
        private void btnEditarLivroCatalogo_Click(object sender, EventArgs e)
        {
            grp3.Show();
            grp5.Show();
            btnGravar.Hide();

            bd = new BaseDados();
            livroCompleto = new Livro();
            interacao = new Interacao();

            int idLivro = selecaoListBoxLivro();

            if (listBox2.SelectedIndex <= -1)
            {
                MessageBox.Show("Seleciona uma edição.");
            }
            else
            {
                try
                {
                    livroCompleto = bd.obterLivroComId(idLivro);
                }
                catch (SqlException et)
                { throw new Exception("Erro na leitura do registo do propritário. " + et.Message); }
                txtTitulo2.Text = livroCompleto.getTitulo();
                txtAno.Text = livroCompleto.getAno().ToString();
                txtAutor.Text = livroCompleto.getAutor();
                txtEdicao.Text = livroCompleto.getEdicao().ToString();
                txtLocal.Text = livroCompleto.getLocal();
                cmbFormato.Text = livroCompleto.getFormato();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bd = new BaseDados();
            l = new Livro();
            int idLivro = 0;
            int idLivroAntigo = selecaoListBoxLivro();

            int idInteracao = -1;
            int idProprietario = selecaoListBoxProp();
            grp3.Show();
            grp5.Show();
            btnGravar.Hide();
            l.setLocal(txtLocal.Text);
            l.setAutor(txtAutor.Text);
            l.setFormato(cmbFormato.SelectedText.ToString());
            l.setTitulo(txtTitulo2.Text);
            try
            {
                l.setAno(Int32.Parse(txtAno.Text));
                l.setEdicao(Int32.Parse(txtEdicao.Text));

                interacao.setNExemplar(Int32.Parse(txtNumeroExemplares.Text));
            }
            catch (ArgumentNullException)
            {
                throw new Exception("Ano ou Edição em branco. É preciso preencher estes campos.");
            }
            catch (FormatException)
            {
                throw new Exception("Ano e Edição devem ser preenchidos com um valor inteiro.");
            }
            catch (OverflowException)
            {
                throw new Exception("Ano e Edição devem ser preenchidos com um valor inteiro válido.");
            }

            try
            {
                bd.guardarLivro(l);
                idLivro = bd.lerIdLivro(l);
                idInteracao = bd.localizarIdInteracao(idProprietario, idLivroAntigo);
            }
            catch (SqlException et)
            {
                MessageBox.Show("Erro ao guardar e buscar id do livro na Base de Dados." + et.Message);
            }
            if (idLivro == -1)
            {
                MessageBox.Show("Id do livro é inválido.");
            }
            else
            {
                interacao = new Interacao();
                interacao.setLId(idLivro);
                interacao.setCategoria(cmbCategoria.SelectedText.ToString());
                interacao.setPId(idProprietario);
                interacao.setId(idInteracao);

                try
                {
                    bd.alterarInteracao(interacao);
                    MessageBox.Show("Alteração realizada.");
                    Hide();
                }
                catch (SqlException ex)
                {
                    throw new Exception("Erro ao alterar a interaxcao na Base de Dados." + ex.Message);
                }
            }

        }
    }
}