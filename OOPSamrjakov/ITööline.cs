using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSamrjakov
{
    public interface ITööline
    {
        TööTüüp VäljamakseTüüp { get; set; } //Töö tüübi omadus
        double ArvutaPalk(); //Ainult meetodi allkiri. Meetod, mis arvutab tööline palga
    }

    public enum TööTüüp
    {
        Palk,
        Toetus
    }
}
