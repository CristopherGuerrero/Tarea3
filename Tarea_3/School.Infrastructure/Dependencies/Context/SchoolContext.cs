namespace School.Infrastructure.Dependencies.Context
{
    public class SchoolContext
    {
        // Simulación de DbSets
        public List<object> Courses { get; set; }
        public List<object> Departments { get; set; }

        public SchoolContext()
        {
            Courses = new List<object>();
            Departments = new List<object>();
        }
    }
}
