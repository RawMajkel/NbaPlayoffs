using MediatR;

namespace PlayoffsApi.Application.Configuration.Queries;

public interface IQuery<out TResult> : IRequest<TResult>
{
}