using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace SymfonyCMDBuddy
{
    public partial class newProjectForm : Form
    {

        public Form1 mainForm;
        public settingsForm formSettings;
        public Boolean symfonyInstalled;
        public FolderBrowserDialog fbd;

        public Profile profile;
        public newProjectForm(settingsForm form)
        {
            this.formSettings = form;
            this.mainForm = form.mainForm;
            this.symfonyInstalled = false;
            InitializeComponent();
            this.symfonyInstall.Visible = false;
            this.createProject.Enabled = false;
        }

        private void projectDirectory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.projectName.Text))
            {
                MessageBox.Show("Project name cannot be empty!", "Project Name Empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description"; //not mandatory

                if (this.fbd.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(this.fbd.SelectedPath + "\\vendor\\symfony"))
                    {
                        this.symfonyInstalled = true;
                        this.createProject.Enabled = true;
                        this.pathLabel.Text = "Symfony instance found in:" + Environment.NewLine + this.fbd.SelectedPath;
                        //save the profile
                        string symfonyVersion = this.mainForm.returnSymfonyVersion(this.fbd.SelectedPath);
                        int profileNumber = this.mainForm.getSettingsProfileCount() + 1;
                        this.profile = new Profile();
                        this.profile.setActive(false);
                        this.profile.setDocumentRoot(this.fbd.SelectedPath);
                        this.profile.setSymfonyVersion(symfonyVersion);
                        this.profile.setProfileNumber(profileNumber);
                        this.profile.setName(this.projectName.Text);
                    }
                    else
                    {
                        //promt user to install symfony in the selected directory
                        this.symfonyInstalled = false;
                        this.pathLabel.Text = "Symfony instance NOT found in:" + Environment.NewLine + this.fbd.SelectedPath;
                        this.symfonyInstall.Visible = true;
                    }
                }
            }
        }
        public void installSymfony()
        {
            this.mainForm.documentRoot = this.fbd.SelectedPath;
            //string command = "php -r \"readfile('https://symfony.com/installer');\" > symfony";
            //this.mainForm.callCommand(command, "", false);
            //command = "php symfony";
            //this.mainForm.callCommand(command,"",false);
            //MessageBox.Show("Please wait, currently installing symfony. Loading times may vary based on your internet connection! Be PATIENT! ", "Installing Symfony", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //command = "php symfony new " + this.projectName.Text;
            //this.mainForm.callCommandWithoutExit(command,false);
            //this.mainForm.documentRoot = this.fbd.SelectedPath + "\\" + this.projectName.Text;
            string command = "composer create-project symfony/framework-standard-edition " + this.projectName.Text;
            this.mainForm.callCommandWithoutExit(command, false,"Installing the Symfony Framework....." + Color.Green);
            this.mainForm.writeConsole("Symfony has been successfully installed!" + Color.Green);
            this.mainForm.documentRoot = this.fbd.SelectedPath + "\\" + this.projectName.Text;
            //this.mainForm.getSymfonyVersion();
            //save the profile
            string[] newProject = new string[2];
            newProject[0] = this.projectName.Text;
            newProject[1] = this.mainForm.documentRoot;
            this.formSettings.projects.Add(newProject);
            this.formSettings.refreshProjects();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void symfonyInstall_Click(object sender, EventArgs e)
        {
            this.installSymfony();
            
        }

        private void createProject_Click(object sender, EventArgs e)
        {
            this.profile.setActive(true);
            //set the mainform selected path variable
            this.mainForm.setSettingsActiveProfile(this.profile.getName());
            this.mainForm.setSettingsDocumentRoot(this.profile.getDocumentRoot());
            this.mainForm.setSettingsProfile(this.profile.getName(), this.profile);
            this.mainForm.setSettingsProfileCount(this.profile.getProfileNumber());
            this.mainForm.setSettingsSymfonyVersion(this.profile.getSymfonyVersion());

            this.mainForm.setDocumentRoot(this.profile.getDocumentRoot());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
