using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)

        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationService());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Engin", LastName = "Demiroğ", IdentityNumber = 7576474 });


        }
        

    }
}

    

