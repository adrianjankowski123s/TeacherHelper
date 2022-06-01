using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository.IRepository
{
    public interface ILogbookRepository : IRepository<Logbook>
    {
        void Update(Logbook obj);
    }
}