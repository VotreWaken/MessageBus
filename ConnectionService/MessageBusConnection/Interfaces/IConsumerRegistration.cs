namespace Airbnb.Connection.ConnectionService.MessageBusConnection.Interfaces;

public interface IConsumerRegistration
{
    void Register<T>(Func<T, Task> handler) where T : class;
}