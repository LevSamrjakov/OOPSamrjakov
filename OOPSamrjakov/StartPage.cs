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
            Isik Inimene1 = new Isik();
            Inimene1.Nimi = "Lev";
            Inimene1.Sünniaasta = 2008;
            //Inimene1.Vanus = 17;
            Inimene1.Tervita(); //Väljund: Tere! Mina olen Lev...

            //Õpetaja andmed
            Õpetaja Õpetaja1 = new Õpetaja();
            Õpetaja1.Nimi = "Marina";
            Õpetaja1.Sünniaasta = 2008;
            Õpetaja1.Tervita();

            Õpetaja1.Aine = "Programmeerimine";
            Õpetaja1.Õpeta();

            //Õpilase andmed
            Õpilane Õpilane1 = new Õpilane();
            Õpilane1.Nimi = "Konstantin";
            Õpilane1.Sünniaasta = 2008;
            Õpilane1.Tervita();

            Õpilane1.Kool = "Ehte Humanitaargümnaasium";
            Õpilane1.Klass = 11;
            Õpilane1.Õpi();
        }
    }
}
