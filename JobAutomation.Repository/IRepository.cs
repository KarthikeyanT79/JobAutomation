using System;
using System.Collections.Generic;
using System.Text;

namespace JobAutomation.Repository
{
    public interface IRepository<T>
    {
        void Add(T t);

        void Remove(T t);

        void Update(T t);

        List<T> GetAll();

        T GetById(int id);
    }
}
