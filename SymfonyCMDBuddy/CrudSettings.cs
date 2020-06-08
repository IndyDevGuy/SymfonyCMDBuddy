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
    public partial class CrudSettings : Form
    {
        public Form1 mainForm;
        public CrudSettings(Form1 form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        private void CrudSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
