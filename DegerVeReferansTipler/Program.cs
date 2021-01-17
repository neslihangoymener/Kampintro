using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
             Console.WriteLine(sayilar1[0]);

            // int,decimal,float,double,boll = değer tip
            // array,class,interface = referans tip

            //stack (değer tipler burada çalışıyor)  sayi1=10,sayi2=30, sayi1=sayi2 -->sayi2=65 --> sayi1=30 olur
            //heap  (referans tipler burada çalışıyor) array alan oluşturuyor 
            //sayilar1 [10,20,30] --> sistem sayilar1 için 101 nolu adres veriyor, new demek heap de yeni bir yer oluştur demek
            //sayilar2 [100,200,300] --> sistem sayilar2 için 102 nolu adres veriyor
            //sayilar1=sayilar2 demek sayilar1 in referans numarasını 102 yapıyor, yani [100,200,300] oldu
            //sayilar2[0] = 999 demek 102 adresinin ilk elemanını 999 yaptı [999,200,300] oldu
            //101 nolu adresi sistem çöp olarak görür ve siler
            //sayilar1 adresi 102 den aldığına göre sayilar1[0] değeri 999 olur.

            Console.ReadLine();
        }
    }
}
