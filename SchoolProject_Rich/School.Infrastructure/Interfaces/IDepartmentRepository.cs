namespace School.Infrastructure.Interfaces
{
    public interface IDepartmentRepository
    {
        void AddDepartment(string name, decimal budget);
        IEnumerable<string> GetDepartmentNames();
    }
}
