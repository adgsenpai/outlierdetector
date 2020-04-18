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
    public partial class frmDT : Form
    {
        public frmDT()
        {
            InitializeComponent();
        }

        private void FrmDT_Load(object sender, EventArgs e)
        {
            string userName = @"C:\Users\" + Environment.UserName;
            string folderName = userName + @"\AppData\Local\ADG TECH";
            string pathString = System.IO.Path.Combine(folderName, "settings");
            INIFile inif = new INIFile(pathString + @"\setting.ini");


            dataGridView1.DataSource = ConvertCSVtoDataTable(inif.Read("Database","Directory"));
            dataGridView1.AutoResizeColumns();
            this.Text = "Showing dataset for "+ inif.Read("Database", "Directory");




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

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
