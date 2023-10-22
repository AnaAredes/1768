using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Catalogos
{
    public class Livro
    {
        // variáveis de instância
        private int id;
        private string titulo;
        private string local;
        private int ano;
        private string autor;
        private int edicao;
        private string formato;

        public Livro()
        {
            id = 0;
            titulo = string.Empty;
            ano = 0;
            local = string.Empty;
            autor = string.Empty;
            edicao = 0;
            formato = string.Empty;
        }
        // construtor
        public Livro(int novoId, string novoTitulo, int novoAno, string novoLocal, string novoAutor, int novoEdicao, string novoFormato)
        {
            id = novoId;
            titulo = novoTitulo;
            ano = novoAno;
            local = novoLocal;
            autor = novoAutor;
            edicao = novoEdicao;
            formato = novoFormato;
        }
        // métodos de instância
        public int getId() { return id; }
        public string getTitulo() { return titulo; }
        public string getLocal() { return local; }
        public int getAno() { return ano; }
        public string getAutor() { return autor; }
        public int getEdicao() { return edicao; }
        public string getFormato() { return formato; }

        public void setTitulo(string tit)
        {
            if (tit.Length <= 0)
            {
                throw new NullReferenceException();
            }
            this.titulo = tit;
        }
        public void setLocal(string local)
        {
            if (local.Length < 0)
            {
                throw new NullReferenceException();
            }
            this.local = local;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }
        public void setAutor(string autor)
        {
            if (autor.Length < 0)
            {
                throw new NullReferenceException();
            }
            this.autor = autor;
        }
        public void setId(int id) { this.id = id; }
        public void setEdicao(int edicao) { this.edicao = edicao; }
        public void setFormato(string formato) { this.formato = formato; }

        private BaseDados db;

        public Livro(BaseDados db)
        {
            this.db = db;
        }
    }
}
