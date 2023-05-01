
namespace PropertyFinder
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_report_grouping = new System.Windows.Forms.Button();
            this.button_report_summary = new System.Windows.Forms.Button();
            this.button_report_formula = new System.Windows.Forms.Button();
            this.button_report_parametar = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(339, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // button_report_grouping
            // 
            this.button_report_grouping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_report_grouping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_report_grouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_grouping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.button_report_grouping.Location = new System.Drawing.Point(319, 185);
            this.button_report_grouping.Name = "button_report_grouping";
            this.button_report_grouping.Size = new System.Drawing.Size(465, 66);
            this.button_report_grouping.TabIndex = 1;
            this.button_report_grouping.Text = "Report Grouping";
            this.button_report_grouping.UseVisualStyleBackColor = true;
            this.button_report_grouping.Click += new System.EventHandler(this.button_report_grouping_Click);
            // 
            // button_report_summary
            // 
            this.button_report_summary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_report_summary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_report_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_summary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.button_report_summary.Location = new System.Drawing.Point(319, 269);
            this.button_report_summary.Name = "button_report_summary";
            this.button_report_summary.Size = new System.Drawing.Size(465, 66);
            this.button_report_summary.TabIndex = 2;
            this.button_report_summary.Text = "Report Summary";
            this.button_report_summary.UseVisualStyleBackColor = true;
            this.button_report_summary.Click += new System.EventHandler(this.button_report_summary_Click);
            // 
            // button_report_formula
            // 
            this.button_report_formula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_report_formula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_report_formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_formula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.button_report_formula.Location = new System.Drawing.Point(319, 354);
            this.button_report_formula.Name = "button_report_formula";
            this.button_report_formula.Size = new System.Drawing.Size(465, 66);
            this.button_report_formula.TabIndex = 3;
            this.button_report_formula.Text = "Report Formula";
            this.button_report_formula.UseVisualStyleBackColor = true;
            this.button_report_formula.Click += new System.EventHandler(this.button_report_formula_Click);
            // 
            // button_report_parametar
            // 
            this.button_report_parametar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_report_parametar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_report_parametar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_parametar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.button_report_parametar.Location = new System.Drawing.Point(319, 435);
            this.button_report_parametar.Name = "button_report_parametar";
            this.button_report_parametar.Size = new System.Drawing.Size(465, 66);
            this.button_report_parametar.TabIndex = 4;
            this.button_report_parametar.Text = "Report Parameter";
            this.button_report_parametar.UseVisualStyleBackColor = true;
            this.button_report_parametar.Click += new System.EventHandler(this.button_report_parametar_Click);
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::PropertyFinder.Properties.Resources.PikPng_com_logout_png_5199120__2_;
            this.logout.Location = new System.Drawing.Point(12, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(123, 33);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 41;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(932, 542);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.button_report_parametar);
            this.Controls.Add(this.button_report_formula);
            this.Controls.Add(this.button_report_summary);
            this.Controls.Add(this.button_report_grouping);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_report_grouping;
        private System.Windows.Forms.Button button_report_summary;
        private System.Windows.Forms.Button button_report_formula;
        private System.Windows.Forms.Button button_report_parametar;
        private System.Windows.Forms.PictureBox logout;
    }
}