using School.Infrastructure.Interfaces;

namespace School.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly List<string> _departments = new();

        public void AddDepartment(string name, decimal budget)
        {
            _departments.Add(name);
        }

        public IEnumerable<string> GetDepartmentNames()
        {
            return _departments;
        }
    }
}
