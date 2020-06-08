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
    public partial class createEntityForm : Form
    {
        public Form1 mainform;
        public createEntityForm(Form1 form)
        {
            this.mainform = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = this.mainform.entityFormCMD + " " + this.entityName.Text;
            this.mainform.callCommand(command,"");
            this.Close();
        }
    }
}
