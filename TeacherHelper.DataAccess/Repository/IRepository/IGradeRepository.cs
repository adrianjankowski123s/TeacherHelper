using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository.IRepository
{
    public interface IGradeRepository : IRepository<Grade>
    {
        void Update(Grade obj);
    }
}