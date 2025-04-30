using System;
using System.Drawing;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;

        public MainForm()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            RefreshTaskList();
        }

        private void RefreshTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in taskManager.GetTasks())
            {
                listBoxTasks.Items.Add(task.ToString());
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text;
            if (!string.IsNullOrEmpty(description))
            {
                taskManager.AddTask(new Task(description));
                RefreshTaskList();
                textBoxDescription.Clear();
            }
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                string newDescription = textBoxDescription.Text;
                if (!string.IsNullOrEmpty(newDescription))
                {
                    taskManager.EditTask(listBoxTasks.SelectedIndex, newDescription);
                    RefreshTaskList();
                    textBoxDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Task description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                taskManager.DeleteTask(listBoxTasks.SelectedIndex);
                RefreshTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonToggleStatus_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                taskManager.ToggleTaskStatus(listBoxTasks.SelectedIndex);
                RefreshTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to toggle its status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSaveTasks_Click(object sender, EventArgs e)
        {
            taskManager.SaveTasks();
        }

        private void listBoxTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            var task = taskManager.GetTasks()[e.Index];
            var font = new Font("Segoe UI", 10, FontStyle.Regular);
            var checkmark = task.IsCompleted ? "✔" : "✘";
            var color = task.IsCompleted ? Color.Green : Color.Red;

            using (var brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(checkmark, font, brush, e.Bounds.Left, e.Bounds.Top);
            }

            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(task.Description, font, brush, e.Bounds.Left + 20, e.Bounds.Top);
            }

            e.DrawFocusRectangle();
        }
    }
}
