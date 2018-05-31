using IniParser;
using IniParser.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLRHudEditor
{
    public partial class Form1 : Form
    {
        FileIniDataParser parser = new FileIniDataParser();


        public Form1()
        {
            Thread splashScreenThread = new Thread(new ThreadStart(InitSplashScreen));
            splashScreenThread.Start();

            parser.Parser.Configuration.AllowDuplicateKeys = true;
            if (!File.Exists("settings.ini"))
            {

                //FileStream settings_file = File.Create("settings.ini");
                //settings_file.Close();

                string processer_architecture = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString();

                string installPath;
                if (processer_architecture == "x86")
                {
                    installPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam", "InstallPath", null).ToString();
                }
                else
                {
                    installPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", null).ToString();
                }

                IniData data = new IniData();//parser.ReadFile("settings.ini");

                data["paths"]["SteamPath"] = installPath;
                data["paths"]["UseCustomPath"] = "0";
                data["paths"]["CustomSteamPath"] = "";

                parser.WriteFile("settings.ini", data);

                Thread.Sleep(500);

            }

            

            Thread.Sleep(1000);

            InitializeComponent();

            splashScreenThread.Abort();
        }

        string steam_path, FoxHud_ini;

        private void Form1_Load(object sender, EventArgs e)
        {
            SceneComboBox.SelectedIndex = 0;

            IniData settings = parser.ReadFile("settings.ini");
            if (settings["paths"]["UseCustomPath"] == "1")
            {
                steam_path = settings["paths"]["CustomSteamPath"];
            }
            else
            {
                steam_path = settings["paths"]["SteamPath"];
            }

            FoxHud_ini = steam_path + @"\steamapps\common\blacklightretribution\FoxGame\Config\PCConsole\Cooked\FoxHud.ini";

            IniData blr_settings = parser.ReadFile(FoxHud_ini);

            var fox_hud_ui_list = blr_settings["FoxGame.FoxHudUI"];


            foreach (var item in fox_hud_ui_list)
            {
                if (item.KeyName.EndsWith("Widget"))
                {
                    comboBox1.Items.Add(item.KeyName);
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
        }

        public void InitSplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void KilledPlayerInfoWidget_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x_rot = ((Cursor.Position.X - 955) + 350);
                int y_rot = ((Cursor.Position.Y - 810) + 350);

                KilledPlayerInfoWidget.Location =  this.PointToClient(Cursor.Position);


                x.Text = x_rot.ToString();

                y.Text = y_rot.ToString();
            }
               
        }

        private void KilledPlayerInfoWidget_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.SizeAll;
            comboBox1.SelectedItem = "KilledPlayerInfoWidget";
        }

        private void Test(object sender, EventArgs e)
        {
            string widget_name = (string)comboBox1.SelectedItem;


            IniData blr_settings = parser.ReadFile(FoxHud_ini);

            string widget_value = blr_settings["FoxGame.FoxHudUI"][widget_name];

            string[] widget_values = widget_value.Replace("(", "").Replace(")", "").Split(',');

            string x_value = widget_values[0].Replace("X=" ,"");
            string y_value = widget_values[1].Replace("Y=" ,"");
            string FOV_value = widget_values[2].Replace("FOV=", "");
            string YRot_value = widget_values[3].Replace("YRot=", "");
            string Opacity_value = widget_values[4].Replace("Opacity=", "");
            if (widget_values.Count() > 5)
            {
                string DispTime_value = widget_values[5].Replace("DispTime=", "");
                disptime.Text = DispTime_value;
            }

            x.Text = x_value;
            y.Text = y_value;
            fov.Text = FOV_value;
            yrot.Text = YRot_value;
            opacity.Text = Opacity_value;



        }
    }
}
