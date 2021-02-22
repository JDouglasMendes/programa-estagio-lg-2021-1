using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Modelos.Relatorio
{
    public static class GeradorRelatorio
    {
        public static void GerarRelatorio(IRelatorio relatorio)
        {
            relatorio.GerarRelatorio();
        }
    }
}
