using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KafaTopu
{
    class Kafatopu
    {
        int genislik;
        int yukseklik;
        
        Saha saha;
        Oyuncu oyuncu1;
        Oyuncu oyuncu2;
        SkorTablosu skortablosu;
        OyunBilgisi oyunbilgisi;
        Top top;

        ConsoleKeyInfo keyInfo;
        ConsoleKey consoleKey;
        public Kafatopu(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            saha = new Saha(genislik, yukseklik);
            top = new Top(genislik / 2, yukseklik / 2, yukseklik, genislik);
            oyunbilgisi = new OyunBilgisi();
        }
        public void Setup()
        {
            oyuncu1 = new Oyuncu(2, yukseklik, oyunbilgisi.oyuncu1Skor);
            oyuncu2 = new Oyuncu(genislik - 2, yukseklik, oyunbilgisi.oyuncu2Skor);
            keyInfo = new ConsoleKeyInfo();
            consoleKey = new ConsoleKey();
            top.X = genislik / 2;
            top.Y = yukseklik / 2;
            top.yon = 0;
            skortablosu = new SkorTablosu(genislik / 2, yukseklik);
        }
        void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;
            }
        }

        public void Calistir()
        {
            while (true)
            {
                Console.Clear();
                Setup();
                saha.Yazdir();
                oyuncu1.Yazdir();
                oyuncu2.Yazdir();
                top.Yazdir();
                skortablosu.Write(oyuncu1.skor, oyuncu2.skor);
                while (top.X != 1 && top.X != genislik - 1)
                {
                    if (oyunbilgisi.bittiMi())
                    {
                        //Console.Clear();
                        skortablosu.Write(oyuncu1.skor, oyuncu2.skor);
                        oyunbilgisi.skoruSıfırla();
                        Thread.Sleep(1000);
                        break;
                    }
                    else
                    {
                        Input();
                        switch (consoleKey)
                        {
                            case ConsoleKey.W:
                                oyuncu1.Yukarı();
                                oyuncu2.Yukarı();
                                break;
                            case ConsoleKey.S:
                                oyuncu1.Aşağı();
                                oyuncu2.Aşağı();
                                break;
                        }
                        consoleKey = ConsoleKey.A;
                        top.Mantık(oyuncu1, oyuncu2, oyunbilgisi);
                        top.Yazdir();
                        Thread.Sleep(20);
                    }
                }
            }
        }
    }
}

