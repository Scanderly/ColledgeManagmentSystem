using ColledgeManageSystem.DAL;
using ColledgeManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private readonly ColledgeContext _context;
        private IDbSet<T> _set;
        public GenericRepository()
        {
            _context = new ColledgeContext();
            _set = _context.Set<T>();

        }
        public void CreateItem(T obj)
        {
            _set.Add(obj);
            SaveItem();
        }

        public void Delete(int? id)
        {
            T obj = GetItemById(id);
            _context.Set<T>().Remove(obj);
            SaveItem();
        }

        public IReadOnlyList<T> GetAllEntities()
        {
            return _set.ToList();
        }

        public T GetItemById(int? id)
        {
            return _set.Find(id);
        }

        public void SaveItem()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _set.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            SaveItem();

        }
    }
}