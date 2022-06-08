using Patterns.StrategyP.Abstractions;

namespace Patterns.StrategyP
{
    public class VolarConAlas : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Volar con alas");
        }
    }
}