namespace SymfonyCMDBuddy
{
    partial class newProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newProjectForm));
            this.projectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createProject = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.symfonyInstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(110, 12);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(126, 20);
            this.projectName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Name:";
            // 
            // projectDirectory
            // 
            this.projectDirectory.Location = new System.Drawing.Point(110, 39);
            this.projectDirectory.Name = "projectDirectory";
            this.projectDirectory.Size = new System.Drawing.Size(126, 23);
            this.projectDirectory.TabIndex = 2;
            this.projectDirectory.Text = "Project Directory";
            this.projectDirectory.UseVisualStyleBackColor = true;
            this.projectDirectory.Click += new System.EventHandler(this.projectDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Directory:";
            // 
            // createProject
            // 
            this.createProject.Location = new System.Drawing.Point(13, 129);
            this.createProject.Name = "createProject";
            this.createProject.Size = new System.Drawing.Size(223, 23);
            this.createProject.TabIndex = 4;
            this.createProject.Text = "Create Project & Set Current";
            this.createProject.UseVisualStyleBackColor = true;
            this.createProject.Click += new System.EventHandler(this.createProject_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(79, 68);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(91, 13);
            this.pathLabel.TabIndex = 5;
            this.pathLabel.Text = "Directory Not Set!";
            // 
            // symfonyInstall
            // 
            this.symfonyInstall.Location = new System.Drawing.Point(75, 100);
            this.symfonyInstall.Name = "symfonyInstall";
            this.symfonyInstall.Size = new System.Drawing.Size(98, 23);
            this.symfonyInstall.TabIndex = 6;
            this.symfonyInstall.Text = "Install Symfony";
            this.symfonyInstall.UseVisualStyleBackColor = true;
            this.symfonyInstall.Click += new System.EventHandler(this.symfonyInstall_Click);
            // 
            // newProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 164);
            this.Controls.Add(this.symfonyInstall);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.createProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newProjectForm";
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button projectDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createProject;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button symfonyInstall;
    }
}