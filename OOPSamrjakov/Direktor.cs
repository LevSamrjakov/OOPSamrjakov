using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public class Direktor : Õpetaja
    {
        public double LisaTasu { get; set; }

        public Direktor(string nimi, double lisaTasu, double baaspalk)
        {
            LisaTasu = lisaTasu;
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen direktor, minu nimi on {Nimi} ja ma saan lisa tasu {LisaTasu}");
        }

        public override double ArvutaPalk()
        {
            return base.ArvutaPalk() + LisaTasu;
        }
    }
}
