using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2 //Object Oriented Programing - Nesne Tabanlı Programlama
 /* SOYUTLAMA
  * interface, inherits, abstract kavramlar syntax olarak biliniyor ama mantığı anlaşılmıyor

*/
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id=1
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo ="54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo ="1234567890";

            /*Gerçek Müşteri - Tüzel Müşteri ayrımına dikkat
             * SOLID -- L ye dikkat
            */
            Musteri musteri3 = new GercekMusteri(); // new - bellekteki bir referans nosudur
            Musteri musteri4 = new TuzelMusteri(); // Musteri hem Gercek hem Tüzel referansını tutabiliyor

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1); // Ekle metodu ile hem gercek hem tuzel musteri ekleyebiliyorum
            musteriManager.Ekle(musteri2);

        }
    }
}
