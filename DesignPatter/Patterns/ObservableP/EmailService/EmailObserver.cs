using Patterns.ObservableP.Abstractions;
using Patterns.ObservableP.Models;

namespace Patterns.ObservableP.EmailService
{
    public class EmailObserver : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine("ORder N° '{0}' status is updated to '{1}'. An email sent to customer.",
            order.OrderNumber, order.OrderStatus.ToString());
        }
    }
}