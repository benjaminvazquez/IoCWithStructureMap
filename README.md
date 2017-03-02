# IoCWithStructureMap
Using IoC with StructureMap and C#

In this project I'm using Inversion of Control with Structure Map to detect an specific interface IHandle. When IDomainEvent is raised, all implementations with the DomainEvent configured executes his Handle event. 

With this, the developer only worry about generate events, and all the listeners will be decoupled from the business logic.
