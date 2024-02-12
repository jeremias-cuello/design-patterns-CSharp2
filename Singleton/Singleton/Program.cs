using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // con singleton
            Conexion cx1 = Conexion.GetInstance();
            Console.WriteLine("cx1");
            cx1.Conectar();
            cx1.Desconectar();
            
            Conexion cx2 = Conexion.GetInstance();
            Console.WriteLine("cx2");
            cx2.Conectar();
            cx2.Desconectar();

            Conexion cx3 = Conexion.GetInstance();
            Console.WriteLine("cx3");
            cx3.Conectar();
            cx3.Desconectar();

            // sin singleton
            OtraConexion otrCx1 = new OtraConexion();
            Console.WriteLine("otrCx1");
            otrCx1.Conectar();
            otrCx1.Desconectar();

            OtraConexion otrCx2 = new OtraConexion();
            Console.WriteLine("otrCx2");
            otrCx2.Conectar();
            otrCx2.Desconectar();

            OtraConexion otrCx3 = new OtraConexion();
            Console.WriteLine("otrCx3");
            otrCx3.Conectar();
            otrCx3.Desconectar();

            // otro  singleton
            Calendario cld = Calendario.GetInstance();

            for (int i = 0; i < 4*12; i+=4)
            {
                Console.WriteLine(cld.GetMes(i));
            }

            Calendario cld2 = Calendario.GetInstance();

            Console.WriteLine("Ingrese semana: ");
            int semana = int.Parse(Console.ReadLine());
            string result = cld2.GetMes(semana);
            Console.WriteLine(result);
        }
    }
}
