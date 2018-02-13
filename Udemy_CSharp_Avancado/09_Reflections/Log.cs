using System.Collections.Generic;

namespace _09_Reflections
{
    internal class Log
    {

        public static List<object> objetos = new List<object>();

        public static void Gravar(object obj)
        {
            objetos.Add(obj);
        }

        public static void ApresentarLogs()
        {
            foreach (var obj in objetos)
            {
                System.Console.WriteLine("\n --- Nome da Classe: {0}  ---", obj.GetType().Name);
                foreach (var prop in obj.GetType().GetProperties())
                {
                    System.Console.WriteLine(prop.Name + ": " + prop.GetValue(obj));
                }
            }

            //public static List<Usuario> ListaUsuarios = new List<Usuario>();

            //public static void GravarUsuario(Usuario usu)
            //{
            //    ListaUsuarios.Add((Usuario)usu.Clone());
            //}

            //public static List<Carro> ListaCarros = new List<Carro>();

            //public static void GravarCarro(Carro carro)
            //{
            //    ListaCarros.Add(carro);
            //}

            //public static void ApresentarLog()
            //{
            //    ListaUsuarios.ForEach(u => System.Console.WriteLine(u.Email + ", " + u.Nome + ", " + u.Senha));

            //    ListaCarros.ForEach(u => System.Console.WriteLine(u.Marca+ ", " + u.Modelo));

            //}
        }
    }
}