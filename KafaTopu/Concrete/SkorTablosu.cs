using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KafaTopu
{
    class SkorTablosu
    {
        public int X { get; set; }
        public int Y { get; set; }
        int sahaYuksekligi;
        public SkorTablosu(int x, int sahaYuksekligi)
        {
            this.sahaYuksekligi = sahaYuksekligi;
            X = x + 45;
            Y = sahaYuksekligi / 2;
        }
        public void Write(int skor1, int skor2)
        {
            Console.SetCursorPosition(X, Y);
            if (skor1 != 3 && skor2 != 3)
            {
                Console.Write($"Oyuncu 1 : {skor1} - Oyuncu 2 : {skor2}");
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(X, Y);
                if (skor1 == 3)
                {
                    Console.Write("Oyuncu 1 Oyunu Kazandı");
                    Thread.Sleep(4000);
                }
                if (skor2 == 3)

                {
                    Console.Clear();
                    Console.Write("Oyuncu 2 Oyunu Kazandı");
                    Thread.Sleep(4000);
                }

            }
        }
    }
}
