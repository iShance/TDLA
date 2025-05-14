namespace TodoListApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonToggleStatus;
        private System.Windows.Forms.Button buttonSaveTasks;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;

        private void InitializeComponent()
        {
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonToggleStatus = new System.Windows.Forms.Button();
            this.buttonSaveTasks = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "To-Do List Manager";
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.Color.Lavender;
            this.listBoxTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 30;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 50);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(360, 154);
            this.listBoxTasks.TabIndex = 1;
            this.listBoxTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxTasks_DrawItem);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(12, 230);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(81, 19);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(99, 227);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(273, 25);
            this.textBoxDescription.TabIndex = 3;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTask.ForeColor = System.Drawing.Color.White;
            this.buttonAddTask.Location = new System.Drawing.Point(12, 270);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 30);
            this.buttonAddTask.TabIndex = 4;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditTask.ForeColor = System.Drawing.Color.White;
            this.buttonEditTask.Location = new System.Drawing.Point(93, 270);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(75, 30);
            this.buttonEditTask.TabIndex = 5;
            this.buttonEditTask.Text = "Edit";
            this.buttonEditTask.UseVisualStyleBackColor = false;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteTask.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTask.Location = new System.Drawing.Point(174, 270);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(75, 30);
            this.buttonDeleteTask.TabIndex = 6;
            this.buttonDeleteTask.Text = "Delete";
            this.buttonDeleteTask.UseVisualStyleBackColor = false;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonToggleStatus
            // 
            this.buttonToggleStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggleStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonToggleStatus.ForeColor = System.Drawing.Color.White;
            this.buttonToggleStatus.Location = new System.Drawing.Point(255, 270);
            this.buttonToggleStatus.Name = "buttonToggleStatus";
            this.buttonToggleStatus.Size = new System.Drawing.Size(75, 30);
            this.buttonToggleStatus.TabIndex = 7;
            this.buttonToggleStatus.Text = "Toggle";
            this.buttonToggleStatus.UseVisualStyleBackColor = false;
            this.buttonToggleStatus.Click += new System.EventHandler(this.buttonToggleStatus_Click);
            // 
            // buttonSaveTasks
            // 
            this.buttonSaveTasks.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSaveTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTasks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveTasks.ForeColor = System.Drawing.Color.White;
            this.buttonSaveTasks.Location = new System.Drawing.Point(336, 270);
            this.buttonSaveTasks.Name = "buttonSaveTasks";
            this.buttonSaveTasks.Size = new System.Drawing.Size(75, 30);
            this.buttonSaveTasks.TabIndex = 8;
            this.buttonSaveTasks.Text = "Save";
            this.buttonSaveTasks.UseVisualStyleBackColor = false;
            this.buttonSaveTasks.Click += new System.EventHandler(this.buttonSaveTasks_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.Teal;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(12, 310);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 30);
            this.buttonExport.TabIndex = 9;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.Teal;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImport.ForeColor = System.Drawing.Color.White;
            this.buttonImport.Location = new System.Drawing.Point(93, 310);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 30);
            this.buttonImport.TabIndex = 10;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 360);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonSaveTasks);
            this.Controls.Add(this.buttonToggleStatus);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonEditTask);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "To-Do List Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
