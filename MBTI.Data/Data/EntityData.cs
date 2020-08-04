using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class EntityData<T> where T : class
    {
        protected MBTIEntities CreateContext()
        {
            MBTIEntities context = new MBTIEntities();
            context.Configuration.ProxyCreationEnabled = false;
            context.Database.Log = x => Console.WriteLine(x);
            return context;
        }
        public void Insert(T entity)
        {
            MBTIEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Added;

            context.SaveChanges();
        }
        public void Update(T entity)
        {
            MBTIEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            MBTIEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
        public List<T> GetAll()
        {
            MBTIEntities context = CreateContext();
            return context.Set<T>().ToList();
        }
        public int GetCount()
        {
            MBTIEntities context = CreateContext();

            return context.Set<T>().Count();
        }

    }
}
