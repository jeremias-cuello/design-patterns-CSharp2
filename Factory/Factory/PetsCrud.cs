using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class PetsCrud : ICrud
    {
        public void Actualizar()
        {
            Console.WriteLine("Actualizando una mascota");
        }

        public void Agregar()
        {
            Console.WriteLine("Agregando una mascota");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminando una mascota");
        }

        public void Vacunarse()
        {
            Console.WriteLine("Me vacuné");
        }
    }
}
