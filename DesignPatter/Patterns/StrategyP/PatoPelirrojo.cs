using Patterns.StrategyP.Abstractions;

namespace Patterns.StrategyP
{
    class PatoPelirrojo : Pato
    {
        public PatoPelirrojo() : 
        base(new VolarConAlas(),new GraznarComoUnPato()){}

        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato pelirrojo");
        }

        public override void Nadar()
        {
            Console.WriteLine("Nadando");
        }
    }
}