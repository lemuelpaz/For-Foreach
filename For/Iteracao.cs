using System;
using System.Collections.Generic;

namespace For
{
    public static class Iteracao
    {
        public static List<string> ExecutarFor(int inicio, int fim)
        {
            var resultados = new List<string>();

            for (int i = inicio; i <= fim; i++)
            {
                resultados.Add(i.ToString());
            }

            return resultados;
        }

        public static List<string> ExecutarForeach(IEnumerable<string> itens)
        {
            var resultados = new List<string>();

            foreach (var item in itens)
            {
                resultados.Add(item);
            }

            return resultados;
        }
    }
}