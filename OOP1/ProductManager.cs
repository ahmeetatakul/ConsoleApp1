using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi. ");

        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");

        }
       // public int Topla(int sayı1 , int sayı2)
       // {
           // return sayı1 + sayı2;

       // }
       // public void Topla2(int sayı1, int sayı2)
       // {
         //   Console.WriteLine(sayı1+ sayı2);
            //Topla2 void ilede işlemini yapıyor sıkıntı yok ama bizim onun dönüşüne ihtiyacımız olduğu zaman tekrara kullanamayız
            //neden returna ihtiyacım var = sonucu başka birşeydede kulllanamak istediğimiz için 
       // }

        // 2 void git yap git ekle anlamına gelmektedir

        //public void BiseyYap(int sayi)
        //{
        // sayi = 99;
        // 

        

    }
}
