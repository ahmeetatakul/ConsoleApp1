using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]{ "Yazaılım Geliştrime Kampı" , "Proglamlamaya Başlangıç İçin Temel Kurs" ,
                "Java", "python" ,"aaaa"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("fot bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
