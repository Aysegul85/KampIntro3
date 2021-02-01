using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{   // MicroService
    class GamerManager : IGameService
    {
        //doğrulama servisi kullanma //generate constructer
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt silindi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
        }

        public void Update(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt güncellendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
        }
    }
}
