using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product // ürün
    {

        //unıtprice fiyatı
        public int Id { get; set; }
        //kategorisi refans oldğu için kategoriler ikinci sırada Id den hemen sonra yazılır
        public int CategoryId { get; set; }
        //ürünİsmi
        public string ProductName { get; set; }
        //fiyatı
        public double UnitPrice { get; set; }
        //stokAdedi
        public int UnitınStock { get; set; }

    }
}
