using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    // Õpilane pärib klassist Isik
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public Õppevorm Staatus { get; set; } //Kasutame enumi andmetüübina

        // Alamklassi konstruktor peab "base" märksõnaga kutsuma baasklassi konstruktorit
        public Õpilane() : base()
        {

        }

        public Õpilane(string nimi, int klass, Õppevorm staatus) : base(nimi)
        {
            Klass = klass;
            Staatus = staatus;
        }

        public double KeskminneHinne { get; set; } //Põhitoetus (60 eur)
        public int Puudumised { get; set; } = 0; //Põhetoetus
        public bool KasOnSotsiaalneTõend { get; set; } = false; //Eritoetus (120 eur)

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }

        public override string Kirjelda()
        {
            string õpilane_kirjelda = $"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}. Kool: {Kool}.";
            return õpilane_kirjelda;
        }

        public double ArvutaPalk()
        {
            //if (KeskminneHinne >= 3.8 || KeskminneHinne < 5 || Puudumised < 10 || Puudumised >= 0)
            //{
            //    return 60; //Ainult põhitoetus
            //}
            //else if (KeskminneHinne >= 3.8 || KeskminneHinne < 5 || Puudumised < 10 || Puudumised >= 0 || KasOnSotsiaalneTõend == true)
            //{
            //    return 60 + 120; //Põhitoetus koos eritoetusega
            //}
            //else if (KasOnSotsiaalneTõend == true)
            //{
            //    return 120; //Ainult eritoetus
            //}
            //else
            //{
            //    return 0; //Mitte midagi
            //}

            double Põhitoetus = 0;
            double Eritoetus = 0;

            if (KeskminneHinne >= 3.8 || Puudumised < 10)
            {
                Põhitoetus += 60; //Ainult põhitoetus
            }
            if (KasOnSotsiaalneTõend)
            {
                Eritoetus += 120;
            }

            return Põhitoetus + Eritoetus;
        }
    }
}
