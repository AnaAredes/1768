using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Catalogos
{
    public class Freguesia
    {
        // variáveis de instância
        private int id;
        private int comarca_Id;
        private string descricao_freguesia;

        public Freguesia()
        {
            id = 0;
            comarca_Id = 0;
            descricao_freguesia = string.Empty;
        }
        //construtor
        public Freguesia(int novoId, int novaComarcaId, string novodescricao)
        {
            id = novoId;
            comarca_Id = novaComarcaId;
            descricao_freguesia = novodescricao;
        }
        // métodos de instância
        public int getId() { return id; }
        public int getComarcaId() {  return comarca_Id; }
        public string getDescricao_freguesia() {  return descricao_freguesia;}
        public void setId(int id) { this.id = id;}
        public void setComarcaId(int concelhoId) { this.comarca_Id = concelhoId;}
        public void setDescricaoFreguesia (string descricaoFreguesia) { this.descricao_freguesia= descricaoFreguesia;}
    }
}
