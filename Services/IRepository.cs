namespace workout_helper_2.Services;


public interface IRepository<T> where T : class
{
    IQueryable<T> GetAll();
    IQueryable<T> GetAll(Func<T, bool> filter);
    T? Get(object id);
    T? First(Func<T, bool> filter);
    T Add(T entity);
    IEnumerable<T> AddRange(IEnumerable<T> entities);
    void Update(T entity);
    void Delete(object id);
    void Delete(T entity);
    void DeleteRange(IEnumerable<T> entity);
    int Count();
    int Count(Func<T, bool> filter);
    void UpdateRange(IEnumerable<T> entity);
    public int Commit();
}
