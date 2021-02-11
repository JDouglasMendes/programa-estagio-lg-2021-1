using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class RepositorioFolhaPagamento : IRepositorio<ValoresCalculados>
    {
        List<ValoresCalculados> ListaValoresCalculados;

        public RepositorioFolhaPagamento()
        {
            ListaValoresCalculados = new List<ValoresCalculados>();
        }

        public void Delete(ValoresCalculados obj)
        {
            ListaValoresCalculados.Remove(obj);
        }

        public void Insert(ValoresCalculados obj)
        {
            if (!ListaValoresCalculados.Contains(obj))
                ListaValoresCalculados.Add(obj);
        }
    }
}
