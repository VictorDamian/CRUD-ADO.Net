using Patterns.FactoryP.Abstractions;

namespace Patterns.FactoryP.Implementations
{
    public class ConnectionSQL : MyConnection
    {
        public override string Connections()
        {
            return "Conectado a SQL";
        }
    }
}