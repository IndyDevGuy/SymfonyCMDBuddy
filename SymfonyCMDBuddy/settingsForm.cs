using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace SymfonyCMDBuddy
{
    public partial class settingsForm : Form
    {
        public Form1 mainForm;

        //document root
        public string documentRoot;

        public List<string[]> projects; 

        //boolean if document root has been set
        public Boolean docSet;
        public settingsForm(Form1 form)
        {
            this.projects = new List<string[]>();
            this.mainForm = form;
            InitializeComponent();
            this.reloadProfiles();
            this.documentRoot = mainForm.documentRoot;
            if(!string.IsNullOrEmpty(this.documentRoot))
            {
                this.docSet = true;
                this.label2.Text = this.documentRoot;
            }
            else
            {
                this.docSet = false;
                this.label2.Text = "The path has not been set yet,"+ Environment.NewLine + "please select a folder with the button below!";
            }
            if(this.docSet)
            {
            }
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {

        }

        private class Item
        {
            public string Name;
            public string Value;
            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        public void reloadProfiles()
        {
            Dictionary<string, Profile> profiles = this.mainForm.getSettingsProfiles();
            //first lets add the active selected profile if there is one
            string activeProfile = this.mainForm.getSettingsActiveProfile();
            if (activeProfile != null)
            {
                Profile profile = this.mainForm.getSettingsProfile(activeProfile);
                Item item = new Item(profile.getName(), profile.getName());
                this.projectSelect.Items.Add(item);
                this.projectSelect.SelectedItem = item;
            }
            if (profiles != null)
            {
                foreach (KeyValuePair<string, Profile> profile in profiles)
                {
                    if (profile.Value.getName() != activeProfile)
                    {
                        this.mainForm.writeConsole(profile.Value.getName());
                        this.projectSelect.Items.Add(new Item(profile.Value.getName(), profile.Value.getName()));
                    }
                }
            }
        }
        
        public void setDocumentRoots(string root)
        {
            this.documentRoot = root;
            this.mainForm.setDocumentRoot(root);
            this.label2.Text = root;
            if(!string.IsNullOrEmpty(root))
            {
                this.docSet = true;
                this.mainForm.rootSet = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.setDocumentRoots(fbd.SelectedPath);
                Properties.Settings.Default["DocumentRoot"] = this.documentRoot;
                Properties.Settings.Default["SymfonyVersion"] = this.mainForm.symfonyVersion;
                Properties.Settings.Default.Save();
                this.mainForm.getSymfonyVersion();
            }
            else
                this.setDocumentRoots(string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void newProject_Click(object sender, EventArgs e)
        {
            newProjectForm form = new newProjectForm(this);
            form.Show();
            if (form.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                //this.Hide();
            }
        }

        public void refreshProjects()
        {
            foreach(string[] project in this.projects)
            {
                int index = 0;
                foreach(string data in project)
                {
                    if(index == 0)
                    {
                        // project name should always be first in the project array!
                        this.projectSelect.Items.Add(data);
                    }
                    else
                    {
                        break;
                    }
                    index++;
                }
            }
        }

        private void projectSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
