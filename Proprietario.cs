using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Catalogos
{
    public class Proprietario
    {
        // variáveis de instância
        private int id;
        private int catalogoId;
        private string nome;
        private string qualificacao;
        private string ocupacao;
        private string descricao_localizacao;
        private int freguesiaId;
        private string obs;

        public Proprietario() 
        {
            id = 0; 
            catalogoId = 0;
            nome = string.Empty;
            qualificacao = string.Empty;
            ocupacao = string.Empty;
            descricao_localizacao = string.Empty;
            freguesiaId = 0;
            obs = string.Empty;
        }
        //construtor
        public Proprietario(int novoid,int novocatalogoId, string novonome, string novoqualificacao, string novoocupacao, string novolocalizacao, int novofreguesiaId, string novoobs)
        {
            id = novoid;
            catalogoId = novocatalogoId;
            nome = novonome;
            qualificacao = novoqualificacao;
            ocupacao = novoocupacao;
            descricao_localizacao = novolocalizacao;
            freguesiaId = novofreguesiaId;
            obs = novoobs;
        }
              
        // métodos de instância
        public int getId() { return id; }
        public int getCatalogoId() { return catalogoId; }
        public string getNome() { return nome; }
        public string getQualificacao() {  return qualificacao; }
        public string getOcupacao() { return ocupacao; }
        public string getDescricaoLocalizacao() { return descricao_localizacao; }
        public int getFreguesiaId() { return freguesiaId; }
        public string getObs() { return obs; }
        public void setId(int id) { this.id = id; }
        public void setCatalogoId(int catalogoId) { this.catalogoId = catalogoId; }
        public void setNome(string nome) { this.nome = nome; }
        public void setQualificacao(string qualificacao) { this.qualificacao = qualificacao; }
        public void setOcupacao(string ocupacao) { this.ocupacao = ocupacao; }
        public void setDescricao(string descricao_localizacao) { this.descricao_localizacao = descricao_localizacao; }
        public void setFreguesiaID(int fregresiaId) { this.freguesiaId = fregresiaId; }
        public void setObs(string obs) {  this.obs = obs; }
    }
}
