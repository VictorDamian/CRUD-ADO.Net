using Patterns.StrategyP.Abstractions;

namespace Patterns.StrategyP
{
    class GraznarEnSilencio : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("~");
        }
    }
}