using Patterns.FactoryP.Abstractions;

namespace Patterns.FactoryP.Implementations
{
    public class ConnectionRestSales : IConnectionRest
    {
        public string readURL(string url)
        {
            return "Conctado al servicio ventas";
        }
    }
}