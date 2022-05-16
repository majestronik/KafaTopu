using System;
using System.Collections.Generic;
using System.Text;

namespace KafaTopu
{
    class OyunBilgisi
    {
        public int oyuncu1Skor = 0;
        public int oyuncu2Skor = 0;


        public bool bittiMi()
        {
            if (oyuncu1Skor == 3 || oyuncu2Skor == 3) return true;
            return false;
        }

        public void skoruSıfırla()
        {
            oyuncu1Skor = oyuncu2Skor = 0;
        }
    }
}
