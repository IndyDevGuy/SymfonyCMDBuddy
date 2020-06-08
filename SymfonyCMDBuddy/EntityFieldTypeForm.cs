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
    public partial class EntityFieldTypeForm : Form
    {
        public entityForm createEntityForm;
        public Form1 mainForm;

        public int fieldNumber;

        public Boolean submitted;

        public EntityFieldTypeForm(entityForm form, int fieldNum)
        {
            this.createEntityForm = form;
            this.mainForm = form.mainFrom;
            this.submitted = false;
            this.fieldNumber = fieldNum;
            InitializeComponent();
            this.fieldCount.Text = Convert.ToString(fieldNum);
            this.saveField.DialogResult = DialogResult.OK;
        }

        private void saveField_Click(object sender, EventArgs e)
        {
            string command = this.fieldTitle.Text + ":" + this.fieldType.Text + "(length=" + this.fieldLength.Text + " nullable=" + this.fieldNullable.Text + " scale=" + this.fieldScale.Text + " precision=" + this.fieldPrecision.Text + " unique=" + this.fieldUnique.Text + ")";
            this.createEntityForm.setConsole(command);
            this.createEntityForm.fields.SetValue(command, this.fieldNumber - 1);
        }
    }
}
