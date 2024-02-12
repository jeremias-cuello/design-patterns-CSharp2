using System;

namespace DependecyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IInstrumento guitarra = new Guitarra();
            IInstrumento flauta = new Flauta();

            Musico musico = new Musico(guitarra);
            musico.Tocar();

            musico = new Musico(flauta);
            musico.Tocar();
        }
    }
}
