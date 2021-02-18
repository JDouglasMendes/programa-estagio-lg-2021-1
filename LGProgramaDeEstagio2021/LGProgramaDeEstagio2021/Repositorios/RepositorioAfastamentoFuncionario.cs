using LGProgramaDeEstagio2021.Modelos.Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Repositorios
{
    public class RepositorioAfastamentoFuncionario : IRepositorio<AfastamentoFuncionario>
    {
        private List<AfastamentoFuncionario> listaAfastamentoFuncionario;
        public RepositorioAfastamentoFuncionario()
        {
            listaAfastamentoFuncionario = new List<AfastamentoFuncionario>();
        }
        public void Delete(AfastamentoFuncionario obj)
        {
            listaAfastamentoFuncionario.Remove(obj);
        }

        public void Insert(AfastamentoFuncionario obj)
        {
            if (!listaAfastamentoFuncionario.Contains(obj))
                listaAfastamentoFuncionario.Add(obj);
        }

        public List<AfastamentoFuncionario> Select(Func<AfastamentoFuncionario, bool> abobrinha)
            => listaAfastamentoFuncionario.Where(abobrinha).ToList();
    }
}
