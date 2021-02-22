using LGProgramaDeEstagio2021.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public interface IRepositorio<T> where T: Entidade
    {
        void Insert(T obj);
        void Delete(T obj);        
        List<T> ConsultarTodos();
        List<T> Select(Func<T, bool> filtro);
    }
}
