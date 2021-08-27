using System;

namespace POO_C_
{
    public class Persona
    {
        string Minombre;
        int Miedad;

        public Persona(string nombre,int edad)
        {
            Minombre = nombre;
            Miedad = edad;
        }

        public void Hablar()
        {
            Console.WriteLine("Me llamo " + Minombre +" y tengo "+Miedad+" años");
        }
        public void Caminar()
        {
            Console.Write("Estoy caminando");
        }
        public void Comer()
        {
            Console.Write("Estoy comiendo");
        }
    }
}