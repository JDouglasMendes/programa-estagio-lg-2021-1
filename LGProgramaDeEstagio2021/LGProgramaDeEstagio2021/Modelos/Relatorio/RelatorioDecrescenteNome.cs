using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Modelos.Relatorio
{
	public class RelatorioDecrescenteNome : IRelatorio
	{
		RepositorioFuncionario repositorioFuncionario;

		public RelatorioDecrescenteNome(RepositorioFuncionario repositorioFuncionario)
		{
			this.repositorioFuncionario = repositorioFuncionario;
		}

		public void GerarRelatorio()
		{
			var listaOrdenada = repositorioFuncionario.ConsultarTodos().OrderByDescending(x => x.Nome).ToList();
			listaOrdenada.ForEach(x => Console.WriteLine(x.Nome));
		}
	}
}
