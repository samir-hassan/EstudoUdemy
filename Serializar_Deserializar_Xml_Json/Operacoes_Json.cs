using _00_biblioteca;
using System;
using System.IO;
using System.Web.Script.Serialization;

namespace Serializar_Deserializar_Xml_Json
{
    internal class Operacoes_Json
    {
        internal void Serializar()
        {
            Usuario usuario = new Usuario { Nome = "Asgard", Email = "Asgard@hotmail.com", Cpf = "4142241" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string serializado = serializador.Serialize(usuario);

            StreamWriter stream = new StreamWriter(@"C:\Users\samir\Source\Repos\EstudoUdemy\Auxiliar\02_SerializarJson.json");
            stream.WriteLine(serializado);
            stream.Close();
        }

        internal void Deserializar()
        {
            StreamReader stream = new StreamReader(@"C:\Users\samir\Source\Repos\EstudoUdemy\Auxiliar\02_SerializarJson.json");
            string JsonToString = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)serializador.Deserialize(JsonToString, typeof(Usuario));

            Console.WriteLine(usuario.Nome);
            Console.ReadLine();
        }
    }
}