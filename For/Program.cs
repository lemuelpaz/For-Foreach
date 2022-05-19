using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(i);
            }

            string[] valores = { "Vinte", "Trinta", "Quarenta" };

            foreach (string y in valores)
            {
                Console.WriteLine(y);
            }
        }
    }
}
