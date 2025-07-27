using School.Infrastructure.Interfaces;

namespace School.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly List<string> _courses = new();

        public void AddCourse(string title, int credits, int departmentId)
        {
            _courses.Add(title);
        }

        public IEnumerable<string> GetAllCourseTitles()
        {
            return _courses;
        }
    }
}
