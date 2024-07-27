namespace WebApplication4.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public Guid Owner { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
