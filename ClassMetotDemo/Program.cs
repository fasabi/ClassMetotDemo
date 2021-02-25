using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                ID = 1,
                MusteriTC = "11111111111",
                MusteriAdi = "Fatıma Saliha Biter",
                MusteriTel = "05554443322",
                BakiyeLimiti = 10000
            };

            Musteri musteri2 = new Musteri
            {
                ID = 2,
                MusteriTC = "11111111112",
                MusteriAdi = "Fatıma Biter",
                MusteriTel = "05554443322",
                BakiyeLimiti = 10000
            };

            Musteri musteri3 = new Musteri
            {
                ID = 3,
                MusteriTC = "11111111113",
                MusteriAdi = "Saliha Biter",
                MusteriTel = "05554443322",
                BakiyeLimiti = 10000
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.MusteriListele(musteriler);

            musteriManager.MusteriSil(musteri3);

            Console.ReadKey();
        }
    }
}
