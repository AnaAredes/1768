using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Catalogos
{
    public class Comarca
    {
        // variáveis de instância
        private int id;
        private int provinciaId;
        private string descricao_comarca;

        public Comarca()
        {
            id = 0;
            provinciaId = 0;
            descricao_comarca = string.Empty;
        }
        //construtor
        public Comarca(int novoId, int novoprovinciaId, string novodescricao)
        {
            id = novoId;
            provinciaId = novoprovinciaId;
            descricao_comarca = novodescricao;
        }
        // métodos de instância
        public int getId() { return id; }
        public int getProvinciaId() { return provinciaId; }
        public string getDescricao_Comarca() { return descricao_comarca; }
        public void setId(int id) { this.id = id; }
        public void setProvinciaId(int provinciaId) { this.provinciaId = provinciaId; }
        public void setDescricaoComarca(string descricaoComarca) { this.descricao_comarca = descricaoComarca; }

    }
}
