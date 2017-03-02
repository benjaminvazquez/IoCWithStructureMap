// -----------------------------------------------------------------------
// <copyright file="DomainEventsManager.cs" company="Mk">
//   Benjamín Vázquez
// </copyright>
// ------------------------------------------------------------------------

namespace Mk.DomainEventsManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StructureMap;

    public class DomainEventsManager
    {
        [ThreadStatic]
        private static List<Delegate> actions;
        public static IContainer Container { get; set; }

        static DomainEventsManager()
        {
            Container = new Container();
        }

        public static void Register<T>(Action<T> callback) where T : IDomainEvent
        {
            if (actions == null)
            {
                actions = new List<Delegate>();
            }

            actions.Add(callback);
        }

        public static void ClearCallbacks()
        {
            actions = null;
        }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            foreach (var handler in Container.GetAllInstances<IHandle<T>>())
            {
                handler.Handle(args);
            }

            if (actions != null)
            {
                foreach (var action in actions.Where(x => x is Action<T>))
                {
                    ((Action<T>)action)(args);
                }
            }
        }
    }
}