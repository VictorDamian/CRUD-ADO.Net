using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    // Toda clase que herede de T va poder sustituir a T
    public abstract class AbstractSale
    {
        protected decimal amount;
        protected string customer;

        public abstract void Generate();
    }
    public abstract class SaleWithTaxes : AbstractSale
    {
        protected decimal taxes;
        public abstract void CalculateTaxes();
    }
    public class ForeignSale : AbstractSale
    {
        // Acceso a los miembros heredados
        public ForeignSale(decimal amount, string customer)
        {
            this.amount = amount;
            this.customer = customer;
        }
        public override void Generate()
        {
            Console.WriteLine("Calcular impuestos");
        }
    }

    public class LocalSale : SaleWithTaxes
    {
        // Acceso a los miembros heredados
        public LocalSale(decimal amount, string customer, decimal taxes)
        {
            this.amount = amount;
            this.customer = customer;
            this.taxes = taxes;
        }

        public override void CalculateTaxes()
        {
            Console.WriteLine("Generar venta");
        }
        public override void Generate()
        {
            Console.WriteLine("Calcular impuestos");
        }
    }
    public class SaleInvoice : SaleWithTaxes
    {
        // Acceso a los miembros heredados
        public SaleInvoice(decimal amount, string customer, decimal taxes)
        {
            this.amount = amount;
            this.customer = customer;
            this.taxes = taxes;
        }

        public override void CalculateTaxes()
        {
            Console.WriteLine("Generar venta");
        }
        public override void Generate()
        {
            Console.WriteLine("Calcular impuestos");
        }
        public void XML()
        {
            Console.WriteLine("Generar factura");
        }
    }
}
