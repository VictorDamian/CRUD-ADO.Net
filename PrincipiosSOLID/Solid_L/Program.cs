// See https://aka.ms/new-console-template for more information
using Solid_L;

Console.WriteLine("Principio Liskov");

SaleWithTaxes sale = new LocalSale(100,"Vic",0.16m);
sale.Generate();
sale.CalculateTaxes();
// Factuyra
sale = new SaleInvoice(100, "Damian", 0.42m);
sale.Generate();
sale.CalculateTaxes();

AbstractSale sale2 = new ForeignSale(200, "Pepe");
sale2.Generate();