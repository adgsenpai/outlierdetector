namespace ADG_AI_OUTLIER_DETECTOR
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnReport = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBuild = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblCSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnView = new Bunifu.Framework.UI.BunifuTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Interval = 1000;
            this.tmrDateTime.Tick += new System.EventHandler(this.TmrDateTime_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.btnReport);
            this.bunifuGradientPanel1.Controls.Add(this.btnBuild);
            this.bunifuGradientPanel1.Controls.Add(this.lblCSV);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTileButton3);
            this.bunifuGradientPanel1.Controls.Add(this.lblDay);
            this.bunifuGradientPanel1.Controls.Add(this.lblDateTime);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnView);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1016, 547);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BunifuGradientPanel1_Paint);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.color = System.Drawing.Color.ForestGreen;
            this.btnReport.colorActive = System.Drawing.Color.PaleVioletRed;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::ADG_AI_OUTLIER_DETECTOR.Properties.Resources.large_data_set;
            this.btnReport.ImagePosition = 15;
            this.btnReport.ImageZoom = 50;
            this.btnReport.LabelPosition = 31;
            this.btnReport.LabelText = "View Outlier Report";
            this.btnReport.Location = new System.Drawing.Point(422, 140);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(225, 147);
            this.btnReport.TabIndex = 12;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuild.color = System.Drawing.Color.RoyalBlue;
            this.btnBuild.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuild.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBuild.ForeColor = System.Drawing.Color.White;
            this.btnBuild.Image = global::ADG_AI_OUTLIER_DETECTOR.Properties.Resources.clustering;
            this.btnBuild.ImagePosition = 20;
            this.btnBuild.ImageZoom = 50;
            this.btnBuild.LabelPosition = 41;
            this.btnBuild.LabelText = "Model Builder";
            this.btnBuild.Location = new System.Drawing.Point(209, 140);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(210, 147);
            this.btnBuild.TabIndex = 10;
            this.btnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.BackColor = System.Drawing.Color.Transparent;
            this.lblCSV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSV.ForeColor = System.Drawing.Color.Lime;
            this.lblCSV.Location = new System.Drawing.Point(35, 472);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(146, 23);
            this.lblCSV.TabIndex = 9;
            this.lblCSV.Text = "loaded .csv   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pre-Alpha 0.0.1";
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTileButton3.color = System.Drawing.Color.RoyalBlue;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.LightSkyBlue;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::ADG_AI_OUTLIER_DETECTOR.Properties.Resources.onnx;
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Settings";
            this.bunifuTileButton3.Location = new System.Drawing.Point(39, 289);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(179, 156);
            this.bunifuTileButton3.TabIndex = 7;
            this.bunifuTileButton3.Click += new System.EventHandler(this.BunifuTileButton3_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(777, 244);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(49, 23);
            this.lblDay.TabIndex = 6;
            this.lblDay.Text = "day";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblDateTime.Location = new System.Drawing.Point(778, 216);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(62, 17);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "datetime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADG_AI_OUTLIER_DETECTOR.Properties.Resources.ai_loader_opt;
            this.pictureBox1.Location = new System.Drawing.Point(781, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Crimson;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnView.color = System.Drawing.Color.Crimson;
            this.btnView.colorActive = System.Drawing.Color.PaleVioletRed;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = global::ADG_AI_OUTLIER_DETECTOR.Properties.Resources.large_data_set;
            this.btnView.ImagePosition = 20;
            this.btnView.ImageZoom = 50;
            this.btnView.LabelPosition = 41;
            this.btnView.LabelText = "View Data Field";
            this.btnView.Location = new System.Drawing.Point(39, 140);
            this.btnView.Margin = new System.Windows.Forms.Padding(6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(167, 147);
            this.btnView.TabIndex = 3;
            this.btnView.Click += new System.EventHandler(this.BunifuTileButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "What would you like to do?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi welcome to ADG AI OUTLIER DETECTOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(649, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Warning this is not the final product";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 547);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADG AI PROGRAM";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btnView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label lblDay;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCSV;
        private Bunifu.Framework.UI.BunifuTileButton btnBuild;
        private Bunifu.Framework.UI.BunifuTileButton btnReport;
        private System.Windows.Forms.Label label4;
    }
}

