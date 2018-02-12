using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Tasks_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Execução normal
            Task.Run(() => Metodo01());
            Task.Run(() => Metodo01());
            Task.Run(() => Metodo01());

            Console.Clear();

            List<Task> listaTasks = new List<Task>();
            listaTasks.Add(Task.Factory.StartNew(Metodo01));
            listaTasks.Add(Task.Factory.StartNew(Metodo01));
            listaTasks.Add(Task.Factory.StartNew(Metodo01));
            listaTasks.Add(Task.Factory.StartNew(Metodo01));
            listaTasks.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(listaTasks.ToArray());
            Console.WriteLine("Programa Finalizado");
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + " "+Task.CurrentId);
            }
        }
    }
}
