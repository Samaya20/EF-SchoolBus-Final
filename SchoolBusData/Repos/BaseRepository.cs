using Microsoft.EntityFrameworkCore;
using SchoolBusData.Contexts;
using SchoolBusData_Models.Base;
using System.Linq.Expressions;

namespace SchoolBusData.Repos;

public class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    private readonly MainContext _context;
    private readonly DbSet<T> _dbSet;
    public BaseRepository()
    {
        _context = new MainContext();
        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _dbSet.AddRange(entities);
    }

    public T? Get(int id, bool tracking = true)
    {
        if (tracking)
            return _dbSet.FirstOrDefault(obj => obj.Id == id);
        return _dbSet.AsNoTracking().FirstOrDefault(obj => obj.Id == id);
    }

    public IEnumerable<T>? Get(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression).ToList();
    }

    public IEnumerable<T>? GetAll()
    {
        return _dbSet.ToList();
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}
