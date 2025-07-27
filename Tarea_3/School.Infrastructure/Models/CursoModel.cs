namespace School.Infrastructure.Models
{
    public class CursoModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }
        public int DepartamentoId { get; set; }
    }
}
