using Patterns.FactoryP.Abstractions;
using Patterns.FactoryP.Implementations;

namespace Patterns.FactoryP
{
    public class ConnRestFactory : IAbstractFactory
    {
        public MyConnection GetDB(ConnectionProviderType type)
        {
            return null;
        }

        public IConnectionRest GetRest(ConnectionProviderType url)
        {
            switch(url){
                case ConnectionProviderType.UserRest:
                    return (new ConnectionRestUsers());
                case ConnectionProviderType.SalesRest:
                    return (new ConnectionRestSales());
                default:
                    return null;
            }
        }
    }
}