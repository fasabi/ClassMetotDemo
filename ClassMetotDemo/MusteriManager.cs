using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine($"Ekleme işlemi yapılmıştır.\n" +
                $"ID: {musteri.ID}\n" +
                $"Müşteri TC No: {musteri.MusteriTC}\n" +
                $"Müşteri Adı: {musteri.MusteriAdi}\n" +
                $"Müşteri Telefon No: {musteri.MusteriTel}\n" +
                $"Bakiye Limiti: {musteri.BakiyeLimiti} bilgilerine sahip müşteri eklenmiştir.\n\n");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine($"Listeleme işlemi yapılmıştır.\n");
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine($"Müşteriler listesinin {i+1}. elemanı listelendi.\n" +
                    $"ID: {musteriler[i].ID}\n" +
                    $"Müşteri TC No: {musteriler[i].MusteriTC}\n" +
                    $"Müşteri Adı: {musteriler[i].MusteriAdi}\n" +
                    $"Müşteri Telefon No: {musteriler[i].MusteriTel}\n" +
                    $"Bakiye Limiti: {musteriler[i].BakiyeLimiti} bilgilerine sahip müşteri listelenmiştir.\n");
            }
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine($"Silme işlemi yapılmıştır.\n" +
                $"ID: {musteri.ID}\n" +
                $"Müşteri TC No: {musteri.MusteriTC}\n" +
                $"Müşteri Adı: {musteri.MusteriAdi}\n" +
                $"Müşteri Telefon No: {musteri.MusteriTel}\n" +
                $"Bakiye Limiti: {musteri.BakiyeLimiti} bilgilerine sahip müşteri silinmiştir.\n\n");
        }
    }
}
