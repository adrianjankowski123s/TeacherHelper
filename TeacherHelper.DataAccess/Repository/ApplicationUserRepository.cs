using TeacherHelper.DataAccess.Repository.Data;
using TeacherHelper.DataAccess.Repository.IRepository;
using TeacherHelper.Models;


namespace TeacherHelper.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


    }
}