using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class FactoryFactories
    {
        public const string CRUD = "crud";
        public const string BD = "bd";

        public static AbstractFactory GetFactory(string factory)
        {
            factory = factory.ToLower();
            switch (factory)
            {
                case CRUD: return new FactoryCrud();
                case BD: return new FactoryBD();
                default: return null;
            }
        }
    }
}
