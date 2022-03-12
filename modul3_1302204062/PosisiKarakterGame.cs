using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204062
{
    public class PosisiKarakterGame
    {
        public enum Posisi { Jongkok, Berdiri, Tengkurap, Terbang};
        public enum Aksi { TombolS, TombolW, TombolX};

        public class Transisi
        {
            public Posisi PosisiAwal;
            public Posisi PosisiAkhir;
            public Aksi Trigger;

            public Transisi(Posisi Awal, Posisi Akhir, Aksi Action)
            {
                PosisiAwal = Awal;
                PosisiAkhir = Akhir;
                Trigger = Action;
            }
        }

        Transisi[] listPerpindahanPosisi =
        {
            new Transisi(Posisi.Berdiri, Posisi.Terbang, Aksi.TombolW),
            new Transisi(Posisi.Berdiri, Posisi.Jongkok, Aksi.TombolS),
            new Transisi(Posisi.Terbang, Posisi.Berdiri, Aksi.TombolS),
            new Transisi(Posisi.Terbang, Posisi.Jongkok, Aksi.TombolX),
            new Transisi(Posisi.Jongkok, Posisi.Berdiri, Aksi.TombolW),
            new Transisi(Posisi.Jongkok, Posisi.Tengkurap, Aksi.TombolS),
            new Transisi(Posisi.Tengkurap, Posisi.Jongkok, Aksi.TombolW),
        };

        public Posisi CurrentPosition = Posisi.Berdiri;

        public Posisi GetPosisiAkhir(Posisi awal, Aksi action)
        {
            Posisi positionAkhir = awal;

            for (int i = 0; i < listPerpindahanPosisi.Length; i++)
            {
                Posisi positionAwal = listPerpindahanPosisi[i].PosisiAwal;
                Aksi triggerAksi = listPerpindahanPosisi[i].Trigger;

                if (positionAwal == awal && triggerAksi == action)
                {
                    positionAkhir = listPerpindahanPosisi[i].PosisiAkhir;
                    if(positionAwal == Posisi.Terbang && positionAkhir == Posisi.Jongkok)
                    {
                        Console.WriteLine("posisi landing");
                    } else if(positionAwal == Posisi.Berdiri && positionAkhir == Posisi.Terbang)
                    {
                        Console.WriteLine("posisi take off");
                    }
                }
            }
            return positionAkhir;
        }

        public void ActionTriggered(Aksi Action)
        {
            Posisi NextPosition = GetPosisiAkhir(CurrentPosition, Action);
            CurrentPosition = NextPosition;

            Console.WriteLine("Posisi saat ini adalah: " + CurrentPosition);
        }

        public PosisiKarakterGame()
        {
        }
    }
}
