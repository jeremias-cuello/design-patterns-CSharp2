using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Conexion : Singleton<Conexion>
    {
        private const string conexion = "mismoUsuario";
        
        public Conexion()
        {
            Console.WriteLine("Conexion - Se creo.");
        }

        public void Conectar()
        {
            Console.WriteLine(String.Format("{0}: conectando a la base de datos", conexion));
        }

        public void Desconectar()
        {
            Console.WriteLine(String.Format("{0}: desconectando a la base de datos", conexion));
        }
    }
}
