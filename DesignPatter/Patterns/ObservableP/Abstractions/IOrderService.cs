using Patterns.ObservableP.Models;

namespace Patterns.ObservableP.Abstractions
{
    public interface IOrderService:IOrderNotifier
    {
         void UpdateOrder(Order order);
    }
}