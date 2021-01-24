﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,ILogerService logerService)
        {
            //Başvuran bilgilerini değerlendirme

            krediManager.Hesapla();
            logerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
