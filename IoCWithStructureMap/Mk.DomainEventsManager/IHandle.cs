// -----------------------------------------------------------------------
// <copyright file="IHandle.cs" company="Mk">
//   Benjamín Vázquez
// </copyright>
// -----------------------------------------------------------------------

namespace Mk.DomainEventsManager
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}