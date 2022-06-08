using Patterns.StrategyP.Abstractions;

namespace Patterns.StrategyP
{
    class GraznarComoUnaBocina : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("Mec!, mec!");   
        }
    }
}