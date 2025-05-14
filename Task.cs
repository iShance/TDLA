namespace TodoListApp
{
    /// <summary>
    /// Defines possible priority levels for tasks.
    /// </summary>
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    /// <summary>
    /// Represents a general to-do item with a description, completion status, and priority.
    /// </summary>
    public class Task
    {
        // Property: Description of the task
        public string Description { get; set; }
        // Property: Indicates whether the task is completed
        public bool IsCompleted { get; set; }
        // Property: Task priority, using the TaskPriority enumeration
        public TaskPriority Priority { get; set; }

        // Constructor: initialize a Task with a description and optional priority
        public Task(string description, TaskPriority priority = TaskPriority.Medium)
        {
            Description = description;
            IsCompleted = false;
            Priority = priority;
        }

        // ToString override: returns string representation including completion and priority
        public override string ToString()
        {
            return $"{(IsCompleted ? "[✓]" : "[ ]")} {Description} (Priority: {Priority})";
        }
    }

    /// <summary>
    /// Extends Task by adding a due date property to represent timed tasks.
    /// </summary>
    public class TimedTask : Task
    {
        // Property: Due date specific to a timed task
        public DateTime DueDate { get; set; }

        // Constructor: call base Task constructor and set the due date
        public TimedTask(string description, DateTime dueDate, TaskPriority priority = TaskPriority.Medium)
            : base(description, priority)
        {
            DueDate = dueDate;
        }

        // ToString override: include due date information
        public override string ToString()
        {
            return base.ToString() + $" (Due: {DueDate:yyyy-MM-dd})";
        }
    }
}