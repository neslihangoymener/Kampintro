using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe  -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("\n--------------------------");
            }

            Console.WriteLine("-------Metottlar-----------");
            //instance - örnek
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle2("Armut","Yeşil",12,10);
            sepetmanager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır", 12,8);

            //Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}

//Do not repeat yourself