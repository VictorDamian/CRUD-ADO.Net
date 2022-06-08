using Patterns.ObservableP.Abstractions;
using Patterns.ObservableP.Models;

namespace Patterns.ObservableP
{
    public class OrderService : IOrderService
    {
        List<IOrderObserver> Observers = new List<IOrderObserver>();
        public void Attach(IOrderObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(Order order)
        {
            foreach(var obs in Observers){
                obs.Update(order);
            }
        }

        public void UpdateOrder(Order order)
        {
            Notify(order);
        }
    }
}