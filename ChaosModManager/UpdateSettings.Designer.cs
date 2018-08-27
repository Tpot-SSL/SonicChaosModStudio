namespace SonicChaosModStudio {
    partial class UpdateSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSettings));
            this.checkUpdatesBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.autoBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.versionText = new System.Windows.Forms.Label();
            this.lastCheckText = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkUpdatesBox
            // 
            this.checkUpdatesBox.AutoSize = true;
            this.checkUpdatesBox.Location = new System.Drawing.Point(5, 5);
            this.checkUpdatesBox.Name = "checkUpdatesBox";
            this.checkUpdatesBox.Size = new System.Drawing.Size(166, 17);
            this.checkUpdatesBox.TabIndex = 0;
            this.checkUpdatesBox.Text = "Check for updates on launch.";
            this.checkUpdatesBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check every ";
            // 
            // numBox
            // 
            this.numBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numBox.Location = new System.Drawing.Point(78, 59);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(45, 20);
            this.numBox.TabIndex = 2;
            this.numBox.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "minutes.";
            // 
            // autoBox
            // 
            this.autoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoBox.AutoSize = true;
            this.autoBox.Location = new System.Drawing.Point(5, 41);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(177, 17);
            this.autoBox.TabIndex = 4;
            this.autoBox.Text = "Automatically check for updates";
            this.autoBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(205, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.Location = new System.Drawing.Point(194, 7);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(48, 13);
            this.versionText.TabIndex = 6;
            this.versionText.Text = "Version: ";
            // 
            // lastCheckText
            // 
            this.lastCheckText.AutoSize = true;
            this.lastCheckText.Location = new System.Drawing.Point(2, 25);
            this.lastCheckText.Name = "lastCheckText";
            this.lastCheckText.Size = new System.Drawing.Size(66, 13);
            this.lastCheckText.TabIndex = 7;
            this.lastCheckText.Text = "Last check: ";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(286, 56);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 83);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lastCheckText);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.autoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkUpdatesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSettings";
            this.Text = "Update Settings";
            this.Load += new System.EventHandler(this.UpdateSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkUpdatesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autoBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.Label lastCheckText;
        private System.Windows.Forms.Button cancelButton;
    }
}