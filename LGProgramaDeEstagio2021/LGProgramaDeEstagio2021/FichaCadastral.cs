using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class FichaCadastral
    {
        public void CadastraFuncionario(string nome,  
            float salarioContratual,
            DateTime dataAdmissao, 
            EnumTipoFuncionario enumTipoFuncionario)
        {
            if (ValidaNome(nome))
                throw new ArgumentException();

            if (ValidaSalarioContratual(salarioContratual))
                throw new ArgumentException();

            if (ValidaDataAdmissao(dataAdmissao))
                throw new ArgumentException();

        }

        private bool ValidaDataAdmissao(DateTime dataAdmissao)
            => dataAdmissao > DateTime.Now;

        private bool ValidaSalarioContratual(float salarioContratual)
            => salarioContratual <= 0;

       
        private bool ValidaNome(string nome)
            => string.IsNullOrEmpty(nome);

        public void CadastraFuncionario(string nome, 
            float salarioContratual, 
            DateTime dataAdmissao, 
            EnumTipoFuncionario enumTipoFuncionario,
            CNH cnh)
        {
            if (ValidaNome(nome))
                throw new ArgumentException();

            if (ValidaSalarioContratual(salarioContratual))
                throw new ArgumentException();

            if (ValidaDataAdmissao(dataAdmissao))
                throw new ArgumentException();

            if (ValidaCNH(cnh))
                throw new ArgumentException();

        }

        private bool ValidaCNH(CNH cnh)
            => !(cnh != null && cnh.Numero > 0 && cnh.DataValidade != default(DateTime));
       
    }
}
