using System;

namespace Ex_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] Aster = { "*", "**", "***", "****", "*****", "******","*******", "********", "*********", "**********" };
            int lengthofAster = Aster.Length;

                Console.WriteLine("\n\n");

            for (i = 0; i < Aster.Length; i++)
            {
                Console.WriteLine(" {0} ", Aster[i]);
            }
        }
    }
}
