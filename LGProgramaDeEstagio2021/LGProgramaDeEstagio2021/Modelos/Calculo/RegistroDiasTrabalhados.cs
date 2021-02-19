using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Modelos.Calculo
{
    public class RegistroDiasTrabalhados
    {
        private IRepositorio<DiasTrabalhadosIntermitente> repositorioDiasTrabalhados;

        public RegistroDiasTrabalhados(IRepositorio<DiasTrabalhadosIntermitente> repositorioDiasTrabalhados) 
        {
            this.repositorioDiasTrabalhados = repositorioDiasTrabalhados;
        }
        public void AdicionarRegistro(int matricula, DateTime dataInicio, DateTime dataFim) {
            repositorioDiasTrabalhados.Insert(new DiasTrabalhadosIntermitente
            {
                Matricula = matricula,
                DataInicio = dataInicio,
                DataFim = dataFim
            });
        }
    }
}
