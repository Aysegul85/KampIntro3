using System;
using System.Collections.Generic; //List<string> listelemek için ampul kısmından seç
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
        //forech listedeki her bir kredinin hesabını yap
        //bana bir liste ver ve bu kredinin  türü ICreditManager olsun



    }
}


