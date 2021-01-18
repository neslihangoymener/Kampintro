using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        private string musteri;

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklenmiştir.");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silinmiştir.");
        }

        
    }
    
}