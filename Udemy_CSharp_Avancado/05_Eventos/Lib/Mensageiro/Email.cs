using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Eventos.Lib.Mensageiro
{
    class Email
    {
        public void EnviarMensagem(Video video)
        {
            Console.WriteLine($"Email Enviado para o video {video.Nome}");
        }
    }
}
