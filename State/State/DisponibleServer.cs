using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class DisponibleServer : ServerState
    {
        public override void Recibir()
        {
            Console.WriteLine("Recibido. Code Status: 200");
        }
    }
}
