using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicChaosModStudio {
    public partial class About : Form {
        public About() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void About_Load(object sender, EventArgs e) {
            aboutInfo.Text = aboutInfo.Text.Replace("[]", ModManager.Version);
        }
    }
}
