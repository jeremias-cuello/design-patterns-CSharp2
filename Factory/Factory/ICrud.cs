using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    interface ICrud
    {
        void Agregar();
        void Eliminar();
        void Actualizar();
    }
}
