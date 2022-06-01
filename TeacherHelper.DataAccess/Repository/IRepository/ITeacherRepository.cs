using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository.IRepository
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        void Update(Teacher obj);
    }
}