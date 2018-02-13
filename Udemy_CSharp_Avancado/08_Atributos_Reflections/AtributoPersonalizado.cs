using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Atributos_Reflections
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property| AttributeTargets.Method)]
    class AtributoPersonalizado: Attribute
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public AtributoPersonalizado(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
