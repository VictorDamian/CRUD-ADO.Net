using Patterns.ObservableP.Models;

namespace Patterns.ObservableP.Abstractions
{
    public interface IOrderObserver
    {
         void Update(Order order);
    }
}