using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Reflections
{
    class Program
    {


        static void Main(string[] args)
        {

            GetDescription();

            Usuario usu = new Usuario { Nome = "Samir", Senha = "1234", Email = "Samir.hassan@live.com" };
            Log.Gravar(usu.Clone());
            usu.Email = "Samir@live.com";
            Log.Gravar(usu.Clone());

            Carro carro = new Carro { Marca = "Honda", Modelo = "Civic" };
            Log.Gravar(carro.Clone());
            carro.Modelo = "New Civic";
            Log.Gravar(carro);

            Log.ApresentarLogs();

            Console.Read();
        }

        private static void GetDescription()
        {
            Console.WriteLine("REFLECTIONS \n" +
                              "1. Muito usado para logs \n");
        }
    }
}
