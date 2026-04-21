using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public class Direktor : Õpetaja
    {
        public double LisaTasu { get; set; }

        public override double ArvutaPalk()
        {
            return base.ArvutaPalk() + LisaTasu;
        }
    }
}
