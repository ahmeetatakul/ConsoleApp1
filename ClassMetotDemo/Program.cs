using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Müşteri Bilgileri-----");
            Musteri musteri1 = new Musteri();
            musteri1.Adı = "Ahmet";
            musteri1.SoyAdı = "ATAKUL";
            musteri1.TcNo = 1111111;

            

            Musteri musteri2 = new Musteri();
            musteri2.Adı = "Engin";
            musteri2.SoyAdı = "DEMİROĞ";
            musteri2.TcNo = 22222222;

            Musteri musteri3 = new Musteri();
            musteri3.Adı = "Yusuf";
            musteri3.SoyAdı = "ELDEMİR";
            musteri3.TcNo = 33333333;

           Musteri[] musteriler = new Musteri[] { musteri1, musteri2 , musteri3};

           foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adı);
                Console.WriteLine(musteri.SoyAdı);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine("    ");

            }
            Console.WriteLine("---Müşteri Eklme-----");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("---Müşteri Listeleme----");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            Console.WriteLine("----Müşteri Silme-----");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);


        }
    }
}
