using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // new yaptığında önceki kayıtlar temizlenir, gider, artık onlara ulaşamazsın
            //Console.WriteLine("new yapıldı");
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[0]); //önceki kayıtlar gittiği için boş döner
            //Console.WriteLine(isimler[4]); // new yaptıktan sonra eklediğin için gelir
            
            // Ctrl + K Ctrl C yaptığında seçtiğin satırları toplu commentler
            //Ctrl + K Ctrl U yaptığında seçtiğin satırların toplu commentlerini kaldırır

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler2[0]+" isimler2[0]");
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine("------araya eleman eklendi------------");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0] + " isimler2[0]");
            Console.ReadLine();
        }
    }
}
