using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class UserAdmin : Colleague
    {
        public UserAdmin(IMediator mediator) : base(mediator)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine("El administrador recibe un mensaje: " + message);
        }
    }
}
