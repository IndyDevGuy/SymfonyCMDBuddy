using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymfonyCMDBuddy
{
    public partial class Form1 : Form
    {
        //profiles list
        Dictionary<int, Profile> profileArray = new Dictionary<int, Profile>();

        //refs to all the forms of this application
        public settingsForm settingsForm;
        public EntitySettings entitySettingsForm;
        public CrudSettings crudSettingsFrom;

        //root of users symfony project
        public string documentRoot;

        //Current Symfony Version
        public string symfonyVersion;

        //location of symfony console
        public string consoleLocation;

        public StringBuilder consoleOutput;

        //cmd functions for symfony/doctrine
        //cache
        public string cacheProdCMD;
        public string cacheDevCMD;
        public string cacheResultCMD;
        public string cacheQueryCMD;
        public string cacheCollectionRegionCMD;
        public string cacheQueryRegionCMD;
        public string cacheEntityRegionCMD;
        public string cacheMetadataCMD;
        //entity
        public string entityCreateCMD;
        public string entityCrudCMD;
        public string entityFormCMD;
        //assets
        public string assetsReloadCMD;
        //mapping
        public string mappingInfoCMD;
        public string mappingImportCMD;
        public string mappingConvertCMD;
        //database
        public string databaseDQLCMD;
        public string databaseSQLCMD;
        public string databaseCreateCMD;
        public string databaseDropCMD;
        //schema
        public string schemaUpdateCMD;
        public string schemaCreateCMD;
        public string schemaDropCMD;
        public string schemaValidateCMD;
        //generate
        public string generateCommandCMD;
        public string generateBundleCMD;
        public string generateControllerCMD;
        //debug
        public string debugConfigCMD;
        public string debugRouterCMD;
        public string debugTwigCMD;
        public string debugContainerCMD;
        public string debugEventDispatcherCMD;
        public string debugSwiftmailerCMD;
        //router
        public string routerMatchCMD;
        //security
        public string securityCheckCMD;
        public string securityEncodePasswordCMD;
        //swiftmailer
        public string swiftmailerEmailCMD;
        public string swiftmailerSpoolCMD;

        //used for creating a entity and crud controllers for entity
        public string entityName;

        //booleans
        public Boolean rootSet;


        //error strings
        public string rootSetError;
        public string rootSetErrorTitle;
        public Form1()
        {
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.indydevguy.com/";
            this.linkLabel1.Links.Add(link);
            //init booleans
            this.rootSet = false;
            //init all forms
            this.settingsForm = new settingsForm(this);
            this.entitySettingsForm = new EntitySettings(this);
            this.crudSettingsFrom = new CrudSettings(this);

            //init all console commands
            this.consoleLocation = "php bin/console";
            //cache
            this.cacheDevCMD = this.consoleLocation + " cache:clear --env=dev";
            this.cacheProdCMD = this.consoleLocation + " cache:clear --env=prod";
            this.cacheResultCMD = this.consoleLocation + " doctrine:cache:clear-result";
            this.cacheQueryCMD = this.consoleLocation + " doctrine:cache:clear-query";
            this.cacheCollectionRegionCMD = this.consoleLocation + " doctrine:cache:clear-collection-region";
            this.cacheQueryRegionCMD = this.consoleLocation + " doctrine:cache:clear-query-region";
            this.cacheEntityRegionCMD = this.consoleLocation + " doctrine:cache:clear-entity-region";
            this.cacheMetadataCMD = this.consoleLocation + " doctrine:cache:clear-metadata";
            //entity
            this.entityCreateCMD = this.consoleLocation + " doctrine:generate:entity";
            this.entityCrudCMD = this.consoleLocation + " generate:doctrine:crud";
            this.entityFormCMD = this.consoleLocation + " doctrine:generate:form";
            //assets
            this.assetsReloadCMD = this.consoleLocation + " assets:install --symlink";
            //mapping
            this.mappingInfoCMD = this.consoleLocation + " doctrine:mapping:info";
            this.mappingImportCMD = this.consoleLocation + " doctrine:mapping:import";
            this.mappingConvertCMD = this.consoleLocation + " doctrine:mapping:convert";
            //database
            this.databaseCreateCMD = this.consoleLocation + " doctrine:database:create";
            this.databaseDQLCMD = this.consoleLocation + " doctrine:query:dql";
            this.databaseSQLCMD = this.consoleLocation + " doctrine:query:sql";
            this.databaseDropCMD = this.consoleLocation + " doctrine:database:drop";
            //schema
            this.schemaUpdateCMD = this.consoleLocation + " doctrine:schema:update --force";
            this.schemaDropCMD = this.consoleLocation + " doctrine:schema:drop";
            this.schemaCreateCMD = this.consoleLocation + " doctrine:schema:create";
            this.schemaValidateCMD = this.consoleLocation + " doctrine:schema:validate";
            //generate
            this.generateBundleCMD = this.consoleLocation + " generate:bundle";
            this.generateCommandCMD = this.consoleLocation + " generate:command";
            this.generateControllerCMD = this.consoleLocation + " generate:controller";
            //debug
            this.debugConfigCMD = this.consoleLocation + " debug:config";
            this.debugContainerCMD = this.consoleLocation + " debug:container";
            this.debugEventDispatcherCMD = this.consoleLocation + " debug:event-dispatcher";
            this.debugRouterCMD = this.consoleLocation + " debug:router";
            this.debugTwigCMD = this.consoleLocation + " debug:twig";
            this.debugSwiftmailerCMD = this.consoleLocation + " debug:swiftmailer";
            //router
            this.routerMatchCMD = this.consoleLocation + " router:match";
            //security
            this.securityCheckCMD = this.consoleLocation + " security:check";
            this.securityEncodePasswordCMD = this.consoleLocation + " security:encode-password";
            //swiftmailer
            this.swiftmailerEmailCMD = this.consoleLocation + " swiftmailer:email:send";
            this.swiftmailerSpoolCMD = this.consoleLocation + " swiftmailer:spool:send";

            //load savable settings
            MySettings settings = MySettings.Load();
            if(settings.activeProfile != null)
            {
                Profile activeProfile = this.getSettingsProfile(settings.activeProfile);
                settings.documentRoot = activeProfile.getDocumentRoot();
                settings.SymfonyVersion = activeProfile.getSymfonyVersion();
            }
            if(settings.documentRoot != null)
                this.setDocumentRoot(settings.documentRoot);
            //this.documentRoot = settings.documentRoot;
            if(settings.SymfonyVersion != null)
                this.symfonyVersion = settings.SymfonyVersion;
            //this.SymfonyVersionLabel.Text += settings.SymfonyVersion;
            //set labels

            //set error strings
            this.rootSetError = "The project root must first be set in the settings to be able to call any commands on your Symfony instance.";
            this.rootSetErrorTitle = "Project Root Not Set";
        }

        class MySettings : AppSettings<MySettings>
        {
            public string documentRoot = null;
            public string SymfonyVersion = null;
            public int profileCount = 0;
            public string activeProfile = null;
            public Dictionary<string, Profile> profileArray;
        }

        public string getSettingsDocumentRoot()
        {
            MySettings settings = MySettings.Load();
            return settings.documentRoot;
        }

        public void setSettingsDocumentRoot(string documentRoot)
        {
            MySettings settings = MySettings.Load();
            settings.documentRoot = documentRoot;
            settings.Save();
        }

        public string getSettingsSymfonyVersion()
        {
            MySettings settings = MySettings.Load();
            return settings.SymfonyVersion;
        }

        public void setSettingsSymfonyVersion(string symfonyVersion)
        {
            MySettings settings = MySettings.Load();
            settings.SymfonyVersion = symfonyVersion;
            settings.Save();
        }

        public int getSettingsProfileCount()
        {
            MySettings settings = MySettings.Load();
            return settings.profileCount;
        }

        public void setSettingsProfileCount(int profileCount)
        {
            MySettings settings = MySettings.Load();
            settings.profileCount = profileCount;
            settings.Save();
        }

        public string getSettingsActiveProfile()
        {
            MySettings settings = MySettings.Load();
            return settings.activeProfile;
        }

        public void setSettingsActiveProfile(string profileName)
        {
            MySettings settings = MySettings.Load();
            settings.activeProfile = profileName;
            settings.Save();
        }

        public Profile getSettingsProfile(string profile)
        {
            MySettings settings = MySettings.Load();
            return settings.profileArray[profile];
        }

        public void setSettingsProfile(string name, Profile profile)
        {
            MySettings settings = MySettings.Load();
            if (settings.profileArray == null)
                settings.profileArray = new Dictionary<string, Profile>();
            
            settings.profileArray[name] = profile;
            settings.Save();
        }

        public Dictionary<string, Profile> getSettingsProfiles()
        {
            MySettings settings = MySettings.Load();
            return settings.profileArray;
        }

        public void setSettingsProfiles(Dictionary<string, Profile> profiles)
        {
            MySettings settings = MySettings.Load();
            settings.profileArray = profiles;
            settings.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //prod cache button
            this.callCommandWithErrorBox(this.cacheProdCMD, "Clearing Production Cache!");
        }

        private void devcache_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.cacheDevCMD, "Clearing Development Cache!");
        }

        private void createentity_Click(object sender, EventArgs e)
        {
            if (this.rootSet)
            {
                entityForm form = new entityForm(this);
                form.Show();
            }
            else
            {
                MessageBox.Show("The project root must first be set in the settings to be able to call any commands on your Symfony instance.", "Project Root Not Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createcrud_Click(object sender, EventArgs e)
        {
            if (this.rootSet)
            {
                CrudControllerForm form = new CrudControllerForm(this);
                form.Show();
            }
            else
            {
                MessageBox.Show("The project root must first be set in the settings to be able to call any commands on your Symfony instance.", "Project Root Not Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reloadassets_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.assetsReloadCMD, "Reloading All Bundle Assets!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.settingsForm = new settingsForm(this);
            this.settingsForm.Show();

            if (this.settingsForm.DialogResult == DialogResult.OK)
            {
                this.settingsForm.Hide();
            }
        }

        //getter and setter methods
        public void setEntityName(string name)
        {
            this.entityName = name;
        }

        public void setDocumentRoot(string root)
        {
            MySettings settings = MySettings.Load();
            settings.documentRoot = root;
            settings.Save();
            this.documentRoot = root;
            this.projectPath.Text = root;
            this.getSymfonyVersion();
            this.rootSet = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox("php bin/console", "Viewing Commands");
        }

        public void getSymfonyVersion()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"" + this.documentRoot;
            p.StartInfo.Arguments = "/c "+this.consoleLocation + " -V --version";
            p.Start();
            var reader = p.StandardOutput;
            int seconds = 0;
            string texter = "";
            while (!reader.EndOfStream)
            {

                texter += Environment.NewLine + reader.ReadLine();
                seconds++;
            }
            p.WaitForExit();
            this.symfonyVersion = texter;
            this.SymfonyVersionLabel.Text += this.symfonyVersion;
            MySettings settings = MySettings.Load();
            settings.SymfonyVersion = this.symfonyVersion;
            settings.Save();
        }

        public string returnSymfonyVersion(string root)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"" + root;
            p.StartInfo.Arguments = "/c " + this.consoleLocation + " -V --version";
            p.Start();
            var reader = p.StandardOutput;
            int seconds = 0;
            string texter = "";
            while (!reader.EndOfStream)
            {

                texter += Environment.NewLine + reader.ReadLine();
                seconds++;
            }
            p.WaitForExit();
            return texter;
        }

        public void callCommandWithoutExit(string command, Boolean clearConsole, string consoleMessage)
        {
            if (clearConsole)
                this.clearConsole();
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"" + this.documentRoot;
            p.StartInfo.Arguments = "/c " + command;
            p.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            p.ErrorDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            p.Start();
            p.BeginOutputReadLine();

            
            while (!p.HasExited)
            {
                p.WaitForExit();
            }
        }

        public void callCommand(string command, string consoleMessage, Boolean clearConsole = true)
        {
            if(clearConsole)
                this.clearConsole();
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"" + this.documentRoot;
            p.StartInfo.Arguments = "/c " + command;
            p.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            p.ErrorDataReceived += new DataReceivedEventHandler(SortOutputHandler);

            p.Start();
            p.BeginOutputReadLine();
            p.WaitForExit();
            
            
        }

        private void SortOutputHandler(object sendingProcess,DataReceivedEventArgs outLine)
        {
            if (richTextBox1.InvokeRequired) {
                richTextBox1.BeginInvoke(new DataReceivedEventHandler(SortOutputHandler), new[] { sendingProcess, outLine });
            }
            else
            {
                richTextBox1.AppendText(outLine.Data + Environment.NewLine ?? string.Empty);
                // set the current caret position to the end
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                // scroll it automatically
                richTextBox1.ScrollToCaret();
            }
        }

        public void setConsoleColors(string consoleLine)
        {
            //see if we can find symfony in the string

        }

        private void cacheResult_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.cacheResultCMD, "");
        }

        private void cacheQuery_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.cacheQueryCMD, "");
        }

        private void cacheCollectionRegion_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.cacheCollectionRegionCMD, "");
        }

        private void cacheQueryRegion_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.cacheQueryRegionCMD, "");
        }

        private void cacheEntityRegion_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.cacheEntityRegionCMD, "");
        }

        private void cacheMetadata_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.cacheMetadataCMD, "");
        }

        private void entityForm_Click(object sender, EventArgs e)
        {

            if (this.rootSet)
            {
                createEntityForm form = new createEntityForm(this);
                form.Show();
            }
            else
            {
                MessageBox.Show("The project root must first be set in the settings to be able to call any commands on your Symfony instance.", "Project Root Not Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mappingInfo_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.mappingInfoCMD, "");
        }

        private void mappingImport_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.mappingImportCMD, "");
        }

        private void mappingConvert_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.mappingConvertCMD, "");
        }

        private void databaseDQL_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.databaseDQLCMD, "");
        }

        private void databaseCreate_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.databaseCreateCMD, "");
        }

        private void databaseSQL_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.databaseSQLCMD, "");
        }

        private void databaseDrop_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.databaseDropCMD, "");
        }

        private void schemaDrop_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.schemaDropCMD, "");
        }

        private void schemaUpdate_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.schemaUpdateCMD, "");
        }

        private void schemaValidate_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.schemaValidateCMD, "");
        }

        private void generateCommand_Click(object sender, EventArgs e)
        {
            if (this.rootSet)
            {
                generateCommandForm form = new generateCommandForm(this);
                form.Show();
            }
            else
            {
                MessageBox.Show("The project root must first be set in the settings to be able to call any commands on your Symfony instance.", "Project Root Not Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (this.rootSet)
            {
                generateBundleForm form = new generateBundleForm(this);
                form.Show();
            }
            else
            {
                MessageBox.Show("The project root must first be set in the settings to be able to call any commands on your Symfony instance.", "Project Root Not Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateController_Click(object sender, EventArgs e)
        {
            if (this.rootSet)
            {
                
            }
            else
            {
                MessageBox.Show("The project root must first be set in the settings to be able to call any commands on your Symfony instance.", "Project Root Not Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void debugConfig_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.debugConfigCMD, "");
        }

        private void debugRouter_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.debugRouterCMD, "");
        }

        private void debugTwig_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.debugTwigCMD, "");
        }

        private void debugContainer_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.debugContainerCMD, "");
        }

        private void debugEventDispatcher_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.debugEventDispatcherCMD, "");
        }

        private void debugSwiftmailer_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.debugSwiftmailerCMD, "");
        }

        private void routerMatch_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.routerMatchCMD, "");
        }

        private void securityCheck_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.securityCheckCMD, "");
        }

        private void securityEncodePassword_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.securityEncodePasswordCMD, "");
        }

        private void swiftmailerEmail_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.swiftmailerEmailCMD, "");
        }

        private void swiftmailerSpool_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.swiftmailerSpoolCMD, "");
        }

        private void schemaCreate_Click(object sender, EventArgs e)
        {
            this.callCommandWithErrorBox(this.schemaCreateCMD, "");
        }

        public void clearConsole()
        {
            this.richTextBox1.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        public void writeConsole(string text)
        {
            this.richTextBox1.Text += Environment.NewLine + text;
        }

        public void displayErrorBox(string errorText, string errorTitle)
        {
            MessageBox.Show(errorText, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void callCommandWithErrorBox(string command, string message)
        {
            if (this.rootSet)
                this.callCommand(command, message);
            else
                this.displayErrorBox(this.rootSetError,this.rootSetErrorTitle);
        }
    }
}
