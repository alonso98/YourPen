using LinqSpecs;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YourPen.Domain.Core.Common;

namespace YourPen.Domain.Core.Repositories
{
    public interface IRepository
    {
        T Get<T>(object id) where T : Entity;
        T FirstOrDefault<T>(Specification<T> specification) where T : Entity;

        Entity Add<T>(T entity) where T : Entity;
        void Update<T>(T entity) where T : Entity;
        void Remove<T>(T entity) where T : Entity;
        void Remove<T>(object id) where T : Entity;

        IQueryable<T> Get<T>() where T : Entity;
        IQueryable<T> Get<T>(Specification<T> specification) where T : Entity;

        int CountAll<T>() where T : Entity;
        int CountWhere<T>(Specification<T> specification) where T : Entity;
    }
}
