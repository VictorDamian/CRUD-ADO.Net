using System;
using System.Collections.Generic;

namespace POO_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Niño niñ = new Niño("Pepito", 10);
            //niñ.Hablar();

            Niño niño1 = new Niño("Josecito");
            Niño niño2 = new Niño("Juancito");
            Niño niño3 = new Niño("Memito");
            Niño niño4 = new Niño("Luicito");
            Niño niño5 = new Niño("Carlitos");
            
            List<Humano> ListaNiños = new List<Humano>();
            ListaNiños.Add(niño1);
            ListaNiños.Add(niño2);
            ListaNiños.Add(niño3);
            ListaNiños.Add(niño4);
            ListaNiños.Add(niño5);

            foreach (Humano item in ListaNiños)
            {
                item.IrEscuela();
            }
        }
    }
}
