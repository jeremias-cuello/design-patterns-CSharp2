using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class UsersCrud : ICrud
    {
        public void Actualizar()
        {
            Console.WriteLine("Actualizando una usuario");
        }

        public void Agregar()
        {
            Console.WriteLine("Agregando una usuario");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminando una usuario");
        }

        public void CobrarVacuna()
        {
            Console.WriteLine("Cobrando vacuna");
        }
    }
}
