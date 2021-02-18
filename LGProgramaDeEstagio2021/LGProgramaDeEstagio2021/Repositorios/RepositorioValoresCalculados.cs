using LGProgramaDeEstagio2021.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public class RepositorioValoresCalculados : RepositorioGenerico, IRepositorio<ValoresCalculados>
    {
        private List<ValoresCalculados> listaValoresCalculados;

        public RepositorioValoresCalculados()
        {
            listaValoresCalculados = new List<ValoresCalculados>();
        }

        public void Delete(ValoresCalculados obj)
        {
            listaValoresCalculados.Remove(obj);
        }

        public void Insert(ValoresCalculados obj)
        {
            if (!listaValoresCalculados.Contains(obj))
                listaValoresCalculados.Add(obj);
        }
        public List<ValoresCalculados> ConsultarTodos()
         => listaValoresCalculados;

        public List<ValoresCalculados> Select(Func<ValoresCalculados, bool> filtro)
        {
            throw new NotImplementedException();
        }
    }
}
