using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    //Õpetaja pärib klassist Isik (koolon tähistab pärimist)
    public class Õpetaja : Isik, ITööline, IHindaja
    {
        public string Aine { get; set; }
        public double Tunnitasu { get; set; }
        public int TunnidKuus { get; set; }

        public Õpetaja(string nimi, string aine, double tunnitasu, int tunnidKuus) : base(nimi)
        {
            Aine = aine;
            Tunnitasu = tunnitasu;
            TunnidKuus = tunnidKuus;
        }

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }

        //Override kirjutab abstraktse meetodi üle
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }

        //Kohustuslik meetod liidesest. ITööline liidese meetodi realiseerimine
        public virtual double ArvutaPalk()
        {
            return Tunnitasu * TunnidKuus; //Kuupalk
        }

        public void Hinda(string Hinne)
        {
            Console.WriteLine($"Õpetaja lisab hinne: {Hinne}");
        }
    }
}
