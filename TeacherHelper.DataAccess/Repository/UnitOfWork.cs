using TeacherHelper.DataAccess.Repository.Data;
using TeacherHelper.DataAccess.Repository.IRepository;

namespace TeacherHelper.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Teacher = new TeacherRepository(_db);
            Student = new StudentRepository(_db);
            Grade = new GradeRepository(_db);
            Logbook = new LogbookRepository(_db);
        }

        public ITeacherRepository Teacher { get; private set; }
        public IStudentRepository Student { get; private set; }
        public IGradeRepository Grade { get; private set; }
        public ILogbookRepository Logbook { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
