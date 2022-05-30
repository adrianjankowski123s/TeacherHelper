using TeacherHelper.Data;
using TeacherHelper.Models;
using TeacherHelper.Repository.IRepository;

namespace TeacherHelper.Repository
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
