using Layer1.DATA.Infrastructure;
using Layer1.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.DATA.Repositories
{
    public sealed class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private CStudentContext dataContext;

        public IQueryable<T> GetAll()
        {
            return cStudentContext.Set<T>().Where(x => x.IsDeleted == false);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <value>
        /// All.
        /// </value>
        public IQueryable<T> All => GetAll();

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = cStudentContext.Set<T>().Where(x => x.IsDeleted == false);
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public T GetSingle(long id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }


        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return cStudentContext.Set<T>().Where(predicate).Where(x => x.IsDeleted == false);
        }

        public IQueryable<T> FindByAll(Expression<Func<T, bool>> predicate)
        {
            return cStudentContext.Set<T>().Where(predicate);
        }

        public void Add(T entity)
        {
            entity.IsDeleted = false;
            cStudentContext.Entry(entity);
            cStudentContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.IsDeleted = false;
                cStudentContext.Entry(entity);
                cStudentContext.Set<T>().Add(entity);
            }
        }

        public void Edit(T oldEntity, T newEntity)
        {
            //DbEntityEntry dbEntityEntry = DbContext.Entry<T>(entity);
            //dbEntityEntry.State = EntityState.Modified;
            cStudentContext.Entry(oldEntity).CurrentValues.SetValues(newEntity);
        }

        //public virtual void UpdateValues(T oldEntity, T newEntity)
        //{ 
        //    DbContext.Entry(oldEntity).CurrentValues.SetValues(newEntity); 
        //}
        public void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = cStudentContext.Entry(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public void SoftDelete(T entity)
        {
            entity.IsDeleted = true;
            DbEntityEntry dbEntityEntry = cStudentContext.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        #region Properties

        private IDbFactory DbFactory { get; }

        private CStudentContext cStudentContext => dataContext ?? (dataContext = DbFactory.Init());

        public EntityBaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        #endregion
    }
}
