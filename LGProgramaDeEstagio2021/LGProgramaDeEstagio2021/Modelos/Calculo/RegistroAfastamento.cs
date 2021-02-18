using LGProgramaDeEstagio2021.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Modelos.Calculo
{
    public class RegistroAfastamento
    {
        private IRepositorio<AfastamentoFuncionario> repositorioAfastamentoFuncionario;
        public RegistroAfastamento(RepositorioAfastamentoFuncionario repositorioAfastamentoFuncionario)
        {
            this.repositorioAfastamentoFuncionario = repositorioAfastamentoFuncionario;
        }

        public void AdicionarRegistro(AfastamentoFuncionario afastamentoFuncionario)
        {
            repositorioAfastamentoFuncionario.Insert(afastamentoFuncionario);
        }

    }
}
