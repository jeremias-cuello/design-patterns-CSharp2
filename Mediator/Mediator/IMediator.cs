using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    interface IMediator
    {
        void Send(string message, Colleague colega);
    }
}
