using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class OtraConexion
    {
        private const string conexion = "mismoUsuario";
        
        public OtraConexion()
        {
            Console.WriteLine("OtraConexion - Se creo.");
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
