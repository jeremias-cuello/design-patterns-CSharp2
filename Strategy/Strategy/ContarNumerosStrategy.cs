using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ContarNumerosStrategy
    {
        private IContarNumeros strategy;
        public enum Strategies { ordenado, sinOrdenar };
        
        public ContarNumerosStrategy(Strategies strategyOptional)
        {
            switch (strategyOptional)
            {
                case Strategies.ordenado:
                    this.strategy = new Ordenado();
                    break;
                case Strategies.sinOrdenar:
                    this.strategy = new SinOrdenar();
                    break;
            }
        }

        public void ContarNumeros(int[] numeros)
        {
            this.strategy.Contar(numeros);
        }
    }
}
