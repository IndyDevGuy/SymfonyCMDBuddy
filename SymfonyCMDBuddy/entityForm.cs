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
    public partial class entityForm : Form
    {
        public Form1 mainFrom;
        public string[] fields;
        public string name;
        public string format;
        public int fieldNumber;
        public int fieldCount;

        public entityForm(Form1 form)
        {
            this.mainFrom = form;
            InitializeComponent();
        }

        public void setConsole(string text)
        {
            this.entityConsole.Text += Environment.NewLine + text;
        }

        private void generateFields_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(this.entityNumberOfFields.Text, out number))
            {
                this.fieldCount = number;
                this.fields = new string[number];
                for(int i = 1; i <= number; i++)
                {
                    EntityFieldTypeForm fieldForm = new EntityFieldTypeForm(this, i);
                    
                        fieldForm.TopMost = true;
                    var dialogResult = fieldForm.ShowDialog();
                    
                    while (fieldForm.DialogResult == DialogResult.None)
                    {
                    }
                    fieldForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Please only type a number for number of entity fields!","Number Of Entity Fields is not a integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createEntity_Click(object sender, EventArgs e)
        {
            if(this.fields.Length > 0)
            {
                string fieldString = "";
                int i = 0;
                foreach(string field in this.fields)
                {
                    if (i == 0)
                        fieldString += field;
                    else
                        fieldString += " " + field;
                }
                string command = this.mainFrom.entityCreateCMD + " --no-interaction --entity="+this.entityName.Text + " --fields=\""+fieldString + "\" --format="+this.entityFormat.Text;
                this.mainFrom.writeConsole(command);
                this.mainFrom.callCommand(command, "test");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please add at least one field to the entity!", "Entity has no fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
