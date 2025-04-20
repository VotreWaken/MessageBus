namespace Airbnb.Connection.ConnectionService.MessageBusConnection.Interfaces;

public interface IRetryPolicy
{
    Task ExecuteAsync(Func<Task> action);
}