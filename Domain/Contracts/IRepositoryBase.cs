using System.Linq.Expressions;

namespace Contracts;
public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindByCondition(Expression<Func<T,bool>> condition ,         
        bool trackChanges);

    IQueryable<T> FindByConditionIncluding(Expression<Func<T,bool>> condition ,
        bool trackChnages,
        params string[] conditions);

    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}

