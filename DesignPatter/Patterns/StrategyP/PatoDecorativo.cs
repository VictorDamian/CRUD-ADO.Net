namespace Patterns.StrategyP
{
    class PatoDecorativo : Pato
    {
        public PatoDecorativo():
        base(new NoVolar(), new GraznarEnSilencio()){}
        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato decorativo");
        }

        public override void Nadar()
        {
            Console.WriteLine("No se nadar");
        }
    }
}