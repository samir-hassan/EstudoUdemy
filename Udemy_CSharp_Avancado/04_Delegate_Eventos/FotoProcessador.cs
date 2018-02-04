using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Delegate_Eventos
{
    public static class FotoProcessador
    {

        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processador(Foto foto)
        {
            filtros(foto);
        }
    }
}
