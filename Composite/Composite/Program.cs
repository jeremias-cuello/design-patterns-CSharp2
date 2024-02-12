using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrediente ing1 = new Ingrediente("Leche", 1500, 1, "Litro");
            Ingrediente ing2 = new Ingrediente("Harina", 100, 2, "Kilo");
            Ingrediente ing3 = new Ingrediente("Dulce de  Leche", 500, 250, "gramos");

            PastelComposite pastel = new PastelComposite("Pastel de dulce de leche");
            pastel.Add(ing1);
            pastel.Add(ing2);
            pastel.Add(ing3);

            Console.WriteLine(pastel.Costo);

            PastelComposite pastelDeChocolate = new PastelComposite("Pastel de Chocolate");
            Ingrediente ing4 = new Ingrediente("Chocolate", 300, 250, "gramos");
            pastelDeChocolate.Add(ing4);
            pastelDeChocolate.Add(pastel);

            Console.WriteLine(pastelDeChocolate.Costo);
        }
    }
}
