namespace PropertyFinder
{
    partial class HostProperties
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
            this.Back_btn = new System.Windows.Forms.Button();
            this.hostproperties_dataGrid = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hostproperties_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "My Properties";
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(12, 9);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(81, 42);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // hostproperties_dataGrid
            // 
            this.hostproperties_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostproperties_dataGrid.Location = new System.Drawing.Point(12, 117);
            this.hostproperties_dataGrid.Name = "hostproperties_dataGrid";
            this.hostproperties_dataGrid.RowHeadersWidth = 51;
            this.hostproperties_dataGrid.RowTemplate.Height = 24;
            this.hostproperties_dataGrid.Size = new System.Drawing.Size(853, 261);
            this.hostproperties_dataGrid.TabIndex = 5;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(344, 405);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(139, 50);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // HostProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(874, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.hostproperties_dataGrid);
            this.Controls.Add(this.save_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HostProperties";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HostProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostproperties_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.DataGridView hostproperties_dataGrid;
        private System.Windows.Forms.Button save_btn;
    }
}