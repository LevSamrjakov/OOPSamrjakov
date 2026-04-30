using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }

        public Üliõpilane(string nimi, string eriala, Õppevorm staatus)
        {

        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen üliõpilane {Nimi} ja õpin {Eriala}. Vorm: {Staatus}");
        }

        //public override void Kirjelda()
        //{
        //    base.Kirjelda();
        //    Console.WriteLine($"Eriala: {Eriala}.");
        //}
    }
}
