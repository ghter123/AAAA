using AAAA.Domain.Interfaces;
using AAAA.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AAAA.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AAAAContext DB;
        protected readonly DbSet<TEntity> DBSet;
        public Repository(AAAAContext context)
        {
            DB = context;
            DBSet = DB.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DBSet.Add(obj);
        }

        public IQueryable<TEntity> GetAll()
        {
           return DBSet;
        }

        public TEntity GetById(Guid id)
        {
            return DBSet.Find(id);
        }

        public void Revmoe(Guid id)
        {
            DBSet.Remove(DBSet.Find(id));
        }

        public int SaveChanges()
        {
            return DB.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            DBSet.Update(obj);
        }

        public void Dispose()
        {
            DB.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
