using TeacherHelper.Data;
using TeacherHelper.Models;
using TeacherHelper.Repository.IRepository;

namespace TeacherHelper.Repository
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
