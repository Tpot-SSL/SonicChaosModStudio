namespace SonicChaosModStudio {
    partial class ModManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModManager));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Game", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Images", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Meshes", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Music", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Objects", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Shaders", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("SoundFX", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Sprites", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Stages", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Strings", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Videos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Other", System.Windows.Forms.HorizontalAlignment.Left);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.installUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manLargeRadio = new System.Windows.Forms.RadioButton();
            this.manSmallRadio = new System.Windows.Forms.RadioButton();
            this.manListRadio = new System.Windows.Forms.RadioButton();
            this.manDetailsRadio = new System.Windows.Forms.RadioButton();
            this.downloadButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.applyAndRundButton = new System.Windows.Forms.Button();
            this.orderDownButton = new System.Windows.Forms.Button();
            this.orderUpButton = new System.Windows.Forms.Button();
            this.openModFolder = new System.Windows.Forms.Button();
            this.checkAllButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.runGameButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.openDataFolder = new System.Windows.Forms.Button();
            this.openGameFolder = new System.Windows.Forms.Button();
            this.resetModDefaults = new System.Windows.Forms.Button();
            this.applyModsButton = new System.Windows.Forms.Button();
            this.openModFolderButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addFromFolderButton = new System.Windows.Forms.Button();
            this.addModButton = new System.Windows.Forms.Button();
            this.modView = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeImages = new System.Windows.Forms.ImageList(this.components);
            this.smallImages = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.creatorSearchReset = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.allRadio = new System.Windows.Forms.RadioButton();
            this.gameBox = new System.Windows.Forms.RadioButton();
            this.imagesBox = new System.Windows.Forms.RadioButton();
            this.meshesBox = new System.Windows.Forms.RadioButton();
            this.musicBox = new System.Windows.Forms.RadioButton();
            this.objectsBox = new System.Windows.Forms.RadioButton();
            this.videosBox = new System.Windows.Forms.RadioButton();
            this.shadersBox = new System.Windows.Forms.RadioButton();
            this.stringsBox = new System.Windows.Forms.RadioButton();
            this.soundFXBox = new System.Windows.Forms.RadioButton();
            this.stagesBox = new System.Windows.Forms.RadioButton();
            this.spritesBox = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createListRadio = new System.Windows.Forms.RadioButton();
            this.creatorDetailsRadio = new System.Windows.Forms.RadioButton();
            this.optimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.modCreatorVersionBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.clearFilesButton = new System.Windows.Forms.Button();
            this.modCreatorAuthorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modCreatorIcon = new System.Windows.Forms.PictureBox();
            this.modCreatorResetButton = new System.Windows.Forms.Button();
            this.modCreatorFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modCreatorPathButton = new System.Windows.Forms.Button();
            this.modCreatorPathBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createModButton = new System.Windows.Forms.Button();
            this.modCreatorDescBox = new System.Windows.Forms.TextBox();
            this.modCreatorNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modCreatorPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.setCustomDataDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.addModFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.addModDialog = new System.Windows.Forms.OpenFileDialog();
            this.spriteMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.iconOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modCreatorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.updateDropDown,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButton});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton2.Text = "File";
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 22);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // updateDropDown
            // 
            this.updateDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installUpdateToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.updateSettingsToolStripMenuItem});
            this.updateDropDown.Enabled = false;
            this.updateDropDown.Image = ((System.Drawing.Image)(resources.GetObject("updateDropDown.Image")));
            this.updateDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateDropDown.Name = "updateDropDown";
            this.updateDropDown.Size = new System.Drawing.Size(63, 22);
            this.updateDropDown.Text = "Updates";
            // 
            // installUpdateToolStripMenuItem
            // 
            this.installUpdateToolStripMenuItem.Name = "installUpdateToolStripMenuItem";
            this.installUpdateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.installUpdateToolStripMenuItem.Text = "Install Update";
            this.installUpdateToolStripMenuItem.Visible = false;
            this.installUpdateToolStripMenuItem.Click += new System.EventHandler(this.installUpdateToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // updateSettingsToolStripMenuItem
            // 
            this.updateSettingsToolStripMenuItem.Name = "updateSettingsToolStripMenuItem";
            this.updateSettingsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updateSettingsToolStripMenuItem.Text = "Update Settings";
            this.updateSettingsToolStripMenuItem.Click += new System.EventHandler(this.updateSettingsToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton1.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Enabled = false;
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(12, 28);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(968, 634);
            this.mainTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.downloadButton);
            this.tabPage1.Controls.Add(this.refreshButton);
            this.tabPage1.Controls.Add(this.applyAndRundButton);
            this.tabPage1.Controls.Add(this.orderDownButton);
            this.tabPage1.Controls.Add(this.orderUpButton);
            this.tabPage1.Controls.Add(this.openModFolder);
            this.tabPage1.Controls.Add(this.checkAllButton);
            this.tabPage1.Controls.Add(this.editButton);
            this.tabPage1.Controls.Add(this.runGameButton);
            this.tabPage1.Controls.Add(this.infoButton);
            this.tabPage1.Controls.Add(this.openDataFolder);
            this.tabPage1.Controls.Add(this.openGameFolder);
            this.tabPage1.Controls.Add(this.resetModDefaults);
            this.tabPage1.Controls.Add(this.applyModsButton);
            this.tabPage1.Controls.Add(this.openModFolderButton);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.addFromFolderButton);
            this.tabPage1.Controls.Add(this.addModButton);
            this.tabPage1.Controls.Add(this.modView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manager";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.manLargeRadio);
            this.groupBox1.Controls.Add(this.manSmallRadio);
            this.groupBox1.Controls.Add(this.manListRadio);
            this.groupBox1.Controls.Add(this.manDetailsRadio);
            this.groupBox1.Location = new System.Drawing.Point(848, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 113);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // manLargeRadio
            // 
            this.manLargeRadio.AutoSize = true;
            this.manLargeRadio.Location = new System.Drawing.Point(6, 88);
            this.manLargeRadio.Name = "manLargeRadio";
            this.manLargeRadio.Size = new System.Drawing.Size(81, 17);
            this.manLargeRadio.TabIndex = 3;
            this.manLargeRadio.Text = "Large Icons";
            this.manLargeRadio.UseVisualStyleBackColor = true;
            this.manLargeRadio.CheckedChanged += new System.EventHandler(this.manLargeRadio_CheckedChanged);
            // 
            // manSmallRadio
            // 
            this.manSmallRadio.AutoSize = true;
            this.manSmallRadio.Location = new System.Drawing.Point(6, 65);
            this.manSmallRadio.Name = "manSmallRadio";
            this.manSmallRadio.Size = new System.Drawing.Size(79, 17);
            this.manSmallRadio.TabIndex = 2;
            this.manSmallRadio.Text = "Small Icons";
            this.manSmallRadio.UseVisualStyleBackColor = true;
            this.manSmallRadio.CheckedChanged += new System.EventHandler(this.manSmallRadio_CheckedChanged);
            // 
            // manListRadio
            // 
            this.manListRadio.AutoSize = true;
            this.manListRadio.Location = new System.Drawing.Point(6, 42);
            this.manListRadio.Name = "manListRadio";
            this.manListRadio.Size = new System.Drawing.Size(41, 17);
            this.manListRadio.TabIndex = 1;
            this.manListRadio.Text = "List";
            this.manListRadio.UseVisualStyleBackColor = true;
            this.manListRadio.CheckedChanged += new System.EventHandler(this.manListRadio_CheckedChanged);
            // 
            // manDetailsRadio
            // 
            this.manDetailsRadio.AutoSize = true;
            this.manDetailsRadio.Checked = true;
            this.manDetailsRadio.Location = new System.Drawing.Point(6, 19);
            this.manDetailsRadio.Name = "manDetailsRadio";
            this.manDetailsRadio.Size = new System.Drawing.Size(57, 17);
            this.manDetailsRadio.TabIndex = 0;
            this.manDetailsRadio.TabStop = true;
            this.manDetailsRadio.Text = "Details";
            this.manDetailsRadio.UseVisualStyleBackColor = true;
            this.manDetailsRadio.CheckedChanged += new System.EventHandler(this.manDetailsRadio_CheckedChanged);
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(848, 162);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(106, 23);
            this.downloadButton.TabIndex = 21;
            this.downloadButton.Text = "Download Mods";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(848, 133);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(106, 23);
            this.refreshButton.TabIndex = 20;
            this.refreshButton.Text = "Refresh Mod List";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // applyAndRundButton
            // 
            this.applyAndRundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyAndRundButton.Location = new System.Drawing.Point(848, 75);
            this.applyAndRundButton.Name = "applyAndRundButton";
            this.applyAndRundButton.Size = new System.Drawing.Size(106, 23);
            this.applyAndRundButton.TabIndex = 19;
            this.applyAndRundButton.Text = "Apply and Run";
            this.applyAndRundButton.UseVisualStyleBackColor = true;
            this.applyAndRundButton.Click += new System.EventHandler(this.applyAndRundButton_Click);
            // 
            // orderDownButton
            // 
            this.orderDownButton.Location = new System.Drawing.Point(244, 17);
            this.orderDownButton.Name = "orderDownButton";
            this.orderDownButton.Size = new System.Drawing.Size(75, 23);
            this.orderDownButton.TabIndex = 18;
            this.orderDownButton.Text = "Order Down";
            this.orderDownButton.UseVisualStyleBackColor = true;
            this.orderDownButton.Click += new System.EventHandler(this.orderDownButton_Click);
            // 
            // orderUpButton
            // 
            this.orderUpButton.Location = new System.Drawing.Point(176, 17);
            this.orderUpButton.Name = "orderUpButton";
            this.orderUpButton.Size = new System.Drawing.Size(62, 23);
            this.orderUpButton.TabIndex = 17;
            this.orderUpButton.Text = "Order Up";
            this.orderUpButton.UseVisualStyleBackColor = true;
            this.orderUpButton.Click += new System.EventHandler(this.orderUpButton_Click);
            // 
            // openModFolder
            // 
            this.openModFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openModFolder.Location = new System.Drawing.Point(848, 492);
            this.openModFolder.Name = "openModFolder";
            this.openModFolder.Size = new System.Drawing.Size(106, 23);
            this.openModFolder.TabIndex = 16;
            this.openModFolder.Text = "Open Mod Folder";
            this.openModFolder.UseVisualStyleBackColor = true;
            this.openModFolder.Click += new System.EventHandler(this.openModFolder_Click);
            // 
            // checkAllButton
            // 
            this.checkAllButton.Location = new System.Drawing.Point(325, 17);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(63, 23);
            this.checkAllButton.TabIndex = 13;
            this.checkAllButton.Text = "Check All";
            this.checkAllButton.UseVisualStyleBackColor = true;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(752, 17);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(35, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // runGameButton
            // 
            this.runGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runGameButton.Location = new System.Drawing.Point(848, 579);
            this.runGameButton.Name = "runGameButton";
            this.runGameButton.Size = new System.Drawing.Size(106, 23);
            this.runGameButton.TabIndex = 11;
            this.runGameButton.Text = "Run Sonic Chaos";
            this.runGameButton.UseVisualStyleBackColor = true;
            this.runGameButton.Click += new System.EventHandler(this.runGameButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoButton.Location = new System.Drawing.Point(631, 17);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(36, 23);
            this.infoButton.TabIndex = 10;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // openDataFolder
            // 
            this.openDataFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openDataFolder.Location = new System.Drawing.Point(848, 521);
            this.openDataFolder.Name = "openDataFolder";
            this.openDataFolder.Size = new System.Drawing.Size(106, 23);
            this.openDataFolder.TabIndex = 9;
            this.openDataFolder.Text = "Open Data Folder";
            this.openDataFolder.UseVisualStyleBackColor = true;
            this.openDataFolder.Click += new System.EventHandler(this.openDataFolder_Click);
            // 
            // openGameFolder
            // 
            this.openGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openGameFolder.Location = new System.Drawing.Point(848, 550);
            this.openGameFolder.Name = "openGameFolder";
            this.openGameFolder.Size = new System.Drawing.Size(106, 23);
            this.openGameFolder.TabIndex = 8;
            this.openGameFolder.Text = "Open Chaos Folder";
            this.openGameFolder.UseVisualStyleBackColor = true;
            this.openGameFolder.Click += new System.EventHandler(this.openGameFolder_Click);
            // 
            // resetModDefaults
            // 
            this.resetModDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetModDefaults.Location = new System.Drawing.Point(848, 104);
            this.resetModDefaults.Name = "resetModDefaults";
            this.resetModDefaults.Size = new System.Drawing.Size(106, 23);
            this.resetModDefaults.TabIndex = 7;
            this.resetModDefaults.Text = "Restore";
            this.resetModDefaults.UseVisualStyleBackColor = true;
            this.resetModDefaults.Click += new System.EventHandler(this.resetModDefaults_Click);
            // 
            // applyModsButton
            // 
            this.applyModsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyModsButton.Location = new System.Drawing.Point(848, 46);
            this.applyModsButton.Name = "applyModsButton";
            this.applyModsButton.Size = new System.Drawing.Size(106, 23);
            this.applyModsButton.TabIndex = 6;
            this.applyModsButton.Text = "Apply";
            this.applyModsButton.UseVisualStyleBackColor = true;
            this.applyModsButton.Click += new System.EventHandler(this.applyModsButton_Click);
            // 
            // openModFolderButton
            // 
            this.openModFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openModFolderButton.Location = new System.Drawing.Point(673, 17);
            this.openModFolderButton.Name = "openModFolderButton";
            this.openModFolderButton.Size = new System.Drawing.Size(73, 23);
            this.openModFolderButton.TabIndex = 5;
            this.openModFolderButton.Text = "Open Folder";
            this.openModFolderButton.UseVisualStyleBackColor = true;
            this.openModFolderButton.Click += new System.EventHandler(this.openModFolderButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(793, 17);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(49, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addFromFolderButton
            // 
            this.addFromFolderButton.Enabled = false;
            this.addFromFolderButton.Location = new System.Drawing.Point(51, 17);
            this.addFromFolderButton.Name = "addFromFolderButton";
            this.addFromFolderButton.Size = new System.Drawing.Size(79, 23);
            this.addFromFolderButton.TabIndex = 3;
            this.addFromFolderButton.Text = "Add (Folder)";
            this.addFromFolderButton.UseVisualStyleBackColor = true;
            this.addFromFolderButton.Click += new System.EventHandler(this.addFromFolderButton_Click);
            // 
            // addModButton
            // 
            this.addModButton.Location = new System.Drawing.Point(6, 17);
            this.addModButton.Name = "addModButton";
            this.addModButton.Size = new System.Drawing.Size(39, 23);
            this.addModButton.TabIndex = 2;
            this.addModButton.Text = "Add";
            this.addModButton.UseVisualStyleBackColor = true;
            this.addModButton.Click += new System.EventHandler(this.addModButton_Click);
            // 
            // modView
            // 
            this.modView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modView.CheckBoxes = true;
            this.modView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.columnHeader3,
            this.cDesc,
            this.columnHeader4});
            this.modView.LargeImageList = this.largeImages;
            this.modView.Location = new System.Drawing.Point(6, 46);
            this.modView.Name = "modView";
            this.modView.Size = new System.Drawing.Size(836, 556);
            this.modView.SmallImageList = this.smallImages;
            this.modView.TabIndex = 0;
            this.modView.UseCompatibleStateImageBehavior = false;
            this.modView.View = System.Windows.Forms.View.Details;
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 114;
            // 
            // cDesc
            // 
            this.cDesc.Text = "Description";
            this.cDesc.Width = 430;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Version";
            this.columnHeader4.Width = 123;
            // 
            // largeImages
            // 
            this.largeImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.largeImages.ImageSize = new System.Drawing.Size(100, 100);
            this.largeImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallImages
            // 
            this.smallImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.smallImages.ImageSize = new System.Drawing.Size(16, 16);
            this.smallImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.creatorSearchReset);
            this.tabPage2.Controls.Add(this.searchButton);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.optimizeButton);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.filterBox);
            this.tabPage2.Controls.Add(this.deselectAllButton);
            this.tabPage2.Controls.Add(this.selectAllButton);
            this.tabPage2.Controls.Add(this.modCreatorVersionBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.clearFilesButton);
            this.tabPage2.Controls.Add(this.modCreatorAuthorBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.modCreatorIcon);
            this.tabPage2.Controls.Add(this.modCreatorResetButton);
            this.tabPage2.Controls.Add(this.modCreatorFiles);
            this.tabPage2.Controls.Add(this.modCreatorPathButton);
            this.tabPage2.Controls.Add(this.modCreatorPathBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.createModButton);
            this.tabPage2.Controls.Add(this.modCreatorDescBox);
            this.tabPage2.Controls.Add(this.modCreatorNameBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Creator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // creatorSearchReset
            // 
            this.creatorSearchReset.Location = new System.Drawing.Point(776, 98);
            this.creatorSearchReset.Name = "creatorSearchReset";
            this.creatorSearchReset.Size = new System.Drawing.Size(75, 22);
            this.creatorSearchReset.TabIndex = 38;
            this.creatorSearchReset.Text = "Reset";
            this.creatorSearchReset.UseVisualStyleBackColor = true;
            this.creatorSearchReset.Click += new System.EventHandler(this.creatorSearchReset_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(695, 98);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 22);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.allRadio);
            this.groupBox3.Controls.Add(this.gameBox);
            this.groupBox3.Controls.Add(this.imagesBox);
            this.groupBox3.Controls.Add(this.meshesBox);
            this.groupBox3.Controls.Add(this.musicBox);
            this.groupBox3.Controls.Add(this.objectsBox);
            this.groupBox3.Controls.Add(this.videosBox);
            this.groupBox3.Controls.Add(this.shadersBox);
            this.groupBox3.Controls.Add(this.stringsBox);
            this.groupBox3.Controls.Add(this.soundFXBox);
            this.groupBox3.Controls.Add(this.stagesBox);
            this.groupBox3.Controls.Add(this.spritesBox);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(865, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 348);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Types";
            this.groupBox3.Visible = false;
            // 
            // allRadio
            // 
            this.allRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allRadio.AutoSize = true;
            this.allRadio.Checked = true;
            this.allRadio.Location = new System.Drawing.Point(10, 20);
            this.allRadio.Name = "allRadio";
            this.allRadio.Size = new System.Drawing.Size(36, 17);
            this.allRadio.TabIndex = 30;
            this.allRadio.TabStop = true;
            this.allRadio.Text = "All";
            this.allRadio.UseVisualStyleBackColor = true;
            this.allRadio.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // gameBox
            // 
            this.gameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameBox.AutoSize = true;
            this.gameBox.Location = new System.Drawing.Point(10, 43);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(53, 17);
            this.gameBox.TabIndex = 19;
            this.gameBox.Text = "Game";
            this.gameBox.UseVisualStyleBackColor = true;
            this.gameBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // imagesBox
            // 
            this.imagesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesBox.AutoSize = true;
            this.imagesBox.Location = new System.Drawing.Point(10, 66);
            this.imagesBox.Name = "imagesBox";
            this.imagesBox.Size = new System.Drawing.Size(59, 17);
            this.imagesBox.TabIndex = 20;
            this.imagesBox.Text = "Images";
            this.imagesBox.UseVisualStyleBackColor = true;
            this.imagesBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // meshesBox
            // 
            this.meshesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meshesBox.AutoSize = true;
            this.meshesBox.Enabled = false;
            this.meshesBox.Location = new System.Drawing.Point(10, 89);
            this.meshesBox.Name = "meshesBox";
            this.meshesBox.Size = new System.Drawing.Size(62, 17);
            this.meshesBox.TabIndex = 21;
            this.meshesBox.Text = "Meshes";
            this.meshesBox.UseVisualStyleBackColor = true;
            this.meshesBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // musicBox
            // 
            this.musicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.musicBox.AutoSize = true;
            this.musicBox.Location = new System.Drawing.Point(10, 112);
            this.musicBox.Name = "musicBox";
            this.musicBox.Size = new System.Drawing.Size(53, 17);
            this.musicBox.TabIndex = 22;
            this.musicBox.Text = "Music";
            this.musicBox.UseVisualStyleBackColor = true;
            this.musicBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // objectsBox
            // 
            this.objectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsBox.AutoSize = true;
            this.objectsBox.Location = new System.Drawing.Point(10, 135);
            this.objectsBox.Name = "objectsBox";
            this.objectsBox.Size = new System.Drawing.Size(61, 17);
            this.objectsBox.TabIndex = 23;
            this.objectsBox.Text = "Objects";
            this.objectsBox.UseVisualStyleBackColor = true;
            this.objectsBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // videosBox
            // 
            this.videosBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videosBox.AutoSize = true;
            this.videosBox.Enabled = false;
            this.videosBox.Location = new System.Drawing.Point(10, 273);
            this.videosBox.Name = "videosBox";
            this.videosBox.Size = new System.Drawing.Size(52, 17);
            this.videosBox.TabIndex = 29;
            this.videosBox.Text = "Video";
            this.videosBox.UseVisualStyleBackColor = true;
            this.videosBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // shadersBox
            // 
            this.shadersBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shadersBox.AutoSize = true;
            this.shadersBox.Location = new System.Drawing.Point(10, 158);
            this.shadersBox.Name = "shadersBox";
            this.shadersBox.Size = new System.Drawing.Size(64, 17);
            this.shadersBox.TabIndex = 24;
            this.shadersBox.Text = "Shaders";
            this.shadersBox.UseVisualStyleBackColor = true;
            this.shadersBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // stringsBox
            // 
            this.stringsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stringsBox.AutoSize = true;
            this.stringsBox.Location = new System.Drawing.Point(10, 250);
            this.stringsBox.Name = "stringsBox";
            this.stringsBox.Size = new System.Drawing.Size(57, 17);
            this.stringsBox.TabIndex = 28;
            this.stringsBox.Text = "Strings";
            this.stringsBox.UseVisualStyleBackColor = true;
            this.stringsBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // soundFXBox
            // 
            this.soundFXBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soundFXBox.AutoSize = true;
            this.soundFXBox.Location = new System.Drawing.Point(10, 181);
            this.soundFXBox.Name = "soundFXBox";
            this.soundFXBox.Size = new System.Drawing.Size(69, 17);
            this.soundFXBox.TabIndex = 25;
            this.soundFXBox.Text = "SoundFX";
            this.soundFXBox.UseVisualStyleBackColor = true;
            this.soundFXBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // stagesBox
            // 
            this.stagesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stagesBox.AutoSize = true;
            this.stagesBox.Enabled = false;
            this.stagesBox.Location = new System.Drawing.Point(10, 227);
            this.stagesBox.Name = "stagesBox";
            this.stagesBox.Size = new System.Drawing.Size(58, 17);
            this.stagesBox.TabIndex = 27;
            this.stagesBox.Text = "Stages";
            this.stagesBox.UseVisualStyleBackColor = true;
            this.stagesBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // spritesBox
            // 
            this.spritesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spritesBox.AutoSize = true;
            this.spritesBox.Location = new System.Drawing.Point(10, 204);
            this.spritesBox.Name = "spritesBox";
            this.spritesBox.Size = new System.Drawing.Size(57, 17);
            this.spritesBox.TabIndex = 26;
            this.spritesBox.Text = "Sprites";
            this.spritesBox.UseVisualStyleBackColor = true;
            this.spritesBox.CheckedChanged += new System.EventHandler(this.gameBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.createListRadio);
            this.groupBox2.Controls.Add(this.creatorDetailsRadio);
            this.groupBox2.Location = new System.Drawing.Point(865, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 79);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // createListRadio
            // 
            this.createListRadio.AutoSize = true;
            this.createListRadio.Location = new System.Drawing.Point(6, 42);
            this.createListRadio.Name = "createListRadio";
            this.createListRadio.Size = new System.Drawing.Size(41, 17);
            this.createListRadio.TabIndex = 1;
            this.createListRadio.Text = "List";
            this.createListRadio.UseVisualStyleBackColor = true;
            this.createListRadio.CheckedChanged += new System.EventHandler(this.createListRadio_CheckedChanged);
            // 
            // creatorDetailsRadio
            // 
            this.creatorDetailsRadio.AutoSize = true;
            this.creatorDetailsRadio.Checked = true;
            this.creatorDetailsRadio.Location = new System.Drawing.Point(6, 19);
            this.creatorDetailsRadio.Name = "creatorDetailsRadio";
            this.creatorDetailsRadio.Size = new System.Drawing.Size(57, 17);
            this.creatorDetailsRadio.TabIndex = 0;
            this.creatorDetailsRadio.TabStop = true;
            this.creatorDetailsRadio.Text = "Details";
            this.creatorDetailsRadio.UseVisualStyleBackColor = true;
            this.creatorDetailsRadio.CheckedChanged += new System.EventHandler(this.creatorDetailsRadio_CheckedChanged);
            // 
            // optimizeButton
            // 
            this.optimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.optimizeButton.Enabled = false;
            this.optimizeButton.Location = new System.Drawing.Point(101, 564);
            this.optimizeButton.Name = "optimizeButton";
            this.optimizeButton.Size = new System.Drawing.Size(89, 23);
            this.optimizeButton.TabIndex = 33;
            this.optimizeButton.Text = "Optimize";
            this.optimizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Search";
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(72, 99);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(618, 20);
            this.filterBox.TabIndex = 30;
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deselectAllButton.Location = new System.Drawing.Point(605, 564);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(85, 23);
            this.deselectAllButton.TabIndex = 18;
            this.deselectAllButton.Text = "Uncheck All";
            this.deselectAllButton.UseVisualStyleBackColor = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllButton.Location = new System.Drawing.Point(531, 564);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(68, 23);
            this.selectAllButton.TabIndex = 17;
            this.selectAllButton.Text = "Check All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // modCreatorVersionBox
            // 
            this.modCreatorVersionBox.Location = new System.Drawing.Point(309, 17);
            this.modCreatorVersionBox.MaxLength = 64;
            this.modCreatorVersionBox.Name = "modCreatorVersionBox";
            this.modCreatorVersionBox.Size = new System.Drawing.Size(116, 20);
            this.modCreatorVersionBox.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Version";
            // 
            // clearFilesButton
            // 
            this.clearFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFilesButton.Location = new System.Drawing.Point(696, 564);
            this.clearFilesButton.Name = "clearFilesButton";
            this.clearFilesButton.Size = new System.Drawing.Size(74, 23);
            this.clearFilesButton.TabIndex = 14;
            this.clearFilesButton.Text = "Clear Files";
            this.clearFilesButton.UseVisualStyleBackColor = true;
            this.clearFilesButton.Click += new System.EventHandler(this.clearFilesButton_Click);
            // 
            // modCreatorAuthorBox
            // 
            this.modCreatorAuthorBox.Location = new System.Drawing.Point(674, 17);
            this.modCreatorAuthorBox.MaxLength = 128;
            this.modCreatorAuthorBox.Name = "modCreatorAuthorBox";
            this.modCreatorAuthorBox.Size = new System.Drawing.Size(176, 20);
            this.modCreatorAuthorBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Author";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Icon (Click to set)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modCreatorIcon
            // 
            this.modCreatorIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modCreatorIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modCreatorIcon.Location = new System.Drawing.Point(856, 6);
            this.modCreatorIcon.Name = "modCreatorIcon";
            this.modCreatorIcon.Size = new System.Drawing.Size(100, 100);
            this.modCreatorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.modCreatorIcon.TabIndex = 10;
            this.modCreatorIcon.TabStop = false;
            this.modCreatorIcon.Click += new System.EventHandler(this.modCreatorIcon_Click);
            // 
            // modCreatorResetButton
            // 
            this.modCreatorResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modCreatorResetButton.Location = new System.Drawing.Point(776, 564);
            this.modCreatorResetButton.Name = "modCreatorResetButton";
            this.modCreatorResetButton.Size = new System.Drawing.Size(74, 23);
            this.modCreatorResetButton.TabIndex = 9;
            this.modCreatorResetButton.Text = "Reset All";
            this.modCreatorResetButton.UseVisualStyleBackColor = true;
            this.modCreatorResetButton.Click += new System.EventHandler(this.modCreatorResetButton_Click);
            // 
            // modCreatorFiles
            // 
            this.modCreatorFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modCreatorFiles.CheckBoxes = true;
            this.modCreatorFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewGroup1.Header = "Game";
            listViewGroup1.Name = "Game";
            listViewGroup2.Header = "Images";
            listViewGroup2.Name = "Images";
            listViewGroup3.Header = "Meshes";
            listViewGroup3.Name = "Meshes";
            listViewGroup4.Header = "Music";
            listViewGroup4.Name = "Music";
            listViewGroup5.Header = "Objects";
            listViewGroup5.Name = "Objects";
            listViewGroup6.Header = "Shaders";
            listViewGroup6.Name = "Shaders";
            listViewGroup7.Header = "SoundFX";
            listViewGroup7.Name = "SoundFX";
            listViewGroup8.Header = "Sprites";
            listViewGroup8.Name = "Sprites";
            listViewGroup9.Header = "Stages";
            listViewGroup9.Name = "Stages";
            listViewGroup10.Header = "Strings";
            listViewGroup10.Name = "Strings";
            listViewGroup11.Header = "Videos";
            listViewGroup11.Name = "Videos";
            listViewGroup12.Header = "Other";
            listViewGroup12.Name = "Other";
            this.modCreatorFiles.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
            this.modCreatorFiles.Location = new System.Drawing.Point(3, 125);
            this.modCreatorFiles.Name = "modCreatorFiles";
            this.modCreatorFiles.Size = new System.Drawing.Size(847, 433);
            this.modCreatorFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.modCreatorFiles.TabIndex = 8;
            this.modCreatorFiles.UseCompatibleStateImageBehavior = false;
            this.modCreatorFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Relative Path";
            this.columnHeader1.Width = 323;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Path";
            this.columnHeader2.Width = 519;
            // 
            // modCreatorPathButton
            // 
            this.modCreatorPathButton.Location = new System.Drawing.Point(820, 70);
            this.modCreatorPathButton.Name = "modCreatorPathButton";
            this.modCreatorPathButton.Size = new System.Drawing.Size(30, 22);
            this.modCreatorPathButton.TabIndex = 7;
            this.modCreatorPathButton.Text = "...";
            this.modCreatorPathButton.UseVisualStyleBackColor = true;
            this.modCreatorPathButton.Click += new System.EventHandler(this.modCreatorPathButton_Click);
            // 
            // modCreatorPathBox
            // 
            this.modCreatorPathBox.Location = new System.Drawing.Point(72, 71);
            this.modCreatorPathBox.Name = "modCreatorPathBox";
            this.modCreatorPathBox.Size = new System.Drawing.Size(742, 20);
            this.modCreatorPathBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Path";
            // 
            // createModButton
            // 
            this.createModButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createModButton.Enabled = false;
            this.createModButton.Location = new System.Drawing.Point(6, 564);
            this.createModButton.Name = "createModButton";
            this.createModButton.Size = new System.Drawing.Size(89, 23);
            this.createModButton.TabIndex = 4;
            this.createModButton.Text = "Create/Update";
            this.createModButton.UseVisualStyleBackColor = true;
            this.createModButton.Click += new System.EventHandler(this.createModButton_Click);
            // 
            // modCreatorDescBox
            // 
            this.modCreatorDescBox.Location = new System.Drawing.Point(72, 44);
            this.modCreatorDescBox.MaxLength = 1200;
            this.modCreatorDescBox.Name = "modCreatorDescBox";
            this.modCreatorDescBox.Size = new System.Drawing.Size(778, 20);
            this.modCreatorDescBox.TabIndex = 3;
            // 
            // modCreatorNameBox
            // 
            this.modCreatorNameBox.Location = new System.Drawing.Point(72, 17);
            this.modCreatorNameBox.MaxLength = 32;
            this.modCreatorNameBox.Name = "modCreatorNameBox";
            this.modCreatorNameBox.Size = new System.Drawing.Size(183, 20);
            this.modCreatorNameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // addModDialog
            // 
            this.addModDialog.FileName = "ModData.txt";
            this.addModDialog.Filter = "Mod Data|ModData.txt;mod.ini";
            this.addModDialog.Title = "Select Mod";
            // 
            // spriteMapDialog
            // 
            this.spriteMapDialog.FileName = "spr.bin";
            this.spriteMapDialog.Filter = "Sprite Mappings|*.bin";
            this.spriteMapDialog.Title = "Select Sprite Mapping file";
            // 
            // iconOpenDialog
            // 
            this.iconOpenDialog.FileName = "icon";
            this.iconOpenDialog.Filter = "Image Files|*.png;";
            this.iconOpenDialog.Title = "Select Icon";
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 60000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // ModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 674);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ModManager";
            this.Text = "Chaos Mod Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modCreatorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button resetModDefaults;
        private System.Windows.Forms.Button applyModsButton;
        private System.Windows.Forms.Button openModFolderButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addFromFolderButton;
        private System.Windows.Forms.Button addModButton;
        private System.Windows.Forms.ListView modView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox modCreatorAuthorBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox modCreatorIcon;
        private System.Windows.Forms.Button modCreatorResetButton;
        private System.Windows.Forms.ListView modCreatorFiles;
        private System.Windows.Forms.Button modCreatorPathButton;
        private System.Windows.Forms.TextBox modCreatorPathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createModButton;
        private System.Windows.Forms.TextBox modCreatorDescBox;
        private System.Windows.Forms.TextBox modCreatorNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog modCreatorPathDialog;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog setCustomDataDialog;
        private System.Windows.Forms.FolderBrowserDialog addModFolderDialog;
        private System.Windows.Forms.OpenFileDialog addModDialog;
        private System.Windows.Forms.Button openGameFolder;
        private System.Windows.Forms.Button clearFilesButton;
        private System.Windows.Forms.Button openDataFolder;
        private System.Windows.Forms.OpenFileDialog spriteMapDialog;
        private System.Windows.Forms.TextBox modCreatorVersionBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.Button runGameButton;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.Button deselectAllButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.Button orderDownButton;
        private System.Windows.Forms.Button orderUpButton;
        private System.Windows.Forms.Button openModFolder;
        private System.Windows.Forms.Button applyAndRundButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cDesc;
        private System.Windows.Forms.RadioButton videosBox;
        private System.Windows.Forms.RadioButton stringsBox;
        private System.Windows.Forms.RadioButton stagesBox;
        private System.Windows.Forms.RadioButton spritesBox;
        private System.Windows.Forms.RadioButton soundFXBox;
        private System.Windows.Forms.RadioButton shadersBox;
        private System.Windows.Forms.RadioButton objectsBox;
        private System.Windows.Forms.RadioButton musicBox;
        private System.Windows.Forms.RadioButton meshesBox;
        private System.Windows.Forms.RadioButton imagesBox;
        private System.Windows.Forms.RadioButton gameBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button optimizeButton;
        private System.Windows.Forms.ToolStripDropDownButton updateDropDown;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton manLargeRadio;
        private System.Windows.Forms.RadioButton manSmallRadio;
        private System.Windows.Forms.RadioButton manListRadio;
        private System.Windows.Forms.RadioButton manDetailsRadio;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton createListRadio;
        private System.Windows.Forms.RadioButton creatorDetailsRadio;
        private System.Windows.Forms.ToolStripMenuItem installUpdateToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.OpenFileDialog iconOpenDialog;
        private System.Windows.Forms.ImageList smallImages;
        private System.Windows.Forms.ImageList largeImages;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton allRadio;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button creatorSearchReset;
    }
}

