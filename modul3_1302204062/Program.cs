using System;

namespace modul3_1302204062
{
    public class Program
    {
        static void Main(string[] args)
        {
            KodeBuah buah1 = new KodeBuah();
            buah1.GetKodeBuah(KodeBuah.NamaBuah.Apel);
            buah1.GetKodeBuah(KodeBuah.NamaBuah.Kelapa);
            buah1.GetKodeBuah(KodeBuah.NamaBuah.Melon);
        }
    }
}