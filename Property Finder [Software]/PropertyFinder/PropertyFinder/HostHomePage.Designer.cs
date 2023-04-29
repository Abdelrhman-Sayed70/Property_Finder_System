namespace PropertyFinder
{
    partial class HostHomePage
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
            this.addproperty_btn = new System.Windows.Forms.Button();
            this.myproperties_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.balance_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.price_txtBox = new System.Windows.Forms.TextBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.locations_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms_lbl = new System.Windows.Forms.Label();
            this.location_comboBox = new System.Windows.Forms.ComboBox();
            this.House_btn = new System.Windows.Forms.RadioButton();
            this.land_btn = new System.Windows.Forms.RadioButton();
            this.Appartement_btn = new System.Windows.Forms.RadioButton();
            this.Villa_btn = new System.Windows.Forms.RadioButton();
            this.buy_chkBox = new System.Windows.Forms.CheckBox();
            this.Rent_chkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addproperty_btn
            // 
            this.addproperty_btn.Location = new System.Drawing.Point(338, 219);
            this.addproperty_btn.Name = "addproperty_btn";
            this.addproperty_btn.Size = new System.Drawing.Size(168, 51);
            this.addproperty_btn.TabIndex = 19;
            this.addproperty_btn.Text = "Add Property";
            this.addproperty_btn.UseVisualStyleBackColor = true;
            this.addproperty_btn.Click += new System.EventHandler(this.addproperty_btn_Click);
            // 
            // myproperties_btn
            // 
            this.myproperties_btn.Location = new System.Drawing.Point(555, 455);
            this.myproperties_btn.Name = "myproperties_btn";
            this.myproperties_btn.Size = new System.Drawing.Size(197, 66);
            this.myproperties_btn.TabIndex = 19;
            this.myproperties_btn.Text = "My Properties";
            this.myproperties_btn.UseVisualStyleBackColor = true;
            this.myproperties_btn.Click += new System.EventHandler(this.my_prop_btn);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(17, 430);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(145, 47);
            this.logout_btn.TabIndex = 20;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // balance_btn
            // 
            this.balance_btn.Location = new System.Drawing.Point(780, 455);
            this.balance_btn.Name = "balance_btn";
            this.balance_btn.Size = new System.Drawing.Size(163, 66);
            this.balance_btn.TabIndex = 20;
            this.balance_btn.Text = "My Balance";
            this.balance_btn.UseVisualStyleBackColor = true;
            this.balance_btn.Click += new System.EventHandler(this.balance_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Property Market Type";
            // 
            // price_txtBox
            // 
            this.price_txtBox.Location = new System.Drawing.Point(455, 143);
            this.price_txtBox.Name = "price_txtBox";
            this.price_txtBox.Size = new System.Drawing.Size(86, 35);
            this.price_txtBox.TabIndex = 35;
            this.price_txtBox.TextChanged += new System.EventHandler(this.price_txtBox_TextChanged);
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(450, 102);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(69, 29);
            this.price_lbl.TabIndex = 31;
            this.price_lbl.Text = "Price";
            // 
            // locations_lbl
            // 
            this.locations_lbl.AutoSize = true;
            this.locations_lbl.Location = new System.Drawing.Point(330, 102);
            this.locations_lbl.Name = "locations_lbl";
            this.locations_lbl.Size = new System.Drawing.Size(116, 29);
            this.locations_lbl.TabIndex = 32;
            this.locations_lbl.Text = "Locations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Property Name";
            // 
            // rooms_lbl
            // 
            this.rooms_lbl.AutoSize = true;
            this.rooms_lbl.Location = new System.Drawing.Point(231, 102);
            this.rooms_lbl.Name = "rooms_lbl";
            this.rooms_lbl.Size = new System.Drawing.Size(90, 29);
            this.rooms_lbl.TabIndex = 34;
            this.rooms_lbl.Text = "Rooms";
            // 
            // location_comboBox
            // 
            this.location_comboBox.FormattingEnabled = true;
            this.location_comboBox.Location = new System.Drawing.Point(335, 140);
            this.location_comboBox.Name = "location_comboBox";
            this.location_comboBox.Size = new System.Drawing.Size(102, 37);
            this.location_comboBox.TabIndex = 29;
            this.location_comboBox.SelectedIndexChanged += new System.EventHandler(this.location_comboBox_SelectedIndexChanged);
            // 
            // House_btn
            // 
            this.House_btn.AutoSize = true;
            this.House_btn.Location = new System.Drawing.Point(673, 168);
            this.House_btn.Name = "House_btn";
            this.House_btn.Size = new System.Drawing.Size(108, 33);
            this.House_btn.TabIndex = 25;
            this.House_btn.TabStop = true;
            this.House_btn.Text = "House";
            this.House_btn.UseVisualStyleBackColor = true;
            this.House_btn.CheckedChanged += new System.EventHandler(this.House_btn_CheckedChanged);
            // 
            // land_btn
            // 
            this.land_btn.AutoSize = true;
            this.land_btn.Location = new System.Drawing.Point(588, 170);
            this.land_btn.Name = "land_btn";
            this.land_btn.Size = new System.Drawing.Size(91, 33);
            this.land_btn.TabIndex = 26;
            this.land_btn.TabStop = true;
            this.land_btn.Text = "Land";
            this.land_btn.UseVisualStyleBackColor = true;
            this.land_btn.CheckedChanged += new System.EventHandler(this.land_btn_CheckedChanged);
            // 
            // Appartement_btn
            // 
            this.Appartement_btn.AutoSize = true;
            this.Appartement_btn.Location = new System.Drawing.Point(673, 133);
            this.Appartement_btn.Name = "Appartement_btn";
            this.Appartement_btn.Size = new System.Drawing.Size(175, 33);
            this.Appartement_btn.TabIndex = 27;
            this.Appartement_btn.TabStop = true;
            this.Appartement_btn.Text = "Appartement";
            this.Appartement_btn.UseVisualStyleBackColor = true;
            this.Appartement_btn.CheckedChanged += new System.EventHandler(this.Appartement_btn_CheckedChanged);
            // 
            // Villa_btn
            // 
            this.Villa_btn.AutoSize = true;
            this.Villa_btn.Location = new System.Drawing.Point(588, 133);
            this.Villa_btn.Name = "Villa_btn";
            this.Villa_btn.Size = new System.Drawing.Size(84, 33);
            this.Villa_btn.TabIndex = 28;
            this.Villa_btn.TabStop = true;
            this.Villa_btn.Text = "Villa";
            this.Villa_btn.UseVisualStyleBackColor = true;
            this.Villa_btn.CheckedChanged += new System.EventHandler(this.Villa_btn_CheckedChanged);
            // 
            // buy_chkBox
            // 
            this.buy_chkBox.AutoSize = true;
            this.buy_chkBox.Location = new System.Drawing.Point(97, 140);
            this.buy_chkBox.Name = "buy_chkBox";
            this.buy_chkBox.Size = new System.Drawing.Size(79, 33);
            this.buy_chkBox.TabIndex = 23;
            this.buy_chkBox.Text = "Buy";
            this.buy_chkBox.UseVisualStyleBackColor = true;
            this.buy_chkBox.CheckedChanged += new System.EventHandler(this.buy_chkBox_CheckedChanged);
            // 
            // Rent_chkBox
            // 
            this.Rent_chkBox.AutoSize = true;
            this.Rent_chkBox.Location = new System.Drawing.Point(17, 140);
            this.Rent_chkBox.Name = "Rent_chkBox";
            this.Rent_chkBox.Size = new System.Drawing.Size(89, 33);
            this.Rent_chkBox.TabIndex = 24;
            this.Rent_chkBox.Text = "Rent";
            this.Rent_chkBox.UseVisualStyleBackColor = true;
            this.Rent_chkBox.CheckedChanged += new System.EventHandler(this.Rent_chkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Add Property Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HostHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(979, 631);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_txtBox);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.locations_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rooms_lbl);
            this.Controls.Add(this.location_comboBox);
            this.Controls.Add(this.House_btn);
            this.Controls.Add(this.land_btn);
            this.Controls.Add(this.Appartement_btn);
            this.Controls.Add(this.Villa_btn);
            this.Controls.Add(this.buy_chkBox);
            this.Controls.Add(this.Rent_chkBox);
            this.Controls.Add(this.balance_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.myproperties_btn);
            this.Controls.Add(this.addproperty_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HostHomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "HostHomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HostHomePage_FormClosing);
            this.Load += new System.EventHandler(this.HostHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addproperty_btn;
        private System.Windows.Forms.Button myproperties_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button balance_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_txtBox;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label locations_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rooms_lbl;
        private System.Windows.Forms.ComboBox location_comboBox;
        private System.Windows.Forms.RadioButton House_btn;
        private System.Windows.Forms.RadioButton land_btn;
        private System.Windows.Forms.RadioButton Appartement_btn;
        private System.Windows.Forms.RadioButton Villa_btn;
        private System.Windows.Forms.CheckBox buy_chkBox;
        private System.Windows.Forms.CheckBox Rent_chkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}