using System;

namespace Patterns.ObservableP.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public OrderStatuses OrderStatus {get;set;}

        public void OrderData()
        {
            Console.WriteLine();
            Console.WriteLine($"Order number :\t{OrderNumber}\nDate :\t{OrderDate}\nAmount :\t{TotalAmount}\nStatus :\t{OrderStatus}"
            );
        }
    }
}