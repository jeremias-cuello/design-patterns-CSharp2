using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Ingrediente : Component
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }

        public Ingrediente(string nombre, decimal costo, int cantidad, string unidad)
            : base(nombre, costo)
        {
            this.Cantidad = cantidad;
            this.Unidad = unidad;
        }
    }
}
