using System.Linq.Expressions;

namespace SchoolBusData.Repos;

public interface IRepository<T>
{
    IEnumerable<T>? GetAll();

    T? Get(int id, bool tracking = true);

    IEnumerable<T>? Get(Expression<Func<T, bool>> expression);

    void Add(T entity);

    void AddRange(IEnumerable<T> entity);

    void Update(T entity);

    void Remove(T entity);

    void SaveChanges();
}
