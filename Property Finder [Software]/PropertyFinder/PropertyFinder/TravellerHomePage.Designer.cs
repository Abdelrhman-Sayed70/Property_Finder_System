namespace PropertyFinder
{
    partial class TravellerHomePage
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
            this.Properties_datagrid = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.Rent_chkBox = new System.Windows.Forms.CheckBox();
            this.buy_chkBox = new System.Windows.Forms.CheckBox();
            this.Villa_btn = new System.Windows.Forms.RadioButton();
            this.Appartement_btn = new System.Windows.Forms.RadioButton();
            this.land_btn = new System.Windows.Forms.RadioButton();
            this.House_btn = new System.Windows.Forms.RadioButton();
            this.rooms_cmboBox = new System.Windows.Forms.ComboBox();
            this.rooms_lbl = new System.Windows.Forms.Label();
            this.location_comboBox = new System.Windows.Forms.ComboBox();
            this.locations_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.price_txtBox = new System.Windows.Forms.TextBox();
            this.completeprocess_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.balance_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Properties_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Properties_datagrid
            // 
            this.Properties_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Properties_datagrid.Location = new System.Drawing.Point(17, 167);
            this.Properties_datagrid.Margin = new System.Windows.Forms.Padding(4);
            this.Properties_datagrid.Name = "Properties_datagrid";
            this.Properties_datagrid.RowHeadersWidth = 51;
            this.Properties_datagrid.RowTemplate.Height = 24;
            this.Properties_datagrid.Size = new System.Drawing.Size(925, 302);
            this.Properties_datagrid.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(412, 476);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(109, 39);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // Rent_chkBox
            // 
            this.Rent_chkBox.AutoSize = true;
            this.Rent_chkBox.Location = new System.Drawing.Point(17, 90);
            this.Rent_chkBox.Name = "Rent_chkBox";
            this.Rent_chkBox.Size = new System.Drawing.Size(89, 33);
            this.Rent_chkBox.TabIndex = 2;
            this.Rent_chkBox.Text = "Rent";
            this.Rent_chkBox.UseVisualStyleBackColor = true;
            // 
            // buy_chkBox
            // 
            this.buy_chkBox.AutoSize = true;
            this.buy_chkBox.Location = new System.Drawing.Point(97, 90);
            this.buy_chkBox.Name = "buy_chkBox";
            this.buy_chkBox.Size = new System.Drawing.Size(79, 33);
            this.buy_chkBox.TabIndex = 2;
            this.buy_chkBox.Text = "Buy";
            this.buy_chkBox.UseVisualStyleBackColor = true;
            // 
            // Villa_btn
            // 
            this.Villa_btn.AutoSize = true;
            this.Villa_btn.Location = new System.Drawing.Point(588, 83);
            this.Villa_btn.Name = "Villa_btn";
            this.Villa_btn.Size = new System.Drawing.Size(84, 33);
            this.Villa_btn.TabIndex = 3;
            this.Villa_btn.TabStop = true;
            this.Villa_btn.Text = "Villa";
            this.Villa_btn.UseVisualStyleBackColor = true;
            // 
            // Appartement_btn
            // 
            this.Appartement_btn.AutoSize = true;
            this.Appartement_btn.Location = new System.Drawing.Point(673, 83);
            this.Appartement_btn.Name = "Appartement_btn";
            this.Appartement_btn.Size = new System.Drawing.Size(175, 33);
            this.Appartement_btn.TabIndex = 3;
            this.Appartement_btn.TabStop = true;
            this.Appartement_btn.Text = "Appartement";
            this.Appartement_btn.UseVisualStyleBackColor = true;
            // 
            // land_btn
            // 
            this.land_btn.AutoSize = true;
            this.land_btn.Location = new System.Drawing.Point(588, 120);
            this.land_btn.Name = "land_btn";
            this.land_btn.Size = new System.Drawing.Size(91, 33);
            this.land_btn.TabIndex = 3;
            this.land_btn.TabStop = true;
            this.land_btn.Text = "Land";
            this.land_btn.UseVisualStyleBackColor = true;
            // 
            // House_btn
            // 
            this.House_btn.AutoSize = true;
            this.House_btn.Location = new System.Drawing.Point(673, 118);
            this.House_btn.Name = "House_btn";
            this.House_btn.Size = new System.Drawing.Size(108, 33);
            this.House_btn.TabIndex = 3;
            this.House_btn.TabStop = true;
            this.House_btn.Text = "House";
            this.House_btn.UseVisualStyleBackColor = true;
            // 
            // rooms_cmboBox
            // 
            this.rooms_cmboBox.FormattingEnabled = true;
            this.rooms_cmboBox.Items.AddRange(new object[] {
            "All"});
            this.rooms_cmboBox.Location = new System.Drawing.Point(236, 90);
            this.rooms_cmboBox.Name = "rooms_cmboBox";
            this.rooms_cmboBox.Size = new System.Drawing.Size(68, 37);
            this.rooms_cmboBox.TabIndex = 4;
            // 
            // rooms_lbl
            // 
            this.rooms_lbl.AutoSize = true;
            this.rooms_lbl.Location = new System.Drawing.Point(231, 52);
            this.rooms_lbl.Name = "rooms_lbl";
            this.rooms_lbl.Size = new System.Drawing.Size(90, 29);
            this.rooms_lbl.TabIndex = 5;
            this.rooms_lbl.Text = "Rooms";
            // 
            // location_comboBox
            // 
            this.location_comboBox.FormattingEnabled = true;
            this.location_comboBox.Items.AddRange(new object[] {
            "All"});
            this.location_comboBox.Location = new System.Drawing.Point(335, 90);
            this.location_comboBox.Name = "location_comboBox";
            this.location_comboBox.Size = new System.Drawing.Size(102, 37);
            this.location_comboBox.TabIndex = 4;
            // 
            // locations_lbl
            // 
            this.locations_lbl.AutoSize = true;
            this.locations_lbl.Location = new System.Drawing.Point(330, 52);
            this.locations_lbl.Name = "locations_lbl";
            this.locations_lbl.Size = new System.Drawing.Size(116, 29);
            this.locations_lbl.TabIndex = 5;
            this.locations_lbl.Text = "Locations";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(450, 52);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(119, 29);
            this.price_lbl.TabIndex = 5;
            this.price_lbl.Text = "Max Price";
            // 
            // price_txtBox
            // 
            this.price_txtBox.Location = new System.Drawing.Point(455, 93);
            this.price_txtBox.Name = "price_txtBox";
            this.price_txtBox.Size = new System.Drawing.Size(86, 35);
            this.price_txtBox.TabIndex = 6;
            this.price_txtBox.Text = "0";
            // 
            // completeprocess_btn
            // 
            this.completeprocess_btn.Location = new System.Drawing.Point(373, 533);
            this.completeprocess_btn.Name = "completeprocess_btn";
            this.completeprocess_btn.Size = new System.Drawing.Size(189, 39);
            this.completeprocess_btn.TabIndex = 1;
            this.completeprocess_btn.Text = "Complete Process";
            this.completeprocess_btn.UseVisualStyleBackColor = true;
            this.completeprocess_btn.Click += new System.EventHandler(this.completeprocess_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(12, 593);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(109, 39);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // balance_btn
            // 
            this.balance_btn.Location = new System.Drawing.Point(794, 593);
            this.balance_btn.Name = "balance_btn";
            this.balance_btn.Size = new System.Drawing.Size(161, 39);
            this.balance_btn.TabIndex = 21;
            this.balance_btn.Text = "My Balance";
            this.balance_btn.UseVisualStyleBackColor = true;
            this.balance_btn.Click += new System.EventHandler(this.balance_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filter Your Choic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Property Market Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Property Name";
            // 
            // TravellerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balance_btn);
            this.Controls.Add(this.price_txtBox);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.locations_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rooms_lbl);
            this.Controls.Add(this.location_comboBox);
            this.Controls.Add(this.rooms_cmboBox);
            this.Controls.Add(this.House_btn);
            this.Controls.Add(this.land_btn);
            this.Controls.Add(this.Appartement_btn);
            this.Controls.Add(this.Villa_btn);
            this.Controls.Add(this.buy_chkBox);
            this.Controls.Add(this.Rent_chkBox);
            this.Controls.Add(this.completeprocess_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.Properties_datagrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TravellerHomePage";
            this.Text = "TravellerHomePage";
            this.Load += new System.EventHandler(this.TravellerHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Properties_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Properties_datagrid;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.CheckBox Rent_chkBox;
        private System.Windows.Forms.CheckBox buy_chkBox;
        private System.Windows.Forms.RadioButton Villa_btn;
        private System.Windows.Forms.RadioButton Appartement_btn;
        private System.Windows.Forms.RadioButton land_btn;
        private System.Windows.Forms.RadioButton House_btn;
        private System.Windows.Forms.ComboBox rooms_cmboBox;
        private System.Windows.Forms.Label rooms_lbl;
        private System.Windows.Forms.ComboBox location_comboBox;
        private System.Windows.Forms.Label locations_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.TextBox price_txtBox;
        private System.Windows.Forms.Button completeprocess_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button balance_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}