using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adı +" "+musteri.SoyAdı + " " +"Ekniyor");
            Console.WriteLine("Müşteri Eklendi" + " " + musteri.Adı + " "+  musteri.SoyAdı);
            Console.WriteLine( " ");

            
            Console.WriteLine("   ");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Adı" + " : " + musteri.Adı);
            Console.WriteLine("Soyadı" +" : " + musteri.SoyAdı);
            Console.WriteLine("Tc Nu "+" : "+musteri.TcNo);
            Console.WriteLine(" ");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sil" + " " + musteri.Adı + " " + musteri.SoyAdı);
            Console.WriteLine("Silme İşlemini Onaylıyor musunuz ?");
            Console.WriteLine(musteri.Adı + " " + musteri.SoyAdı +" " +"Artık Müşterimiz Değil");
            Console.WriteLine(" ");
        }
       
    }
}
