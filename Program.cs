using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    class Program {
        static void Main(string[] args){
            //Artista e Produtor
            Artista artista1 = new Artista("James Hetfield", 25497104010, new DateTime(1963, 08, 03), new DateTime(0001, 01, 01), new DateTime(1981, 12, 01), "Heavy Metal", new List<Album>());
            Produtor produtor1 = new Produtor("Bob Rock", 81253974004, new DateTime(1954, 04, 19), new DateTime(0001, 01, 01), "Elektra Records", "Rock, Heavy Metal, Hard Rock, Punk e New Wave", new List<Album>());

            List<Artista> artistas = new List<Artista>();
            List<Produtor> produtores = new List<Produtor>();

            artistas.Add(artista1);
            produtores.Add(produtor1);
            

            //Lista Albuns
            Album album1 = new Album("Black Album", "Heavy Metal", new DateTime(1991, 08, 12), new List<Musica>());
            Album album2 = new Album("St. Anger", "Metal Alternativo", new DateTime(2003, 06, 05), new List<Musica>());
            Album album3 = new Album("ReLoad", "Hard Rock", new DateTime(1997, 11, 18), new List<Musica>());

            List<Album> albuns = new List<Album>();

            albuns.Add(album1);
            albuns.Add(album2);
            albuns.Add(album3);

            //Lista de Músicas 1
            albuns[0].musicas.Add(new Musica("Dont Tread on Me", 241, "Heavy Metal", new DateTime(1991, 08, 29)));
            albuns[0].musicas.Add(new Musica("Enter Sandman", 331, "Heavy Metal", new DateTime(1991, 08, 01)));
            albuns[0].musicas.Add(new Musica("Wherever I May Roam", 406, "Heavy Metal", new DateTime(1992, 10, 19)));

            //Lista de Músicas 2
            albuns[1].musicas.Add(new Musica("Frantic", 351, "Metal Alternativo", new DateTime(2003, 06, 05)));
            albuns[1].musicas.Add(new Musica("St. Anger", 441, "Metal Alternativo", new DateTime(2003, 06, 05)));
            albuns[1].musicas.Add(new Musica("Some Kind of Monster", 506, "Metal Alternativo", new DateTime(2004, 07, 13)));

            //Lista de Músicas 3
            albuns[2].musicas.Add(new Musica("Fuel", 269, "Hard Rock", new DateTime(1998, 06, 22)));
            albuns[2].musicas.Add(new Musica("The Memory Remains", 279, "Hard Rock", new DateTime(1996, 07, 02)));
            albuns[2].musicas.Add(new Musica("Better than You", 321, "Heavy Metal", new DateTime(1998, 07, 16)));

            artistas[0].albuns = albuns;
            produtores[0].albuns = albuns;

            //Programa
            System.Console.WriteLine("1 - Imprime todos os álbuns de um determinado artista: ");
            foreach(var album in Busca.AlbunsPorArtista(artistas, artistas[0].nome)) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("\n2 - Imprime todos os álbuns lançados em determinado ano: ");
            foreach(var album in Busca.AlbunsPorArtistaPorAno(artista1, 1997)) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("\n3 - Imprime todas as músicas de um artista: ");
            foreach(var musica in Busca.MusicaPorArtista(artista1)) Console.WriteLine("- " + musica.nome);
            System.Console.WriteLine("\n4 - Imprime todas as músicas de um artista em determinado ano: ");
            foreach(var musica in Busca.MusicaPorArtistaPorAno(2003, artista1)) Console.WriteLine("- " + musica.nome);
            System.Console.WriteLine("\n5 - Imprime todos os álbuns do mesmo gênero de um produtor: ");
            foreach(var album in Busca.AlbunsPorGeneroPorProdutor(produtor1, "Heavy Metal")) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("\n6 - Imprime todos os álbuns do mesmo ano de um produtor: ");
            foreach(var album in Busca.AlbunsPorGeneroPorProdutor(produtor1, "Heavy Metal")) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("\n7 - Imprime a lista ordenada decrescente de lançamento dos álbuns de um artista: ");
            foreach(var album in Busca.AlbunsOrdenadosDecrescentePorArtista(artista1)) Console.WriteLine("- " + album.nome);
        }    
    }
}