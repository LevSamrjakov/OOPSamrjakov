using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    // Õpetaja pärib klassist Isik (koolon tähistab pärimist)
    public class Õpetaja : Isik
    {
            public string Aine { get; set; }

            public void Õpeta()
            {
                Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
            }
    }
}
