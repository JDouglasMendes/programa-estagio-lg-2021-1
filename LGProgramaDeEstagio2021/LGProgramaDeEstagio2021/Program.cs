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

            var funcionario = new FuncionarioAutonomo("Teste",
                1,
                10000,
                DateTime.Now);
            //  var mensagens = ValidadorGenerico.ValideGenerico(funcionario);
            var repositorio = new RepositorioValoresCalculados();

            var calculo = new CalculaSalarioAutonomo(
                repositorio,
                2,
                2021);

            calculo.CalculaSalario(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.Read();
        }
    }
}