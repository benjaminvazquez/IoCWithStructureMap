// -----------------------------------------------------------------------
// <copyright file="IDomainEvent.cs" company="Mk">
//   Benjamín Vázquez
// </copyright>
// -----------------------------------------------------------------------

namespace Mk.DomainEventsManager
{
    using System;

    public interface IDomainEvent
    {
        DateTime EventOccurred { get; }
    }
}
