namespace STI.DAT.Contractors
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> CountAllAsync();
        Task<int> CountByConditionAsync(Func<T, bool> condition);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetByConditionAsync<TKey>(Func<T, bool> condition);
        Task<T> GetByIDAsync(object id);
        Task AddAsync(T entity);
        Task UpdateAsync(object id, object model);
        Task DeleteAsync(object id);
    }
}