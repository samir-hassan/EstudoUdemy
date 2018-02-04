using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(Video video)
        {
            Console.WriteLine($"SMS Enviado para o video {video.Nome}");
        }
    }
}
