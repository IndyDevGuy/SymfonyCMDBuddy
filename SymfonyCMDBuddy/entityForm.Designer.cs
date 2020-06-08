namespace SymfonyCMDBuddy
{
    partial class entityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entityForm));
            this.entityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entityNumberOfFields = new System.Windows.Forms.TextBox();
            this.createEntity = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.generateFields = new System.Windows.Forms.Button();
            this.entityConsole = new System.Windows.Forms.RichTextBox();
            this.entityFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entityName
            // 
            this.entityName.Location = new System.Drawing.Point(131, 9);
            this.entityName.Name = "entityName";
            this.entityName.Size = new System.Drawing.Size(141, 20);
            this.entityName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entity Bundle Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Fields:";
            // 
            // entityNumberOfFields
            // 
            this.entityNumberOfFields.Location = new System.Drawing.Point(131, 35);
            this.entityNumberOfFields.Name = "entityNumberOfFields";
            this.entityNumberOfFields.Size = new System.Drawing.Size(141, 20);
            this.entityNumberOfFields.TabIndex = 3;
            // 
            // createEntity
            // 
            this.createEntity.Location = new System.Drawing.Point(116, 254);
            this.createEntity.Name = "createEntity";
            this.createEntity.Size = new System.Drawing.Size(75, 23);
            this.createEntity.TabIndex = 4;
            this.createEntity.Text = "Create";
            this.createEntity.UseVisualStyleBackColor = true;
            this.createEntity.Click += new System.EventHandler(this.createEntity_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(197, 254);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // generateFields
            // 
            this.generateFields.Location = new System.Drawing.Point(131, 89);
            this.generateFields.Name = "generateFields";
            this.generateFields.Size = new System.Drawing.Size(141, 23);
            this.generateFields.TabIndex = 6;
            this.generateFields.Text = "Generate Fields";
            this.generateFields.UseVisualStyleBackColor = true;
            this.generateFields.Click += new System.EventHandler(this.generateFields_Click);
            // 
            // entityConsole
            // 
            this.entityConsole.Location = new System.Drawing.Point(12, 118);
            this.entityConsole.Name = "entityConsole";
            this.entityConsole.Size = new System.Drawing.Size(260, 130);
            this.entityConsole.TabIndex = 7;
            this.entityConsole.Text = "";
            // 
            // entityFormat
            // 
            this.entityFormat.FormattingEnabled = true;
            this.entityFormat.Items.AddRange(new object[] {
            "annotation",
            "php",
            "yml",
            "xml"});
            this.entityFormat.Location = new System.Drawing.Point(131, 62);
            this.entityFormat.Name = "entityFormat";
            this.entityFormat.Size = new System.Drawing.Size(141, 21);
            this.entityFormat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Format:";
            // 
            // entityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entityFormat);
            this.Controls.Add(this.entityConsole);
            this.Controls.Add(this.generateFields);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createEntity);
            this.Controls.Add(this.entityNumberOfFields);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entityName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "entityForm";
            this.Text = "Create A Entity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entityNumberOfFields;
        private System.Windows.Forms.Button createEntity;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button generateFields;
        private System.Windows.Forms.RichTextBox entityConsole;
        private System.Windows.Forms.ComboBox entityFormat;
        private System.Windows.Forms.Label label3;
    }
}