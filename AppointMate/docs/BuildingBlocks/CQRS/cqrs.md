# AppointMate.BuildingBlocks.CQRS

## ICommand Abstraction
Represents a command in the CQRS pattern that encapsulates an action or intent to change system state.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/ICommandAbstraction-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/ICommandAbstraction-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 1 - ICommand Abstraction diagram</p>

## ICommandHandler Abstraction
Represents a logical separation of command handler responsibilities.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/ICommandHandlerAbstraction-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/ICommandHandlerAbstraction-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 2 - ICommandHandler Abstraction diagram</p>

## IQuery Abstraction
Represents a query in the CQRS pattern that encapsulates an intent of data retrieval from the system.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/IQueryAbstraction-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/IQueryAbstraction-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 3 - IQuery Abstraction diagram</p>

## IQueryHandler Abstraction
Defines a handler for executing queries in the CQRS pattern, where queries represent read-only operations that return data without modifying system state.

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/IQueryHandlerAbstraction-Dark.png#gh-dark-mode-only">
    <img src="/AppointMate/src/BuildingBlocks/AppointMate.BuildingBlocks/docs/CQRS/images/IQueryHandlerAbstraction-Light.png#gh-light-mode-only">
  </picture>
</p>
<p align="center">Picture 4 - IQueryHandler Abstraction diagram</p>