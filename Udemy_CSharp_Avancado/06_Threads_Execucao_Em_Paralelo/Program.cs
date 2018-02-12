using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_Threads_Execucao_Em_Paralelo
{
    class Program
    {
        static ManualResetEvent manual;

        static void Main(string[] args)
        {
            manual = new ManualResetEvent(false);

            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start(1);

            Thread t2 = new Thread(ThreadRepeticao);
            t2.Start(2);

            Thread t3 = new Thread(ThreadRepeticao2);
            t3.Start(3);

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Fim");
            Console.WriteLine("Fim");
            Console.WriteLine("Fim");

            Console.Read();
        }

        static void ThreadRepeticao(object id)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Thread ID " + id + ": " + i + "  Id Interno: " + Thread.CurrentThread.ManagedThreadId);
            }

            manual.Set();
        }


        static void ThreadRepeticao2(object id)
        {
            for (int i = 0; i < 20; i++)
            {
                manual.WaitOne();
                Console.WriteLine("Thread ID " + id + ": " + i + "  Id Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
