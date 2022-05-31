using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    public class Artista : Pessoa {
        public DateTime dataContrato;
        public String genero;
        public List<Album> albuns;

        public Artista(String nome, long cpf, DateTime dataNascimento, DateTime dataFalecimento, DateTime dataContrato, String genero, List<Album> albuns){
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.dataFalecimento = dataFalecimento;
            this.dataContrato = dataContrato;
            this.genero = genero;
        }
    }
}