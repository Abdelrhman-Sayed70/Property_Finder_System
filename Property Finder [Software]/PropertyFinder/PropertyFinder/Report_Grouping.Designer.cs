
namespace PropertyFinder
{
    partial class Report_Grouping
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.logout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 62);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1119, 478);
            this.crystalReportViewer1.TabIndex = 12;
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::PropertyFinder.Properties.Resources.PikPng_com_logout_png_5199120__2_;
            this.logout.Location = new System.Drawing.Point(12, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(123, 33);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 42;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Report_Grouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1121, 542);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report_Grouping";
            this.Text = "Report_Grouping";
            this.Load += new System.EventHandler(this.Report_Grouping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox logout;
    }
}