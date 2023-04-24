namespace PropertyFinder
{
    partial class Host_Properties
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
            this.save_btn = new System.Windows.Forms.Button();
            this.hostproperties_dataGrid = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hostproperties_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(415, 370);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(132, 50);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // hostproperties_dataGrid
            // 
            this.hostproperties_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostproperties_dataGrid.Location = new System.Drawing.Point(186, 80);
            this.hostproperties_dataGrid.Name = "hostproperties_dataGrid";
            this.hostproperties_dataGrid.RowHeadersWidth = 51;
            this.hostproperties_dataGrid.RowTemplate.Height = 24;
            this.hostproperties_dataGrid.Size = new System.Drawing.Size(588, 261);
            this.hostproperties_dataGrid.TabIndex = 1;
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(127, 45);
            this.Back_btn.TabIndex = 2;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            // 
            // Host_Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 470);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.hostproperties_dataGrid);
            this.Controls.Add(this.save_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Host_Properties";
            this.Text = "Host_Properties";
            this.Load += new System.EventHandler(this.Host_Properties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostproperties_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DataGridView hostproperties_dataGrid;
        private System.Windows.Forms.Button Back_btn;
    }
}