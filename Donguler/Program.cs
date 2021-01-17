using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "Yazılımcı Geliştir yetiştirme";
            //string kurs2 = "Programlamaya başlangıç";
            //string kurs3 = "Java Kursu";

            //array - dizi
            string[] kurslar = new string[] { "Yazılımcı Geliştir yetiştirme", "Programlamaya başlangıç","Java Kursu","Python","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //dizi elemanlarını tek tek dolaşmaya yarıyor
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
            Console.ReadKey();
        }


    }
}
