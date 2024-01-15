using Agency.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agency.DAL.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        Task<IQueryable<TEntity>> GetAll(
            Expression<Func<TEntity, bool>> expression = null,
            Expression<Func<TEntity, object>> OrderByExpression = null,
            bool isDescending = false,
            params string[] includes
            );

        DbSet<TEntity> Table {  get; }
        Task Delete(int id);
        Task<TEntity> GetById(int id);
        Task Update(TEntity entity);
        Task Create(TEntity entity);
        Task SaveChanges();
    }
}
