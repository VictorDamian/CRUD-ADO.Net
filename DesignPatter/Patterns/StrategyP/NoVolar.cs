using Patterns.StrategyP.Abstractions;

namespace Patterns.StrategyP
{
    public class NoVolar : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("No puedo volar");
        }
    }
}