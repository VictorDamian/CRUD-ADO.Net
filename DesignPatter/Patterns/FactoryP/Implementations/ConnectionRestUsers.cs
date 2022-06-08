using Patterns.FactoryP.Abstractions;

namespace Patterns.FactoryP.Implementations
{
    public class ConnectionRestUsers : IConnectionRest
    {
        public string readURL(string url)
        {
            return "Conectado a servicio usuarios";
        }
    }
}