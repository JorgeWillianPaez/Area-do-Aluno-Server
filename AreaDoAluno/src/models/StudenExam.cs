namespace AreaDoAluno.Models
{
    public class StudentExam
    {
        public int Id { get; set;}
        public Student? Student { get; set; }
        public Exam? Exam { get; set; }
        public float Grade { get; set; }

        public StudentExam() {}
    }
}