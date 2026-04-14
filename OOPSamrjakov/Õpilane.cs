using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    // Õpilane pärib klassist Isik
    public class Õpilane : Isik
    {
        public string Kool { get; set; }
        public int Klass { get; set; }

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }
    }
}
