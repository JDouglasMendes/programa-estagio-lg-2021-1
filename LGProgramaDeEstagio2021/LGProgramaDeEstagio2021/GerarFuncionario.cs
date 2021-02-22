using LGProgramaDeEstagio2021.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public static class  GeradorFuncionario
    {

        public static void GerarFuncionario(RepositorioGenerico<Funcionario> repositorioFuncionario, int quantidadeFuncionario)
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
                System.Threading.Thread.Sleep(50);
                fichaCadastral.CadastraFuncionario("Funcionário - " + new Random().Next(0, Int32.MaxValue),
                    salario,
                    DateTime.Now, 
                    TipoFuncionario(index));

                index++;
            }
            
        }
        public static EnumTipoFuncionario TipoFuncionario(int matricula)
        {
            if (matricula < 10)
                return EnumTipoFuncionario.CLT;
            if (matricula < 20)
                return EnumTipoFuncionario.AUTONOMO;
            if (matricula < 30)
                return EnumTipoFuncionario.PROLABORE;
            else
                return EnumTipoFuncionario.INTERMITENTE;

        }

    }
}
