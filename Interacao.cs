using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Catalogos
{
    public class Interacao
    {
        // variáveis de instância
        private int id;
        private int livroId;
        private int proprietarioId;
        private int nExemplar;
        private string categoria;

        public Interacao()
        {
            id = 0;
            livroId = 0;
            proprietarioId = 0;
            nExemplar= 0;
            categoria =string.Empty;

        }
        // construtor
        public Interacao(int novoId, int novoLivroId, int novoProprietarioId, int novoNExemplar, string novoCategoria)
        {
           id = novoId;
           livroId = novoLivroId;
           proprietarioId = novoProprietarioId;
           nExemplar = novoNExemplar;
           categoria = novoCategoria;
        }
        // métodos de instância
        public int getId() { return id; }
        public int getLivroId() {  return livroId; }
        public int getProprietarioId() {  return proprietarioId; }
        public int getNExemplar() {  return nExemplar; }
        public string getCategoria() { return categoria; }
        public void setId(int id) { this.id = id;}
        public void setNExemplar(int nExemplar) { this.nExemplar = nExemplar;}
        public void setCategoria(string categoria) { this.categoria = categoria;}
        public void setLId(int livroId) { this.livroId = livroId;}
        public void setPId(int proprietarioId) { this.proprietarioId=proprietarioId;}
    }
}
