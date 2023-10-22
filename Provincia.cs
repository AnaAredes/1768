using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Catalogos
{
    public class Provincia
    {
        // variáveis de instância
        private int id;
        private string descricao_provincia;

        public Provincia()
        {
            id = 0;
            descricao_provincia = string.Empty;
        }
        //construtor
        public Provincia(int novoId, string novodescricao)
        {
            id = novoId;
            descricao_provincia = novodescricao;
        }
        // métodos de instância
        public int getId() { return id; }
        public string getDescricaoProvincia() { return descricao_provincia; }
        public void setId(int id) { this.id = id; }
        public void setDescricaoProvincia(string descricao_provincia) { this.descricao_provincia = descricao_provincia; }
    }
}
