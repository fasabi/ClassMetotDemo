using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IEntityService<T>
    {
        public void Add(T item);
        public void Update(T item);
        public void Delete(T item);
    }
}
