using LGProgramaDeEstagio2021.Modelos.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class Relatorio : IRelatorio
    {
        private RepositorioFuncionario repositorioFuncionario;
        public Relatorio (RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            
        }
        public void GerarRelatorio()
        {
          var listaOrdenada =  repositorioFuncionario.ConsultarTodos().OrderBy(x => x.Nome).ToList();
            listaOrdenada.ForEach(x => Console.WriteLine(x.Nome));
                
        }
    }
}
