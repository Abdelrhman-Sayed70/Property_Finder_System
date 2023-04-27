namespace PropertyFinder
{
    partial class LogInPage
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.showpassword_chkBox = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.systemname = new System.Windows.Forms.Label();
            this.signin_lbl = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.username_lbl.Location = new System.Drawing.Point(7, 119);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(124, 29);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username";
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(12, 151);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(211, 34);
            this.username_txtBox.TabIndex = 1;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.password_lbl.Location = new System.Drawing.Point(7, 197);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(120, 29);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password";
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(12, 229);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(211, 34);
            this.password_txtBox.TabIndex = 1;
            this.password_txtBox.TextChanged += new System.EventHandler(this.password_txtBox_TextChanged);
            // 
            // showpassword_chkBox
            // 
            this.showpassword_chkBox.AutoSize = true;
            this.showpassword_chkBox.Location = new System.Drawing.Point(229, 231);
            this.showpassword_chkBox.Name = "showpassword_chkBox";
            this.showpassword_chkBox.Size = new System.Drawing.Size(96, 33);
            this.showpassword_chkBox.TabIndex = 2;
            this.showpassword_chkBox.Text = "Show";
            this.showpassword_chkBox.UseVisualStyleBackColor = true;
            this.showpassword_chkBox.CheckedChanged += new System.EventHandler(this.showpassword_chkBox_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(165, 322);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(95, 38);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(85, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Don\'t hava an account !\r\n";
            // 
            // systemname
            // 
            this.systemname.AutoSize = true;
            this.systemname.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemname.ForeColor = System.Drawing.Color.Blue;
            this.systemname.Location = new System.Drawing.Point(12, 9);
            this.systemname.Name = "systemname";
            this.systemname.Size = new System.Drawing.Size(435, 50);
            this.systemname.TabIndex = 0;
            this.systemname.Text = "Property Finder System";
            // 
            // signin_lbl
            // 
            this.signin_lbl.AutoSize = true;
            this.signin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.signin_lbl.Location = new System.Drawing.Point(193, 59);
            this.signin_lbl.Name = "signin_lbl";
            this.signin_lbl.Size = new System.Drawing.Size(90, 32);
            this.signin_lbl.TabIndex = 0;
            this.signin_lbl.Text = "Login";
            // 
            // signup_btn
            // 
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(139, 451);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(144, 37);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "Create Account";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 516);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.showpassword_chkBox);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.systemname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signin_lbl);
            this.Controls.Add(this.username_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LogInPage";
            this.Text = "LogInPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInPage_FormClosing);
            this.Load += new System.EventHandler(this.LogInPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.CheckBox showpassword_chkBox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label systemname;
        private System.Windows.Forms.Label signin_lbl;
        private System.Windows.Forms.Button signup_btn;
    }
}

