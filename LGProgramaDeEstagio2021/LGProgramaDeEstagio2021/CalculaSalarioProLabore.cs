using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class CalculaSalarioProLabore : ICalcularSalario
    {
        public DateTime MesCalculo;
        public CalculaSalarioProLabore(int mes, int ano)
        {
            MesCalculo = new DateTime(ano, mes, 1);
        }
        public float CalculaSalario(Funcionario funcionario)
        {
            int diasUteis = CalcularDiasUteis.Calcula(MesCalculo.Month, MesCalculo.Year);
            int diasMes = MesCalculo.Month;

            return (funcionario.SalarioContratual / diasMes) * diasUteis;
        }
    }
}
