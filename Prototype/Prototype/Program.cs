using System;

namespace Prototype
{
    class Program
    {
        static void Main (string[] args)
        {
            Animal oAnimal = new Animal() { Nombre = "Oveja", Patas = 4 };
            oAnimal.Rasgos = new Detalles() { Color = "Marron" , Raza = "Oveja Del Sur" };

            // Animal animalClonado = oAnimal;
            Animal animalClonado = oAnimal.Clone() as Animal;

            animalClonado.Patas = 8;
            animalClonado.Rasgos.Color = "Blanco";

            Console.WriteLine(oAnimal);
            Console.WriteLine(animalClonado);

        }
    }
}
