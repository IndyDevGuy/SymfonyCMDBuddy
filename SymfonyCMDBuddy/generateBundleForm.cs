using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymfonyCMDBuddy
{
    public partial class generateBundleForm : Form
    {
        public Form1 mainForm;
        public generateBundleForm(Form1 form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = this.mainForm.generateBundleCMD + " --namespace=" + this.bundleNamespace.Text + " --bundle-name=" + this.bundleName.Text + " --format=" + this.bundleFormat.Text + " --shared --no-interaction";
            this.mainForm.callCommand(command, "");
            this.Close();
        }
    }
}
