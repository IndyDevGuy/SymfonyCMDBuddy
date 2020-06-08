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
    public partial class CrudControllerForm : Form
    {
        public Form1 mainForm;
        public CrudControllerForm(Form1 form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = this.mainForm.entityCrudCMD + " --entity=" + this.entityName.Text + " --format=" + this.controllerFormat.Text + " --with-write --route-prefix=" + this.routePrefix.Text + " --overwrite --no-interaction";
            this.mainForm.callCommand(command,"Generating CRUD Controller for entity: " + this.entityName.Text);
            this.Close();
        }
    }
}
