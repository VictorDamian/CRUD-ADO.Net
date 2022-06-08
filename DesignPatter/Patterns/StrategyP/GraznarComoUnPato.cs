using Patterns.StrategyP.Abstractions;

namespace Patterns.StrategyP
{
    class GraznarComoUnPato : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("Cuac!, cuac!");
        }
    }
}