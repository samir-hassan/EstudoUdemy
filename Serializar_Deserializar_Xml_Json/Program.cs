using _00_biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Serializar_Deserializar_Xml_Json
{
    class Program
    {
        static void Main(string[] args)
        {

            Operacoes_Xml opXml = new Operacoes_Xml();
            //opXml.Serializar();
            //opXml.Deserializar();

            Operacoes_Json opJson = new Operacoes_Json();
            //opJson.Serializar();
            //opJson.Deserializar();
            
        }
    }
}
