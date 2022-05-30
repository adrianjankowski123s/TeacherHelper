using TeacherHelper.Data;
using TeacherHelper.Models;
using TeacherHelper.Repository.IRepository;

namespace TeacherHelper.Repository
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
