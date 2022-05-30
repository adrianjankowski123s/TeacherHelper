using TeacherHelper.Data;
using TeacherHelper.Models;
using TeacherHelper.Repository.IRepository;

namespace TeacherHelper.Repository
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        private ApplicationDbContext _db;
        public TeacherRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Teacher obj)
        {
            _db.Teachers.Update(obj);
        }

    }
}
