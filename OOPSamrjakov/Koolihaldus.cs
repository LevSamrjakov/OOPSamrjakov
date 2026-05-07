using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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

        public void LisaInimene(List<Isik> uuedInimesed)
        {

            inimesed.AddRange(uuedInimesed);
            foreach (var isik in inimesed)
                Console.WriteLine($"Lisati {isik.Nimi} uue inimene.");
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                Console.WriteLine(isik.Kirjelda());
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

            bool leitud = false;

            foreach (var isik in inimesed)
            {
                if (isik.Nimi != null &&
                    isik.Nimi.Contains(otsitavNimi, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(isik.Kirjelda());
                    leitud = true;
                }
            }

            if (!leitud)
            {
                Console.WriteLine("Otsitav isik ei leitud!");
            }
        }

        // 2. Otsing nimekirjas numbri/sünniaasta järgi (sama nimi, aga võtab vastu int)
        public void Otsi(int sünniaasta)
        {
            Console.WriteLine($"\nOtsime kedagi, kes on sündinud aastal: {sünniaasta}");

            bool leitud = false;

            foreach (var isik in inimesed)
            {
                if (isik.Sünniaasta == sünniaasta)
                {
                    Console.WriteLine(isik.Kirjelda());
                    leitud = true;
                }
            }

            if (!leitud)
            {
                Console.WriteLine("Selle sünniaastaga isikut ei leitud!");
            }
        }

        public void SalvestaFaili(string failinimi)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(failinimi, false, Encoding.UTF8))
                {
                    sw.WriteLine($"--- KOOLI NIMEKIRI (Salvestatud: {DateTime.Now}) ---");

                    foreach (var isik in inimesed)
                    {
                        sw.WriteLine(isik.Kirjelda()); // Salvestame faili iga isiku kirjelduse
                    }
                }
                Console.WriteLine($"\nAndmed on edukalt salvestatud faili: {failinimi}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Viga salvestamisel: {e.Message}");
            }
        }

        public void KuvaAinultÕpilased()
        {
            foreach (var isik in inimesed)
            {
                if (isik is Õpilane)
                {
                    Console.WriteLine(isik.Kirjelda());
                }
            }
        }
    }
}
