using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public abstract class BaseEntityManager<T> : IEntityService<T> where T : class
    {

        public virtual void Add(T item)
        {
            Console.WriteLine("Oyuncu kayıt edildi.");
        }

        public void Delete(T item)
        {
            Console.WriteLine("Oyuncu silindi.");
        }


        public void Update(T item)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi.");
        }
    }
}