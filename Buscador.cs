using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    public abstract class Busca
        {
            //Album por Artista
            public static List<Album> AlbunsPorArtista(Artista artista, string nomeArtista)
            {
                var _albuns =   from albuns in artista.albuns
                                where artista.nome == nomeArtista
                                select albuns;
                return _albuns.ToList();
            }

            //Album por ano
            public static List<Album> AlbunsPorArtistaPorAno(Artista artista, int ano)
            {
                var _albuns =   from albuns in artista.albuns where albuns.dataLancamento.Year == ano select albuns;
                return _albuns.ToList();
            }

            //Musica por Artista
            public static List<Musica> MusicaPorArtista(Artista artista)
            {
                var _musicas =  from albuns in artista.albuns from musicas in albuns.musicas select musicas;
                return _musicas.ToList();
            }

            //Musica por ano
            public static List<Musica> MusicaPorArtistaPorAno(int ano, Artista artista)
            {
                var _musicas =  from albuns in artista.albuns from musicas in albuns.musicas where albuns.dataLancamento.Year == ano select musicas;
                return _musicas.ToList();
            }

            //Álbum por gênero
            public static List<Album> AlbunsPorGeneroPorProdutor(Produtor produtor, string genero)
            {
                var _albuns =   from albuns in produtor.albuns where albuns.genero == genero select albuns;
                return _albuns.ToList();
            }

            //Album por ano
            public static List<Album> AlbunsPorAnoPorProdutor(Produtor produtor, int ano)
            {
                var _albuns =   from albuns in produtor.albuns where albuns.dataLancamento.Year == ano select albuns;
                return _albuns.ToList();
            }

            //Lista ordenada decrescente
            public static List<Album> AlbunsOrdenadosDecrescentePorArtista(Artista artista)
            {
                var _albuns =   from albuns in artista.albuns orderby albuns.dataLancamento select albuns;
                return _albuns.ToList();
            }
        }
}