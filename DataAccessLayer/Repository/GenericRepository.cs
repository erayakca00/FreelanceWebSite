using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new FreelancerWSDBContext();
            c.Remove(t);
            c.SaveChanges();    
        }

        public T GetById(int id)
        {
            using var c = new FreelancerWSDBContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new FreelancerWSDBContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new FreelancerWSDBContext(); 
            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T t)
        {
            using var c = new FreelancerWSDBContext();
            c.Add(t);
        }

        public void Update(T t)
        {
            using var c = new FreelancerWSDBContext();
            c.Update(t);
        }
    }
}
