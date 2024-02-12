using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class AbstractFactory
    {
        public abstract ICrud FabricarCrud(string crud);
        public abstract MotorBD FabricarBD(string motor);
    }
}
