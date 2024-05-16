namespace AreaDoAluno.src.Models
{
    public class Class
    {
        public int Id { get; set;}
        public Professor? Professor { get; set; }
        public Discipline? Discipline { get; set; }
        public string? Room { get; set; }

        public Class() {}
    }
}