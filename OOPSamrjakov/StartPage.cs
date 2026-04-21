using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public class StartPage
    {
        public static void Main()
        {
            //Klass ja Objekt
            //Isiku andmed
            //Isik Inimene1 = new Isik();
            //Inimene1.Nimi = "Lev";
            //Inimene1.Sünniaasta = 2008;
            //Inimene1.Vanus = 17;
            //Inimene1.Tervita(); //Väljund: Tere! Mina olen Lev...

            //Õpetaja andmed
            Õpetaja Õpetaja1 = new Õpetaja();
            Õpetaja1.Nimi = "Marina";
            Õpetaja1.Sünniaasta = 2008;
            Õpetaja1.Tervita();

            Õpetaja1.Aine = "Programmeerimine";
            Õpetaja1.Õpeta();

            Õpetaja1.Kirjelda();

            //Õpilase andmed
            Õpilane Õpilane1 = new Õpilane();
            Õpilane1.Nimi = "Konstantin";
            Õpilane1.Sünniaasta = 2008;
            Õpilane1.Tervita();

            Õpilane1.Kool = "Ehte Humanitaargümnaasium";
            Õpilane1.Klass = 11;
            Õpilane1.Õpi();

            Õpilane1.Kirjelda();

            //Õpilane, ITööline

            List<ITööline> Palgasaajad = new List<ITööline>();

            Õpilane Õpilane2 = new Õpilane { Nimi = "Kadi", Klass = 11, Kool = "Kutsehariduskeskus", KeskminneHinne = 4.5, Puudumised = 3, KasOnSotsiaalneTõend = false, Staatus = Õppevorm.Päevane };

            Õpetaja Õpetaja2 = new Õpetaja { Nimi = "Anna", Aine = "Python", Tunnitasu = 20, TunnidKuus = 80 };

            Palgasaajad.Add(Õpilane2);
            Palgasaajad.Add(Õpetaja2);

            //Palgasaajad.AddRange(new ITööline[] { Õpilane2, Õpilane3, Õpetaja2, Õpetaja3 });

            //2. Variant
            Random RND = new Random();
            string[] Nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };
            string[] Hinne = { "1", "2", "3", "4", "5" };
            //Õppevorm[] Õppevormid = { Õppevorm.Päevane, Õppevorm.Kaugõpe, Õppevorm.Ekstern, Õppevorm.AkadeemilinePuhkus };
            Õppevorm[] Õppevormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm));
            for (int I = 0; I < Nimed.Length; I++)
            {
                Õpilane Õpilane = new Õpilane()
                {
                    Nimi = Nimed[RND.Next(Nimed.Length)],
                    Klass = RND.Next(1, 13),
                    Kool = "TTHK",
                    KeskminneHinne = RND.NextDouble() * 5, //Keskmine hinne vahemikus 0-5
                    Puudumised = RND.Next(0, 350), //Puudumised vahemikus 0-350
                    KasOnSotsiaalneTõend = RND.Next(0, 2) == 1,
                    Staatus = Õppevormid[RND.Next(Õppevormid.Length)]
                };
                Palgasaajad.Add(Õpilane);
            }

            Console.WriteLine("--- Väljamaksed ---");
            foreach (ITööline Isik in Palgasaajad)
            {
                string Tüüp = Isik.VäljamakseTüüp.ToString();
                Console.WriteLine($"{Tüüp} summa: {Isik.ArvutaPalk()} eurot. {((Isik)Isik).Nimi}le");
            }

            Koolihaldus minuKool = new Koolihaldus();

            Õpetaja op = new Õpetaja { Nimi = "Mati", Aine = "Programmeerimine" };
            Õpilane opilane1 = new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };

            minuKool.LisaInimene(op);
            minuKool.LisaInimene(opilane1);
            minuKool.LisaInimene(Õpilane1);
            minuKool.LisaInimene(Õpetaja1);
            minuKool.LisaInimene(Õpilane2);
            minuKool.LisaInimene(Õpetaja2);

            Direktor Direktor1 = new Direktor { Nimi = "Arno", Tunnitasu = 35, TunnidKuus = 60, LisaTasu = 750 };
            Console.WriteLine($"Direktori nimi on {Direktor1.Nimi}, teie palk on {Direktor1.ArvutaPalk()}");

            Õpetaja UusÕpetaja1 = new Õpetaja { Nimi = "Tatjana" };
            UusÕpetaja1.Hinda(Hinne[RND.Next(1, 5)]);

            Üliõpilane Üliõpilane1 = new Üliõpilane { Nimi = "Oleg", Eriala = "IT-Osakond", Staatus = Õppevorm.Päevane };
            Üliõpilane1.Kirjelda();
            minuKool.LisaInimene(Üliõpilane1);
            minuKool.KuvaKõik();

            Console.WriteLine("Sisesta otsitav nimi");
            string otsitavnimi = Console.ReadLine();
            minuKool.OtsiNimeJärgi(otsitavnimi);
        }
    }
}
