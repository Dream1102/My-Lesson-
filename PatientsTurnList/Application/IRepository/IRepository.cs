using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Models;

namespace Application.IRepository
{
    public interface IRepository<T>
    {

         void Add(T item);

        void Delete(Guid item);

        void Update(Guid item, int WorkTime);

        T Get(Guid item);
        List<T> GetAll();
    }
}
