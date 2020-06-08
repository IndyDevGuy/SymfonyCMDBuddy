namespace SymfonyCMDBuddy
{
    partial class CrudControllerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudControllerForm));
            this.entityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controllerFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.routePrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entityName
            // 
            this.entityName.Location = new System.Drawing.Point(140, 6);
            this.entityName.Name = "entityName";
            this.entityName.Size = new System.Drawing.Size(139, 20);
            this.entityName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entity Bundle Name:";
            // 
            // controllerFormat
            // 
            this.controllerFormat.FormattingEnabled = true;
            this.controllerFormat.Items.AddRange(new object[] {
            "annotation",
            "php",
            "yml",
            "xml"});
            this.controllerFormat.Location = new System.Drawing.Point(140, 33);
            this.controllerFormat.Name = "controllerFormat";
            this.controllerFormat.Size = new System.Drawing.Size(139, 21);
            this.controllerFormat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Controller Format:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate CRUD Controller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // routePrefix
            // 
            this.routePrefix.Location = new System.Drawing.Point(140, 60);
            this.routePrefix.Name = "routePrefix";
            this.routePrefix.Size = new System.Drawing.Size(139, 20);
            this.routePrefix.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Route Prefix:";
            // 
            // CrudControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.routePrefix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controllerFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entityName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudControllerForm";
            this.Text = "CRUD Controller Generation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox controllerFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox routePrefix;
        private System.Windows.Forms.Label label4;
    }
}