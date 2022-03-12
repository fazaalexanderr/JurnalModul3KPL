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

            PosisiKarakterGame karakter1 = new PosisiKarakterGame();
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolW);
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolS);
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolW);
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolX);
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolW);
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolS);
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolS);
            karakter1.ActionTriggered(PosisiKarakterGame.Aksi.TombolW);
        }
    }
}