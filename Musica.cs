using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    public class Musica {
        public String nome;
        public int duracao;
        public String genero;
        public DateTime lancamento;
        public Musica(String nome, int duracao, String genero, DateTime lancamento){
                this.nome = nome;
                this.duracao = duracao;
                this.genero = genero;
                this.lancamento = lancamento;
            }
    }
}