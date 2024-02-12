using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory fabricaBD = FactoryFactories.GetFactory("BD");
            MotorBD oracleBD = fabricaBD.FabricarBD("Oracle");
            MotorBD mysqlBD = fabricaBD.FabricarBD("mysql");

            oracleBD.Conectar();
            oracleBD.Desonectar();
            mysqlBD.Conectar();
            mysqlBD.Desonectar();

            AbstractFactory fabricaCrud = FactoryFactories.GetFactory(FactoryFactories.CRUD);
            ICrud crudMascotas = fabricaCrud.FabricarCrud(FactoryCrud.PETS);
            ICrud crudClientes = fabricaCrud.FabricarCrud(FactoryCrud.USERS);

            crudClientes.Agregar();
            crudMascotas.Agregar();
            PetsCrud m = new PetsCrud();
            m.Vacunarse();
            UsersCrud u = new UsersCrud();
            u.CobrarVacuna();
        }
    }
}
