namespace School.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public int Credits { get; set; }
    }
}
