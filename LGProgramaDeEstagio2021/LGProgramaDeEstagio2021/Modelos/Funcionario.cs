using LGProgramaDeEstagio2021.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public abstract class Funcionario :
        Entidade
    {
        [Obrigatorio("O Nome deve ser informado")]
        public string Nome { get; private set; }
        
        [MaiorQue(0 , "O salario deve ser maior que 0")]
        //[MenorQue(1000000, "O salario deve ser menor que 1.000.000")]
        public float SalarioContratual { get; private set; }

        public DateTime DataAdmissao { get; private set; }
        public CNH CNH { get; set; }

        protected Funcionario(
            string nome,
            int matricula,
            float salarioContratual,
            DateTime dataAdmissao)
        {
            Codigo = matricula;
            Nome = nome;
            SalarioContratual = salarioContratual;
            DataAdmissao = dataAdmissao;
        }

		public override bool Equals(object obj)
		{
			if (!(obj is Funcionario funcionario))
				return false;

            return Equals(funcionario);
        }

		public override string ToString()
		{
			return base.ToString();
		}       
	}
}
