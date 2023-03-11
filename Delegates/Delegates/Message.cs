using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Delegates
{
    public class Message
    {
        public delegate string ObterMensagemEspecifica();

        public static string ObterMensagem(ObterMensagemEspecifica mensagemEspecifica)
        {
            string mensagem = $"essa mensagem retornou do delegate: { mensagemEspecifica() } !!!";

            return mensagem;
        }
    }
}
