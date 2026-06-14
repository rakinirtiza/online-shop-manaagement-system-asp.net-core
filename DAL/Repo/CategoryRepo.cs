using DAL.Entities.Context;
using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DAL.Repo
{
    public class CategoryRepo
    {
        SmsContext db;
        public CategoryRepo(SmsContext db) {
        this.db = db;
        }
        public bool Create(Category c)
        {
            db.Categories.Add(c);
            return db.SaveChanges()>0;
        }
        public List<Category> Get()
        {
            return db.Categories.Include(c=>c.Products).ToList();

        }
        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }
        public bool Update(Category c)
        {
            var ex =Get(c.Id);
            db.Entry(ex).CurrentValues.SetValues(c);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Categories.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
