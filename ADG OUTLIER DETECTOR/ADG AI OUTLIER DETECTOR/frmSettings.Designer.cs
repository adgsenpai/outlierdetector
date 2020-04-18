namespace ADG_AI_OUTLIER_DETECTOR
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.edtDirectory = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSelect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel1.Controls.Add(this.btnSelect);
            this.bunifuGradientPanel1.Controls.Add(this.edtDirectory);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(607, 207);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the directory which your data file is stored at.";
            // 
            // edtDirectory
            // 
            this.edtDirectory.BorderColorFocused = System.Drawing.Color.Blue;
            this.edtDirectory.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edtDirectory.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.edtDirectory.BorderThickness = 3;
            this.edtDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDirectory.Enabled = false;
            this.edtDirectory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.edtDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edtDirectory.isPassword = false;
            this.edtDirectory.Location = new System.Drawing.Point(23, 75);
            this.edtDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.edtDirectory.Name = "edtDirectory";
            this.edtDirectory.Size = new System.Drawing.Size(513, 41);
            this.edtDirectory.TabIndex = 4;
            this.edtDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSelect
            // 
            this.btnSelect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.BorderRadius = 0;
            this.btnSelect.ButtonText = "Submit";
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.DisabledColor = System.Drawing.Color.Gray;
            this.btnSelect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelect.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSelect.Iconimage")));
            this.btnSelect.Iconimage_right = null;
            this.btnSelect.Iconimage_right_Selected = null;
            this.btnSelect.Iconimage_Selected = null;
            this.btnSelect.IconMarginLeft = 0;
            this.btnSelect.IconMarginRight = 0;
            this.btnSelect.IconRightVisible = true;
            this.btnSelect.IconRightZoom = 0D;
            this.btnSelect.IconVisible = true;
            this.btnSelect.IconZoom = 90D;
            this.btnSelect.IsTab = false;
            this.btnSelect.Location = new System.Drawing.Point(441, 143);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSelect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelect.selected = false;
            this.btnSelect.Size = new System.Drawing.Size(149, 42);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Submit";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Textcolor = System.Drawing.Color.White;
            this.btnSelect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "...";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(537, 75);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(53, 42);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 207);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Directory";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelect;
        private Bunifu.Framework.UI.BunifuMetroTextbox edtDirectory;
    }
}