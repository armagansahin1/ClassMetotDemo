using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public Musteri Ekle(Musteri musteri)
        {


            Console.WriteLine("Id : " + musteri.Id);
            Console.WriteLine(" Adı Soyadı : " + musteri.AdSoyad);
            Console.WriteLine(" Adres : " + musteri.Adres);
            Console.WriteLine("Müşteri Eklendi !!!");
            Console.WriteLine("****************************");
            return musteri;
        }

        public void Liseleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Id : " + musteri.Id);
                Console.WriteLine(" Adı Soyadı : " + musteri.AdSoyad);
                Console.WriteLine(" Adres : " + musteri.Adres);
                Console.WriteLine("****************************");
            }
            Console.WriteLine("Müşteriler Listelendi !!!");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Id : " + musteri.Id);
            Console.WriteLine(" Adı Soyadı : " + musteri.AdSoyad);
            Console.WriteLine(" Adres : " + musteri.Adres);
            Console.WriteLine("Kimlikli Müşteri Silindi !!!");
        }
    }
}
