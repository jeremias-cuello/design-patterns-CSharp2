using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class FactoryBD : AbstractFactory
    {
        public const string ORACLE = "oracle";
        public const string MySQL = "mysql";

        public override MotorBD FabricarBD(string motor)
        {
            motor = motor.ToLower();
            switch (motor)
            {
                case ORACLE: return new Oracle();
                case MySQL: return new MySQL();
                default: return null;
            }
        }

        public override ICrud FabricarCrud(string crud)
        {
            return null;
        }
    }
}
