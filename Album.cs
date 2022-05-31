using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    public class Album{
        public String nome;
        public String genero;
        public DateTime dataLancamento;

        public List<Musica> musicas;

        public Album(String nome, String genero, DateTime dataLancamento, List<Musica> musicas){
            this.nome = nome;
            this.genero = genero;
            this.dataLancamento = dataLancamento;
            this.musicas = musicas;
        }
    }
}