using LGProgramaDeEstagio2021.Modelos.Calculo;
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
        private readonly IRepositorio<ValoresCalculados> repositorioValoresCalculados;
        private readonly IRepositorio<AfastamentoFuncionario> repositorioAfastamentoFuncionario;
        public CalculaSalarioCLT(
            IRepositorio<ValoresCalculados> repositorioValoresCalculados,
            IRepositorio<AfastamentoFuncionario> repositorioAfastamentoFuncionario,
            int mes,
            int ano)
        {
            MesCalculo = new DateTime(ano, mes, 1);
            this.repositorioValoresCalculados = repositorioValoresCalculados;
            this.repositorioAfastamentoFuncionario = repositorioAfastamentoFuncionario;
        }
        public void CalculaSalario(Funcionario funcionario)
        {
            var afastamentosNoMes = repositorioAfastamentoFuncionario.
                Select(x =>
            {
                return x.DataInicio.Year == MesCalculo.Year &&
                x.DataInicio.Month == MesCalculo.Month && 
                x.Matricula == funcionario.Matricula;
            }).Sum(x => (x.DataFim - x.DataInicio).Days);

            // condição ? parte verdadeira : parte falsa.

            repositorioValoresCalculados.Insert(new ValoresCalculados
            {
                Salario = afastamentosNoMes <= 15 ? 
                funcionario.SalarioContratual : 
                ((funcionario.SalarioContratual / DateTime.DaysInMonth(MesCalculo.Year, MesCalculo.Month)) * 
                (afastamentosNoMes - DateTime.DaysInMonth(MesCalculo.Year, MesCalculo.Month))),
                Matricula = funcionario.Matricula,
                Mes = MesCalculo
            });
        }

        

    }
}
