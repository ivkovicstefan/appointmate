using MediatR;

namespace AppointMate.User.Domain.Abstractions
{
    public interface IDomainEvent : INotification
    {
        Guid EventId => Guid.NewGuid();
        public string OccuredOn => GetType().AssemblyQualifiedName;
    }
}
