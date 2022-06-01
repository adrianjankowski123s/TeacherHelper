using System.Linq.Expressions;

namespace TeacherHelper.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProporties = null);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProporties = null, bool tracked = true);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}