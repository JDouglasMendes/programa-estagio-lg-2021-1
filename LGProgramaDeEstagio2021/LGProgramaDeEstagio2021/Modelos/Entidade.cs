using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Modelos
{
    public abstract class Entidade : IEquatable<Entidade>
    {
        public int Codigo { get; set; }
        public bool Equals(Entidade funcionario)
            => funcionario.Codigo == this.Codigo;
        public override int GetHashCode()
            => this.Codigo.GetHashCode();
    }
}
