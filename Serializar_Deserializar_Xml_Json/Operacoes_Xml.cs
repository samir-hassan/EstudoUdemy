using _00_biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializar_Deserializar_Xml_Json
{
    class Operacoes_Xml
    {
        internal void Serializar()
        {
            // Serializar - Transformar um objeto em um tipo String(Json, Xml)
            Usuario usuario = new Usuario { Nome = "Samir", Cpf = "48503596806", Email = "samir-hassan@live.com" };

            XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\Users\samir\Source\Repos\EstudoUdemy\Auxiliar\01_SerializarXml.xml");
            serializador.Serialize(stream, usuario);
        }

        internal void Deserializar()
        {
            StreamReader stream = new StreamReader(@"C:\Users\samir\Source\Repos\EstudoUdemy\Auxiliar\01_SerializarXml.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            Console.WriteLine(usuario.Nome);
            Console.WriteLine(usuario.Cpf);
            Console.WriteLine(usuario.Email);
            Console.ReadLine();
        }
    }
}
