using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitınStock = 3;

            Console.WriteLine(product1.ProductName);

            Product product2 = new Product {Id = 2, CategoryId =5, UnitınStock=5,ProductName="Kalem",UnitPrice=35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Uptade(product1);

            //productManager.Topla(2, 3);
           

            //int toplamSonucu = productManager.Topla(2, 3);
           // Console.WriteLine(toplamSonucu*2);

            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);


            //int,double bool değer tipler // değer tiplerde atamalar tamamen değeri üzerinden olur ve bütün bağlantı kopar
            //dizle,class,abstrackt classinderse,, refarans tipler ise atamalar refansın numarası ile yapılır yani bellekteki adresten gelir . bellekteki fiziksellokasyon yollanır
            //ref ve out
        }

    }
}
