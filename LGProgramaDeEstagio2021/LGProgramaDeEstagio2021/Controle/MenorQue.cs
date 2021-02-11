using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class MenorQue : Attribute, IValidacao
    {
        public MenorQue(int numero, string mensagem)
        {
            Mensagem = mensagem;
            Numero = numero;
        }

        public string Mensagem { get; }
        public int Numero { get; }

        public bool Valide(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                if (Numero < int.Parse(obj.ToString()))
                    return false;
            }
            return true;
        }
    }
}
