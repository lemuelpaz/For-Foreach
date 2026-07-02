using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var iteracao = new Iteracao();

            iteracao.ExecutarForSimples(5);

            string[] valores = { "Vinte", "Trinta", "Quarenta" };
            iteracao.ExecutarForeachStrings(valores);
        }
    }
}