using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class MaiorQue : Attribute, IValidacao
    {
            public MaiorQue (int numero, string mensagem)
            {
                Mensagem = mensagem;
                Numero = numero;
            }
        public string Mensagem { get; }
        public float Numero { get; }

        public bool Valide(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                if (Numero > float.Parse(obj.ToString()))
                    return false;
            }
            return true;
        }
    }
}
