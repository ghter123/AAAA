﻿using System;
using System.Linq;

namespace AAAA.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Revmoe(Guid id);
        int SaveChanges();
    }
}
