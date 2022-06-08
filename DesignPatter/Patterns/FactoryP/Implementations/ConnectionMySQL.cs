using Patterns.FactoryP.Abstractions;

namespace Patterns.FactoryP.Implementations
{
    public class ConnectionMySQL : MyConnection
    {
        public override string Connections()
        {
            return "Conectado a Mysql";
        }
    }
}