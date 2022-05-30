using TeacherHelper.Data;
using TeacherHelper.Repository.IRepository;

namespace TeacherHelper.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
