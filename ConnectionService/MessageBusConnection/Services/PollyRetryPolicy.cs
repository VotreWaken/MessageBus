using Airbnb.Connection.ConnectionService.MessageBusConnection.Interfaces;
using Polly;

namespace Airbnb.Connection.ConnectionService.MessageBusConnection.Services;

public class PollyRetryPolicy : IRetryPolicy
{
    private readonly IAsyncPolicy _policy;

    public PollyRetryPolicy(IAsyncPolicy policy)
    {
        _policy = policy;
    }

    public Task ExecuteAsync(Func<Task> action) => _policy.ExecuteAsync(action);
}
