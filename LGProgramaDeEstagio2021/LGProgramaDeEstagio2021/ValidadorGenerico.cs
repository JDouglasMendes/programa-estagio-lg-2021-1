using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LGProgramaDeEstagio2021
{
    public static class ValidadorGenerico
    {
        public static List<string> Valide(object obj)
        {          
            var propriedades = obj.GetType()
                .GetProperties()
                .ToList()
                .Where(propriedade => propriedade.GetCustomAttribute<Obrigatorio>() != null).ToList();
            var mensagens = new List<string>();
            propriedades.ForEach(propriedade =>
            {
                var valor = propriedade.GetValue(obj);
                if (valor == null)
                {
                    mensagens.Add(propriedade.GetCustomAttribute<Obrigatorio>().Mensagem);
                }else
                {
                    if (valor.GetType() == typeof(string))
                    {
                        if(string.IsNullOrEmpty(valor.ToString()))
                            mensagens.Add(propriedade.GetCustomAttribute<Obrigatorio>().Mensagem);
                    }                    
                }                                    
            });

            return mensagens;
        }
    }
}
