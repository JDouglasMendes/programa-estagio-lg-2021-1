using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class CalculaSalarioCLT : ICalcularSalario
    {
        public DateTime MesCalculo;
        private readonly IRepositorio<ValoresCalculados> repositorio;
        public CalculaSalarioCLT(
            IRepositorio<ValoresCalculados> res,
            int mes,
            int ano)
        {
            MesCalculo = new DateTime(ano, mes, 1);
            repositorio = res;
        }
        public void CalculaSalario(Funcionario funcionario)
        {
            repositorio.Insert(new ValoresCalculados
            {
                Salario = funcionario.SalarioContratual,
                Matricula = funcionario.Matricula,
                Mes = MesCalculo
            });
        }
    }
}
