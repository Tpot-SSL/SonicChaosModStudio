using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using static SonicChaosModStudio.StaticTools;


namespace SonicChaosModStudio {
    public partial class ModManager : Form {

        public static string ToolsLocation = "";
        public static string GameLocation = "";
        public static string DataLocation = "";

        public static string ExecutableLocation => GameLocation + "\\Sonic Chaos.exe";
        public static string Version => "0.9a";

        public static string ActiveGroup = "All";

        public ModManager() => InitializeComponent();

        public List<ListViewItem> CreatorItems = new List<ListViewItem>();

        public void ModCreatorAddFiles(string path) {
            modCreatorPathBox.Text = path;

            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            //modCreatorFiles.SuspendLayout();

          
            foreach(string f in files) {
                if(f.Substring(path.Length) == "\\ModData.txt" || f.Substring(path.Length) == "\\icon.png")
                    continue;

                string name = f.Substring(path.Length + 1);

                ListViewItem item = new ListViewItem(name);
                item.Tag = f;
                item.Group = modCreatorFiles.Groups[name.Split('\\')[0]];
                item.SubItems.Add(f);
                CreatorItems.Add(item);
            }

            //modCreatorFiles.ResumeLayout();

            createModButton.Enabled = true;
            ModCreatorRefreshFiles();
        }

        public string CreatorSearchFilter ="";

        public void ModCreatorRefreshFiles() {
            modCreatorFiles.BeginUpdate();
            modCreatorFiles.Items.Clear();

            string filter = CreatorSearchFilter;

            List<ListViewItem> list = CreatorItems.Where(p => (filter == "" || p.Text.Contains(filter)) && (ActiveGroup == "All" || p.Text.Split('\\')[0] == ActiveGroup)).ToList();
            foreach(ListViewItem l in list) {
                modCreatorFiles.Items.Add(l);
                l.Group = modCreatorFiles.Groups[l.Text.Split('\\')[0]];
            }

            modCreatorFiles.EndUpdate();
        }

        private void modCreatorPathButton_Click(object sender, EventArgs e) {
            if(modCreatorPathDialog.ShowDialog() != DialogResult.OK)
                return;

            ModCreatorAddFiles(modCreatorPathDialog.SelectedPath);
        }


        private void createModButton_Click(object sender, EventArgs e) {
            if(File.Exists(ExecutableLocation) == false) {
                MessageBox.Show("Chaos executable not found.");
                return;
            }

            if(modCreatorFiles.CheckedItems.Count == 0) {
                MessageBox.Show("Error: No items were selected to be used in the mod.");
                return;
            }

            if(modCreatorNameBox.Text == "") {
                MessageBox.Show("Mod has no name. Please enter one.");
                return;
            }

            if(modCreatorAuthorBox.Text == "") {
                MessageBox.Show("Mod has no author. Please enter one.");
                return;
            }

            if(modCreatorVersionBox.Text == "") {
                MessageBox.Show("Mod has no version number. Please enter one.");
                return;
            }

            if(modCreatorFiles.CheckedItems.Count >= 300 && MessageBox.Show("Your mod has over 300 files. Remember to only include modified files. Are you sure you would like to create it anyway?", "Many entries", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string name = modCreatorNameBox.Text;

            bool valid = name.Where(c => InvalidFileNameChars.Contains(c)).ToList().Count > 0;
            if(valid == true) {
                MessageBox.Show("Name has invalid filename characters.");
                return;
            }

            string dir = GameLocation + "\\Mods\\";
            Directory.CreateDirectory(dir);
            string modDir = dir + name + "\\";

            bool copyOver = false;

            if(File.Exists(modDir + "ModData.txt") == true) {
                DeleteDirectory(DataLocation + "\\Temp\\");
                modDir = DataLocation + "\\Temp\\";
                copyOver = true;
            } else if(Directory.Exists(modDir) && MessageBox.Show("Mod list already has a mod with this name. Would you like to replace it?", "Existing Mod", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            Directory.CreateDirectory(modDir);

            foreach(ListViewItem i in modCreatorFiles.CheckedItems) {
                Directory.CreateDirectory(Path.GetDirectoryName(modDir + i.Text));
                File.Copy(i.Tag.ToString(), modDir + i.Text);
            }

            modCreatorIcon.Image?.Save(modDir + "icon.png");

            File.WriteAllLines(modDir + "ModData.txt", new string[] { modCreatorNameBox.Text, modCreatorAuthorBox.Text, modCreatorDescBox.Text, modCreatorVersionBox.Text });

            if(copyOver) {

                CopyDirectory(DataLocation + "\\Temp\\", dir + name + "\\");
                foreach(ListViewItem i in modCreatorFiles.Items) {
                    if(i.Checked)
                        continue;

                    Directory.CreateDirectory(Path.GetDirectoryName(modDir + i.Text));
                    DeleteFile(dir + name + "\\" + i.Text);
                }
                MessageBox.Show("Mod successfully updated.");
                return;
            }

            ListViewItem item = modView.Items.Add(modCreatorNameBox.Text);
            item.SubItems.Add(modCreatorAuthorBox.Text);
            item.SubItems.Add(modCreatorDescBox.Text);
            item.SubItems.Add(modCreatorVersionBox.Text);
            item.ImageKey = name;
            if(modCreatorIcon.Image != null) {
                Bitmap icon = new Bitmap(modCreatorIcon.Image);
                smallImages.Images.Add(name, icon);
                largeImages.Images.Add(name, icon);
            }
            MessageBox.Show("Mod successfully created.");
        }

        private void modCreatorResetButton_Click(object sender, EventArgs e) {
            modCreatorFiles.Items.Clear();
            modCreatorNameBox.Text = "";
            modCreatorAuthorBox.Text = "";
            modCreatorDescBox.Text = "";
            modCreatorIcon.Image = null;
            modCreatorPathBox.Text = "";
            CreatorItems.Clear(); ;
        }

        private void Form1_Load(object sender, EventArgs e) {
            ToolsLocation = AppDomain.CurrentDomain.BaseDirectory + "Tools";

            File.Delete(Environment.CurrentDirectory + "\\update.zip");
            File.Delete(Environment.CurrentDirectory + "\\download.zip");
            DeleteDirectory(Environment.CurrentDirectory + "\\update");
            GameLocation = Environment.CurrentDirectory;
            DataLocation = Environment.CurrentDirectory + "\\cd";

            bool fTime = Properties.Settings.Default.FirstTime;

            //if(fTime == false && Updater.Startup()) {
            //    updateDropDown.Text = "Updates (1)";
            //    installUpdateToolStripMenuItem.Visible = true;
            //}

            if(string.IsNullOrEmpty(DataLocation))
                DataLocation = GameLocation + "\\cd";

            FillModList();

            if(fTime)
                MessageBox.Show("Welcome to the Chaos Mod Studio.\r\nYou can use this to create, load, and edit mods for Sonic Chaos.", "Welcome");

            Properties.Settings.Default.FirstTime = false;
            Properties.Settings.Default.Save();
        }

        private void applyModsButton_Click(object sender, EventArgs e) {
            ApplyMods();
        }

        private void addModButton_Click(object sender, EventArgs e) {
            if(GameLocation == "" || File.Exists(ExecutableLocation) == false) {
                MessageBox.Show("Chaos exectuable not found.");
                return;
            }

            if(addModDialog.ShowDialog() != DialogResult.OK)
                return;

            string srcPath = Path.GetDirectoryName(addModDialog.FileName);

            string name = "";

            name = File.ReadAllLines(srcPath + "\\ModData.txt")[0];

            name = new string(name.Where(c => !InvalidFileNameChars.Contains(c)).ToArray());

            string destPath = GameLocation + "\\Mods\\" + name + "\\";

            foreach(string dirPath in Directory.GetDirectories(srcPath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(srcPath, destPath));

            foreach(string newPath in Directory.GetFiles(srcPath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(srcPath, destPath), true);

            string i = destPath + "\\icon.png";

            string[] liness = File.ReadAllLines(destPath + "\\ModData.txt");

            ListViewItem item = modView.Items.Add(liness[0]);
            item.SubItems.Add(liness[1]);
            item.SubItems.Add(liness[2]);
            item.SubItems.Add(liness[3]);
            item.ImageKey = name;
            if(File.Exists(i)) {
                Bitmap icon = new Bitmap(i);
                smallImages.Images.Add(name, icon);
                largeImages.Images.Add(name, icon);
            }
        }

        private void openModFolderButton_Click(object sender, EventArgs e) {
            if(modView.SelectedItems.Count <= 0)
                return;

            string dir = GameLocation + "\\Mods\\";
            Process.Start("explorer.exe", dir + modView.SelectedItems[0].Text + "\\");
        }

        private void openDataFolder_Click(object sender, EventArgs e) {
            if(DataLocation == "" || Directory.Exists(DataLocation) == false) {
                MessageBox.Show("Data folder not found.", "Error");
                return;
            }

            Process.Start("explorer.exe", DataLocation);
        }

        private void openGameFolder_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", Directory.GetCurrentDirectory());
        }

        private void addFromFolderButton_Click(object sender, EventArgs e) {
            if(addModFolderDialog.ShowDialog() != DialogResult.OK)
                return;
        }

        private void resetModDefaults_Click(object sender, EventArgs e) {
            string dir = GameLocation;
            if(Directory.Exists(dir + "\\Backup") == false) {
                MessageBox.Show("No backups have been made. Either mods haven't been applied, or something went wrong.");
                return;
            }

            foreach(ListViewItem i in modView.Items)
                i.Checked = false;

            File.WriteAllLines(GameLocation + "\\Backup\\AppliedMods.txt", new string[0]);
            MessageBox.Show("Chaos data folder successfully restored.");
        }

        private void infoButton_Click(object sender, EventArgs e) {
            if(modView.SelectedItems.Count <= 0)
                return;

            string file = DataLocation + $"\\Mods\\{modView.SelectedItems[0].Text}\\ModData.txt";
            string[] txt = File.ReadAllLines(file);
            txt[0] = $"Name: {txt[0]}";
            txt[1] = $"Author: {txt[1]}";
            txt[2] = $"Description: {txt[2]}";
            txt[3] = $"Version: {txt[3]}";
            MessageBox.Show($"{txt[0]}\r\n{txt[1]}\r\n{txt[2]}\r\n{txt[3]}", "Mod Info");
        }

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        public void RunGame() {
            if(string.IsNullOrEmpty(GameLocation) || File.Exists(ExecutableLocation) == false)
                return;

            ProcessStartInfo p = new ProcessStartInfo() {
                FileName = ExecutableLocation,
                WorkingDirectory = GameLocation
            };
            Process.Start(p);
        }

        public void ApplyMods() {
            if(File.Exists(ExecutableLocation) == false) {
                MessageBox.Show("Chaos Executable not found.");
                return;
            }

            //var dir = DataLocation;
            //DeleteDirectory(DataLocation + "\\Current\\");
            List<ListViewItem> modList = modView.CheckedItems.Cast<ListViewItem>().Reverse().ToList();

            if(Directory.Exists($"{GameLocation}/Backup") == false) {
                Directory.CreateDirectory(  $"{GameLocation}/Backup");
                CopyDirectory(DataLocation, $"{GameLocation}/Backup");
            } else {
                CopyDirectory($"{GameLocation}/Backup", DataLocation);
            }
            List<string> lines = new List<string>();

            foreach(ListViewItem i in modList) {
                CopyDirectory(GameLocation + $"\\Mods\\{i.Text}", DataLocation);
                lines.Add(i.Text);
            }

            File.WriteAllLines(GameLocation + "\\Backup\\AppliedMods.txt", lines);
            MessageBox.Show("Mods successfully applied.");
        }

        public void FillModList() {
            string dir = GameLocation + "\\Mods";

            if(Directory.Exists(dir) == false)
                Directory.CreateDirectory(dir);
            else {
                string[] dirs = Directory.GetDirectories(dir);

                modView.SuspendLayout();
                modView.BeginUpdate();
                List<string> active = new List<string>();
                string mods = GameLocation + "\\Backup\\AppliedMods.txt";

                if(File.Exists(mods))
                    active = File.ReadAllLines(mods).ToList();

                foreach(string d in dirs) {
                    string f = d + "\\ModData.txt";

                    if(File.Exists(f) == false)
                        continue;

                    string i = d + "\\icon.png";

                    string[] lines = File.ReadAllLines(f);
                    string name = lines[0];

                    ListViewItem item = modView.Items.Add(name);
                    item.SubItems.Add(lines[1]);
                    item.SubItems.Add(lines[2]);
                    item.SubItems.Add(lines[3]);
                    item.ImageKey = name;
                    if(File.Exists(i)) {
                        Bitmap icon = new Bitmap(i);
                        smallImages.Images.Add(name, icon);
                        largeImages.Images.Add(name, icon);
                    }

                    if(active.Contains(name))
                        item.Checked = true;
                }

                modView.EndUpdate();
                modView.ResumeLayout();
            }
        }

        private void runGameButton_Click(object sender, EventArgs e) => RunGame();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => new About().ShowDialog();

        private void deleteButton_Click(object sender, EventArgs e) {
            if(modView.SelectedItems.Count <= 0)
                return;

            if(MessageBox.Show($"Are you sure you would like to delete: {modView.SelectedItems[0].Text}?", "Mod Deletion", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            string name = modView.SelectedItems[0].Text;
            DeleteDirectory(GameLocation + $"\\Mods\\{modView.SelectedItems[0].Text}");
            modView.Items.Remove(modView.SelectedItems[0]);
        }

        private void clearFilesButton_Click(object sender, EventArgs e) {
            modCreatorPathBox.Text = "";
            modCreatorFiles.Items.Clear();
            CreatorItems.Clear();
        }

        private void selectAllButton_Click(object sender, EventArgs e) {
            foreach(ListViewItem i in modCreatorFiles.Items)
                i.Checked = true;
        }

        private void deselectAllButton_Click(object sender, EventArgs e) {
            foreach(ListViewItem i in modCreatorFiles.Items)
                i.Checked = false;
        }

        private void editButton_Click(object sender, EventArgs e) {
            if(modView.SelectedItems.Count <= 0)
                return;

            modCreatorFiles.Items.Clear();

            string[] info = File.ReadAllLines(GameLocation + $"\\Mods\\{modView.SelectedItems[0].Text}\\ModData.txt");
            CreatorItems.Clear();
            modCreatorNameBox.Text = info[0];
            modCreatorAuthorBox.Text = info[1];
            modCreatorDescBox.Text = info[2];
            modCreatorVersionBox.Text = info[3];
            modCreatorIcon.Image = largeImages.Images[modView.SelectedItems[0].ImageKey];

            ModCreatorAddFiles(GameLocation + $"\\Mods\\{modView.SelectedItems[0].Text}");

            foreach(ListViewItem i in modCreatorFiles.Items)
                i.Checked = true;

            mainTabControl.SelectedIndex = 1;
        }

        private void openModFolder_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", GameLocation + "\\Mods");
        }

        private void openRSDKButton_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", ToolsLocation);
        }

        private void applyAndRundButton_Click(object sender, EventArgs e) {
            if(GameLocation == "" || File.Exists(ExecutableLocation) == false) {
                MessageBox.Show("Chaos not found.");
                return;
            }

            ApplyMods();
            RunGame();
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            modView.Items.Clear();
            FillModList();
        }

        private void checkAllButton_Click(object sender, EventArgs e) {
            foreach(ListViewItem i in modView.Items) {
                if(i.Checked == false) {
                    foreach(ListViewItem i2 in modView.Items)
                        i2.Checked = true;

                    return;
                }
            }
            foreach(ListViewItem i in modView.Items)
                i.Checked = false;
        }

        private void orderDownButton_Click(object sender, EventArgs e) {
            if(modView.SelectedItems.Count <= 0 || modView.SelectedItems[0].Index == modView.Items.Count - 1)
                return;

            ListViewItem item = modView.SelectedItems[0];
            int index = item.Index + 1;
            modView.Items.Remove(item);
            modView.Items.Insert(index, item);
        }

        private void orderUpButton_Click(object sender, EventArgs e) {
            if(modView.SelectedItems.Count <= 0 || modView.SelectedItems[0].Index == 0)
                return;

            ListViewItem item = modView.SelectedItems[0];
            int index = item.Index - 1;
            modView.Items.Remove(item);
            modView.Items.Insert(index, item);
        }

        private void gameBox_CheckedChanged(object sender, EventArgs e) {
            RadioButton rad = sender as RadioButton;
            if(rad == null)
                return;

            ActiveGroup = rad.Text;
            ModCreatorRefreshFiles();
        }

        private void updateSettingsToolStripMenuItem_Click(object sender, EventArgs e) => new UpdateSettings().ShowDialog();

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e) {
        //    bool update = Updater.CheckVersion();
        //    if(update == false)
        //        return;

        //    SetUpdate();
        }

        public void SetUpdate() {
        //    updateDropDown.Text = "Updates (1)";
        //    installUpdateToolStripMenuItem.Visible = true;
        }

        private void installUpdateToolStripMenuItem_Click(object sender, EventArgs e) { }// => Updater.Update();

        private void modCreatorIcon_Click(object sender, EventArgs e) {
            if(iconOpenDialog.ShowDialog() != DialogResult.OK)
                return;

            modCreatorIcon.Image = new Bitmap(iconOpenDialog.FileName);
        }

        private void manDetailsRadio_CheckedChanged(object sender, EventArgs e) => modView.View = View.Details;
        private void manListRadio_CheckedChanged(object sender, EventArgs e) => modView.View = View.List;
        private void manSmallRadio_CheckedChanged(object sender, EventArgs e) => modView.View = View.SmallIcon;
        private void manLargeRadio_CheckedChanged(object sender, EventArgs e) => modView.View = View.LargeIcon;

        private void updateTimer_Tick(object sender, EventArgs e) {
            //if(Updater.CheckAuto == false)
            //    return;

            //if((DateTime.Now - Updater.LastUpdateCheck).Minutes >= Updater.MinutesToCheck) {
            //    if(Updater.CheckVersion(true))
            //        SetUpdate();
            //}
        }

        private void creatorDetailsRadio_CheckedChanged(object sender, EventArgs e) => modCreatorFiles.View = View.Details;
        private void createListRadio_CheckedChanged(object sender, EventArgs e) => modCreatorFiles.View = View.List;

        private void searchButton_Click(object sender, EventArgs e) {
            CreatorSearchFilter = filterBox.Text;
            ModCreatorRefreshFiles();
        }

        private void creatorSearchReset_Click(object sender, EventArgs e) {
            filterBox.Text = "";
            CreatorSearchFilter = filterBox.Text;
            ModCreatorRefreshFiles();
        }

        private void downloadButton_Click(object sender, EventArgs e) {

        }
    }
}
