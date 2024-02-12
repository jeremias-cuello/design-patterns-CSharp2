using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Colleague
    {
        private IMediator mediador;

        public Colleague(IMediator mediador)
        {
            this.mediador = mediador;
        }

        public void Comunicate(string mensaje)
        {
            mediador.Send(mensaje, this);
        }

        public abstract void Receive(string message);
    }
}
