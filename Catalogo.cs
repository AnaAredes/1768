using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Catalogos
{
    public class Catalogo
    {
        int id;
        int caixa;
        int numero_documento;
        string referencia;

        public Catalogo()
        {
            id = 0;
            caixa = 0;
            referencia = string.Empty;
            numero_documento = 0;
        }
        // construtor
        public Catalogo(int novoid, int novocaixa, int novodoc, string novoreferencia)
        {
            id = novoid;
            caixa = novocaixa;
            numero_documento = novodoc;           
            referencia = novoreferencia;
        }
        // métodos de instância
        public int getId() { return id; }
        public int getCaixa() { return caixa; }
        public int getNumeroDocumento() {  return numero_documento; }
        public string getReferencia() {  return referencia; }
        public void setId(int id) { this.id = id;}
        public void setCaixa(int caixa) { this.caixa = caixa;}
        public void setNumeroDocumento(int numero) { this.numero_documento = numero;}
        public void setReferencia(string referencia) { this.referencia = referencia; }
    }
}