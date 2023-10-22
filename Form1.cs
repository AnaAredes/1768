using System.Data.SqlClient;
using System.Numerics;

namespace Gestao_Catalogos
{
    public partial class Form1 : Form
    {
        private BaseDados bd = new BaseDados();
        private List<Catalogo> catalogos = new List<Catalogo>();
        private Proprietario proprietario = new Proprietario();
        private List<Proprietario> listaProprietarios = new List<Proprietario>();
        public Form1()
        {
            InitializeComponent();
            atualizarList();
        }

        private void atualizarList()
        {
            int x = 0;
            bd = new BaseDados();
            try
            {
                listaProprietarios = bd.levarTodosProprietarios();
                x = listaProprietarios.Count;
            }
            catch (SqlException et)
            {
                MessageBox.Show("Erro ao carregar o n�mero de propriet�rios." + et.Message);
            }
            caixaTexto.Text = "   Em raz�o da determina��o r�gia de 10.07.1769, os habitantes dos " +
                "territ�rios portugueses foram obrigados a remeter cat�logos " +
                "das suas bibliotecas particulares para o exame censor.\f" +
                "" + "   Hoje, existem 3223 cat�logos produzidos por obedi�ncia �quela determina��o. " +
                "Esses cat�logos s�o geridos nesta app.\f" + "" + "   Nesta aplica��o, h� " + x +
                " propriet�rios cadastrados neste momento.";
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            FormVerLivros formVerLivros = new FormVerLivros();
            if (formVerLivros.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Fim.");
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarProp formCadastrarProp = new FormCadastrarProp();
            bd = new BaseDados();
            if (formCadastrarProp.ShowDialog() == DialogResult.Yes)
            {
                Proprietario p = formCadastrarProp.getPrp();
                try
                {
                    bd.guardarProprietario(p);
                    MessageBox.Show("Gravado com sucesso. Propriet�rio: " + p.getNome());
                    atualizarList();
                }
                catch (SqlException et)
                {
                    MessageBox.Show("Erro em gravar." + et.Message);
                }
            }
        }
        private void btnFreguesia_Click(object sender, EventArgs e)
        {
            FormCadastrarFreguesia formCadastrarFreguesia = new FormCadastrarFreguesia();
            if (formCadastrarFreguesia.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Freguesia Cadastrada.");
            }
        }
        private void btnLivrosCatalogo_Click(object sender, EventArgs e)
        {
            FormCadastrarLivros formCadastrarlivro = new FormCadastrarLivros();
            if (formCadastrarlivro.ShowDialog() == DialogResult.Yes)
            {
                Interacao i = formCadastrarlivro.getInteracao();
                if (i.getCategoria() != null)
                {
                    bd = new BaseDados();
                    try
                    {
                        MessageBox.Show("Livro Gravado no Cat�logo do Propriet�rio de ID: " + i.getProprietarioId());
                    }
                    catch (SqlException et)
                    {
                        MessageBox.Show("Erro em gravar." + et.Message);
                    }
                }
                else
                { MessageBox.Show("Dados fornecidos incompletos."); }
            }
        }
        private void btnLivros_Click(object sender, EventArgs e)
        {
            FormApagarEditarLivros formApagarEditarLivros = new FormApagarEditarLivros();
            if (formApagarEditarLivros.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Fim.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditarCatalogo formEditarCatalogo = new FormEditarCatalogo();
            if (formEditarCatalogo.ShowDialog() == DialogResult.Yes)
            {
                Proprietario p = formEditarCatalogo.getPrp();
                int idFreg = p.getFreguesiaId();
                if (idFreg == -1)
                {
                    MessageBox.Show("Altera��o recusada.");
                }
                else
                {
                    try
                    {
                        bd.alterarProprietario(p);
                        MessageBox.Show("Gravado com sucesso. Propriet�rio: " + p.getNome());
                    }
                    catch (SqlException et)
                    {
                        MessageBox.Show("Erro em gravar." + et.Message);
                    }
                }
                atualizarList();
            }
        }
        private void btnVerCatalogos_Click(object sender, EventArgs e)
        {
            FormVerCatalogo formVerCatalogo = new FormVerCatalogo();
            if (formVerCatalogo.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Fim.");
            }
        }

        private void btnAlterarFreguesia_Click(object sender, EventArgs e)
        {
            FormAlterarFregCat formAlterarFreg = new FormAlterarFregCat();
            if (formAlterarFreg.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Altera��o realizada.");
            }
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }
    }
}