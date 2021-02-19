using LGProgramaDeEstagio2021.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class FabricaFuncionarios
    {
        public static Funcionario Crie(string nome,
            float salarioContratual,
            DateTime dataAdmissao,
            EnumTipoFuncionario enumTipoFuncionario,
            CNH cnh)
        {
            Funcionario funcionario = null;
            switch (enumTipoFuncionario)
            {
                case EnumTipoFuncionario.AUTONOMO:
                    funcionario = new FuncionarioAutonomo(nome, 0, salarioContratual, dataAdmissao);
                    break;

                case EnumTipoFuncionario.CLT:
                    funcionario = new FuncionarioCLT(nome, 0, salarioContratual, dataAdmissao);
                    break;

                case EnumTipoFuncionario.PROLABORE:
                    funcionario = new FuncionarioProlabore(nome, 0, salarioContratual, dataAdmissao);
                    break;

                case EnumTipoFuncionario.INTERMITENTE:
                    funcionario = new FuncionarioIntermitente(nome, 0, salarioContratual, dataAdmissao);
                    break;

                default:
                    throw new ArgumentException("Tipo nao mapeado na fabrica");
            }
            funcionario.CNH = cnh;
            return funcionario;
        }
    }
}
