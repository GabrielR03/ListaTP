using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    class Program {
        static void Main(string[] args){
            //Lista de Músicas 1
            Musica musicaA1 = new Musica("Dont Tread on Me", 241, "Heavy Metal", new DateTime(1991, 08, 29));
            Musica musicaA2 = new Musica("Enter Sandman", 331, "Heavy Metal", new DateTime(1991, 08, 01));
            Musica musicaA3 = new Musica("Wherever I May Roam", 406, "Heavy Metal", new DateTime(1992, 10, 19));

            List<Musica> musicasAlbum1 = new List<Musica>();

            musicasAlbum1.Add(musicaA1);
            musicasAlbum1.Add(musicaA2);
            musicasAlbum1.Add(musicaA3);

            //Lista de Músicas 2
            Musica musicaB1 = new Musica("Frantic", 351, "Metal Alternativo", new DateTime(2003, 06, 05));
            Musica musicaB2 = new Musica("St. Anger", 441, "Metal Alternativo", new DateTime(2003, 06, 05));
            Musica musicaB3 = new Musica("Some Kind of Monster", 506, "Metal Alternativo", new DateTime(2004, 07, 13));

            List<Musica> musicasAlbum2 = new List<Musica>();

            musicasAlbum2.Add(musicaB1);
            musicasAlbum2.Add(musicaB2);
            musicasAlbum2.Add(musicaB3);

            //Lista de Músicas 3
            Musica musicaC1 = new Musica("Fuel", 269, "Hard Rock", new DateTime(1998, 06, 22));
            Musica musicaC2 = new Musica("The Memory Remains", 279, "Hard Rock", new DateTime(1996, 07, 02));
            Musica musicaC3 = new Musica("Better than You", 321, "Heavy Metal", new DateTime(1998, 07, 16));

            List<Musica> musicasAlbum3 = new List<Musica>();

            musicasAlbum3.Add(musicaC1);
            musicasAlbum3.Add(musicaC2);
            musicasAlbum3.Add(musicaC3);

            //Lista Albuns
            Album album1 = new Album("Black Album", "Heavy Metal", new DateTime(1991, 08, 12), musicasAlbum1);
            Album album2 = new Album("St. Anger", "Metal Alternativo", new DateTime(2003, 06, 05), musicasAlbum2);
            Album album3 = new Album("ReLoad", "Hard Rock", new DateTime(1997, 11, 18), musicasAlbum3);

            List<Album> albuns1 = new List<Album>();

            albuns1.Add(album1);
            albuns1.Add(album2);
            albuns1.Add(album3);

            //Artista e Produtor
            Artista artista = new Artista("James Hetfield", 25497104010, new DateTime(1963, 08, 03), new DateTime(0001, 01, 01), new DateTime(1981, 12, 01), "Heavy Metal", albuns1);
            Produtor produtor = new Produtor("Bob Rock", 81253974004, new DateTime(1954, 04, 19), new DateTime(0001, 01, 01), "Elektra Records", "Rock, Heavy Metal, Hard Rock, Punk e New Wave", albuns1);

            //Programa
            System.Console.WriteLine("1 - Imprime todos os álbuns de um determinado artista: ");
            foreach(var album in Busca.AlbunsPorArtista(artista, "James Hetfield")) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("2 - Imprime todos os álbuns lançados em determinado ano: ");
            foreach(var album in Busca.AlbunsPorArtistaPorAno(artista, 1998)) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("3 - Imprime todas as músicas de um artista: ");
            foreach(var musica in Busca.MusicaPorArtista(artista)) Console.WriteLine("- " + musica.nome);
            System.Console.WriteLine("4 - Imprime todas as músicas de um artista em determinado ano: ");
            foreach(var musica in Busca.MusicaPorArtistaPorAno(2003, artista)) Console.WriteLine("- " + musica.nome);
            System.Console.WriteLine("5 - Imprime todos os álbuns do mesmo gênero de um produtor: ");
            foreach(var album in Busca.AlbunsPorGeneroPorProdutor(produtor, "Heavy Metal")) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("6 - Imprime todos os álbuns do mesmo ano de um produtor: ");
            foreach(var album in Busca.AlbunsPorGeneroPorProdutor(produtor, "Heavy Metal")) Console.WriteLine("- " + album.nome);
            System.Console.WriteLine("7 - Imprime a lista ordenada decrescente de lançamento dos álbuns de um artista: ");
            foreach(var album in Busca.AlbunsOrdenadosDecrescentePorArtista(artista)) Console.WriteLine("- " + album.nome);
        }    
    }
}