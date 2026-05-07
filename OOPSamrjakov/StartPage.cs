using System;
using System.Collections.Generic;
using System.Numerics;
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
            Õpetaja Õpetaja1 = new Õpetaja("Marina", "Programmeerimine", 20, 30);
            //Õpetaja1.Nimi = "Marina";
            //Õpetaja1.Sünniaasta = 2008;
            Õpetaja1.Tervita();

            //Õpetaja1.Aine = "Programmeerimine";
            Õpetaja1.Õpeta();

            Console.WriteLine(Õpetaja1.Kirjelda());

            //Õpilase andmed
            Õpilane Õpilane1 = new Õpilane("Konstantin", 11, Õppevorm.Päevane);
            //Õpilane1.Nimi = "Konstantin";
            //Õpilane1.Sünniaasta = 2008;
            Õpilane1.Tervita();

            //Õpilane1.Kool = "Ehte Humanitaargümnaasium";
            //Õpilane1.Klass = 11;
            Õpilane1.Õpi();

            Console.WriteLine(Õpilane1.Kirjelda());

            //Õpilane, ITööline

            List<ITööline> Palgasaajad = new List<ITööline>();

            Õpilane Õpilane2 = new Õpilane("Kadi", 11, Õppevorm.Päevane); /*{ Nimi = "Kadi", Klass = 11, Kool = "Kutsehariduskeskus", KeskminneHinne = 4.5, Puudumised = 3, KasOnSotsiaalneTõend = false, Staatus = Õppevorm.Päevane };*/

            Õpetaja Õpetaja2 = new Õpetaja("Anna", "Python", 20, 80); /*{ Nimi = "Anna", Aine = "Python", Tunnitasu = 20, TunnidKuus = 80 };*/

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
                string Nimi = Nimed[RND.Next(Nimed.Length)];
                int Klass = RND.Next(1, 13);
                Õppevorm Staatus = Õppevormid[RND.Next(Õppevormid.Length)];
                Õpilane Õpilane = new Õpilane(Nimi, Klass, Staatus)
                {
                    Kool = "TTHK",
                    KeskminneHinne = RND.NextDouble() * 5, //Keskmine hinne vahemikus 0-5
                    Puudumised = RND.Next(0, 350), //Puudumised vahemikus 0-350
                    KasOnSotsiaalneTõend = RND.Next(0, 2) == 1,
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

            Õpetaja op = new Õpetaja("Mati", "Programmeerimine", 15, 45); /*{ Nimi = "Mati", Aine = "Programmeerimine" };*/
            Õpilane opilane1 = new Õpilane("Mari", 10, Õppevorm.Päevane); /*{ Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };*/

            minuKool.LisaInimene(op);
            minuKool.LisaInimene(opilane1);
            minuKool.LisaInimene(Õpilane1);
            minuKool.LisaInimene(Õpetaja1);
            minuKool.LisaInimene(Õpilane2);
            minuKool.LisaInimene(Õpetaja2);

            Direktor Direktor1 = new Direktor("Arno", 750, 2100); /*{ Nimi = "Arno", Tunnitasu = 35, TunnidKuus = 60, LisaTasu = 750 };*/
            Console.WriteLine($"Direktori nimi on {Direktor1.Nimi}, teie palk on {Direktor1.ArvutaPalk()}");

            Õpetaja UusÕpetaja1 = new Õpetaja("Tatjana", "Eesti Keel", 9, 80); /*{ Nimi = "Tatjana" };*/
            UusÕpetaja1.Hinda(Hinne[RND.Next(1, 5)]);

            Üliõpilane Üliõpilane1 = new Üliõpilane("Oleg", "IT-Osakond", Õppevorm.Päevane); /*{ Nimi = "Oleg", Eriala = "IT-Osakond", Staatus = Õppevorm.Päevane };*/
            Console.WriteLine(Üliõpilane1.Kirjelda());
            minuKool.LisaInimene(Üliõpilane1);
            minuKool.KuvaKõik();

            Console.WriteLine("Sisesta otsitav nimi");
            string otsitavnimi = Console.ReadLine();
            minuKool.Otsi(otsitavnimi);

            // Vana viis (ilma konstruktorita):
            // Õpilane mari = new Õpilane();
            // mari.Nimi = "Mari";
            // mari.Klass = 10;
            // mari.Staatus = Õppevorm.Päevane;

            // Uus viis (konstruktoriga):
            // Õpilane mari = new Õpilane("Mari", 10, Õppevorm.Päevane);

            minuKool.Otsi("Mari"); // Käivitab esimese versiooni
            minuKool.Otsi(2008);   // Käivitab teise versiooni

            Õpilane juku = new Õpilane("Juku", 9, Õppevorm.Päevane);
            Õpetaja mati = new Õpetaja("Mati", "Füüsika", 7.5, 30);

            // Paneme tähele, me ei küsi juku.InimesteKoguarv, vaid küsime seda otse klassilt:
            Console.WriteLine($"Koolis on hetkel süsteemis registreeritud {Isik.InimesteKoguarv} isikut.");
            // Väljund: Koolis on hetkel süsteemis registreeritud 2 isikut.

            Õpetaja UusÕpetaja = new Õpetaja("Maksim", "Kehakultuur", 10, 15);


            try
            {
                Õpilane opilane = new Õpilane();
                opilane.Sünniaasta = 3000;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Viga: {e.Message}");
            }

            minuKool.KuvaAinultÕpilased();
        }
    }
}
