using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_MPP_CSharp.Domain;

namespace Proiect_MPP_CSharp.Repos
{
    interface IRepository<ID, T> where T:Entity<ID>
    {
        void save(T entity);
        void update(ID id, T entity);
        T findOne(ID id);
        ICollection<T> findAll();
    }
}
