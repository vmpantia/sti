using Microsoft.EntityFrameworkCore;
using STI.DAT.Contractors;
using STI.DAT.DataAccess;

namespace STI.DAT.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepository(StudentDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public async Task<int> CountAllAsync() => await _table.CountAsync();
        public async Task<int> CountByConditionAsync(Func<T, bool> condition) => _table.Where(condition).Count();

        public async Task<IEnumerable<T>> GetAllAsync() => await _table.ToListAsync();
        public async Task<IEnumerable<T>> GetByConditionAsync<TKey>(Func<T, bool> condition) => _table.Where(condition);
        public async Task<T> GetByIDAsync(object id)
        {
            var result = await _table.FindAsync(id);
            if (result == null)
                throw new Exception();

            return result;
        }

        public async Task AddAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await _table.AddAsync(entity);
        }
        public async Task UpdateAsync(object id, object model)
        {
            var data = await GetByIDAsync(id);
            _context.Entry(data).CurrentValues.SetValues(model);
        }
        public async Task DeleteAsync(object id)
        {
            var data = await GetByIDAsync(id);
            _table.Remove(data);
        }
    }
}
