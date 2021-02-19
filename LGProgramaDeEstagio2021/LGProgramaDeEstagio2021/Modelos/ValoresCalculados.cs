using LGProgramaDeEstagio2021.Modelos;
using System;

namespace LGProgramaDeEstagio2021
{
    public class ValoresCalculados : Entidade
    {
        // Codigo | Matricula | Mes | Salario
        public DateTime Mes { get; set; }
        public int Matricula { get; set; }
        public float Salario { get; set; }
    }
}