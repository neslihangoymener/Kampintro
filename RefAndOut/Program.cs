using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            
            Console.WriteLine("sayi1 (önce): " + sayi1);
            var sonuc2=topla(ref sayi1, sayi2);
            Console.WriteLine("\n------ref------------\ntoplam sonucu : "+sonuc2);
            Console.WriteLine("sayi1 (sonra): " + sayi1);

            int sayi3; // out için ilk değer ataması zorunlu değil
            int sayi4 = 40;
            var sonuc3 = topla2(out sayi3, sayi4);
            Console.WriteLine("\n------out------------\ntoplam sonucu : " + sonuc3);
            Console.WriteLine("sayi3 (sonra): " + sayi3);

            Console.ReadLine();
        }

        static int topla(ref int sayi1, int sayi2)
        {
            // int,decimal,float,double,boll = değer tip
            // array,class,interface = referans tip
            //ref anahtar kelimesi, değer tiplerinin referans tip gibi kullanılmasını sağlar
            //
            sayi1 = 30;
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }  
        static int topla2(out int sayi3,int sayi4)
        {
            sayi3 = 50;//out kullanıldığında metodun içinde bir kere set edilmesi gerekir
            int sonuc = sayi3 + sayi4;
            return sonuc;
        }
    }
}
