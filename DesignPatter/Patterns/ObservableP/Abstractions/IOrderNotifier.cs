using Patterns.ObservableP.Models;

namespace Patterns.ObservableP.Abstractions
{
    public interface IOrderNotifier
    {
        void Attach(IOrderObserver observer);
        void Detach(IOrderObserver observer);
        void Notify(Order order);
    }
}