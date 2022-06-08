namespace Patterns.FactoryP.Abstractions
{
    public interface IAbstractFactory
    {
        MyConnection GetDB(ConnectionProviderType type);
        IConnectionRest GetRest(ConnectionProviderType url);
    }
}