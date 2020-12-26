using LinqSpecs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using YourPen.Domain.Core.Common;
using YourPen.Domain.Core.Repositories;

namespace YourPen.Infrastructure.Data
{
    //public class EfRepository : IRepository
    //{
    //    #region inject
    //    protected AppDbContext context;

    //    public EfRepository(AppDbContext context)
    //    {
    //        this.context = context;
    //    }
    //    #endregion

    //    public int CountAll<T>() where T : Entity
    //        => this.context.Set<T>().Count();

    //    public int CountWhere<T>(Specification<T> specification) where T : Entity
    //        => this.context.Set<T>().Where(specification.ToExpression()).Count();



    //    public T FirstOrDefault<T>(Specification<T> specification) where T : Entity
    //        => this.context.Set<T>().FirstOrDefault(specification.ToExpression());

    //    public IQueryable<T> Get<T>() where T : Entity
    //        => this.context.Set<T>();

    //    public T Get<T>(object id) where T : Entity
    //        => this.context.Set<T>().Find(id);

    //    public IQueryable<T> Get<T>(Specification<T> specification) where T : Entity
    //        => this.context.Set<T>().Where(specification.ToExpression());


    //    public Entity Add<T>(T entity) where T : Entity
    //        => this.context.Set<T>().Add(entity).Entity;

    //    public void Update<T>(T entity) where T : Entity
    //    {
    //        this.context.Entry(entity).State = EntityState.Modified;
    //    }

    //    public void Remove<T>(T entity) where T : Entity
    //        => this.context.Set<T>().Remove(entity);

    //    public void Remove<T>(object id) where T : Entity
    //    {
    //        T entity = this.context.Set<T>().Find(id);
    //        //entity = entity ?? throw new NotFoundException(typeof(T).Name);

    //        this.Remove(entity);
    //    }
    //}
}
