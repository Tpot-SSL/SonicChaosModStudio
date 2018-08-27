using System;
using System.Windows.Forms;

namespace SonicChaosModStudio {
    public partial class UpdateSettings : Form {
        public UpdateSettings() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) {
            //Updater.CheckAuto = autoBox.Checked;
            //Updater.CheckStart = checkUpdatesBox.Checked;
            //Updater.MinutesToCheck = Convert.ToInt32(numBox.Value);

            //Properties.Settings.Default.UpdaterAutoCheck = Updater.CheckAuto;
            //Properties.Settings.Default.UpdaterStartCheck = Updater.CheckStart;
            //Properties.Settings.Default.UpdaterMinutes = Updater.MinutesToCheck;
            //Properties.Settings.Default.Save();

            Close();
        }

        private void UpdateSettings_Load(object sender, EventArgs e) {

            //checkUpdatesBox.Checked = Updater.CheckStart;
            //autoBox.Checked = Updater.CheckAuto;
            //numBox.Value = Updater.MinutesToCheck;

            //versionText.Text += ModManager.Version;
            //lastCheckText.Text += Updater.HasChecked ? Updater.LastUpdate.ToShortDateString() + " " + Updater.LastUpdate.ToShortTimeString() : "Never";
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
