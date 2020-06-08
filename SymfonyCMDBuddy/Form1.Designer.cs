namespace SymfonyCMDBuddy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createentity = new System.Windows.Forms.Button();
            this.createcrud = new System.Windows.Forms.Button();
            this.devcache = new System.Windows.Forms.Button();
            this.procache = new System.Windows.Forms.Button();
            this.reloadassets = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entityForm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cacheQueryRegion = new System.Windows.Forms.Button();
            this.cacheResult = new System.Windows.Forms.Button();
            this.cacheCollectionRegion = new System.Windows.Forms.Button();
            this.cacheEntityRegion = new System.Windows.Forms.Button();
            this.cacheMetadata = new System.Windows.Forms.Button();
            this.cacheQuery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mappingConvert = new System.Windows.Forms.Button();
            this.mappingImport = new System.Windows.Forms.Button();
            this.mappingInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.databaseDQL = new System.Windows.Forms.Button();
            this.databaseSQL = new System.Windows.Forms.Button();
            this.databaseCreate = new System.Windows.Forms.Button();
            this.databaseDrop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.schemaDrop = new System.Windows.Forms.Button();
            this.schemaUpdate = new System.Windows.Forms.Button();
            this.schemaValidate = new System.Windows.Forms.Button();
            this.showAllCommands = new System.Windows.Forms.Button();
            this.SymfonyVersionLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.generateCommand = new System.Windows.Forms.Button();
            this.generateController = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.debugConfig = new System.Windows.Forms.Button();
            this.debugRouter = new System.Windows.Forms.Button();
            this.debugTwig = new System.Windows.Forms.Button();
            this.debugContainer = new System.Windows.Forms.Button();
            this.debugEventDispatcher = new System.Windows.Forms.Button();
            this.debugSwiftmailer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.routerMatch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.securityCheck = new System.Windows.Forms.Button();
            this.securityEncodePassword = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.swiftmailerEmail = new System.Windows.Forms.Button();
            this.swiftmailerSpool = new System.Windows.Forms.Button();
            this.schemaCreate = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.projectPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // createentity
            // 
            this.createentity.Location = new System.Drawing.Point(231, 78);
            this.createentity.Name = "createentity";
            this.createentity.Size = new System.Drawing.Size(63, 23);
            this.createentity.TabIndex = 0;
            this.createentity.Text = "Entity";
            this.createentity.UseVisualStyleBackColor = true;
            this.createentity.Click += new System.EventHandler(this.createentity_Click);
            // 
            // createcrud
            // 
            this.createcrud.Location = new System.Drawing.Point(156, 107);
            this.createcrud.Name = "createcrud";
            this.createcrud.Size = new System.Drawing.Size(138, 23);
            this.createcrud.TabIndex = 1;
            this.createcrud.Text = "CRUD Controller";
            this.createcrud.UseVisualStyleBackColor = true;
            this.createcrud.Click += new System.EventHandler(this.createcrud_Click);
            // 
            // devcache
            // 
            this.devcache.Location = new System.Drawing.Point(12, 107);
            this.devcache.Name = "devcache";
            this.devcache.Size = new System.Drawing.Size(138, 23);
            this.devcache.TabIndex = 2;
            this.devcache.Text = "Dev Cache";
            this.devcache.UseVisualStyleBackColor = true;
            this.devcache.Click += new System.EventHandler(this.devcache_Click);
            // 
            // procache
            // 
            this.procache.Location = new System.Drawing.Point(12, 78);
            this.procache.Name = "procache";
            this.procache.Size = new System.Drawing.Size(138, 23);
            this.procache.TabIndex = 3;
            this.procache.Text = "Production Cache";
            this.procache.UseVisualStyleBackColor = true;
            this.procache.Click += new System.EventHandler(this.button4_Click);
            // 
            // reloadassets
            // 
            this.reloadassets.Location = new System.Drawing.Point(301, 252);
            this.reloadassets.Name = "reloadassets";
            this.reloadassets.Size = new System.Drawing.Size(138, 23);
            this.reloadassets.TabIndex = 4;
            this.reloadassets.Text = "Reload Assets";
            this.reloadassets.UseVisualStyleBackColor = true;
            this.reloadassets.Click += new System.EventHandler(this.reloadassets_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(444, 310);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(137, 23);
            this.settings.TabIndex = 5;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(588, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(523, 387);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cache";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Assets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 0);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // entityForm
            // 
            this.entityForm.Location = new System.Drawing.Point(156, 78);
            this.entityForm.Name = "entityForm";
            this.entityForm.Size = new System.Drawing.Size(69, 23);
            this.entityForm.TabIndex = 12;
            this.entityForm.Text = "Form";
            this.entityForm.UseVisualStyleBackColor = true;
            this.entityForm.Click += new System.EventHandler(this.entityForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 103);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Symfony CMD Buddy";
            // 
            // cacheQueryRegion
            // 
            this.cacheQueryRegion.Location = new System.Drawing.Point(12, 194);
            this.cacheQueryRegion.Name = "cacheQueryRegion";
            this.cacheQueryRegion.Size = new System.Drawing.Size(138, 23);
            this.cacheQueryRegion.TabIndex = 15;
            this.cacheQueryRegion.Text = "Query Region";
            this.cacheQueryRegion.UseVisualStyleBackColor = true;
            this.cacheQueryRegion.Click += new System.EventHandler(this.cacheQueryRegion_Click);
            // 
            // cacheResult
            // 
            this.cacheResult.Location = new System.Drawing.Point(12, 136);
            this.cacheResult.Name = "cacheResult";
            this.cacheResult.Size = new System.Drawing.Size(69, 23);
            this.cacheResult.TabIndex = 16;
            this.cacheResult.Text = "Result";
            this.cacheResult.UseVisualStyleBackColor = true;
            this.cacheResult.Click += new System.EventHandler(this.cacheResult_Click);
            // 
            // cacheCollectionRegion
            // 
            this.cacheCollectionRegion.Location = new System.Drawing.Point(12, 165);
            this.cacheCollectionRegion.Name = "cacheCollectionRegion";
            this.cacheCollectionRegion.Size = new System.Drawing.Size(138, 23);
            this.cacheCollectionRegion.TabIndex = 17;
            this.cacheCollectionRegion.Text = "Collection Region";
            this.cacheCollectionRegion.UseVisualStyleBackColor = true;
            this.cacheCollectionRegion.Click += new System.EventHandler(this.cacheCollectionRegion_Click);
            // 
            // cacheEntityRegion
            // 
            this.cacheEntityRegion.Location = new System.Drawing.Point(12, 223);
            this.cacheEntityRegion.Name = "cacheEntityRegion";
            this.cacheEntityRegion.Size = new System.Drawing.Size(138, 23);
            this.cacheEntityRegion.TabIndex = 18;
            this.cacheEntityRegion.Text = "Entity Region";
            this.cacheEntityRegion.UseVisualStyleBackColor = true;
            this.cacheEntityRegion.Click += new System.EventHandler(this.cacheEntityRegion_Click);
            // 
            // cacheMetadata
            // 
            this.cacheMetadata.Location = new System.Drawing.Point(12, 252);
            this.cacheMetadata.Name = "cacheMetadata";
            this.cacheMetadata.Size = new System.Drawing.Size(138, 23);
            this.cacheMetadata.TabIndex = 19;
            this.cacheMetadata.Text = "Metadata";
            this.cacheMetadata.UseVisualStyleBackColor = true;
            this.cacheMetadata.Click += new System.EventHandler(this.cacheMetadata_Click);
            // 
            // cacheQuery
            // 
            this.cacheQuery.Location = new System.Drawing.Point(87, 136);
            this.cacheQuery.Name = "cacheQuery";
            this.cacheQuery.Size = new System.Drawing.Size(63, 23);
            this.cacheQuery.TabIndex = 20;
            this.cacheQuery.Text = "Query";
            this.cacheQuery.UseVisualStyleBackColor = true;
            this.cacheQuery.Click += new System.EventHandler(this.cacheQuery_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mapping";
            // 
            // mappingConvert
            // 
            this.mappingConvert.Location = new System.Drawing.Point(156, 194);
            this.mappingConvert.Name = "mappingConvert";
            this.mappingConvert.Size = new System.Drawing.Size(138, 23);
            this.mappingConvert.TabIndex = 23;
            this.mappingConvert.Text = "Convert";
            this.mappingConvert.UseVisualStyleBackColor = true;
            this.mappingConvert.Click += new System.EventHandler(this.mappingConvert_Click);
            // 
            // mappingImport
            // 
            this.mappingImport.Location = new System.Drawing.Point(225, 165);
            this.mappingImport.Name = "mappingImport";
            this.mappingImport.Size = new System.Drawing.Size(69, 23);
            this.mappingImport.TabIndex = 24;
            this.mappingImport.Text = "Import";
            this.mappingImport.UseVisualStyleBackColor = true;
            this.mappingImport.Click += new System.EventHandler(this.mappingImport_Click);
            // 
            // mappingInfo
            // 
            this.mappingInfo.Location = new System.Drawing.Point(156, 165);
            this.mappingInfo.Name = "mappingInfo";
            this.mappingInfo.Size = new System.Drawing.Size(63, 23);
            this.mappingInfo.TabIndex = 25;
            this.mappingInfo.Text = "Info";
            this.mappingInfo.UseVisualStyleBackColor = true;
            this.mappingInfo.Click += new System.EventHandler(this.mappingInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Database";
            // 
            // databaseDQL
            // 
            this.databaseDQL.Location = new System.Drawing.Point(302, 310);
            this.databaseDQL.Name = "databaseDQL";
            this.databaseDQL.Size = new System.Drawing.Size(69, 23);
            this.databaseDQL.TabIndex = 27;
            this.databaseDQL.Text = "DQL";
            this.databaseDQL.UseVisualStyleBackColor = true;
            this.databaseDQL.Click += new System.EventHandler(this.databaseDQL_Click);
            // 
            // databaseSQL
            // 
            this.databaseSQL.Location = new System.Drawing.Point(302, 339);
            this.databaseSQL.Name = "databaseSQL";
            this.databaseSQL.Size = new System.Drawing.Size(69, 23);
            this.databaseSQL.TabIndex = 28;
            this.databaseSQL.Text = "SQL";
            this.databaseSQL.UseVisualStyleBackColor = true;
            this.databaseSQL.Click += new System.EventHandler(this.databaseSQL_Click);
            // 
            // databaseCreate
            // 
            this.databaseCreate.Location = new System.Drawing.Point(377, 310);
            this.databaseCreate.Name = "databaseCreate";
            this.databaseCreate.Size = new System.Drawing.Size(63, 23);
            this.databaseCreate.TabIndex = 29;
            this.databaseCreate.Text = "Create";
            this.databaseCreate.UseVisualStyleBackColor = true;
            this.databaseCreate.Click += new System.EventHandler(this.databaseCreate_Click);
            // 
            // databaseDrop
            // 
            this.databaseDrop.Location = new System.Drawing.Point(377, 339);
            this.databaseDrop.Name = "databaseDrop";
            this.databaseDrop.Size = new System.Drawing.Size(63, 23);
            this.databaseDrop.TabIndex = 30;
            this.databaseDrop.Text = "Drop";
            this.databaseDrop.UseVisualStyleBackColor = true;
            this.databaseDrop.Click += new System.EventHandler(this.databaseDrop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Schema";
            // 
            // schemaDrop
            // 
            this.schemaDrop.Location = new System.Drawing.Point(300, 78);
            this.schemaDrop.Name = "schemaDrop";
            this.schemaDrop.Size = new System.Drawing.Size(69, 23);
            this.schemaDrop.TabIndex = 32;
            this.schemaDrop.Text = "Drop";
            this.schemaDrop.UseVisualStyleBackColor = true;
            this.schemaDrop.Click += new System.EventHandler(this.schemaDrop_Click);
            // 
            // schemaUpdate
            // 
            this.schemaUpdate.Location = new System.Drawing.Point(375, 78);
            this.schemaUpdate.Name = "schemaUpdate";
            this.schemaUpdate.Size = new System.Drawing.Size(63, 23);
            this.schemaUpdate.TabIndex = 33;
            this.schemaUpdate.Text = "Update";
            this.schemaUpdate.UseVisualStyleBackColor = true;
            this.schemaUpdate.Click += new System.EventHandler(this.schemaUpdate_Click);
            // 
            // schemaValidate
            // 
            this.schemaValidate.Location = new System.Drawing.Point(300, 107);
            this.schemaValidate.Name = "schemaValidate";
            this.schemaValidate.Size = new System.Drawing.Size(69, 23);
            this.schemaValidate.TabIndex = 34;
            this.schemaValidate.Text = "Validate";
            this.schemaValidate.UseVisualStyleBackColor = true;
            this.schemaValidate.Click += new System.EventHandler(this.schemaValidate_Click);
            // 
            // showAllCommands
            // 
            this.showAllCommands.Location = new System.Drawing.Point(445, 339);
            this.showAllCommands.Name = "showAllCommands";
            this.showAllCommands.Size = new System.Drawing.Size(137, 23);
            this.showAllCommands.TabIndex = 35;
            this.showAllCommands.Text = "Show all commands";
            this.showAllCommands.UseVisualStyleBackColor = true;
            this.showAllCommands.Click += new System.EventHandler(this.button19_Click);
            // 
            // SymfonyVersionLabel
            // 
            this.SymfonyVersionLabel.AutoSize = true;
            this.SymfonyVersionLabel.Location = new System.Drawing.Point(153, 369);
            this.SymfonyVersionLabel.Name = "SymfonyVersionLabel";
            this.SymfonyVersionLabel.Size = new System.Drawing.Size(88, 13);
            this.SymfonyVersionLabel.TabIndex = 36;
            this.SymfonyVersionLabel.Text = "Symfony Version:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(369, 165);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(69, 23);
            this.generateButton.TabIndex = 37;
            this.generateButton.Text = "Bundle";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Generate";
            // 
            // generateCommand
            // 
            this.generateCommand.Location = new System.Drawing.Point(300, 165);
            this.generateCommand.Name = "generateCommand";
            this.generateCommand.Size = new System.Drawing.Size(63, 23);
            this.generateCommand.TabIndex = 39;
            this.generateCommand.Text = "Command";
            this.generateCommand.UseVisualStyleBackColor = true;
            this.generateCommand.Click += new System.EventHandler(this.generateCommand_Click);
            // 
            // generateController
            // 
            this.generateController.Location = new System.Drawing.Point(300, 194);
            this.generateController.Name = "generateController";
            this.generateController.Size = new System.Drawing.Size(138, 23);
            this.generateController.TabIndex = 40;
            this.generateController.Text = "Controller";
            this.generateController.UseVisualStyleBackColor = true;
            this.generateController.Click += new System.EventHandler(this.generateController_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.Location = new System.Drawing.Point(197, 223);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(57, 20);
            this.debugLabel.TabIndex = 41;
            this.debugLabel.Text = "Debug";
            // 
            // debugConfig
            // 
            this.debugConfig.Location = new System.Drawing.Point(156, 252);
            this.debugConfig.Name = "debugConfig";
            this.debugConfig.Size = new System.Drawing.Size(63, 23);
            this.debugConfig.TabIndex = 42;
            this.debugConfig.Text = "Config";
            this.debugConfig.UseVisualStyleBackColor = true;
            this.debugConfig.Click += new System.EventHandler(this.debugConfig_Click);
            // 
            // debugRouter
            // 
            this.debugRouter.Location = new System.Drawing.Point(225, 252);
            this.debugRouter.Name = "debugRouter";
            this.debugRouter.Size = new System.Drawing.Size(69, 23);
            this.debugRouter.TabIndex = 43;
            this.debugRouter.Text = "Router";
            this.debugRouter.UseVisualStyleBackColor = true;
            this.debugRouter.Click += new System.EventHandler(this.debugRouter_Click);
            // 
            // debugTwig
            // 
            this.debugTwig.Location = new System.Drawing.Point(157, 281);
            this.debugTwig.Name = "debugTwig";
            this.debugTwig.Size = new System.Drawing.Size(62, 23);
            this.debugTwig.TabIndex = 44;
            this.debugTwig.Text = "Twig";
            this.debugTwig.UseVisualStyleBackColor = true;
            this.debugTwig.Click += new System.EventHandler(this.debugTwig_Click);
            // 
            // debugContainer
            // 
            this.debugContainer.Location = new System.Drawing.Point(225, 281);
            this.debugContainer.Name = "debugContainer";
            this.debugContainer.Size = new System.Drawing.Size(70, 23);
            this.debugContainer.TabIndex = 45;
            this.debugContainer.Text = "Container";
            this.debugContainer.UseVisualStyleBackColor = true;
            this.debugContainer.Click += new System.EventHandler(this.debugContainer_Click);
            // 
            // debugEventDispatcher
            // 
            this.debugEventDispatcher.Location = new System.Drawing.Point(157, 310);
            this.debugEventDispatcher.Name = "debugEventDispatcher";
            this.debugEventDispatcher.Size = new System.Drawing.Size(138, 23);
            this.debugEventDispatcher.TabIndex = 46;
            this.debugEventDispatcher.Text = "Event Dispatcher";
            this.debugEventDispatcher.UseVisualStyleBackColor = true;
            this.debugEventDispatcher.Click += new System.EventHandler(this.debugEventDispatcher_Click);
            // 
            // debugSwiftmailer
            // 
            this.debugSwiftmailer.Location = new System.Drawing.Point(157, 339);
            this.debugSwiftmailer.Name = "debugSwiftmailer";
            this.debugSwiftmailer.Size = new System.Drawing.Size(138, 23);
            this.debugSwiftmailer.TabIndex = 47;
            this.debugSwiftmailer.Text = "Swiftmailer";
            this.debugSwiftmailer.UseVisualStyleBackColor = true;
            this.debugSwiftmailer.Click += new System.EventHandler(this.debugSwiftmailer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(480, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Router";
            // 
            // routerMatch
            // 
            this.routerMatch.Location = new System.Drawing.Point(445, 252);
            this.routerMatch.Name = "routerMatch";
            this.routerMatch.Size = new System.Drawing.Size(137, 23);
            this.routerMatch.TabIndex = 49;
            this.routerMatch.Text = "Match";
            this.routerMatch.UseVisualStyleBackColor = true;
            this.routerMatch.Click += new System.EventHandler(this.routerMatch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Security";
            // 
            // securityCheck
            // 
            this.securityCheck.Location = new System.Drawing.Point(444, 78);
            this.securityCheck.Name = "securityCheck";
            this.securityCheck.Size = new System.Drawing.Size(138, 23);
            this.securityCheck.TabIndex = 51;
            this.securityCheck.Text = "Check";
            this.securityCheck.UseVisualStyleBackColor = true;
            this.securityCheck.Click += new System.EventHandler(this.securityCheck_Click);
            // 
            // securityEncodePassword
            // 
            this.securityEncodePassword.Location = new System.Drawing.Point(445, 107);
            this.securityEncodePassword.Name = "securityEncodePassword";
            this.securityEncodePassword.Size = new System.Drawing.Size(137, 23);
            this.securityEncodePassword.TabIndex = 52;
            this.securityEncodePassword.Text = "Encode Password";
            this.securityEncodePassword.UseVisualStyleBackColor = true;
            this.securityEncodePassword.Click += new System.EventHandler(this.securityEncodePassword_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(482, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "SwiftMailer";
            // 
            // swiftmailerEmail
            // 
            this.swiftmailerEmail.Location = new System.Drawing.Point(444, 165);
            this.swiftmailerEmail.Name = "swiftmailerEmail";
            this.swiftmailerEmail.Size = new System.Drawing.Size(137, 23);
            this.swiftmailerEmail.TabIndex = 54;
            this.swiftmailerEmail.Text = "Send Email";
            this.swiftmailerEmail.UseVisualStyleBackColor = true;
            this.swiftmailerEmail.Click += new System.EventHandler(this.swiftmailerEmail_Click);
            // 
            // swiftmailerSpool
            // 
            this.swiftmailerSpool.Location = new System.Drawing.Point(444, 194);
            this.swiftmailerSpool.Name = "swiftmailerSpool";
            this.swiftmailerSpool.Size = new System.Drawing.Size(137, 23);
            this.swiftmailerSpool.TabIndex = 55;
            this.swiftmailerSpool.Text = "Send Spool";
            this.swiftmailerSpool.UseVisualStyleBackColor = true;
            this.swiftmailerSpool.Click += new System.EventHandler(this.swiftmailerSpool_Click);
            // 
            // schemaCreate
            // 
            this.schemaCreate.Location = new System.Drawing.Point(376, 107);
            this.schemaCreate.Name = "schemaCreate";
            this.schemaCreate.Size = new System.Drawing.Size(62, 23);
            this.schemaCreate.TabIndex = 56;
            this.schemaCreate.Text = "Create";
            this.schemaCreate.UseVisualStyleBackColor = true;
            this.schemaCreate.Click += new System.EventHandler(this.schemaCreate_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(502, 382);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 13);
            this.linkLabel1.TabIndex = 57;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "IndyDevGuy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(442, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Created By:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(308, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Project Path:";
            // 
            // projectPath
            // 
            this.projectPath.AutoSize = true;
            this.projectPath.Location = new System.Drawing.Point(374, 15);
            this.projectPath.Name = "projectPath";
            this.projectPath.Size = new System.Drawing.Size(43, 13);
            this.projectPath.TabIndex = 60;
            this.projectPath.Text = "Not Set";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 411);
            this.Controls.Add(this.projectPath);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.schemaCreate);
            this.Controls.Add(this.swiftmailerSpool);
            this.Controls.Add(this.swiftmailerEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.securityEncodePassword);
            this.Controls.Add(this.securityCheck);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.routerMatch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.debugSwiftmailer);
            this.Controls.Add(this.debugEventDispatcher);
            this.Controls.Add(this.debugContainer);
            this.Controls.Add(this.debugTwig);
            this.Controls.Add(this.debugRouter);
            this.Controls.Add(this.debugConfig);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.generateController);
            this.Controls.Add(this.generateCommand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.SymfonyVersionLabel);
            this.Controls.Add(this.showAllCommands);
            this.Controls.Add(this.schemaValidate);
            this.Controls.Add(this.schemaUpdate);
            this.Controls.Add(this.schemaDrop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.databaseDrop);
            this.Controls.Add(this.databaseCreate);
            this.Controls.Add(this.databaseSQL);
            this.Controls.Add(this.databaseDQL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mappingInfo);
            this.Controls.Add(this.mappingImport);
            this.Controls.Add(this.mappingConvert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cacheQuery);
            this.Controls.Add(this.cacheMetadata);
            this.Controls.Add(this.cacheEntityRegion);
            this.Controls.Add(this.cacheCollectionRegion);
            this.Controls.Add(this.cacheResult);
            this.Controls.Add(this.cacheQueryRegion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.entityForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.reloadassets);
            this.Controls.Add(this.procache);
            this.Controls.Add(this.devcache);
            this.Controls.Add(this.createcrud);
            this.Controls.Add(this.createentity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1139, 450);
            this.MinimumSize = new System.Drawing.Size(1139, 450);
            this.Name = "Form1";
            this.Text = "Symfony CMD Buddy V1A";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createentity;
        private System.Windows.Forms.Button createcrud;
        private System.Windows.Forms.Button devcache;
        private System.Windows.Forms.Button procache;
        private System.Windows.Forms.Button reloadassets;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button entityForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cacheQueryRegion;
        private System.Windows.Forms.Button cacheResult;
        private System.Windows.Forms.Button cacheCollectionRegion;
        private System.Windows.Forms.Button cacheEntityRegion;
        private System.Windows.Forms.Button cacheMetadata;
        private System.Windows.Forms.Button cacheQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mappingConvert;
        private System.Windows.Forms.Button mappingImport;
        private System.Windows.Forms.Button mappingInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button databaseDQL;
        private System.Windows.Forms.Button databaseSQL;
        private System.Windows.Forms.Button databaseCreate;
        private System.Windows.Forms.Button databaseDrop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button schemaDrop;
        private System.Windows.Forms.Button schemaUpdate;
        private System.Windows.Forms.Button schemaValidate;
        private System.Windows.Forms.Button showAllCommands;
        private System.Windows.Forms.Label SymfonyVersionLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button generateCommand;
        private System.Windows.Forms.Button generateController;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Button debugConfig;
        private System.Windows.Forms.Button debugRouter;
        private System.Windows.Forms.Button debugTwig;
        private System.Windows.Forms.Button debugContainer;
        private System.Windows.Forms.Button debugEventDispatcher;
        private System.Windows.Forms.Button debugSwiftmailer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button routerMatch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button securityCheck;
        private System.Windows.Forms.Button securityEncodePassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button swiftmailerEmail;
        private System.Windows.Forms.Button swiftmailerSpool;
        private System.Windows.Forms.Button schemaCreate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label projectPath;
    }
}

