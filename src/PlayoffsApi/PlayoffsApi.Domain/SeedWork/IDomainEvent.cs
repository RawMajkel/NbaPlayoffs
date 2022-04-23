using MediatR;

namespace PlayoffsApi.Domain.SeedWork;

public interface IDomainEvent : INotification
{
    DateTime OccurredOn { get; }
}