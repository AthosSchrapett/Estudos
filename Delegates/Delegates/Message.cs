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

        public delegate string ObterOutraMensagemEspecifica(string novaMensagem);

        public static string ObterMensagem(ObterMensagemEspecifica mensagemEspecifica)
        {
            string mensagem = $"essa mensagem retornou do delegate: { mensagemEspecifica() } !!!";

            return mensagem;
        }

        public static string ObterOutraMensagem(ObterOutraMensagemEspecifica mensagemEspecifica)
        {
            string valorVazio = string.Empty;

            string mensagem = $"essa mensagem retornou do delegate: { mensagemEspecifica(valorVazio) } !!!";

            return mensagem;
        }
    }
}
