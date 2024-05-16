namespace AreaDoAluno.src.models
{
    public class CourseDiscipline
    {
        public int Id { get; set;}
        public Course Course { get; set; }
        public Discipline Discipline { get; set; }
    }
}