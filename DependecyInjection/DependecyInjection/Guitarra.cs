using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection
{
    class Guitarra : IInstrumento
    {
        public void Sonar()
        {
            Console.WriteLine("GUITARRA: Ra raaa ra ra");
        }

        public void Mantener()
        {
            Console.WriteLine("Afinando las cuerdas");
        }
    }
}
