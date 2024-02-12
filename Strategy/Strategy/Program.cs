using System;
using System.Diagnostics;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            int[] numeros = new int[10];

            ContarNumerosStrategy algoritmo = new ContarNumerosStrategy(ContarNumerosStrategy.Strategies.sinOrdenar);
            algoritmo.ContarNumeros(numeros);
        }
    }
}
