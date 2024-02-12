using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ServerContext
    {
        private ServerState state;
        public void setState(ServerState state)
        {
            this.state = state;
        }

        public void AtenderSolicitud()
        {
            state.Recibir();
        }
    }
}
