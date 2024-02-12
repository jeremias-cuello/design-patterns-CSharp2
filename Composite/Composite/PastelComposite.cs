using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class PastelComposite : Component
    {
        List<Component> ingredientes = new List<Component>();

        public new decimal Costo
        {
            get
            {
                decimal costo = 0;
                foreach (var oElement in ingredientes)
                {
                    if (oElement.GetType().Name == "PastelComposite")
                    {
                        costo += ((PastelComposite)oElement).Costo;
                    }
                    else
                    {
                        costo += oElement.Costo;
                    }
                }

                return costo;
            }
        }

        public void Add(Component component)
        {
            ingredientes.Add(component);
        }

        public void Remove(Component component)
        {
            ingredientes.Remove(component);
        }

        public PastelComposite(string nombre, decimal costo = 0) : base (nombre, costo)
        {
            Nombre = nombre;
        }
    }
}
