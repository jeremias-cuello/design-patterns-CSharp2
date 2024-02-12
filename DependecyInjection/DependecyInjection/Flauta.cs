using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection
{
    class Flauta : IInstrumento
    {
        public void Sonar()
        {
            Console.WriteLine("FLAUTA: Tuuuu turu turu turuuuuu");
        }

        public void Mantener()
        {
            Console.WriteLine("Limpiando saliva");
        }
    }
}
