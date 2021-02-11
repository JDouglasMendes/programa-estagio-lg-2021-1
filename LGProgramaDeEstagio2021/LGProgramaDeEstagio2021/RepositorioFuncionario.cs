using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class RepositorioFuncionario : IRepositorio<Funcionario>
    {
        public List<Funcionario> listaFuncionario;        

        public RepositorioFuncionario()
        {
            listaFuncionario = new List<Funcionario>();
        }
        public void Insert(Funcionario funcionario)
        {                            
            if (!listaFuncionario.Contains(funcionario))
                listaFuncionario.Add(funcionario);            
        }
        public void Delete(Funcionario funcionario)
        {
            listaFuncionario.Remove(funcionario);
        }

    }
}
