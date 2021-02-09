using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class CNH
    {
        public CNH(int numero, DateTime dataValidade)
        {
            Numero = numero;
            DataValidade = dataValidade;
        }

        public int Numero { get;private set; }
        public DateTime DataValidade { get;private set; }
    }
}
