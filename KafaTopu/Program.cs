


// Furkan Kuru B211200371
// BSM NDP ÖDEVİ

using System;

namespace KafaTopu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Kafatopu kafatopu = new Kafatopu(60, 20);
            kafatopu.Calistir();
            Console.ReadKey();
        }
    }
}
