using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class StarudoServer : ServerState
    {
        public override void Recibir()
        {
            Task.Delay(500);
            Console.WriteLine("Recibido. Code Status: 200. Delay de 500ms");
        }
    }
}
