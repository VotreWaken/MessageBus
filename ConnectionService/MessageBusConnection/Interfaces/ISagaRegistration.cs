namespace Airbnb.Connection.ConnectionService.MessageBusConnection.Interfaces;

public interface ISagaRegistration
{
    void Register<TSaga>() where TSaga : class;
}