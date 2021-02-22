using LGProgramaDeEstagio2021.Modelos.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class RelatorioAdmissaoDataNome : IRelatorio
    {
        private IRepositorio<Funcionario> repositorioFuncionario;
        private bool ordemCrescente;

        public RelatorioAdmissaoDataNome(IRepositorio<Funcionario> repositorio, bool ordemCrescente)
        {
            this.repositorioFuncionario = repositorio;
            this.ordemCrescente = ordemCrescente;
        }

        public void GerarRelatorio()
        {
            (ordemCrescente ?
            repositorioFuncionario.ConsultarTodos().OrderBy(x => x.DataAdmissao.Year)
            :
            repositorioFuncionario.ConsultarTodos().OrderByDescending(x => x.DataAdmissao.Year))
            .ThenBy(x => x.DataAdmissao.Month)
            .ThenBy(x => x.DataAdmissao.Day)
            .ThenBy(x => x.Nome)
            .ToList()
            .ForEach(x => Console.WriteLine(x.DataAdmissao + " - " + x.Nome));
        } 
        

    }
}
