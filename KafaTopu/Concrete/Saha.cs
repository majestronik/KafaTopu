using System;
using System.Collections.Generic;
using System.Text;

namespace KafaTopu
{
    class Saha
    {
        public int Yukseklik { get; set; }
        public int Genislik { get; set; }
        public Saha(int genislik, int yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public void Yazdir()
        {
            for (int i = 0; i <= Genislik; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("#");
            }
            for (int i = 0; i <= Genislik; i++)
            {
                Console.SetCursorPosition(i, (Yukseklik + 1));
                Console.Write("#");
            }
            for (int i = 0; i <= Yukseklik; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
            }

            for (int i = 0; i <= Yukseklik; i++)
            {
                Console.SetCursorPosition(Genislik + 1, i);
                Console.Write("#");
            }
        }
    }
}
