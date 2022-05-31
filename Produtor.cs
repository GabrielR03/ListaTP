using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    public class Produtor : Pessoa {
        public String produtora;
        public String generos;
        public List<Album> albuns;
        public Produtor(String nome, long cpf, DateTime dataNascimento, DateTime dataFalecimento, String produtora, String generos, List<Album> albuns){
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.dataFalecimento = dataFalecimento;
            this.produtora = produtora;
            this.generos = generos;
        }
    }
}