using TeacherHelper.DataAccess.Repository.Data;
using TeacherHelper.DataAccess.Repository.IRepository;
using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository
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
