using System;
using System.Collections.Generic;
using System.Text;

namespace KafaTopu
{
    class Top
    {
        public int X { get; set; }
        public int Y { get; set; }
        int yonX;
        int yonY;
        public int yon { get; set; }
        int sahaYuksekligi;
        int sahaGenisligi;
        public Top(int x, int y, int sahaYuksekligi, int sahaGenisligi)
        {
            X = x;
            Y = y;
            this.sahaYuksekligi = sahaYuksekligi;
            this.sahaGenisligi = sahaGenisligi;
            yonX = -1;
            yonY = 1;
        }
        public void Mantık(Oyuncu oyuncu1, Oyuncu oyuncu2, OyunBilgisi oyunbilgisi)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            if (Y <= 1 || Y >= sahaYuksekligi)
            {
                yonY *= -1;
            }
            if (((X == 3 || X == sahaGenisligi - 3) && (oyuncu1.Y - (oyuncu1.Uzunluk / 2)) <= Y && (oyuncu1.Y + (oyuncu1.Uzunluk / 2)) > Y))
            {
                yonX *= -1;
                if (Y == oyuncu1.Y)
                {
                    yon = 0;
                }
                if ((Y >= (oyuncu1.Y) - (oyuncu1.Uzunluk / 2)) && (Y < oyuncu1.Y) || (Y > oyuncu1.Y && Y < (oyuncu1.Y + (oyuncu1.Uzunluk / 2))))
                {
                    yon = 1;
                }
            }
            else
            {
                if (X == 2)
                {
                    oyunbilgisi.oyuncu2Skor += 1;
                }
                if (X == sahaGenisligi - 2)
                {
                    oyunbilgisi.oyuncu1Skor += 1;
                }
            }


            switch (yon)
            {
                case 0:
                    X += yonX;
                    break;
                case 1:
                    X += yonX;
                    Y += yonY;
                    break;
            }
        }
        public void Yazdir()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(X, Y);
            Console.Write("0");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
