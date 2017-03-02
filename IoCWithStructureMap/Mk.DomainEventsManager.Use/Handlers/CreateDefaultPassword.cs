// -----------------------------------------------------------------------
// <copyright file="CreateDefaultPassword.cs" company="Mk">
//   Benjamín Vázquez
// </copyright>
// -----------------------------------------------------------------------

namespace Mk.DomainEventsManager.Use.Handlers
{
    using System;
    using DomainEvents;

    public class CreateDefaultPassword : IHandle<UserCreated>
    {
        public void Handle(UserCreated args)
        {
            Console.WriteLine(string.Format("Generating default password for the user: {0}, at {1}", args.Name, args.EventOccurred));
        }
    }
}