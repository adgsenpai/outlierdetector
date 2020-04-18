using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ADG_AI_OUTLIER_DETECTOR
{
    public partial class frmBuildModel : Form
    {
        public frmBuildModel()
        {
            InitializeComponent();
        }

        public void ExecuteAIProgram()
        {
            var p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            string username = Environment.UserName;
            string path = @"C:\Users\" + username + @"\AppData\Local\ADGAI\ADGAI.dll";
            p.StartInfo.Arguments = "dotnet";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.OutputDataReceived += (a, b) => MessageBox.Show(b.Data);
            p.ErrorDataReceived += (a, b) => MessageBox.Show(b.Data);
            p.Start();
            p.BeginErrorReadLine();
            p.BeginOutputReadLine();
            p.WaitForExit();
        }
        private void FrmBuildModel_Load(object sender, EventArgs e)
        {
            ExecuteAIProgram();
            string userName = @"C:\Users\" + Environment.UserName;
            string folderName = userName + @"\AppData\Local\ADG TECH";
            string pathString = System.IO.Path.Combine(folderName, "settings");
            INIFile inif = new INIFile(pathString + @"\setting.ini");
            string strPath = inif.Read("Database", "Directory");
            DataTable dt = ConvertCSVtoDataTable(strPath);
            for (int i = 0; i < dt.Columns.Count; i++)
                comboBox1.Items.Insert(i, dt.Columns[i].ColumnName);
            comboBox1.SelectedIndex = 0;
        }

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }

        private void FrmBuildModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Visible = true;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string userName = @"C:\Users\" + Environment.UserName;

            string folderName = userName + @"\AppData\Local\ADG TECH";

            string pathString = System.IO.Path.Combine(folderName, "settings");

            INIFile inif = new INIFile(pathString + @"\setting.ini");
            inif.Write("Model Settings", "Training Model", comboBox1.Text);
            frmModelStep2 newfrm = new frmModelStep2();
            newfrm.Show();
            this.Visible = false;
        }
    }
}
