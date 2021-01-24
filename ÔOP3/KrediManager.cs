using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager 
     /* birisi bu interface i kullanırsa buradaki metodları kullanmak zorunda
     Okunurluğu artırmak için KrediManager'ın başına I getirdik, IKrediManager oldu
     Interface arayüz demek, şablon-- o zaman bu interfaci kullanan herkes bu şablona uymak zorunda
     diğerleri kendi kurallarını da yazabilir
     Interface ler implemente denilir
     Interface ler genellikle operasyonel metodlarda kullanılır
     */
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
