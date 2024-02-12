using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            User user = new User(mediator);
            UserAdmin admin = new UserAdmin(mediator);

            mediator.Add(user);
            mediator.Add(admin);

            user.Comunicate("Oye Admin tengo un problema.");
        }
    }
}
