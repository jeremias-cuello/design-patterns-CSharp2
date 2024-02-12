using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class MySQL : MotorBD
    {
        public override void Conectar()
        {
            Console.WriteLine("Conectando con la base de datos MySQL");
        }

        public override void Desonectar()
        {
            Console.WriteLine("Desconectando con la base de datos MySQL");
        }
    }
}
