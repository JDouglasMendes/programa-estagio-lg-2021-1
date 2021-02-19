using LGProgramaDeEstagio2021.Modelos.Calculo;
using LGProgramaDeEstagio2021.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class CalculadoraSalarioFuncionario
    {
        public static void CalculaSalario(Funcionario funcionario,
            RepositorioValoresCalculados repositorioValoresCalculados,
            RepositorioAfastamentoFuncionario  repositorioAfastamentoFuncionario,
            int ano ,
            int mes)
        {
            if (funcionario is FuncionarioCLT)
            {
                var calculaSalarioCLT = new CalculaSalarioCLT(repositorioValoresCalculados, repositorioAfastamentoFuncionario, mes, ano);
                calculaSalarioCLT.CalculaSalario(funcionario);
            }
            else if (funcionario is FuncionarioAutonomo)
            {
                var calculaSalarioAutonomo = new CalculaSalarioAutonomo(repositorioValoresCalculados, mes, ano);
                calculaSalarioAutonomo.CalculaSalario(funcionario);
            }
            else if (funcionario is FuncionarioProlabore)
            {
                var calculaSalarioProlabore = new CalculaSalarioProLabore(repositorioValoresCalculados, mes, ano);
                calculaSalarioProlabore.CalculaSalario(funcionario);
            }
        }

           
    }
}
