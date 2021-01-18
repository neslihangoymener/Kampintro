using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TC = "11111111111";
            musteri1.isim = "Neslihan KUŞ GÖYMENER";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TC = "22222222222";
            musteri2.isim = "Azra Nuray GÖYMENER";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TC = "33333333333";
            musteri3.isim = "Emir Batu GÖYMENER";

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            
            Console.WriteLine("Hoş Geldiniz..\n");
            Console.WriteLine("Lütfen yapacağınız işlem tipini seçiniz.\n\n 1.Yeni Müşteri \n 2. Müşteri Sil \n 3. Müşteri Listesi");

            var keyword = Console.ReadLine();

            switch (keyword)
            {
                case "1":
                    musteriManager.Ekle(musteri1);

                    break;
                case "2":
                    musteriManager.Silme(musteri1);
                    break;
                case "3":
                    foreach (Musteri musteri in musteriler)

                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Musteri ID: " + musteri.Id);
                        Console.WriteLine("Musteri Adı: " + musteri.TC);
                        Console.WriteLine("Musteri Adı: " + musteri.isim);
                        Console.WriteLine(" ");
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
