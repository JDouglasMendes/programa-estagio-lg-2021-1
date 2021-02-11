using System;

namespace LGProgramaDeEstagio2021
{
    public class CalculaSalarioProLabore : ICalcularSalario
    {
        public DateTime MesCalculo;
        private readonly IRepositorio<ValoresCalculados> repositorio;

        public CalculaSalarioProLabore(
            IRepositorio<ValoresCalculados> repositorio,
            int mes,
            int ano)
        {
            MesCalculo = new DateTime(ano, mes, 1);
            this.repositorio = repositorio;
        }

        public void CalculaSalario(Funcionario funcionario)
        {
            int diasUteis = CalcularDiasUteis.Calcula(MesCalculo.Month, MesCalculo.Year);
            int diasMes = DateTime.DaysInMonth(MesCalculo.Year, MesCalculo.Month);
            repositorio.Insert(new ValoresCalculados
            {
                Matricula = funcionario.Matricula,
                Mes = MesCalculo,
                Salario = (funcionario.SalarioContratual / diasMes) * diasUteis,
            });
        }
    }
}