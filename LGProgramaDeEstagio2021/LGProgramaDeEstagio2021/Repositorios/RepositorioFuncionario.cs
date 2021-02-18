using System.Collections.Generic;

namespace LGProgramaDeEstagio2021
{
    public class RepositorioFuncionario : IRepositorio<Funcionario>
    {
        private List<Funcionario> listaFuncionario;

        public RepositorioFuncionario()
        {
            listaFuncionario = new List<Funcionario>();
        }

        public void Insert(Funcionario funcionario)
        {
            if (!listaFuncionario.Contains(funcionario))
            {
                funcionario.Matricula = GetListaCount() + 1;
                listaFuncionario.Add(funcionario);
            }
        }

        public void Delete(Funcionario funcionario)
        {
            listaFuncionario.Remove(funcionario);
        }

        public int GetListaCount()
        {
            return listaFuncionario.Count;
        }
        public Funcionario GetFuncionarioIndice(int indice)
          => listaFuncionario[indice];
        public List<Funcionario> ConsultarTodos()
         => listaFuncionario;
    }
}