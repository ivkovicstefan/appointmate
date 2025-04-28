# AppointMate.User.Domain.Abstractions

## IDomainEvent Abstraction
Represents a domain event in the system.
Used to capture important changes within the domain model that should trigger side effects or notifications.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/docs/User/Domain/Abstractions/images/IDomainEvent-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/docs/User/Domain/Abstractions/images/IDomainEvent-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 1 - IDomainEvent Abstraction diagram</p>

## IEntity Abstraction
Represents a domain entity with a unique identifier and defines auditing information for domain entities, such as creation and modification metadata.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/docs/User/Domain/Abstractions/images/IEntity-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/docs/User/Domain/Abstractions/images/IEntity-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 2 - IEntity Abstraction diagram</p>

## Entity Abstraction
Base class for domain entities, providing a unique identifier and auditing fields.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/docs/User/Domain/Abstractions/images/Entity-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/docs/User/Domain/Abstractions/images/Entity-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 3 - Entity Abstraction diagram</p>

## IAggregate Abstraction
Represents an aggregate root in the domain model with unique identifier.
Manages a collection of domain events and inherits auditing information.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/docs/User/Domain/Abstractions/images/IAggregate-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/docs/User/Domain/Abstractions/images/IAggregate-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 4 - IAggregate Abstraction diagram</p>

## Aggregate Abstraction
Abstract base class for aggregate roots.
Manages a list of domain events and provides methods to record and clear them.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/docs/User/Domain/Abstractions/images/Aggregate-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/docs/User/Domain/Abstractions/images/Aggregate-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 4 - Aggregate Abstraction diagram</p>
