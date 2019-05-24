using System;
using System.Collections.Generic;
using Services.Entities;

namespace Services.Controller
{
    public interface IDataBase<T> where T : IEntity
    {
        List<IEntity> GetAllEntities();
        List<IEntity> Filter(Func<T ,bool> condition);
        bool Upgrade(T entity);
    }
}