using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public abstract class Funcionario
    {
        protected Funcionario(string nome, int matricula, float salarioContratual, DateTime dataAdmissao)
        {
            Nome = nome;
            Matricula = matricula;
            SalarioContratual = salarioContratual;
            DataAdmissao = dataAdmissao;
        }

        public string Nome { get;private set; }
        public int Matricula { get;private set; }
        public float SalarioContratual { get;private set; }
        public DateTime DataAdmissao { get;private set; }
        public CNH CNH { get;set; }


    }
}
