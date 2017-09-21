using Layer1.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.DATA.Repositories
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetAll();
        T GetSingle(long id);


        ////GetStudentByName for login
        //T GetSingleByName(string name);


        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindByAll(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T oldEntity, T newEntity);
        //void UpdateValues(T oldEntity, T newEntity);
        void AddRange(IEnumerable<T> entities);
        void SoftDelete(T entity);
    }
}
