using LGProgramaDeEstagio2021.Modelos;
using LGProgramaDeEstagio2021.Modelos.Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021.Repositorios
{
    public abstract class RepositorioGenerico<T> : IRepositorio<T> where T : Entidade
    {
        private List<T> listaGenerica;

        public RepositorioGenerico(){
            listaGenerica = new List<T>();
        }
        public void Delete(T obj)
        {
            listaGenerica.Remove(obj);
        }

        public void Insert(T obj)
        {
            if (!listaGenerica.Contains(obj))
            {
                obj.Codigo = listaGenerica.Count() + 1;
                listaGenerica.Add(obj);
            }
        }
        public List<T> Select(Func<T, bool> filtro)
        => listaGenerica.Where(filtro).ToList();
        public List<T> ConsultarTodos()
         => listaGenerica;
    }
}
