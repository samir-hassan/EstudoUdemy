using System;

namespace _04_Delegate_Eventos
{
    public static class ExemploDelegate
    {
        delegate int calcula(int a, int b);

        public static void ExemploSimples()
        {
            calcula calc = new calcula(Soma);
            var retorno = calc(10, 20);

            Console.WriteLine(retorno);

            Console.ReadLine();

        }

        private static int Soma(int v1, int v2)
        {
            return v1 + v2;

        }

        internal static void Exemplo2()
        {
            Foto foto = new Foto { Nome = "Foto.jpeg", TamanhoX = 1920, TamanhoY = 1080 };

            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().PretroBranco;

            FotoProcessador.Processador(foto);

            Console.ReadKey();
        }

        private static int Subtrai(int v1, int v2)
        {
            return v1 - v2;
        }
    }
}