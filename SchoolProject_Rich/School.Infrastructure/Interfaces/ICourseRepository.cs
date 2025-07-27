namespace School.Infrastructure.Interfaces
{
    public interface ICourseRepository
    {
        void AddCourse(string title, int credits, int departmentId);
        IEnumerable<string> GetAllCourseTitles();
    }
}
