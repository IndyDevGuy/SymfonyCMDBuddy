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
    public partial class generateCommandForm : Form
    {
        public Form1 mainForm;
        public generateCommandForm(Form1 form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = this.mainForm.generateCommandCMD + " --no-interaction " + this.bundleName.Text+" "+this.commandName.Text;
            this.mainForm.callCommand(command,"");
            this.Close();
        }
    }
}
