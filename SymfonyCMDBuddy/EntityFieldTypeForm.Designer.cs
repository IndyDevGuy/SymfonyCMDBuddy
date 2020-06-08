namespace SymfonyCMDBuddy
{
    partial class EntityFieldTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityFieldTypeForm));
            this.fieldType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldTitle = new System.Windows.Forms.TextBox();
            this.fieldLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldNullable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fieldUnique = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldPrecision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fieldScale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fieldCount = new System.Windows.Forms.Label();
            this.saveField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fieldType
            // 
            this.fieldType.FormattingEnabled = true;
            this.fieldType.Items.AddRange(new object[] {
            "string",
            "integer",
            "smallint",
            "bigint",
            "boolean",
            "decimal",
            "date",
            "time",
            "datetime",
            "datetimetz",
            "text",
            "object",
            "array",
            "simple_array",
            "json_array",
            "float",
            "guid",
            "blob"});
            this.fieldType.Location = new System.Drawing.Point(78, 37);
            this.fieldType.Name = "fieldType";
            this.fieldType.Size = new System.Drawing.Size(121, 21);
            this.fieldType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field Title:";
            // 
            // fieldTitle
            // 
            this.fieldTitle.Location = new System.Drawing.Point(78, 64);
            this.fieldTitle.Name = "fieldTitle";
            this.fieldTitle.Size = new System.Drawing.Size(121, 20);
            this.fieldTitle.TabIndex = 3;
            // 
            // fieldLength
            // 
            this.fieldLength.Location = new System.Drawing.Point(78, 90);
            this.fieldLength.Name = "fieldLength";
            this.fieldLength.Size = new System.Drawing.Size(121, 20);
            this.fieldLength.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Field Length:";
            // 
            // fieldNullable
            // 
            this.fieldNullable.FormattingEnabled = true;
            this.fieldNullable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.fieldNullable.Location = new System.Drawing.Point(78, 116);
            this.fieldNullable.Name = "fieldNullable";
            this.fieldNullable.Size = new System.Drawing.Size(121, 21);
            this.fieldNullable.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nullable:";
            // 
            // fieldUnique
            // 
            this.fieldUnique.FormattingEnabled = true;
            this.fieldUnique.Items.AddRange(new object[] {
            "true",
            "false"});
            this.fieldUnique.Location = new System.Drawing.Point(78, 143);
            this.fieldUnique.Name = "fieldUnique";
            this.fieldUnique.Size = new System.Drawing.Size(121, 21);
            this.fieldUnique.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unique:";
            // 
            // fieldPrecision
            // 
            this.fieldPrecision.Location = new System.Drawing.Point(78, 171);
            this.fieldPrecision.Name = "fieldPrecision";
            this.fieldPrecision.Size = new System.Drawing.Size(121, 20);
            this.fieldPrecision.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precision:";
            // 
            // fieldScale
            // 
            this.fieldScale.Location = new System.Drawing.Point(78, 197);
            this.fieldScale.Name = "fieldScale";
            this.fieldScale.Size = new System.Drawing.Size(121, 20);
            this.fieldScale.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Scale:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Field Number:";
            // 
            // fieldCount
            // 
            this.fieldCount.AutoSize = true;
            this.fieldCount.Location = new System.Drawing.Point(114, 9);
            this.fieldCount.Name = "fieldCount";
            this.fieldCount.Size = new System.Drawing.Size(44, 13);
            this.fieldCount.TabIndex = 15;
            this.fieldCount.Text = "Number";
            // 
            // saveField
            // 
            this.saveField.Location = new System.Drawing.Point(124, 226);
            this.saveField.Name = "saveField";
            this.saveField.Size = new System.Drawing.Size(75, 23);
            this.saveField.TabIndex = 16;
            this.saveField.Text = "Save Field";
            this.saveField.UseVisualStyleBackColor = true;
            this.saveField.Click += new System.EventHandler(this.saveField_Click);
            // 
            // EntityFieldTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 261);
            this.Controls.Add(this.saveField);
            this.Controls.Add(this.fieldCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fieldScale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fieldPrecision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fieldUnique);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fieldNullable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldLength);
            this.Controls.Add(this.fieldTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntityFieldTypeForm";
            this.Text = "Add Entity Field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fieldType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldTitle;
        private System.Windows.Forms.TextBox fieldLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fieldNullable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fieldUnique;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fieldPrecision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fieldScale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label fieldCount;
        private System.Windows.Forms.Button saveField;
    }
}