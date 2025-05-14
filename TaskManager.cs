using System;
using System.IO;
using System.Linq;  // For LINQ operations on task array

namespace TodoListApp
{
    /// <summary>
    /// Manages a collection of Task objects using an array; provides methods to add, edit, delete, toggle status,
    /// and handles file persistence (loading and saving tasks).
    /// </summary>
    public class TaskManager
    {
        // Array of Task objects (nullable to allow empty slots)
        private Task?[] tasks;
        // Number of active tasks in the array
        private int taskCount;
        private const int MaxTasks = 100;
        // File path for saving/loading tasks (file handling)
        private const string FILE_PATH = "tasks.txt";

        /// <summary>
        /// Initializes a new TaskManager, prepares storage array, and loads tasks from file.
        /// </summary>
        public TaskManager()
        {
            // Initialize array (nullable) to hold up to MaxTasks objects
            tasks = new Task?[MaxTasks];
            taskCount = 0;
            // Load existing tasks from file into the array
            LoadTasks();
        }

        public void AddTask(Task task)
        {
            if (taskCount >= MaxTasks)
            {
                Console.WriteLine("Task limit reached!");
                return;
            }
            tasks[taskCount++] = task;
            Console.WriteLine("Task added successfully!");
        }

        /// <summary>
        /// Returns only the active (non-null) tasks as an array.
        /// </summary>
        public Task[] GetTasks()
        {
            // Use LINQ to filter out null slots and return Task[]
            return tasks
                .Where(t => t != null)
                .Cast<Task>()
                .ToArray();
        }

        public void SaveTasks()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FILE_PATH))
                {
                    foreach (var task in tasks)
                    {
                        if (task != null)
                        {
                            writer.WriteLine($"{task.Description},{task.IsCompleted},{task.Priority}");
                        }
                    }
                }
                Console.WriteLine("Tasks saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks: {ex.Message}");
            }
        }

        /// <summary>
        /// Saves tasks to a specified file path.
        /// </summary>
        /// <param name="filePath">Destination file path.</param>
        public void SaveToFile(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    foreach (var task in tasks.Where(t => t != null).Cast<Task>())
                    {
                        writer.WriteLine($"{task.Description},{task.IsCompleted},{task.Priority}");
                    }
                }
                Console.WriteLine($"Tasks exported to: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error exporting tasks: {ex.Message}");
            }
        }

        private void LoadTasks()
        {
            if (!File.Exists(FILE_PATH))
                return;

            try
            {
                string[] lines = File.ReadAllLines(FILE_PATH);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Task task = new Task(parts[0], Enum.Parse<TaskPriority>(parts[2]));
                        task.IsCompleted = bool.Parse(parts[1]);
                        AddTask(task);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks: {ex.Message}");
            }
        }

        /// <summary>
        /// Loads tasks from a specified file, replacing current tasks in memory.
        /// </summary>
        /// <param name="filePath">Path to the tasks file.</param>
        public void LoadFromFile(string filePath)
        {
            // Reset current tasks
            taskCount = 0;
            Array.Clear(tasks, 0, tasks.Length);
            if (!File.Exists(filePath)) return;
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        var task = new Task(parts[0], Enum.Parse<TaskPriority>(parts[2]));
                        task.IsCompleted = bool.Parse(parts[1]);
                        AddTask(task);
                    }
                }
                Console.WriteLine($"Tasks loaded from: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading from file: {ex.Message}");
            }
        }

        public void EditTask(int index, string newDescription)
        {
            if (index >= 0 && index < taskCount)
            {
                tasks[index]!.Description = newDescription;
            }
        }

        /// <summary>
        /// Deletes task at specified index, shifts subsequent tasks left.
        /// </summary>
        public void DeleteTask(int index)
        {
            if (index >= 0 && index < taskCount)
            {
                for (int i = index; i < taskCount - 1; i++)
                {
                    // Shift tasks, non-null guaranteed for indices < taskCount
                    tasks[i] = tasks[i + 1]!;
                }
                // Decrement count and clear last slot
                taskCount--;
                tasks[taskCount] = null;
            }
        }

        public void ToggleTaskStatus(int index)
        {
            if (index >= 0 && index < taskCount)
            {
                // Toggle completion status, non-null as index < taskCount
                tasks[index]!.IsCompleted = !tasks[index]!.IsCompleted;
            }
        }
    }
}