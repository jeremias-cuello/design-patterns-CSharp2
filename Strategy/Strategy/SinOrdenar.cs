using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class SinOrdenar : IContarNumeros
    {
        public void Contar(int[] numeros)
        {
            Console.WriteLine("Contando numeros sin ordenar");
        }
    }
}
