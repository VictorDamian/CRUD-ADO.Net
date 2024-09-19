using Patterns.FactoryP.Abstractions;
using Patterns.FactoryP.Implementations;

namespace Patterns.FactoryP
{
    public class ConnRestFactory : IAbstractFactory
    {
        public MyConnection GetDB(ConnectionProviderType type)
        {
            return type switch
            {
                ConnectionProviderType.SQLConnection => new ConnectionSQL(),
                ConnectionProviderType.MySQLConnection => new ConnectionMySQL(),
                _ => throw new ArgumentException("Tipo de conexi�n no soportado")
            };
        }

        public IConnectionRest GetRest(ConnectionProviderType url)
        {
            return url switch
            {
                ConnectionProviderType.SalesRest => new ConnectionRestSales(),
                ConnectionProviderType.UserRest => new ConnectionRestUsers(),
                _ => throw new ArgumentException("Tipo de conexi�n REST no soportado")
            };
        }
    }
}