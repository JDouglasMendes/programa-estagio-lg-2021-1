using LG.ExemploDLL;
using LGProgramaDeEstagio2021.Modelos.Calculo;
using LGProgramaDeEstagio2021.Modelos.Relatorio;
using LGProgramaDeEstagio2021.Repositorios;
using System;

namespace LGProgramaDeEstagio2021
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Boxing             = tipo primitivo >>>>> tipo por referência. (object)
            // Unboxing           = tipo por referência. (object) >>>>>> tipo primitivo
            // Variancia          = Funcionario CLT >>>>> Funcionario >>>>> Entidade >>>>> Object
            // Contra variancia   = Object >>>> Entidade .........

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
            var repositorioValoresCalculados = new RepositorioValoresCalculados();
            var repositorioAfastamentoFuncionario = new RepositorioAfastamentoFuncionario();
            var repositorioDiasTrabalhados = new RepositorioDiasTrabalhados();
            var registroDiasTrabalhados = new RegistroDiasTrabalhados(repositorioDiasTrabalhados);


            GeradorFuncionario.GerarFuncionario(repositorioFuncionario, 40);
            //var relatorioFuncionarioAsc = new RelatorioCrescenteNome(repositorioFuncionario);
            //relatorioFuncionarioAsc.GerarRelatorio();

            //var relatorioFuncionarioDesc = new RelatorioDecrescenteNome(repositorioFuncionario);

            //GeradorRelatorio.GerarRelatorio(new RelatorioDecrescenteNome(repositorioFuncionario));
            GeradorRelatorio.GerarRelatorio(new RelatorioAdmissaoDataNome(repositorioFuncionario,true));


            // relatorioFuncionarioDesc.GerarRelatorio();

            /*
            registroDiasTrabalhados.AdicionarRegistro(31, new DateTime(2021, 2, 5), new DateTime(2021, 2, 10));
            registroDiasTrabalhados.AdicionarRegistro(32, new DateTime(2021, 2, 5), new DateTime(2021, 2, 10));
            registroDiasTrabalhados.AdicionarRegistro(33, new DateTime(2021, 2, 5), new DateTime(2021, 2, 12));

            repositorioFuncionario.ConsultarTodos().ForEach(funcionario =>
            CalculadoraSalarioFuncionario.CalculaSalario(funcionario,
            repositorioValoresCalculados,
            repositorioAfastamentoFuncionario,
            repositorioDiasTrabalhados,
            2021,
            2));

            repositorioValoresCalculados.ConsultarTodos().ForEach(valorCalculado =>
            Console.WriteLine(valorCalculado.Matricula + " : " + valorCalculado.Salario));
            */



            /*
                Criar um relatorio com as seguites informaçoes
            1- Matricula do funcionario / Nome do funcionario / Mes e Ano calculo / Valor calculado /
               -> Ordenado por matricula ou nome
               *lambda inner join

            */
            /*
             O Desafio FINAL!
            - Criar um novo tipo de funcionário (Menor Aprendiz)
            - Esse tipo de funcionário não poderá ter mais de 21 Anos de Idade
            - Para o Cálculo, terá a mesma regra do CLT, porém sem considerar Afastamentos.
            - Por fim apresentar o seguinte Relatório:
            - Categoria: CLT, Autonomo, Prolabore, Intermitente, Menor Aprendiz.
                - Nome:
                - Data Admissão:
                - Valor Salario Contratual
                - Valor Calculado
                - Idade do funcionário

               Para Cada funcionário saltar uma linha
             */
            Console.Read();
        }
    }
}