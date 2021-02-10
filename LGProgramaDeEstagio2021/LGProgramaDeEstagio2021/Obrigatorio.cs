using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class Obrigatorio : Attribute
    {
        public Obrigatorio(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; }
    }
}
