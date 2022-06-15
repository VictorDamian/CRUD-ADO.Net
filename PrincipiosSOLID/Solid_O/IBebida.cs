using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_O
{
    public interface IBebida
    {
        public string Name { get; set; }
        public decimal Invoice { get; set; }
        public decimal Price { get; set; }
        public decimal GetPrice();
    }
    public class Soda : IBebida
    {
        public string Name { get;set ; }
        public decimal Invoice { get ;set; }
        public decimal Price { get; set; }

        public decimal GetPrice()
        {
            return Price * Invoice;
        }
    }
    public class Beer : IBebida
    {
        public string Name { get; set; }
        public decimal Invoice { get;set; }
        public decimal Price { get; set; }

        public decimal GetPrice()
        {
            var iva = Price * Invoice;
            return iva + Price;
        }
    }
    public class Juice : IBebida
    {
        public string Name { get; set; }
        public decimal Invoice { get; set; }
        public decimal Price { get; set; }
        public decimal Promo { get; set; }
        public decimal GetPrice()
        {
            var iva = Price * Invoice;
            return (iva+Price)-Promo;
        }
    }

public class Invoice
{
    public decimal GetTotal(IEnumerable<IBebida> ltsBebida)
    {
        decimal total = 0;
        foreach(var bebida in ltsBebida)
        {
            total = bebida.GetPrice();
        }
        return total;
    }
}
}
