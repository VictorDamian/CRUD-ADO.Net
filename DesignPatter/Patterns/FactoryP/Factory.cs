using Patterns.FactoryP.Abstractions;
using Patterns.FactoryP.Implementations;

namespace Patterns.FactoryP
{
    // Funcion es devolver instancias de una clase por medio de un ID
    public class Factory
    {
        public IAbstractFactory GetFactory(ConnectionService service)
        {
            switch(service){
                case ConnectionService.DB:
                    return (new ConnDBFactory());
                case ConnectionService.Rest:
                    return (new ConnRestFactory());
                default:
                    return null;
            }
        }
    }
}