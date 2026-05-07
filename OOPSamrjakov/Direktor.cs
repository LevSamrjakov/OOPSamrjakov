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

        public override string Kirjelda()
        {
            string direktor_kirjelda = $"Mina olen direktor: {Nimi} ";
            return direktor_kirjelda;
        }

        public override double ArvutaPalk()
        {
            return base.ArvutaPalk() + LisaTasu;
        }
    }
}
