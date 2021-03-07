using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "SALİHA",
                LastName = "BİTER",
                DateOfBirth = new DateTime(1992,6,1),
                NationalityId = 31807737400
            };


            BaseEntityManager<Gamer> gamerManager = new GamerManager(new Gamer { Id = 1, FirstName = "SALİHA", LastName = "BİTER", DateOfBirth = new DateTime(1992, 6, 1), NationalityId = 31807737400 });

            gamerManager.Add(gamer);

            gamer.FirstName = "FATIMA SALİHA";
            gamer.DateOfBirth = new DateTime(1993,6,6);

            gamerManager.Update(gamer);

            gamerManager.Delete(gamer);

            gamerManager.Add(gamer);

        }
    }
}
