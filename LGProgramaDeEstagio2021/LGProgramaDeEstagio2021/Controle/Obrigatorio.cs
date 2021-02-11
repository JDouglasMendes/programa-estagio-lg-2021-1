using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class Obrigatorio : Attribute, IValidacao
    {
        public Obrigatorio(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; }

        public bool Valide(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                if (obj.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty(obj.ToString()))
                        return false;                
                }
            }
            return true;
        }
    }
}
