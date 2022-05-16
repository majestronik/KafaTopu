
using System;

namespace KafaTopu.Abstract
{
    abstract class _Obje
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int skor { get; set; }
        public int Uzunluk { get; set; }
        public int sahaYuksekligi;

        public void Yukarı()
        {
            if ((Y - 1 - (Uzunluk / 2)) != 0)
            {
                Console.SetCursorPosition(X, ((Y + (Uzunluk / 2)) - 1));
                Console.Write(" ");
                Y--;
                Yazdir();
            }
        }

        public void Aşağı()
        {
            if (Y + 1 + (Uzunluk / 2) != sahaYuksekligi + 2)
            {
                Console.SetCursorPosition(X, Y - (Uzunluk / 2));
                Console.Write(" ");
                Y++;
                Yazdir();
            }
        }
         public void Yazdir()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = (Y - (Uzunluk / 2)); i < (Y + (Uzunluk / 2)); i++)
            {
                Console.SetCursorPosition(X, i);
                Console.Write("I");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}