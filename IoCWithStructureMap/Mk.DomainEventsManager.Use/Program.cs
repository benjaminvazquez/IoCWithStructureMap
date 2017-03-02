// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Mk">
//   Benjamín Vázquez
// </copyright>
// -----------------------------------------------------------------------

namespace Mk.DomainEventsManager.Use
{
    using System;
    using DomainEvents;
    using Domains;

    class Program
    {
        static void Main(string[] args)
        {
            DomainEventsManager.Container.Configure(config =>
            {
                config.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.ConnectImplementationsToTypesClosing(typeof(IHandle<>));
                });
            });

            User user = new User();
            user.Email = "email@email.com";
            user.FirstName= "Benjamín";
            user.LastName = "Vázquez";
            DomainEventsManager.Raise(new UserCreated(user));
            Console.ReadLine();
        }

    }
}
