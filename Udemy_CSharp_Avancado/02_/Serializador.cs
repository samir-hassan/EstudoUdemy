using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _02_
{
    class Serializador
    {
        public static void Serializar(Object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\samir\Source\Repos\EstudoUdemy\Udemy_CSharp_Avancado\02_\Auxiliar\03_"+obj.GetType().Name+".json");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader sw = new StreamReader(@"C:\Users\samir\Source\Repos\EstudoUdemy\Udemy_CSharp_Avancado\02_\Auxiliar\03_" + typeof(T).Name+".json");
            string JsonToString = sw.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T)serializador.Deserialize(JsonToString, typeof(T));

            return obj;
        }
    }
}
