using TeacherHelper.DataAccess.Repository.Data;
using TeacherHelper.DataAccess.Repository.IRepository;
using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository
{
    public class GradeRepository : Repository<Grade>, IGradeRepository
    {
        private ApplicationDbContext _db;
        public GradeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Grade obj)
        {
            _db.Grades.Update(obj);
        }
    }
}
