using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdSoyad = "Armağan Şahin";
            musteri1.Adres = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdSoyad = "Anıl Şahin";
            musteri2.Adres = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.AdSoyad = "Mehmet Demir";
            musteri3.Adres = "Gaziantep";

            Musteri[] musteriler = new Musteri[3];

            MusteriManager musteriManager = new MusteriManager();

            musteriler[0] = musteriManager.Ekle(musteri1);
            musteriler[1] = musteriManager.Ekle(musteri2);
            musteriler[2] = musteriManager.Ekle(musteri3); // Müşteriler diziye method ile eklendi

            Console.WriteLine("---------------LİSTELEME---------------");
            musteriManager.Liseleme(musteriler);

            Console.WriteLine("---------------SİLME---------------");
            musteriManager.Silme(musteri2);
        }
    }
}
