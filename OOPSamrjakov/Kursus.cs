using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public class Kursus
    {
        public string Nimi { get; set; }
        public Õpetaja VastutavÕpetaja { get; set; }

        public void KuvaInfo()
        {
            Console.WriteLine($"Kursus: {Nimi}");
            if (VastutavÕpetaja != null)
            {
                Console.WriteLine($"Vastutav õpetaja: {VastutavÕpetaja.Nimi}");
            }
        }

        public Kursus(string nimi, Õpetaja vastutavÕpetaja)
        {
            Nimi = nimi;
            VastutavÕpetaja = vastutavÕpetaja;
        }
    }
}
