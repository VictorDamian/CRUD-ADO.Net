using System;

namespace POO_C_
{
    public class Humano
    {
        public Humano(){

        }
        private string nombre;
        private int edad;
        private string sexo;

        public string _Nombre { get => nombre; set => nombre = value; }
        public int _Edad { get => edad; set => edad = value; }
        public string _Sexo { get => sexo; set => sexo = value; }

        public Humano(string nombre, int edad)
        {
            _Nombre = nombre;
            _Edad = edad;
        }
        public void Hablar()
        {
            Console.WriteLine("Hola, me llamo "+_Nombre+" y tendo "+_Edad+" años.");
        }
        public void IrEscuela()
        {
            Console.WriteLine(nombre+" va a la escuela.");
        }
    }
}