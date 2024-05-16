namespace AreaDoAluno.src.models
{
    public class Message
    {
        public int Id { get; set;}
        public string? Body { get; set; }
        public Class? Class { get; set; }

        public Message() {}
    }
}