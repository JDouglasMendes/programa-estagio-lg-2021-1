using LGProgramaDeEstagio2021.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class FichaCadastral
    {
        private RepositorioGenerico<Funcionario> repositorioFuncionario;

        public FichaCadastral(RepositorioGenerico<Funcionario> repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
        }

        public void CadastraFuncionario(string nome,
            float salarioContratual,
            DateTime dataAdmissao,
            EnumTipoFuncionario enumTipoFuncionario)
        {
            SalveFuncionario(nome, salarioContratual, dataAdmissao, enumTipoFuncionario, null);
        }
        public void CadastraFuncionario(string nome,
                    float salarioContratual,
                    DateTime dataAdmissao,
                    EnumTipoFuncionario enumTipoFuncionario,
                    CNH cnh)
        {
            SalveFuncionario(nome, salarioContratual, dataAdmissao, enumTipoFuncionario, cnh);

        }
        private bool ValidaDataAdmissao(DateTime dataAdmissao)
            => dataAdmissao > DateTime.Now;

        private bool ValidaSalarioContratual(float salarioContratual)
            => salarioContratual <= 0;

        private bool ValidaNome(string nome)
            => string.IsNullOrEmpty(nome);



        private void SalveFuncionario(string nome,
            float salarioContratual,
            DateTime dataAdmissao,
            EnumTipoFuncionario enumTipoFuncionario,
            CNH cnh)
        {
            if (ValidaCNH(cnh))
                throw new ArgumentException();
            
            Funcionario funcionario = FabricaFuncionarios.Crie(nome,
                salarioContratual,
                dataAdmissao,
                enumTipoFuncionario,
                cnh);
            var mensagens = ValidadorGenerico.ValideGenerico(funcionario);
            if (!mensagens.Any())
                repositorioFuncionario.Insert(funcionario);
        }

        private bool ValidaCNH(CNH cnh)
            => !(cnh == null || (cnh.Numero > 0 && cnh.DataValidade != default(DateTime)));

    }
}
