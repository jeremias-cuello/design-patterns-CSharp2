using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Mediator : IMediator
    {
        private List<Colleague> colegas;

        public Mediator()
        {
            colegas = new List<Colleague>();
        }

        public void Add(Colleague colega)
        {
            colegas.Add(colega);
        }

        public void Send(string message, Colleague colega)
        {
            foreach (Colleague c in colegas)
            {
                if (c != colega)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
