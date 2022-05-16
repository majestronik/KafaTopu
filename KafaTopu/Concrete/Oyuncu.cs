using KafaTopu.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KafaTopu
{
    class Oyuncu : _Obje
    {
        public Oyuncu(int x, int sahaYuksekligi, int skor)
        {
            this.sahaYuksekligi = sahaYuksekligi;
            this.skor = skor;
            X = x;
            Y = sahaYuksekligi / 2;
            Uzunluk = sahaYuksekligi / 3;
        }

    }
}
