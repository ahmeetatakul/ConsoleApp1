using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metedolar
{
    internal class SepetManeger
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi! :"+urun.Adi);
        }

        public void Ekle2(string urunAdı, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi! :" + urunAdı);
        }
    }
}
