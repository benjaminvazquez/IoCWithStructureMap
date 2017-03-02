// -----------------------------------------------------------------------
// <copyright file="UserCreated.cs" company="Mk">
//   Benjamín Vázquez
// </copyright>
// -----------------------------------------------------------------------

namespace Mk.DomainEventsManager.Use.DomainEvents
{
    using System;
    using Domains;

    public class UserCreated : IDomainEvent
    {
        private DateTime eventOccurred;

        public UserCreated(User usr)
        {
            this.eventOccurred = DateTime.Now;
            this.Name = string.Format("{0} {1}", usr.FirstName, usr.LastName);
            this.Email = usr.Email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }

        public DateTime EventOccurred
        {
            get
            {
                return this.eventOccurred;
            }
        }
    }
}