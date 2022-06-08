using Patterns.ObservableP.Abstractions;
using Patterns.ObservableP.Models;

namespace Patterns.ObservableP.EmailService
{
    public class SMSObserver : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine("ORder N° '{0}' status is updated to '{1}'. SMS msg sent to customer.",
            order.OrderNumber, order.OrderStatus.ToString());
        }
    }
}