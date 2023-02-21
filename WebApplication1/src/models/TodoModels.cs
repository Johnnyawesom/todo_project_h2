namespace WebApplication1.src.models
{
    public class TodoModels
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TaskDescription { get; set; }
        public string Title { get; set; }
        public DateTime CreatedTime { get; set; }

        public bool IsCompleted { get; set; }
        public PriorityEnum Priority { get; set; }
    }

}
