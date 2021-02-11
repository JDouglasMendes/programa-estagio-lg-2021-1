using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    class CalculaSalarioCLT : ICalcularSalario
    {
        public float CalculaSalario(Funcionario funcionario)
        {
            return funcionario.SalarioContratual;
            throw new NotImplementedException();
        }
    }
}
