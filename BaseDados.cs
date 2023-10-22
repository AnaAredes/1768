using Gestao_Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace Gestao_Catalogos
{
    public class BaseDados
    {
        private string stringConnection;
        private SqlConnection conn; //usado para executar os comandos SQL
        string sql = ""; //string que transporta os comandos SQL
        private SqlDataAdapter adap; //usado para inserir, alterar e eliminar dados na base de dados
        private SqlCommand cmd; //usado para efetuar operações de leitura a partir da base de dados
        private SqlDataReader dreader; //objeto que conterá os dados que virão da base de dados

        private List<Livro> l = new List<Livro>();
        private Livro livro = new Livro();
        private List<Catalogo> c = new List<Catalogo>();
        private Catalogo catalogo = new Catalogo();
        private List<Provincia> p = new List<Provincia>();
        private List<Freguesia> f = new List<Freguesia>();
        private Freguesia freguesia = new Freguesia();
        private Provincia uma = new Provincia();
        private List<Comarca> listaComarcas = new List<Comarca>();
        private Comarca umaComarca = new Comarca();
        private Proprietario proprietario = new Proprietario();
        private List<Proprietario> listaProprietario = new List<Proprietario>();

        //Construtor:
        public BaseDados()
        {
            // Inicializações
            // Estrutura para a definir a stringConnection = @"Data Source=62.28.39.135,62444;Initial Catalog=NOMEDABASE;User ID=sa;Password=123.Abc##;";
            // Adicionei "Persist Security Info=True" para evitar permitir a instância no antivírus. Trusted_Connection=True
            stringConnection = @"Server = SQLOLEDB.1;Data Source=62.28.39.135,62444;Initial Catalog=JDPPAna;User ID=sa;Password=123.Abc##;Persist Security Info=True;";
            conn = new SqlConnection(stringConnection);
            adap = new SqlDataAdapter();
        }
        // Método para abrir e método para fechar conexão à base de dados:
        private void openConnection() { conn.Open(); }
        private void closeConnection() { conn.Close(); }


        //GUARDAR
        //Método para guardar Livro
        public void guardarLivro(Livro l)
        {
            //abre a conexão
            openConnection();
            // associação entre o comando para inserção SQL ao objeto adaptador.
            // O procedimento para apagar ou atualizar dados é igual, o que muda é a instrução sql
            sql = "INSERT INTO Livro (Titulo, Autor, Edicao, Ano, Local, Formato) VALUES('" + l.getTitulo() + "','" + l.getAutor() + "','" + l.getEdicao() + "','" +
                l.getAno() + "','" + l.getLocal() + "','" + l.getFormato() +
                "');";
            adap.InsertCommand = new SqlCommand(sql, conn);
            // execução da inscrição de inserção 
            adap.InsertCommand.ExecuteNonQuery();
            //fechar a ligação à base de dados:
            adap.Dispose();
            closeConnection();
        }
        //Método para guardar Freguesia
        public void guardarFreguesia(Freguesia freguesia)
        {
            openConnection();
            sql = "INSERT INTO Freguesia (Comarca_Id, Descricao_freguesia) VALUES (" + freguesia.getComarcaId() + ", '" + freguesia.getDescricao_freguesia() + "');";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }

        //Método para guardar Comarca; diferente dos demais, usa parâmetros no command (cmd).
        public void guardarComarca(Comarca comarca)
        {
            openConnection();
            sql = "INSERT INTO Comarca (ProvinciaId, Descricao_Comarca) VALUES (@ProvinciaId, @DescricaoComarca)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ProvinciaId", comarca.getProvinciaId());
                cmd.Parameters.AddWithValue("@DescricaoComarca", comarca.getDescricao_Comarca());
                cmd.ExecuteNonQuery();
            }
            cmd.Dispose();
            closeConnection();
        }
        //Guardar interacao
        public void guardarInteracao(Interacao interacao)
        {
            openConnection();
            sql = "INSERT INTO Interacao (Livro_Id, Proprietario_Id, N_exemplares, Categoria) VALUES('" + interacao.getLivroId() + "','" + interacao.getProprietarioId() +
                "','" + interacao.getNExemplar() + "','" + interacao.getCategoria() + "');";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }
        //Método para guardar objeto na tabela do tipo Proprietario
        public void guardarProprietario(Proprietario p)
        {
            openConnection();
            sql = "INSERT INTO Proprietario (Catalogo_Id, Nome, Qualificacao, Ocupacao, Descricao_localizacao, Freguesia_Id, OBS)" +
                " VALUES('" + p.getCatalogoId() + "','" + p.getNome() + "','" + p.getQualificacao() + "','" +
                p.getOcupacao() + "','" + p.getDescricaoLocalizacao() + "','" + p.getFreguesiaId() + "','" + p.getObs() +
                "');";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }



        // ALTERAR
        //Método para guardar objeto na tabela do tipo Proprietario
        public void alterarProprietario(Proprietario p)
        {
            //abre a conexão
            openConnection();
            //associação entre o comando para inserção SQL ao objeto adaptador; o ID é autoincrementado na base de dados
            sql = "UPDATE Proprietario SET Catalogo_Id='" + p.getCatalogoId() + "', Nome='" + p.getNome() + "', " +
                "Qualificacao='" + p.getQualificacao() + "', " + "Ocupacao='" + p.getOcupacao() + "', Descricao_localizacao='" +
                p.getDescricaoLocalizacao() + "', Freguesia_Id='" + p.getFreguesiaId() + "', OBS='" + p.getObs() +
                "' WHERE Id='" + p.getId() + "';";
            adap.InsertCommand = new SqlCommand(sql, conn);
            // execução da inscrição de inserção 
            adap.InsertCommand.ExecuteNonQuery();
            //fechar a ligação à base de dados:
            adap.Dispose();
            closeConnection();
        }
        //Método para alterar objeto na tabela do tipo Catalogo
        public void alterarFreguesia(Freguesia f)
        {
            openConnection();
            sql = "UPDATE Freguesia SET Comarca_Id='" + f.getComarcaId() + "', Descricao_freguesia='" + f.getDescricao_freguesia() + "' WHERE Id='" + f.getId() + "';";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }
        //Método para alterar um objeto (livro) na tabela do tipo livro (base de dados)
        public void alterarLivro(Livro livro)
        {
            openConnection();
            sql = "UPDATE Livro SET Titulo='" + livro.getTitulo() + "', Autor='" + livro.getAutor() + "', Edicao='" + livro.getEdicao() + "', " +
                "Ano='" + livro.getAno() + "', Local='" + livro.getLocal() + "', Formato='" + livro.getFormato() + "' WHERE Id='" + livro.getId() + "';";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }
        public void alterarInteracao(Interacao interacao)
        {
            openConnection();
            sql = "UPDATE Interacao SET Livro_Id=@LivroId, Proprietario_Id=@ProprietarioId, N_exemplares=@NExemplares, Categoria=@Categoria WHERE Id=@Id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@LivroId", interacao.getLivroId());
            cmd.Parameters.AddWithValue("@ProprietarioId", interacao.getProprietarioId());
            cmd.Parameters.AddWithValue("@NExemplares", interacao.getNExemplar());
            cmd.Parameters.AddWithValue("@Categoria", interacao.getCategoria());
            cmd.Parameters.AddWithValue("@Id", interacao.getId());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            closeConnection();
        }



        // LER
        //pegar os Catálogos
        public List<Catalogo> obterTodosCatalogos()
        {
            c = new List<Catalogo>();
            openConnection();
            sql = "SELECT * FROM DocCatalogo ORDER BY Id;";
            cmd = new SqlCommand(sql, conn);
            // obter todas as linhas da tabela (executar o comando e guardar o resultado no dreader)
            dreader = cmd.ExecuteReader();
            // enquanto houver registos, lê e guarda o resultado
            while (dreader.Read())
            {
                catalogo = new Catalogo();
                catalogo.setId(dreader.GetInt32(0));
                catalogo.setCaixa(dreader.GetInt32(1));
                catalogo.setNumeroDocumento(dreader.GetInt32(2));
                catalogo.setReferencia(dreader.GetString(3));
                c.Add(catalogo);
            }
            //Fechar conexões
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            //retornar a lista
            return c;
        }
        public List<Catalogo> lerTodosCatalogosComProp()
        {
            c = new List<Catalogo>();
            openConnection();
            sql = "SELECT * FROM DocCatalogo c INNER JOIN Proprietario p ON c.Id = p.Catalogo_Id WHERE p.Id != 0 ORDER BY c.Id;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                catalogo = new Catalogo();
                catalogo.setId(dreader.GetInt32(0));
                catalogo.setCaixa(dreader.GetInt32(1));
                catalogo.setNumeroDocumento(dreader.GetInt32(2));
                catalogo.setReferencia(dreader.GetString(3));
                c.Add(catalogo);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return c;
        }
        //Método para ler e retornar a lista de todos catalogos com o mesmo numero:
        public List<Catalogo> obterCatalogo(int documento)
        {
            c = new List<Catalogo>();
            openConnection();
            sql = "SELECT * FROM DocCatalogo WHERE Numero_documento ='" + documento + "' ORDER BY Id;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                catalogo = new Catalogo();
                catalogo.setId(dreader.GetInt32(0));
                catalogo.setCaixa(dreader.GetInt32(1));
                catalogo.setNumeroDocumento(dreader.GetInt32(2));
                catalogo.setReferencia(dreader.GetString(3));
                c.Add(catalogo);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return c;
        }
        public List<Proprietario> obterProprietariosComNumeroDoc(int documento)
        {
            listaProprietario = new List<Proprietario>();
            proprietario = new Proprietario();
            openConnection();
            sql = "SELECT * FROM Proprietario p INNER JOIN DocCatalogo c ON p.Catalogo_Id = c.Id WHERE c.Numero_documento ='" + documento + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                proprietario = new Proprietario();
                proprietario.setId(dreader.GetInt32(0));
                proprietario.setCatalogoId(dreader.GetInt32(1));
                proprietario.setNome(dreader.GetString(2));
                proprietario.setQualificacao(dreader.GetString(3));
                proprietario.setOcupacao(dreader.GetString(4));
                proprietario.setDescricao(dreader.GetString(5));
                proprietario.setFreguesiaID(dreader.GetInt32(6));
                proprietario.setObs(dreader.GetString(7));
                listaProprietario.Add(proprietario);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return listaProprietario;
        }
        //Método para ler e retornar a lista de todas as Provincias:
        public List<Provincia> obterProvincias()
        {
            p = new List<Provincia>();
            openConnection();
            sql = "SELECT * FROM ProvinciaAntiga ORDER BY Id;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                uma = new Provincia();
                uma.setId(dreader.GetInt32(0));
                uma.setDescricaoProvincia(dreader.GetString(1));
                p.Add(uma);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return p;
        }
        //pegar todas as comarcas com o id da provincia,
        public List<Comarca> obterComarcas(int idProvincia)
        {
            listaComarcas = new List<Comarca>();
            openConnection();
            sql = "SELECT * FROM Comarca WHERE ProvinciaId ='" + idProvincia + "' ORDER BY Id;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                umaComarca = new Comarca();
                umaComarca.setId(dreader.GetInt32(0));
                umaComarca.setProvinciaId(dreader.GetInt32(1));
                umaComarca.setDescricaoComarca(dreader.GetString(2));
                listaComarcas.Add(umaComarca);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return listaComarcas;
        }
        public List<(string comarca, string provincia)> conjuntoComarcaProv()
        {
            List<(string comarca, string provincia)> resultados = new List<(string, string)>();
            openConnection();
            sql = "SELECT c.Descricao_Comarca, p.descricao_provincia FROM Comarca c INNER JOIN ProvinciaAntiga p ON p.Id = c.ProvinciaId ORDER BY Descricao_Comarca;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                string comarca = dreader["Descricao_Comarca"].ToString();
                string provincia = dreader["descricao_provincia"].ToString();
                resultados.Add((comarca, provincia));
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return resultados;
        }
        public List<Comarca> obterComarcasUmaProvincia(string nomeProvincia)
        {
            listaComarcas = new List<Comarca>();
            openConnection();
            sql = "SELECT * FROM Comarca c INNER JOIN ProvinciaAntiga p ON p.Id = c.ProvinciaId WHERE p.descricao_provincia ='" + nomeProvincia + "';";

            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                umaComarca = new Comarca();
                umaComarca.setId(dreader.GetInt32(0));
                umaComarca.setProvinciaId(dreader.GetInt32(1));
                umaComarca.setDescricaoComarca(dreader.GetString(2));
                listaComarcas.Add(umaComarca);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return listaComarcas;
        }
        public List<Proprietario> obterProprietarios(int idComarca)
        {
            listaProprietario = new List<Proprietario>();
            openConnection();
            sql = "SELECT * FROM Proprietario p INNER JOIN Freguesia f ON f.Id = p.Freguesia_Id WHERE f.Comarca_Id ='" + idComarca + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                proprietario = new Proprietario();
                proprietario.setId(dreader.GetInt32(0));
                proprietario.setCatalogoId(dreader.GetInt32(1));
                proprietario.setNome(dreader.GetString(2));
                proprietario.setQualificacao(dreader.GetString(3));
                proprietario.setOcupacao(dreader.GetString(4));
                proprietario.setDescricao(dreader.GetString(5));
                proprietario.setFreguesiaID(dreader.GetInt32(6));
                proprietario.setObs(dreader.GetString(7));
                listaProprietario.Add(proprietario);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            //retornar a lista
            return listaProprietario;
        }
        //pegar os nomes das freguesias e das comarcas
        public List<(string Freguesia, string Comarca)> obterProvinciaComarca()
        {
            List<(string Freguesia, string Comarca)> resultados = new List<(string, string)>();
            openConnection();
            sql = "SELECT f.Descricao_freguesia, c.Descricao_Comarca FROM Freguesia f INNER JOIN Comarca c ON f.Comarca_Id = c.Id ORDER BY f.Descricao_freguesia;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                string freguesia = dreader["Descricao_freguesia"].ToString();
                string comarca = dreader["Descricao_Comarca"].ToString();
                resultados.Add((freguesia, comarca));
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return resultados;
        }
        //pegar o id da Freguesia       

        public List<(string freguesia, string comarca)> obterNomeFreguesia(int id)
        {
            List<(string Freguesia, string Comarca)> resultados = new List<(string, string)>();
            openConnection();
            sql = "SELECT f.Descricao_freguesia, c.Descricao_Comarca FROM Freguesia f INNER JOIN" +
                " Comarca c ON f.Comarca_Id = c.Id WHERE f.Id ='" + id + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                string freguesia = dreader["Descricao_freguesia"].ToString();
                string comarca = dreader["Descricao_Comarca"].ToString();
                resultados.Add((freguesia, comarca));
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return resultados;
        }
        //Método para ler e retornar a lista de todos os livros gravados que possuem o mesmo título:
        public List<Livro> obterLivrosMesmoTitulo(string titulo)
        {
            l = new List<Livro>();
            openConnection();
            sql = "SELECT * FROM Livro WHERE Titulo ='" + titulo + "' ORDER BY Id;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                livro = new Livro();
                livro.setId(dreader.GetInt32(0));
                livro.setTitulo(dreader.GetString(1));
                livro.setAutor(dreader.GetString(2));
                livro.setEdicao(dreader.GetInt32(3));
                livro.setAno(dreader.GetInt32(4));
                livro.setLocal(dreader.GetString(5));
                livro.setFormato(dreader.GetString(6));
                l.Add(livro);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return l;
        }
        public List<Livro> obterLivrosMesmoAutor(string autor)
        {
            l = new List<Livro>();
            openConnection();
            sql = "SELECT * FROM Livro WHERE Autor ='" + autor + "' ORDER BY Id;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                livro = new Livro();
                livro.setId(dreader.GetInt32(0));
                livro.setTitulo(dreader.GetString(1));
                livro.setAutor(dreader.GetString(2));
                livro.setEdicao(dreader.GetInt32(3));
                livro.setAno(dreader.GetInt32(4));
                livro.setLocal(dreader.GetString(5));
                livro.setFormato(dreader.GetString(6));
                l.Add(livro);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return l;
        }
        public List<Proprietario> obterProprietariosMesmoAutor(int idLivro)
        {
            listaProprietario = new List<Proprietario>();
            openConnection();
            sql = "SELECT * FROM Proprietario p INNER JOIN Interacao i ON p.Id = i.Proprietario_Id WHERE i.Livro_Id ='" + idLivro + "'ORDER BY p.Nome;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                proprietario = new Proprietario();
                proprietario.setId(dreader.GetInt32(0));
                proprietario.setCatalogoId(dreader.GetInt32(1));
                proprietario.setNome(dreader.GetString(2));
                proprietario.setQualificacao(dreader.GetString(3));
                proprietario.setOcupacao(dreader.GetString(4));
                proprietario.setDescricao(dreader.GetString(5));
                proprietario.setFreguesiaID(dreader.GetInt32(6));
                proprietario.setObs(dreader.GetString(7));
                listaProprietario.Add(proprietario);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return listaProprietario;
        }
        public List<Proprietario> buscaProprietarioNome(string nome)
        {
            listaProprietario = new List<Proprietario>();
            openConnection();
            sql = "SELECT * FROM Proprietario WHERE Nome ='" + nome + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                proprietario = new Proprietario();
                proprietario.setId(dreader.GetInt32(0));
                proprietario.setCatalogoId(dreader.GetInt32(1));
                proprietario.setNome(dreader.GetString(2));
                proprietario.setQualificacao(dreader.GetString(3));
                proprietario.setOcupacao(dreader.GetString(4));
                proprietario.setDescricao(dreader.GetString(5));
                proprietario.setFreguesiaID(dreader.GetInt32(6));
                proprietario.setObs(dreader.GetString(7));
                listaProprietario.Add(proprietario);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return listaProprietario;
        }
        public List<Proprietario> levarTodosProprietarios()
        {
            listaProprietario = new List<Proprietario>();
            openConnection();
            sql = "SELECT * FROM Proprietario ORDER BY Nome;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                proprietario = new Proprietario();
                proprietario.setId(dreader.GetInt32(0));
                proprietario.setCatalogoId(dreader.GetInt32(1));
                proprietario.setNome(dreader.GetString(2));
                proprietario.setQualificacao(dreader.GetString(3));
                proprietario.setOcupacao(dreader.GetString(4));
                proprietario.setDescricao(dreader.GetString(5));
                proprietario.setFreguesiaID(dreader.GetInt32(6));
                proprietario.setObs(dreader.GetString(7));
                listaProprietario.Add(proprietario);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return listaProprietario;
        }
        // necessariamente o numero do argumento é um ID
        public Proprietario obterProprietarioIdCatalogo(int id)
        {
            openConnection();
            sql = "SELECT * FROM Proprietario WHERE Catalogo_Id ='" + id + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            // Verificar se há dados lidos
            if (dreader.Read())
            {
                proprietario = new Proprietario();
                proprietario.setId(dreader.GetInt32(0));
                proprietario.setCatalogoId(dreader.GetInt32(1));
                proprietario.setNome(dreader.GetString(2));
                proprietario.setQualificacao(dreader.GetString(3));
                proprietario.setOcupacao(dreader.GetString(4));
                proprietario.setDescricao(dreader.GetString(5));
                proprietario.setFreguesiaID(dreader.GetInt32(6));
                proprietario.setObs(dreader.GetString(7));
            }
            else
            {
                proprietario = new Proprietario();
                proprietario.setNome("Sem cadastro");
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return proprietario;
        }
        public Livro obterLivroComId(int id)
        {
            openConnection();
            sql = "SELECT * FROM Livro WHERE Id ='" + id + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                livro = new Livro();
                livro.setId(dreader.GetInt32(0));
                livro.setTitulo(dreader.GetString(1));
                livro.setAutor(dreader.GetString(2));
                livro.setEdicao(dreader.GetInt32(3));
                livro.setAno(dreader.GetInt32(4));
                livro.setLocal(dreader.GetString(5));
                livro.setFormato(dreader.GetString(6));
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return livro;
        }
        public List<Livro> lerLivrosMesmoAutorTitulo(string titulo, string autor)
        {
            l = new List<Livro>();
            openConnection();
            sql = "SELECT * FROM Livro WHERE Titulo ='" + titulo + "' AND Autor ='" + autor + "' ORDER BY Id;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                livro = new Livro();
                livro.setId(dreader.GetInt32(0));
                livro.setTitulo(dreader.GetString(1));
                livro.setAutor(dreader.GetString(2));
                livro.setEdicao(dreader.GetInt32(3));
                livro.setAno(dreader.GetInt32(4));
                livro.setLocal(dreader.GetString(5));
                livro.setFormato(dreader.GetString(6));
                l.Add(livro);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return l;
        }
        public List<Livro> livrosCategoria(string categoria)
        {
            l = new List<Livro>();
            openConnection();
            sql = "SELECT * FROM Livro l INNER JOIN Interacao i ON l.Id = i.Livro_Id WHERE i.Categoria ='" + categoria + "' ORDER BY l.Titulo;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                livro = new Livro();
                livro.setId(dreader.GetInt32(0));
                livro.setTitulo(dreader.GetString(1));
                livro.setAutor(dreader.GetString(2));
                livro.setEdicao(dreader.GetInt32(3));
                livro.setAno(dreader.GetInt32(4));
                livro.setLocal(dreader.GetString(5));
                livro.setFormato(dreader.GetString(6));
                l.Add(livro);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return l;
        }
        public List<Proprietario> proprietariosUmLivro(int idLivro)
        {
            listaProprietario = new List<Proprietario>();
            openConnection();
            sql = "SELECT * FROM Proprietario p INNER JOIN Interacao i ON p.Id = i.Proprietario_Id WHERE i.Livro_Id ='" + idLivro + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                proprietario = new Proprietario();
                proprietario.setId(dreader.GetInt32(0));
                proprietario.setCatalogoId(dreader.GetInt32(1));
                proprietario.setNome(dreader.GetString(2));
                proprietario.setQualificacao(dreader.GetString(3));
                proprietario.setOcupacao(dreader.GetString(4));
                proprietario.setDescricao(dreader.GetString(5));
                proprietario.setFreguesiaID(dreader.GetInt32(6));
                proprietario.setObs(dreader.GetString(7));
                listaProprietario.Add(proprietario);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return listaProprietario;
        }
        public List<Livro> obterLivroUmProprietario(string titulo, int idProprietario)
        {
            l = new List<Livro>();
            openConnection();
            sql = "SELECT * FROM Livro l INNER JOIN Interacao i ON l.Id = i.Livro_Id WHERE l.Titulo ='" + titulo + "' AND i.Proprietario_Id ='" + idProprietario + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                livro = new Livro();
                livro.setId(dreader.GetInt32(0));
                livro.setTitulo(dreader.GetString(1));
                livro.setAutor(dreader.GetString(2));
                livro.setEdicao(dreader.GetInt32(3));
                livro.setAno(dreader.GetInt32(4));
                livro.setLocal(dreader.GetString(5));
                livro.setFormato(dreader.GetString(6));
                l.Add(livro);
            }
            // Fechar conexões 
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return l;
        }
        //ler livros de um proprietario (interação)
        public List<Livro> livrosDeUmProp(int id)
        {
            l = new List<Livro>();
            openConnection();
            sql = "SELECT * FROM Livro l INNER JOIN Interacao i ON l.Id = i.Livro_Id WHERE i.Proprietario_Id ='" + id + "' ORDER BY Ano;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                livro = new Livro();
                livro.setId(dreader.GetInt32(0));
                livro.setTitulo(dreader.GetString(1));
                livro.setAutor(dreader.GetString(2));
                livro.setEdicao(dreader.GetInt32(3));
                livro.setAno(dreader.GetInt32(4));
                livro.setLocal(dreader.GetString(5));
                livro.setFormato(dreader.GetString(6));
                l.Add(livro);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return l;
        }
        public int extrairIdProp(string nome)
        {
            int id = -1;
            openConnection();
            sql = "SELECT Id FROM Proprietario WHERE Nome ='" + nome + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                // id.Add(dreader.GetInt32(0));
                id = (dreader.GetInt32(0));
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return id;
        }
        public int localizarIdInteracao(int idproprietario, int idlivro)
        {
            int id = -1;
            openConnection();
            sql = "SELECT Id FROM Interacao WHERE Livro_Id ='" + idlivro + "' AND Proprietario_Id ='" + idproprietario + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                id = (dreader.GetInt32(0));
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return id;
        }
        public int idUmaComarca(string nome, int idProv)
        {
            int id;
            openConnection();
            sql = "SELECT c.Id FROM Comarca c INNER JOIN ProvinciaAntiga p ON p.Id = c.ProvinciaId WHERE c.Descricao_Comarca ='" + nome + "' AND p.Id = '" + idProv + "';";
            cmd = new SqlCommand(sql, conn);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            closeConnection();
            return id;
        }
        public int idFreguesiaSemInfo(string provincia)
        {
            int idFreguesia = -1;
            string seminfo = "Sem informação";
            openConnection();
            sql = "SELECT Freguesia.Id FROM Freguesia, Comarca, ProvinciaAntiga WHERE " +
                "Freguesia.Comarca_Id = Comarca.Id AND Comarca.ProvinciaId = ProvinciaAntiga.Id AND" +
                "Freguesia.Descricao_freguesia = '" + seminfo + "' AND Comarca.Descricao_comarca = '" + seminfo + "'" +
                "AND ProvinciaAntiga.descricao_provincia= '" + provincia + "' ;";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();

            while (dreader.Read())
            {
                idFreguesia = dreader.GetInt32(0);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();

            return idFreguesia;
        }
        public int obterUmaFreguesia(string freguesia, string comarca)
        {
            int retorno = -1;
            openConnection();
            sql = "SELECT f.Id FROM Freguesia f INNER JOIN Comarca c ON f.Comarca_Id = c.Id WHERE f.Descricao_freguesia ='" + freguesia + "' AND c.Descricao_Comarca = '" + comarca + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            if (dreader.Read())
            {
                string id = dreader["id"].ToString();
                retorno = Convert.ToInt32(id);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return retorno;
        }
        public int obterIdFreguesiaPelaComarca(string comarca, string provincia)
        {
            string semInfo = "Sem informação";
            int retorno = -1;
            openConnection();
            sql = "SELECT Freguesia.Id FROM Freguesia INNER JOIN Comarca ON Freguesia.Comarca_Id = Comarca.Id " +
                "INNER JOIN ProvinciaAntiga ON Comarca.ProvinciaId = ProvinciaAntiga.Id " +
                "WHERE Freguesia.Descricao_freguesia = '" + semInfo + "' AND " +
                " Comarca.Descricao_Comarca ='" + comarca + "' AND" +
                " ProvinciaAntiga.descricao_provincia = '" + provincia + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            if (dreader.Read())
            {
                retorno = dreader.GetInt32(0);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return retorno;
        }
        public int obterIdComarca(string comarca, string provincia)
        {
            int retorno = -1;
            openConnection();
            sql = "SELECT Comarca.Id FROM Comarca INNER JOIN ProvinciaAntiga ON" +
                " Comarca.ProvinciaId = ProvinciaAntiga.Id " +
                "WHERE Comarca.Descricao_Comarca ='" + comarca + "'" +
                " AND ProvinciaAntiga.descricao_provincia = '" + provincia + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            if (dreader.Read())
            {
                retorno = dreader.GetInt32(0);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return retorno;
        }
        public int lerIdProvincia(string descricao_provincia)
        {
            int id = -1;
            openConnection();
            sql = "SELECT Id FROM ProvinciaAntiga WHERE descricao_provincia='" + descricao_provincia + "';";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            if (dreader.Read())
            {
                id = dreader.GetInt32(0);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return id;
        }
        public int lerIdLivro(Livro l)
        {
            int id = -1;
            openConnection();
            sql = "SELECT Id FROM Livro WHERE Titulo =" + l.getTitulo() + ", Autor =" + l.getAutor() + ", Edicao = " + l.getEdicao() +
                ", Ano =" + l.getAno() + ", Local = " + l.getLocal() + ", Formato = " + l.getFormato() + ";";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();
            if (dreader.Read())
            {
                id = dreader.GetInt32(0);
            }
            cmd.Dispose();
            dreader.Close();
            closeConnection();
            return id;
        }


        //APAGAR
        //Apagar proprietário
        public void excluirProprietario(int id)
        {
            openConnection();
            sql = "DELETE FROM Proprietario WHERE Id =" + id + ";";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }
        public void excluirLivro(int id)
        {
            openConnection();
            sql = "DELETE FROM Livro WHERE Id =" + id + ";";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }
        public void excluirInteracao(int idlivro)
        {
            openConnection();
            sql = "DELETE FROM Interacao WHERE Livro_Id =" + idlivro +";";
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.Dispose();
            closeConnection();
        }

    }
}
