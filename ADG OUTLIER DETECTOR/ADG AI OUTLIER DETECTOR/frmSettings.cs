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

namespace ADG_AI_OUTLIER_DETECTOR
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            string filePath = "";
            browser.Filter = "Comma-Separated Values(*.csv) | *.csv";
            if (browser.ShowDialog() == DialogResult.OK)
            {
                filePath = Path.GetFullPath(browser.FileName);
            }
            edtDirectory.Text = filePath;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (edtDirectory.Text == "")
            {
                MessageBox.Show("Please select a directory", "ADG AI PROGRAM",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                string userName = @"C:\Users\" + Environment.UserName;
                string folderName = userName + @"\AppData\Local\ADG TECH";
                string pathString = System.IO.Path.Combine(folderName, "settings");
                Directory.Delete(folderName, true);

                SettingsVar();
                INIFile inif = new INIFile(pathString + @"\setting.ini");
                inif.Write("Database", "Directory", edtDirectory.Text);
                MessageBox.Show("Updated Settings...");
                this.Visible = false;
             

            }

            

          
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }
        private void SettingsVar()
        {
            string userName = @"C:\Users\" + Environment.UserName;

            string folderName = userName + @"\AppData\Local\ADG TECH";

            string pathString = System.IO.Path.Combine(folderName, "settings");
            if (File.Exists(pathString))
            {
                if (File.Exists(pathString + @"\setting.ini"))
                {
                   
                }
                else
                {
                    INIFile inif = new INIFile(pathString + @"\setting.ini");
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(pathString);
                pathString = System.IO.Path.Combine(folderName, "MLModels");
                System.IO.Directory.CreateDirectory(pathString);

                pathString = System.IO.Path.Combine(folderName, "OutlierData");
                System.IO.Directory.CreateDirectory(pathString);
                INIFile inif = new INIFile(pathString + @"\setting.ini");
                //inif.Write("Database", "Directory", "");
            }


        }


    }
}
