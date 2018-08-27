using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace SonicChaosModStudio {
    public static class StaticTools {
        public static readonly char[] InvalidFileNameChars = Path.GetInvalidFileNameChars();

        public static void DeleteDirectory(string srcPath) {
            if(Directory.Exists(srcPath) == false)
                return;

            try {
                foreach(string newPath in Directory.GetFiles(srcPath, "*.*", SearchOption.AllDirectories))
                    DeleteFile(newPath);

                Directory.Delete(srcPath, true);
            }
            catch {
                MessageBox.Show("Error: Couldn't delete directory.");
            }
        }

        public static void CopyDirectory(string srcPath, string destPath) {
            if(Directory.Exists(srcPath) == false)
                return;

            foreach(string dirPath in Directory.GetDirectories(srcPath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(srcPath, destPath));

            foreach(string newPath in Directory.GetFiles(srcPath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(srcPath, destPath), true);
        }

        public static void DeleteFile(string fileToDelete) {
            if(File.Exists(fileToDelete) == false)
                return;

            FileInfo fi = new FileInfo(fileToDelete);
            if(fi.Exists) {
                fi.Delete();
                fi.Refresh();
                while(fi.Exists) {
                    System.Threading.Thread.Sleep(10);
                    fi.Refresh();
                }
            }

        }
    }
}
