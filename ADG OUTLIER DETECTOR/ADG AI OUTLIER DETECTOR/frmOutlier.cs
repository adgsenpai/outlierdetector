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
    public partial class frmOutlier : Form
    {
        public frmOutlier()
        {
            InitializeComponent();
        }

        private void FrmOutlier_Load(object sender, EventArgs e)
        {
            string userName = @"C:\Users\" + Environment.UserName;
            string folderName = userName + @"\AppData\Local\ADG TECH";
            string pathString = System.IO.Path.Combine(folderName, "OutlierData")+ @"\Outliers.csv";
            if(File.Exists(pathString))
            {
                dataGridView1.DataSource = ConvertCSVtoDataTable(pathString);
                dataGridView1.AutoResizeColumns();
                this.Text = "Showing dataset for " + pathString;
            }
            else
            {
             MessageBox.Show("Outlier report has not been generated please go to build Data Model",
             "Error",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error);
              
                this.Close();
            }

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

        private void FrmOutlier_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frmold = new frmMain();
            frmold.Show();
        }
    }
}
