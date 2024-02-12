using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class FactoryCrud : AbstractFactory
    {
        public const string USERS = "users";
        public const string PETS = "mascotas";

        public override ICrud FabricarCrud(string entidad)
        {
            entidad = entidad.ToLower();
            switch (entidad)
            {
                case USERS: return new UsersCrud();
                case PETS: return new PetsCrud();
                default: return null;
            }
        }

        public override MotorBD FabricarBD(string motor)
        {
            return null;
        }
    }
}
