using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Ordenado : IContarNumeros
    {
        public void Contar(int[] numeros)
        {
            Console.WriteLine("Contando numeros ordenado");
        }
    }
}
