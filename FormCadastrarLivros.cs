using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Gestao_Catalogos
{
    public partial class FormCadastrarLivros : Form
    {
        private Livro l = new Livro();
        private List<Catalogo> listaCatalogos = new List<Catalogo>();
        private BaseDados bd = new BaseDados();
        private List<Livro> listaLivros = new List<Livro>();
        //        private Catalogo catalogo = new Catalogo();
        private Interacao interacao = new Interacao();
        //        private Proprietario proprietario = new Proprietario();
        private List<Proprietario> listaProprietario = new List<Proprietario>();
        public FormCadastrarLivros()
        {
            InitializeComponent();
            l = new Livro();
            drop();
            drop2();
            drop3();
            listBox1.Items.Clear();
            lstProp.Items.Clear();
            grpLivroCadastrado.Hide();
            grpCadastrarLivro.Hide();
            grpCatalogo.Hide();
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
        //Método para tratar da seleção de uma categoria nova (fora daquelas que povoam a drop)
        private void selecaoComboBox()
        {
            //Se selecionar o último item
            if (cmbCategoria.SelectedIndex == cmbCategoria.Items.Count - 1)
            {
                // Exibir um campo de entrada para adicionar uma nova opção
                string newOption = Microsoft.VisualBasic.Interaction.InputBox("Digite a outra categoria:", "Nova Opção", "");
                // Se não for vazio, adicionar e selecionar a nova opção
                if (!string.IsNullOrEmpty(newOption))
                {
                    cmbCategoria.Items.Insert(cmbCategoria.Items.Count - 1, newOption);
                    cmbCategoria.SelectedIndex = cmbCategoria.Items.Count - 2;
                }
                // Se for vazio, desselecionar
                else
                {
                    cmbCategoria.SelectedIndex = -1;
                }
            }
        }

        //Método para retornar o id a partir da seleção na listBox
        private int selecaoListBox()
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

        //Métodos associados aos botões
        private void btnOk_Click(object sender, EventArgs e)
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
                    grpLivroCadastrado.Show();
                    grpCadastrarLivro.Hide();
                    grpCatalogo.Hide();
                    MessageBox.Show("Foi encontrado um ou mais títulos correspondentes ao informado. Verifique se há correspondência entre as edições.");
                    foreach (Livro livro in listaLivros)
                    {
                        listBox1.Items.Add(livro.getId() + " - Autor: " + livro.getAutor() + ". Ano: " + livro.getAno()
                           + ". Local: " + livro.getLocal() + ". Edição: " + livro.getEdicao() + ". Formato: " + livro.getFormato());
                    }
                }
                else
                {
                    MessageBox.Show("Não foi encontrado título correspondente. Informa as características do livro.");
                    grpCadastrarLivro.Show();
                }
            }
            else
            {
                MessageBox.Show("É preciso inserir um título.");
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            l = new Livro();
            bool possivelGravar = true;
            bd = new BaseDados();
            int ed = -1;
            int ano = -1;

            l.setTitulo(txtTitulo.Text);
            l.setAutor(txtAutor.Text);
            l.setLocal(txtLocal.Text);
            l.setFormato(cmbFormato.SelectedItem.ToString());

            if ((txtAno.Text.Length <= 0) || (txtEdicao.Text.Length <= 0))
            {
                l.setAno(0);
                l.setEdicao(0);
            }
            else
            {
                if ((int.TryParse(txtAno.Text, out ano)) && (int.TryParse(txtEdicao.Text, out ed)))
                {
                    l.setAno(ano);
                    l.setEdicao(ed);
                }
                else
                {
                    possivelGravar = false;
                }
            }
            if (possivelGravar == true)
            {
                try
                {
                    bd.guardarLivro(l);
                    MessageBox.Show("Livro gravado.");
                }
                catch (SqlNullValueException et) { MessageBox.Show("Erro ao determinar o ID" + et.Message); }
                catch (SqlException ex) { MessageBox.Show("Erro em gravar." + ex.Message); }
                grpLivroCadastrado.Show();
                try { listaLivros = bd.obterLivrosMesmoTitulo(l.getTitulo()); }
                catch (SqlException et) { MessageBox.Show("Erro ao obter o Título na Base de Dados." + et.Message); }
                MessageBox.Show("Marca a edição correspondente à gravada.");
                foreach (Livro livro in listaLivros)
                {
                    listBox1.Items.Add(livro.getId() + " - Autor: " + livro.getAutor() + ". Ano: " + livro.getAno()
                       + ". Local: " + livro.getLocal() + ". Edição: " + livro.getEdicao() + ". Formato: " + livro.getFormato());
                }
            }
            else
            {
                MessageBox.Show("Insira valores válidos para o ano e a edição: vazios (0) ou números. Operação recusada.");
            }
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            l = new Livro();
            bd = new BaseDados();
            if (listBox1.SelectedIndex > -1)
            {
                string selecao = listBox1.SelectedItem.ToString();
                List<int> numeros = new List<int>();
                MatchCollection semelhante = Regex.Matches(selecao, @"\d+");
                foreach (Match match in semelhante)
                {
                    int numero = int.Parse(match.Value);
                    numeros.Add(numero);
                }
                int id = numeros[0];
                MessageBox.Show("Id do livro selecionado é: " + id);
                try
                {
                    l = bd.obterLivroComId(id);
                }
                catch (SqlException et)
                {
                    MessageBox.Show("Erro ao obter o id do livro." + et.Message);
                }
                interacao.setLId(id);
                grpCatalogo.Show();
            }
            else
            {
                MessageBox.Show("É necessário selecionar um livro na Lista. Caso não o encontre, cadastre outro ao carregar no botão ao lado.");
            }
        }
        private void btnRecusar_Click(object sender, EventArgs e)
        {
            grpLivroCadastrado.Hide();
            grpCadastrarLivro.Show();
            grpCatalogo.Hide();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void btnOk1_Click(object sender, EventArgs e)
        {
            lstProp.Items.Clear();
            listaProprietario = new List<Proprietario>();
            listaCatalogos = new List<Catalogo>();
            bd = new BaseDados();
            // se os dois vazios
            if ((cmbProp.SelectedItem == null) && (string.IsNullOrWhiteSpace(txtNumero.Text)))
            {
                MessageBox.Show("É necessário preencher um dos campos: Nome do proprietário ou Numero.");
            }
            else
            {
                if ((txtNumero.Text.Length > 0) && (cmbProp.SelectedItem == null))
                {
                    int numero;
                    bool success = int.TryParse(txtNumero.Text, out numero);
                    if (success)
                    {
                        try
                        {
                            listaCatalogos = bd.obterCatalogo(numero);
                        }
                        catch (SqlException et)
                        {
                            throw new Exception("Erro na leitura dos catálogos. " + et.Message);
                        }
                        if (listaCatalogos == null)
                        {
                            MessageBox.Show("Catálogo não encontrado.");
                        }
                        else
                        {
                            MessageBox.Show("Os dados do catálogo correspondente serão exibidos na lista a seguir.");
                            foreach (Catalogo item in listaCatalogos)
                            {
                                lstProp.Items.Add("Numero do documento:" + item.getNumeroDocumento() + "      - Id: " + item.getId());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira um número na caixa de texto.");
                    }
                }
                else
                {
                    // if ((string.IsNullOrWhiteSpace(txtNumero.Text)) && (cmbProp.SelectedItem != null))
                    // {
                    string nomeSelecionado = cmbProp.SelectedItem.ToString();
                    try
                    {
                        listaProprietario = bd.buscaProprietarioNome(nomeSelecionado);
                        MessageBox.Show("Os dados do proprietário correspondente serão exibidos na lista a seguir.");
                        foreach (Proprietario item in listaProprietario)
                        {
                            lstProp.Items.Add("Id do Proprietário: " + item.getId() + ". Proprietario: " + item.getQualificacao()
                               + " " + item.getNome() + " " + item.getOcupacao() + "." + "Id do Catálogo: " + item.getCatalogoId());
                        }
                    }
                    catch (SqlException et)
                    {
                        throw new Exception("Erro na leitura dos catálogos. " + et.Message);
                    }
                    /*  }
                        else
                        {
                            string nomeSelecionado = cmbProp.SelectedItem.ToString();

                            try
                            {
                                listaProprietario = bd.buscaProprietarioNome(nomeSelecionado);
                                MessageBox.Show("Os dados do proprietário correspondente serão exibidos na lista a seguir.");
                                foreach (Proprietario item in listaProprietario)
                                {
                                    lstProp.Items.Add("Id do Proprietário: " + item.getId() + ". Proprietario: " + item.getQualificacao()
                                       + " " + item.getNome() + " " + item.getOcupacao() + "." + "Id do Catálogo: " + item.getCatalogoId());
                                }
                            }
                            catch (SqlException et)
                            {
                                throw new Exception("Erro na leitura dos catálogos. " + et.Message);
                            }
                        }*/
                }
            }
        }
        private void btnConfirmar1_Click(object sender, EventArgs e)
        {
            int idProprietarioSelecionado = selecaoListBox();
            if (idProprietarioSelecionado == -1)
            {
                MessageBox.Show("Seleciona um registo na Lista.");
            }
            else
            {
                selecaoComboBox();
                interacao.setCategoria(cmbCategoria.SelectedItem.ToString());
                interacao.setNExemplar(Convert.ToInt32(txtNumeroExemplares.Text));
                interacao.setPId(idProprietarioSelecionado);
                // interacao.setLId(l.getId());
                try
                {
                    bd.guardarInteracao(interacao);
                }
                catch (SqlException et)
                { MessageBox.Show("Erro em gravar." + et.Message); }
            }
            Hide();
        }
        public Interacao getInteracao() { return interacao; }
        public Livro getLivro() { return l; }
        private void grpCadastrarLivro_Enter(object sender, EventArgs e) { }
    }
}
