// See https://aka.ms/new-console-template for more information
using Solid_O;

Console.WriteLine("Principio abierto/Cerrrado");
SolidO();

void SolidO()
{
    IBebida[] obj =
    {
        new Juice
        {
            Name = "Jugo de mora",
            Invoice = 0.35m,
            Price = 10.0m,
            Promo = 0.55m
        },
        new Beer
        {
            Name = "Corona",
            Invoice = 0.14m,
            Price = 18.0m
        }
    };
    Invoice ltsBebidas = new Invoice();
    Console.WriteLine("{0}",ltsBebidas.GetTotal(obj));
}