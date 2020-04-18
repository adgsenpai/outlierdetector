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
using System.Windows.Interactivity;

namespace ADG_AI_OUTLIER_DETECTOR
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void TmrDateTime_Tick(object sender, EventArgs e)
        {
            this.lblDateTime.Text = DateTime.Now.ToString();
            this.lblDay.Text = System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetDayName(System.DateTime.Now.DayOfWeek);
        }

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SettingsVar();
            this.lblDateTime.Text = DateTime.Now.ToString();
            this.lblDay.Text = System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetDayName(System.DateTime.Now.DayOfWeek);
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
                    EnableComponents();
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

        public void DisableComponents()
        {
            btnBuild.Enabled = false;
            
            btnView.Enabled = false;
            btnReport.Enabled = false;
            
        }
        public void EnableComponents()
        {
           
            btnBuild.Enabled = true;
           
            btnView.Enabled = true;
            btnReport.Enabled = true;
        }
        private void BunifuTileButton2_Click(object sender, EventArgs e)
        {
            frmDT frmNew = new frmDT();
            frmNew.Show();
        }

        private void BunifuTileButton3_Click(object sender, EventArgs e)
        {
            
            frmSettings frm = new frmSettings();
            frm.Show();
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            SettingsVar();
            string userName = @"C:\Users\" + Environment.UserName;
            string folderName = userName + @"\AppData\Local\ADG TECH";
            string pathString = System.IO.Path.Combine(folderName, "settings");
            INIFile inif = new INIFile(pathString + @"\setting.ini");
            string strPath = inif.Read("Database", "Directory");
            if (strPath == "") 
            {

            lblCSV.Text = "Disconnected from Dataset";
                lblCSV.ForeColor = Color.Red;
                DisableComponents();
            }
            else
            {
            lblCSV.Text = "Connected to Dataset " + Path.GetFileName(strPath);
                lblCSV.ForeColor = Color.Green;
                EnableComponents();
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
         
            



        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            frmBuildModel frm = new frmBuildModel();
            frm.Show();
            this.Visible = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            frmOutlier frmNw = new frmOutlier();
            frmNw.Show();
            this.Visible = false;
        }
    }
}
