using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADG_AI_OUTLIER_DETECTOR
{
    public partial class frmModelStep2 : Form
    {
        public frmModelStep2()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string userName = @"C:\Users\" + Environment.UserName;
            string folderName = userName + @"\AppData\Local\ADG TECH";
            string pathString = System.IO.Path.Combine(folderName, "settings");
          
            INIFile inif = new INIFile(pathString + @"\setting.ini");
            inif.Write("Model Settings", "PValueSize", numericUpDown1.Value.ToString());
            inif.Write("Model Settings", "SeasonalitySize", numericUpDown2.Value.ToString());
            inif.Write("Model Settings", "TrainingSize", numericUpDown3.Value.ToString());
            inif.Write("Model Settings", "ConfidenceInterval", numericUpDown4.Value.ToString());

            string message = "Data submitted to Model";
            string title = "ADG TECH";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

            this.Visible = false;
            frmMain frm = new frmMain();
            frm.Show();

        }

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            frmBuildModel newFrm = new frmBuildModel();
            newFrm.Show();
            this.Visible = false;
        }

        private void FrmModelStep2_Load(object sender, EventArgs e)
        {

        }

        private void FrmModelStep2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBuildModel nwForm = new frmBuildModel();
            nwForm.Show();
        }
    }
}
