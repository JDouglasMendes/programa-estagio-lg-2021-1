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
            int diasMes = DateTime.DaysInMonth(MesCalculo.Year, MesCalculo.Month);
            int diasUteis = 0;
            while (MesCalculo.Day <= diasMes)
            {
                if (!(MesCalculo.DayOfWeek == DayOfWeek.Saturday || MesCalculo.DayOfWeek == DayOfWeek.Sunday))
                    diasUteis += 1;
     
                MesCalculo = MesCalculo.AddDays(1); 
            }

            return (funcionario.SalarioContratual / diasMes) * diasUteis;
        }
    }
}
