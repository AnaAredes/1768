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
    public partial class FormVerCatalogo : Form
    {
        public FormVerCatalogo()
        {
            InitializeComponent();
            dataGrid1.Rows.Clear();
        }

        private BaseDados bd = new BaseDados();
        private List<Catalogo> catalogos = new List<Catalogo>();
        private Proprietario proprietario = new Proprietario();
        private List<Livro> listaLivros = new List<Livro>();

        private void atualizarList()
        {
            dataGrid1.Rows.Clear();
            bd = new BaseDados();
            string nome = "";
            int id = 0;
            listaLivros = new List<Livro>();
            try
            {
                catalogos = bd.obterTodosCatalogos();
                foreach (Catalogo item in catalogos)
                {
                    proprietario = new Proprietario();
                    try
                    {
                        proprietario = bd.obterProprietarioIdCatalogo(item.getId());
                        nome = proprietario.getNome();
                        listaLivros = bd.livrosDeUmProp(proprietario.getId());
                        id = listaLivros.Count();
                    }
                    catch (SqlException et)
                    {
                        throw new Exception("Erro na leitura do registo do proprietário. " + et.Message);
                    }
                    dataGrid1.Rows.Add(item.getId(), item.getReferencia(), item.getNumeroDocumento(), proprietario.getNome(), id);
                }
            }
            catch (SqlException et)
            {
                throw new Exception("Erro na leitura do registo dos catálogos. " + et.Message);
            }
        }
        private void filtrar()
        {
            dataGrid1.Rows.Clear();
            bd = new BaseDados();
            string nome = "";
            int id = 0;
            catalogos = new List<Catalogo>();
            try
            {
                catalogos = bd.lerTodosCatalogosComProp();
                foreach (Catalogo item in catalogos)
                {
                    proprietario = new Proprietario();
                    try
                    {
                        proprietario = bd.obterProprietarioIdCatalogo(item.getId());
                        nome = proprietario.getNome();
                        listaLivros = bd.livrosDeUmProp(proprietario.getId());
                        id = listaLivros.Count();
                    }
                    catch (SqlException et)
                    {
                        throw new Exception("Erro na leitura do registo do proprietário. " + et.Message);
                    }
                    dataGrid1.Rows.Add(item.getId(), item.getReferencia(), item.getNumeroDocumento(), proprietario.getNome(), id);
                }
            }
            catch (SqlException et)
            {
                throw new Exception("Erro na leitura do registo dos catálogos. " + et.Message);
            }
        }
        private void filtrarPorLivros()
        {
            dataGrid1.Rows.Clear();
            bd = new BaseDados();
            string nome = "";
            int id = 0;
            catalogos = new List<Catalogo>();
            try
            {
                catalogos = bd.lerTodosCatalogosComProp();
                foreach (Catalogo item in catalogos)
                {
                    proprietario = new Proprietario();
                    try
                    {
                        proprietario = bd.obterProprietarioIdCatalogo(item.getId());
                        nome = proprietario.getNome();
                        listaLivros = bd.livrosDeUmProp(proprietario.getId());
                        id = listaLivros.Count();
                    }
                    catch (SqlException et)
                    {
                        throw new Exception("Erro na leitura do registo do proprietário. " + et.Message);
                    }
                    if (id != 0)
                    {
                        dataGrid1.Rows.Add(item.getId(), item.getReferencia(), item.getNumeroDocumento(), proprietario.getNome(), id);
                    }
                }
            }
            catch (SqlException et)
            {
                throw new Exception("Erro na leitura do registo dos catálogos. " + et.Message);
            }
        }
        //Métodos referentes aos botões
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta operação demorará alguns segundos para ser concluída. Por favor, aguarde.");
            atualizarList();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta operação pode demorar alguns segundos para ser concluída. Por favor, aguarde.");
            filtrar();
        }
        private void btnFiltrarLivros_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta operação pode demorar alguns segundos para ser concluída. Por favor, aguarde.");
            filtrarPorLivros();
        }
    }
}
