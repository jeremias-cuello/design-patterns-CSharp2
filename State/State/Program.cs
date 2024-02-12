using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerContext ctx = new ServerContext();

            DisponibleServer disponible = new DisponibleServer();
            ctx.setState(disponible);
            ctx.AtenderSolicitud();

            StarudoServer starudo = new StarudoServer();
            ctx.setState(starudo);
            ctx.AtenderSolicitud();

            ServerCaido caido = new ServerCaido();
            ctx.setState(caido);
            ctx.AtenderSolicitud();
        }
    }
}
