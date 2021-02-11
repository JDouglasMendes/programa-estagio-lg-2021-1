using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public interface IValidacao
    {
        bool Valide(object obj);
        string Mensagem { get; }

    }
}
