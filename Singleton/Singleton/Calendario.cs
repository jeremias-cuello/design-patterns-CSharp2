using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Calendario : Singleton<Calendario>
    {
        private string[] Muchosmeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        public Calendario()
        {
            Console.WriteLine("Calendario - Se creo");
        }

        public string GetMes(int semana)
        {
            return Muchosmeses[semana / 4];
        }
    }
}
