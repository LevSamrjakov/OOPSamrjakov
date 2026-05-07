using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }
        public string Kuurs { get; set; }

        public Üliõpilane(string nimi, string eriala, Õppevorm staatus)
        {

        }

        public override string Kirjelda()
        {
            string üli_õpilane = $"Üliõpilane {Nimi} õpib {Kuurs}. Kuursusel. Vorm: {Staatus}";
            return üli_õpilane;
        }

        //public override void Kirjelda()
        //{
        //    base.Kirjelda();
        //    Console.WriteLine($"Eriala: {Eriala}.");
        //}
    }
}
