using System;
using System.Windows.Forms;

namespace TodoListApp
{
    static class Program
    {
        /// <summary>
        /// Program entry point: creates and runs the MainForm Windows form for the TodoListApp.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Show visual styles and run the application.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // Tasks are auto-loaded on form init and saved via Save button. To persist tasks manually: click "Save" button.
        }
    }
}
