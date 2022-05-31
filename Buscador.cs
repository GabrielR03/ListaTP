using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNS{
    public abstract class Buscador
        {
            //Album por Artista
            public static List<Album> AlbunsArtista(List<Artista> artistas, string nomeArtista)
            {
                var _albuns =   from artistasL in artistas
                                from albuns in artistasL.albuns
                                where artistasL.nome == nomeArtista
                                select albuns;
                    return _albuns.ToList();
            }
            //Album por ano
            public static List<Album> AlbunsArtistaAno(Artista artista, int ano)
            {
                var _albuns =   from albuns in artista.albuns
                                where albuns.dataLancamento.Year == ano
                                select albuns;
                return _albuns.ToList();
            }

            //Musica por Artista
            public static List<Musica> MusicaArtista(Artista artista)
            {
                var _musicas =  from albuns in artista.albuns
                                from musicas in albuns.musicas
                                select musicas;
                return _musicas.ToList();
            }

            //Musica por ano
            public static List<Musica> MusicaArtistaAno(int ano, Artista artista)
            {
                var _musicas =  from albuns in artista.albuns
                                from musicas in albuns.musicas
                                where musicas.lancamento.Year == ano
                                select musicas;
                return _musicas.ToList();
            }

            //Álbum por gênero
            public static List<Album> AlbunsGeneroProdutor(Produtor produtor, string genero)
            {
                var _albuns =   from albuns in produtor.albuns
                                where albuns.genero == genero
                                select albuns;
                return _albuns.ToList();
            }

            //Album por ano
            public static List<Album> AlbunsAnoProdutor(Produtor produtor, int ano)
            {
                var _albuns =   from albuns in produtor.albuns
                                where albuns.dataLancamento.Year == ano
                                select albuns;
                return _albuns.ToList();
            }

            //Lista ordenada decrescente
            public static List<Album> AlbunsDecrescenteArtista(Artista artista)
            {
                var _albuns =   from albuns in artista.albuns
                                orderby albuns.dataLancamento
                                select albuns;
                return _albuns.ToList();
            }
        }
}