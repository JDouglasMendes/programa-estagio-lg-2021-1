using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class RepositorioFuncionario
    {
        private List<Funcionario> listaFuncionario;
        public RepositorioFuncionario()
        {
            listaFuncionario = new List<Funcionario>();
        }
        public void Insert(Funcionario funcionario)
        {
            listaFuncionario.Add(funcionario);
        }

    }
}
