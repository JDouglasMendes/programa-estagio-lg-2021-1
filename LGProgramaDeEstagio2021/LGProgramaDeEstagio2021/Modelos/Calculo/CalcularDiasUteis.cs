using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class CalcularDiasUteis
    {

        public static int Calcula(int mes, int ano)
        {
            var MesCalculo = new DateTime(ano, mes, 1);
            var diasMes =  new DateTime(ano, mes, DateTime.DaysInMonth(MesCalculo.Year, MesCalculo.Month));
            int diasUteis = 0;
            while (MesCalculo <= diasMes)
            {
                if (!(MesCalculo.DayOfWeek == DayOfWeek.Saturday || MesCalculo.DayOfWeek == DayOfWeek.Sunday))
                    diasUteis += 1;

                MesCalculo = MesCalculo.AddDays(1);
            }
            return diasUteis;
        }
    }
}
