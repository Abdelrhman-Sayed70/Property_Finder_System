namespace PropertyFinder
{
    partial class SignUpPage
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
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.phonenumber_txtBox = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.phonenumber_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.usertype_lbl = new System.Windows.Forms.Label();
            this.traveller_btn = new System.Windows.Forms.RadioButton();
            this.host_btn = new System.Windows.Forms.RadioButton();
            this.signin_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.systemname = new System.Windows.Forms.Label();
            this.showpassword_chkBox = new System.Windows.Forms.CheckBox();
            this.signin_bnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(13, 115);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(197, 30);
            this.username_txtBox.TabIndex = 0;
            this.username_txtBox.TextChanged += new System.EventHandler(this.username_txtBox_TextChanged);
            this.username_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_txtBox_KeyPress);
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(12, 407);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(198, 30);
            this.password_txtBox.TabIndex = 0;
            this.password_txtBox.TextChanged += new System.EventHandler(this.password_txtBox_TextChanged);
            this.password_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_txtBox_KeyPress);
            // 
            // phonenumber_txtBox
            // 
            this.phonenumber_txtBox.Location = new System.Drawing.Point(12, 346);
            this.phonenumber_txtBox.Name = "phonenumber_txtBox";
            this.phonenumber_txtBox.Size = new System.Drawing.Size(197, 30);
            this.phonenumber_txtBox.TabIndex = 0;
            this.phonenumber_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonenumber_txtBox_KeyPress);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(8, 90);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(110, 25);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "User Name";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(7, 379);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(98, 25);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password";
            // 
            // email_txtBox
            // 
            this.email_txtBox.Location = new System.Drawing.Point(13, 178);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.Size = new System.Drawing.Size(197, 30);
            this.email_txtBox.TabIndex = 0;
            this.email_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.email_txtBox_KeyPress);
            // 
            // phonenumber_lbl
            // 
            this.phonenumber_lbl.AutoSize = true;
            this.phonenumber_lbl.Location = new System.Drawing.Point(7, 318);
            this.phonenumber_lbl.Name = "phonenumber_lbl";
            this.phonenumber_lbl.Size = new System.Drawing.Size(143, 25);
            this.phonenumber_lbl.TabIndex = 1;
            this.phonenumber_lbl.Text = "Phone Number";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(8, 150);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(60, 25);
            this.email_lbl.TabIndex = 1;
            this.email_lbl.Text = "Email";
            // 
            // signup_btn
            // 
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_btn.Location = new System.Drawing.Point(121, 484);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(165, 44);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // usertype_lbl
            // 
            this.usertype_lbl.AutoSize = true;
            this.usertype_lbl.Location = new System.Drawing.Point(8, 233);
            this.usertype_lbl.Name = "usertype_lbl";
            this.usertype_lbl.Size = new System.Drawing.Size(103, 25);
            this.usertype_lbl.TabIndex = 1;
            this.usertype_lbl.Text = "User Type";
            this.usertype_lbl.Click += new System.EventHandler(this.usertype_lbl_Click);
            // 
            // traveller_btn
            // 
            this.traveller_btn.AutoSize = true;
            this.traveller_btn.Location = new System.Drawing.Point(13, 261);
            this.traveller_btn.Name = "traveller_btn";
            this.traveller_btn.Size = new System.Drawing.Size(109, 29);
            this.traveller_btn.TabIndex = 4;
            this.traveller_btn.TabStop = true;
            this.traveller_btn.Text = "Traveller";
            this.traveller_btn.UseVisualStyleBackColor = true;
            // 
            // host_btn
            // 
            this.host_btn.AutoSize = true;
            this.host_btn.Location = new System.Drawing.Point(128, 261);
            this.host_btn.Name = "host_btn";
            this.host_btn.Size = new System.Drawing.Size(73, 29);
            this.host_btn.TabIndex = 5;
            this.host_btn.TabStop = true;
            this.host_btn.Text = "Host";
            this.host_btn.UseVisualStyleBackColor = true;
            // 
            // signin_lbl
            // 
            this.signin_lbl.AutoSize = true;
            this.signin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.signin_lbl.Location = new System.Drawing.Point(176, 59);
            this.signin_lbl.Name = "signin_lbl";
            this.signin_lbl.Size = new System.Drawing.Size(110, 32);
            this.signin_lbl.TabIndex = 6;
            this.signin_lbl.Text = "Signup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Already have an account?";
            // 
            // systemname
            // 
            this.systemname.AutoSize = true;
            this.systemname.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemname.ForeColor = System.Drawing.Color.Blue;
            this.systemname.Location = new System.Drawing.Point(4, 9);
            this.systemname.Name = "systemname";
            this.systemname.Size = new System.Drawing.Size(435, 50);
            this.systemname.TabIndex = 7;
            this.systemname.Text = "Property Finder System";
            // 
            // showpassword_chkBox
            // 
            this.showpassword_chkBox.AutoSize = true;
            this.showpassword_chkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword_chkBox.Location = new System.Drawing.Point(216, 413);
            this.showpassword_chkBox.Name = "showpassword_chkBox";
            this.showpassword_chkBox.Size = new System.Drawing.Size(72, 24);
            this.showpassword_chkBox.TabIndex = 8;
            this.showpassword_chkBox.Text = "Show";
            this.showpassword_chkBox.UseVisualStyleBackColor = true;
            this.showpassword_chkBox.CheckedChanged += new System.EventHandler(this.showpassword_chkBox_CheckedChanged);
            // 
            // signin_bnt
            // 
            this.signin_bnt.Location = new System.Drawing.Point(138, 611);
            this.signin_bnt.Name = "signin_bnt";
            this.signin_bnt.Size = new System.Drawing.Size(104, 39);
            this.signin_bnt.TabIndex = 9;
            this.signin_bnt.Text = "Login";
            this.signin_bnt.UseVisualStyleBackColor = true;
            this.signin_bnt.Click += new System.EventHandler(this.signin_bnt_Click);
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 697);
            this.Controls.Add(this.signin_bnt);
            this.Controls.Add(this.showpassword_chkBox);
            this.Controls.Add(this.systemname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signin_lbl);
            this.Controls.Add(this.host_btn);
            this.Controls.Add(this.traveller_btn);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.phonenumber_lbl);
            this.Controls.Add(this.usertype_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.email_txtBox);
            this.Controls.Add(this.phonenumber_txtBox);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignUpPage";
            this.Text = "SignUpPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpPage_FormClosing);
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.TextBox phonenumber_txtBox;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox email_txtBox;
        private System.Windows.Forms.Label phonenumber_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label usertype_lbl;
        private System.Windows.Forms.RadioButton traveller_btn;
        private System.Windows.Forms.RadioButton host_btn;
        private System.Windows.Forms.Label signin_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label systemname;
        private System.Windows.Forms.CheckBox showpassword_chkBox;
        private System.Windows.Forms.Button signin_bnt;
    }
}