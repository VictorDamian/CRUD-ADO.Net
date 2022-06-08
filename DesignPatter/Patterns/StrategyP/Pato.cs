using Patterns.StrategyP.Abstractions;

namespace Patterns.StrategyP
{
    abstract class Pato
    {
        private readonly IVolar _strategyVolar;
        private readonly IGraznar _strategyGraznar;

        protected Pato(IVolar strategyVolar, IGraznar strategyGraznar)
        {
            _strategyVolar = strategyVolar;
            _strategyGraznar = strategyGraznar;
        }
        public void Graznar()
        {
            _strategyGraznar.Graznar();
        }
        public void Volar()
        {
            _strategyVolar.Volar();
        }
        public abstract void Nadar();
        public abstract void Mostrar();
    }
}