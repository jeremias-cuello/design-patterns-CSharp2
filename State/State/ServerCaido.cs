using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ServerCaido : ServerState
    {
        public override void Recibir()
        {
            Task.Delay(1000);
            Console.WriteLine("Recibido. Code Status: 503. Delay: 1000");
        }
    }
}
