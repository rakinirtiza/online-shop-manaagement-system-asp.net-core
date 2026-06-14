using DAL.Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repo
{
    public class Repository <T> where T : class
    {
        DbSet<T> tbl;
        SmsContext db;
        public Repository(SmsContext db)
        {
            this.db = db;
            tbl=db.Set<T>();
        }
        public List<T> Get()
        {
            return tbl.ToList();

        }
        public T Get(int id)
        {
            return tbl.Find(id);

        }
        public bool Create(T obj)
        {
            tbl.Add(obj);
            return db.SaveChanges() > 0;

        }
        public bool Update(T obj)
        {

            return true;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            tbl.Remove(ex);
            return db.SaveChanges() > 0;

        }
    }
}
