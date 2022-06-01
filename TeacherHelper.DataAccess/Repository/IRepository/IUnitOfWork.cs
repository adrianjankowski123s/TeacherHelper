namespace TeacherHelper.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IGradeRepository Grade { get; }
        ILogbookRepository Logbook { get; }
        IStudentRepository Student { get; }
        ITeacherRepository Teacher { get; }

        void Save();
    }
}