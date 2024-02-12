using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Animal : ICloneable
    {
        public string Nombre { get; set; }
        public int Patas { get; set; }
        public Detalles Rasgos { get; set; }

        public object Clone ()
        {
            Animal animalClonado = this.MemberwiseClone() as Animal;
            Detalles detalles = new Detalles
            {
                Color = this.Rasgos.Color,
                Raza = this.Rasgos.Raza
            };
            animalClonado.Rasgos = detalles;
            
            return animalClonado;
        }

        public override string ToString ()
        {
            return String.Format("Animal [ Nombre: {0} - Patas: {1} - Detalles : {2} ]" , Nombre , Patas , Rasgos);
        }
    }

    class Detalles
    {
        public string Color { get; set; }
        public string Raza { get; set; }

        public override string ToString ()
        {
            return String.Format("Detalles[ Color: {0} - Raza: {1} ]" , Color , Raza);
        }
    }
}
