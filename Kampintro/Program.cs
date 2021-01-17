using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // Do not repeat yourself - Kendini tekrarlama

            //Type safety  - tip güvenliği
            String kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45; //ondalık
            bool sistemeGirisYapmismi =false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu Göster");
            }

            if (sistemeGirisYapmismi==true) // if yaz iki kere tab tuşuna bas, format otomatik geliyor
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

         

            Console.WriteLine(kategoriEtiketi);
            Console.ReadKey();
        }
    }
}
