using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public static class  GeradorFuncionario
    {

        public static void GerarFuncionario(RepositorioFuncionario repositorioFuncionario, int quantidadeFuncionario)
        {   FichaCadastral fichaCadastral = new FichaCadastral(repositorioFuncionario);

            int index = 0;
            float salario = 2;
            
            while (index < quantidadeFuncionario)
            {
                if (index == 0)
                    salario = 2;
                else if (index == 1)
                    salario = 3;
                else
                    salario *= 2;

                fichaCadastral.CadastraFuncionario("teste", salario, DateTime.Now, TipoFuncionario(index));


                index++;

            }
            
        }
        public static EnumTipoFuncionario TipoFuncionario(int matricula)
        {
            if (matricula < 10)
                return EnumTipoFuncionario.CLT;
            if (matricula < 20)
                return EnumTipoFuncionario.AUTONOMO;
            else
                return EnumTipoFuncionario.PROLABORE;

        }

    }
}
