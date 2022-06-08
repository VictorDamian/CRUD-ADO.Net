using Patterns.FactoryP.Abstractions;
using Patterns.FactoryP.Implementations;

namespace Patterns.FactoryP
{
    public class ConnDBFactory : IAbstractFactory
    {
        public MyConnection GetDB(ConnectionProviderType type)
        {
            switch(type){
                case ConnectionProviderType.SQLConnection:
                    return (new ConnectionSQL());
                case ConnectionProviderType.MySQLConnection:
                    return (new ConnectionMySQL());
                default:
                    return null;
            }
        }

        public IConnectionRest GetRest(ConnectionProviderType url)
        {
            throw new NotImplementedException();
        }
    }
}