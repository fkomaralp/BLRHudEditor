using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLRHudEditor
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        string steam_path, FoxHud_ini;

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();

            IniData data = parser.ReadFile("settings.ini");

            string steamPath = data["paths"]["SteamPath"];
            string useCustomPath = data["paths"]["UseCustomPath"].Trim();
            string customSteamPath = data["paths"]["CustomSteamPath"];


            if (useCustomPath == "0")
            {
                autoFindRadioBtn.Checked = true;
            } else
            {
                customRadioBtn.Checked = true;
            }

            textBox1.Text = steamPath;
            textBox2.Text = customSteamPath;

            IniData settings = parser.ReadFile("settings.ini");
            if (settings["paths"]["UseCustomPath"] == "1")
            {
                steam_path = settings["paths"]["CustomSteamPath"];
            }
            else
            {
                steam_path = settings["paths"]["SteamPath"];
            }


        }

        private void UpdateFolderPath(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox2.Text = fbd.SelectedPath;
                }
            }
        }

        private void saveOptions_Click(object sender, EventArgs e)
        {
            if (customRadioBtn.Checked && textBox2.Text == "")
            {
                MessageBox.Show("Please select Steam folder.");
                return;
            } else
            {
                int useCustomPath = 0;
                if (autoFindRadioBtn.Checked)
                {
                    useCustomPath = 0;
                }
                else
                {
                    useCustomPath = 1;
                }

                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("settings.ini");
                data["paths"]["UseCustomPath"] = useCustomPath.ToString();
                data["paths"]["CustomSteamPath"] = textBox2.Text;
                parser.WriteFile("settings.ini", data);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FoxHud_ini = steam_path + @"\steamapps\common\blacklightretribution\FoxGame\Config\PCConsole\Cooked";

            string backupFolder = "BLEHudEditor";

            var backupFolderExists = File.Exists(Path.Combine(FoxHud_ini, backupFolder));
            if (!backupFolderExists)
            {
                Directory.CreateDirectory(Path.Combine(FoxHud_ini, backupFolder));
            }

            string[] FoxHud_ini_files = Directory.GetFiles(FoxHud_ini);

            foreach (var item in FoxHud_ini_files)
            {
                string fileName = Path.GetFileName(item);
                string targetFolder = Path.Combine(FoxHud_ini, Path.Combine(backupFolder, fileName));

                File.Copy(item, targetFolder, true);
            }
        }
    }
}
