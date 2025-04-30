namespace TodoListApp
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public TaskPriority Priority { get; set; }

        public Task(string description, TaskPriority priority = TaskPriority.Medium)
        {
            Description = description;
            IsCompleted = false;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"{(IsCompleted ? "[✓]" : "[ ]")} {Description} (Priority: {Priority})";
        }
    }

    public class TimedTask : Task
    {
        public DateTime DueDate { get; set; }

        public TimedTask(string description, DateTime dueDate, TaskPriority priority = TaskPriority.Medium)
            : base(description, priority)
        {
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return base.ToString() + $" (Due: {DueDate:yyyy-MM-dd})";
        }
    }
}