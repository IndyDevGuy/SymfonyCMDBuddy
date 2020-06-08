namespace SymfonyCMDBuddy
{
    partial class generateBundleForm
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
            this.bundleNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bundleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bundleFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bundleNamespace
            // 
            this.bundleNamespace.Location = new System.Drawing.Point(142, 13);
            this.bundleNamespace.Name = "bundleNamespace";
            this.bundleNamespace.Size = new System.Drawing.Size(130, 20);
            this.bundleNamespace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namespace:";
            // 
            // bundleName
            // 
            this.bundleName.Location = new System.Drawing.Point(142, 40);
            this.bundleName.Name = "bundleName";
            this.bundleName.Size = new System.Drawing.Size(130, 20);
            this.bundleName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bundle Name:";
            // 
            // bundleFormat
            // 
            this.bundleFormat.FormattingEnabled = true;
            this.bundleFormat.Items.AddRange(new object[] {
            "annotation",
            "php",
            "yml",
            "xml"});
            this.bundleFormat.Location = new System.Drawing.Point(142, 67);
            this.bundleFormat.Name = "bundleFormat";
            this.bundleFormat.Size = new System.Drawing.Size(130, 21);
            this.bundleFormat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Format:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Bundle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateBundleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bundleFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bundleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bundleNamespace);
            this.Name = "generateBundleForm";
            this.Text = "Bundle Generation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bundleNamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bundleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bundleFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}