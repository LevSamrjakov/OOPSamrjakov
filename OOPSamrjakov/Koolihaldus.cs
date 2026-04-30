using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public class Koolihaldus
    {
        // Kapseldatud list
        private List<Isik> inimesed = new List<Isik>();

        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                isik.Kirjelda();
            }
        }

        //public void OtsiNimeJärgi(string OtsitavNimi)
        //{
        //    bool Leitud = false;

        //    foreach (var isik in inimesed)
        //    {
        //        if (isik.Nimi.Contains(OtsitavNimi, StringComparison.OrdinalIgnoreCase))
        //        {
        //            isik.Kirjelda();
        //            Console.WriteLine("---------------------");
        //            Leitud = true;
        //        }
        //    }

        //    if (!Leitud)
        //    {
        //        Console.WriteLine("Otsitav isik ei leitud!");
        //    }
        //}

        // 1. Otsing nime järgi (võtab vastu stringi)
        public void Otsi(string otsitavNimi)
        {
            Console.WriteLine($"\nOtsime nime: {otsitavNimi}");
            foreach (var isik in inimesed)
            {
                if (isik.Nimi.Contains(otsitavNimi)) isik.Kirjelda();
            }
        }

        // 2. Otsing nimekirjas numbri/sünniaasta järgi (sama nimi, aga võtab vastu int)
        public void Otsi(int sünniaasta)
        {
            Console.WriteLine($"\nOtsime kedagi, kes on sündinud aastal: {sünniaasta}");
            // Siin eeldame, et lisasime Isik klassile ka Sünniaasta tagasi
        }
    }
}
