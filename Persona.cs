using System;

namespace POO_C_
{
    public class Persona
    {
        string Minombre;
        int Miedad;

        public string _Minombre1 { get => Minombre; set => Minombre = value; }
        public int _Miedad1 { get => Miedad; set => Miedad = value; }

        public Persona(string nombre,int edad)
        {
            _Minombre1 = nombre;
            _Miedad1 = edad;
        }

        public void Hablar()
        {
            Console.WriteLine("Me llamo " + _Minombre1 +" y tengo "+_Miedad1+" años");
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