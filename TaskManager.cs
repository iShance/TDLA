using System;
using System.IO;

namespace TodoListApp
{
    // Class: TaskManager manages an array of Task objects
    // Demonstrates:
    // - Array of objects: uses Task[] tasks to store multiple Task instances
    // - File handling: LoadTasks reads from tasks.txt, SaveTasks writes to tasks.txt
    public class TaskManager
    {
        // Array of Task objects
        private Task[] tasks;
        // Number of active tasks in the array
        private int taskCount;
        private const int MaxTasks = 100;
        // File path for saving/loading tasks (file handling)
        private const string FILE_PATH = "tasks.txt";

        public TaskManager()
        {
            // Initialize array to hold up to MaxTasks objects
            tasks = new Task[MaxTasks];
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

        public Task[] GetTasks()
        {
            Task[] activeTasks = new Task[taskCount];
            Array.Copy(tasks, activeTasks, taskCount);
            return activeTasks;
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

        public void EditTask(int index, string newDescription)
        {
            if (index >= 0 && index < taskCount)
            {
                tasks[index].Description = newDescription;
            }
        }

        public void DeleteTask(int index)
        {
            if (index >= 0 && index < taskCount)
            {
                for (int i = index; i < taskCount - 1; i++)
                {
                    tasks[i] = tasks[i + 1];
                }
                tasks[--taskCount] = null;
            }
        }

        public void ToggleTaskStatus(int index)
        {
            if (index >= 0 && index < taskCount)
            {
                tasks[index].IsCompleted = !tasks[index].IsCompleted;
            }
        }
    }
}