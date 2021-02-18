using System;

namespace LGProgramaDeEstagio2021
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*
                1ª Funcionario CLT
                2ª Autonomo
                3ª Prolabore

                Criar 10 Funcionário de cada tipo,
                    onde o valor do salario seja a soma de todos os salarios anteriores iniciados de
                    1, somado 1 a cada novo salario.
                (Ex: 2,3,6,12.........) -> Salario Contratual.
                Não resetar o salário ao mudar de tipo.
                Calcular a folha para esses funcionários.
                Aprensentar no Console os salarios calculados "matricula: salario" Ex: 1: 200
                A matricula deve ser iniciado de 1 e cada novo somar mais 1;
                (Ex: 1,2,3,4,......30)
                Calcular mes 02/2021.
            */

            var repositorioFuncionario = new RepositorioFuncionario();
            GeradorFuncionario.GerarFuncionario(repositorioFuncionario, 30);

            var repositorioValoresCalculados = new RepositorioValoresCalculados();

            repositorioFuncionario.ConsultarTodos().ForEach(funcionario =>
            CalculadoraSalarioFuncionario.CalculaSalario(funcionario,
            repositorioValoresCalculados,
            2021,
            2));

            repositorioValoresCalculados.ConsultarTodos().ForEach(valorCalculado =>
            Console.WriteLine(valorCalculado.Matricula + " : " + valorCalculado.Salario));





            Console.Read();
        }
    }
}