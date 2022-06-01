using TeacherHelper.DataAccess.Repository.Data;
using TeacherHelper.DataAccess.Repository.IRepository;
using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private ApplicationDbContext _db;
        public StudentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Student obj)
        {
            _db.Students.Update(obj);
        }
    }
}
