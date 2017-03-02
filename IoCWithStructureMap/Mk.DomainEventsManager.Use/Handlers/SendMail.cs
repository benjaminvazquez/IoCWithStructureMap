// -----------------------------------------------------------------------
// <copyright file="SendMail.cs" company="Mk">
//   Benjamín Vázquez
// </copyright>
// -----------------------------------------------------------------------

namespace Mk.DomainEventsManager.Use.Handlers
{
    using System;
    using DomainEvents;

    public class SendMail : IHandle<UserCreated>
    {
        public void Handle(UserCreated args)
        {
            Console.WriteLine(string.Format("Sending mail to: {0} at {1}", args.Email, args.EventOccurred));
        }
    }
}