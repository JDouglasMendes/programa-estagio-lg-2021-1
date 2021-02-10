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
                .Where(propriedade => propriedade.GetCustomAttribute(null) != null).ToList();
            var mensagens = new List<string>();
            propriedades.ForEach(propriedade =>
            {
                var valor = propriedade.GetValue(obj);
                var atributos = propriedade.GetCustomAttributes().ToList();
                atributos.ForEach(atributo =>
                {
                    var validacao = atributo as IValidacao;
                    if (!validacao.Valide(valor))
                        mensagens.Add(validacao.Mensagem);
                 });
            });

            return mensagens;
        }

    }
}
