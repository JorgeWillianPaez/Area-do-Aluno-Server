namespace AreaDoAluno.src.models
{
    public class Exam
    {
        public int Id { get; set;}
        public DateOnly? Deadline { get; set; }
        public float MaxGrade { get; set; }
        public Class? Class { get; set; }

        public Exam() {}
    }
}