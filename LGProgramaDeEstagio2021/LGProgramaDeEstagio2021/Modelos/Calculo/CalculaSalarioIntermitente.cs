using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Modelos.Calculo
{
    public class CalculaSalarioIntermitente : ICalcularSalario
    {
        private IRepositorio<ValoresCalculados> repositorioValoresCalculados;
        private IRepositorio<DiasTrabalhadosIntermitente> repositorioDiasTrabalhados;
        private DateTime mesCalculo;

        public CalculaSalarioIntermitente(IRepositorio<ValoresCalculados> repositorioValoresCalculados, IRepositorio<DiasTrabalhadosIntermitente> repositorioDiasTrabalhados, int mes, int ano)
        {
            this.repositorioValoresCalculados = repositorioValoresCalculados;
            this.repositorioDiasTrabalhados = repositorioDiasTrabalhados;
            mesCalculo = new DateTime(ano, mes, 1);
        }

        public void CalculaSalario(Funcionario funcionario)
        {
            var diasTrabalhados = repositorioDiasTrabalhados.
                Select(x =>
                {
                    return x.DataInicio.Year == mesCalculo.Year &&
                    x.DataInicio.Month == mesCalculo.Month &&
                    x.Matricula == funcionario.Codigo;
                }).Sum(x => (x.DataFim - x.DataInicio).Days);

            repositorioValoresCalculados.Insert(new ValoresCalculados
            {
                Salario = (funcionario.SalarioContratual / DateTime.DaysInMonth(mesCalculo.Year, mesCalculo.Month))*diasTrabalhados,
                Matricula = funcionario.Codigo,
                Mes = mesCalculo
            });

        }
    }
}
