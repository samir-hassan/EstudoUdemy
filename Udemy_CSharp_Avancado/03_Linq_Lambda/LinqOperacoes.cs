using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Linq_Lambda
{
    internal class LinqOperacoes
    {
        internal void Exemplo1()
        {
            /*
                         WHERE
                         SELECT
                         ORDER BY
                         */

            int[] arrayInt = { 3, 9, 5, 2, 1, 23, 21 };

            var array2 = arrayInt.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            //Mesa coisa de cima
            var array3 = from c in array2
                         where c > 10
                         orderby c
                         select c;

            foreach (var a in array2)
            {
                Console.WriteLine(a);
            }

            foreach (var a in array3)
            {
                Console.WriteLine(a);
            }

            Console.Read();
        }

        internal void ExemploGroupBy()
        {
            int[] listaNum = { 1, 1, 1, 1, 1, 5, 4, 4, 3, 2, 2, 1 };

            var listaDistinct = listaNum.GroupBy(a => a).Select(a => a);

            foreach (var item in listaDistinct)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadLine();
        }

        internal void ExemploJoin()
        {
            List<Livro> listaLivros = new List<Livro>();
            listaLivros.Add(new Livro { Titulo = "Anjos e Demônios", anoPublicacao = 2010, AutorId = 1, Id = 1 });
            listaLivros.Add(new Livro { Titulo = "Livro2", anoPublicacao = 2010, AutorId = 2, Id = 2 });
            listaLivros.Add(new Livro { Titulo = "Ponto de Impacto", anoPublicacao = 2010, AutorId = 1, Id = 3 });

            List<Autor> listaAutores = new List<Autor>();
            listaAutores.Add(new Autor { Id = 1, Nome = "Dan Brown" });
            listaAutores.Add(new Autor { Id = 2, Nome = "Autor2" });
            listaAutores.Add(new Autor { Id = 3, Nome = "Fabricio" });


            var ListaJoin = from livro in listaLivros
                            join autor in listaAutores on livro.AutorId equals autor.Id
                            select new { livro.Titulo, autor.Nome };

            foreach (var item in ListaJoin)
            {
                Console.WriteLine($"Livro: {item.Titulo} -- Autor: {item.Nome}");
            }

            Console.ReadLine();
        }

        internal void ExemploComObjetos()
        {
            Usuario usuario = new Usuario { Nome = "Samir", Idade = 20 };
            Usuario usuario2 = new Usuario { Nome = "Maria", Idade = 20 };
            Usuario usuario3 = new Usuario { Nome = "Vinicios", Idade = 20 };
            Usuario usuario4 = new Usuario { Nome = "Pedro", Idade = 20 };

            List<Usuario> lista = new List<Usuario>();
            lista.Add(usuario);
            lista.Add(usuario2);
            lista.Add(usuario3);
            lista.Add(usuario4);

            var listaFiltrada = from obj in lista
                                where obj.Nome.Contains("ria")
                                select obj;

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item.Nome);
            }

            Console.ReadLine();
        }
    }
}