using TeacherHelper.DataAccess.Repository.Data;
using TeacherHelper.DataAccess.Repository.IRepository;
using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository
{
    public class LogbookRepository : Repository<Logbook>, ILogbookRepository
    {
        private ApplicationDbContext _db;
        public LogbookRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Logbook obj)
        {
            _db.Logbooks.Update(obj);
        }
    }
}
