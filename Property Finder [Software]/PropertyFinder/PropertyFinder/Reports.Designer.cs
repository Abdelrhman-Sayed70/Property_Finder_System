
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
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // button_report_grouping
            // 
            this.button_report_grouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_grouping.Location = new System.Drawing.Point(198, 141);
            this.button_report_grouping.Name = "button_report_grouping";
            this.button_report_grouping.Size = new System.Drawing.Size(386, 55);
            this.button_report_grouping.TabIndex = 1;
            this.button_report_grouping.Text = "Report Grouping";
            this.button_report_grouping.UseVisualStyleBackColor = true;
            this.button_report_grouping.Click += new System.EventHandler(this.button_report_grouping_Click);
            // 
            // button_report_summary
            // 
            this.button_report_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_summary.Location = new System.Drawing.Point(198, 211);
            this.button_report_summary.Name = "button_report_summary";
            this.button_report_summary.Size = new System.Drawing.Size(386, 55);
            this.button_report_summary.TabIndex = 2;
            this.button_report_summary.Text = "Report Summary";
            this.button_report_summary.UseVisualStyleBackColor = true;
            this.button_report_summary.Click += new System.EventHandler(this.button_report_summary_Click);
            // 
            // button_report_formula
            // 
            this.button_report_formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_formula.Location = new System.Drawing.Point(198, 282);
            this.button_report_formula.Name = "button_report_formula";
            this.button_report_formula.Size = new System.Drawing.Size(386, 55);
            this.button_report_formula.TabIndex = 3;
            this.button_report_formula.Text = "Report Formula";
            this.button_report_formula.UseVisualStyleBackColor = true;
            this.button_report_formula.Click += new System.EventHandler(this.button_report_formula_Click);
            // 
            // button_report_parametar
            // 
            this.button_report_parametar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report_parametar.Location = new System.Drawing.Point(198, 352);
            this.button_report_parametar.Name = "button_report_parametar";
            this.button_report_parametar.Size = new System.Drawing.Size(386, 55);
            this.button_report_parametar.TabIndex = 4;
            this.button_report_parametar.Text = "Report Parameter";
            this.button_report_parametar.UseVisualStyleBackColor = true;
            this.button_report_parametar.Click += new System.EventHandler(this.button_report_parametar_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(12, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_report_parametar);
            this.Controls.Add(this.button_report_formula);
            this.Controls.Add(this.button_report_summary);
            this.Controls.Add(this.button_report_grouping);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_report_grouping;
        private System.Windows.Forms.Button button_report_summary;
        private System.Windows.Forms.Button button_report_formula;
        private System.Windows.Forms.Button button_report_parametar;
        private System.Windows.Forms.Button button_back;
    }
}