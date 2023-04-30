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
            this.signin_lbl = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.ForeColor = System.Drawing.Color.White;
            this.username_lbl.Location = new System.Drawing.Point(13, 163);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(124, 29);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username";
            // 
            // username_txtBox
            // 
            this.username_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.username_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_txtBox.ForeColor = System.Drawing.Color.White;
            this.username_txtBox.Location = new System.Drawing.Point(140, 161);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(301, 34);
            this.username_txtBox.TabIndex = 1;
            this.username_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_txtBox_KeyPress_1);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.ForeColor = System.Drawing.Color.White;
            this.password_lbl.Location = new System.Drawing.Point(19, 221);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(120, 29);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password";
            // 
            // password_txtBox
            // 
            this.password_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.password_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txtBox.ForeColor = System.Drawing.Color.White;
            this.password_txtBox.Location = new System.Drawing.Point(142, 218);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(299, 34);
            this.password_txtBox.TabIndex = 1;
            this.password_txtBox.TextChanged += new System.EventHandler(this.password_txtBox_TextChanged);
            // 
            // showpassword_chkBox
            // 
            this.showpassword_chkBox.AutoSize = true;
            this.showpassword_chkBox.Checked = true;
            this.showpassword_chkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showpassword_chkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword_chkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.showpassword_chkBox.Location = new System.Drawing.Point(369, 258);
            this.showpassword_chkBox.Name = "showpassword_chkBox";
            this.showpassword_chkBox.Size = new System.Drawing.Size(72, 24);
            this.showpassword_chkBox.TabIndex = 2;
            this.showpassword_chkBox.Text = "Show";
            this.showpassword_chkBox.UseVisualStyleBackColor = true;
            this.showpassword_chkBox.CheckedChanged += new System.EventHandler(this.showpassword_chkBox_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(18, 308);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(423, 48);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(85, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Don\'t have an account !\r\n";
            // 
            // signin_lbl
            // 
            this.signin_lbl.AutoSize = true;
            this.signin_lbl.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_lbl.ForeColor = System.Drawing.Color.White;
            this.signin_lbl.Location = new System.Drawing.Point(81, 9);
            this.signin_lbl.Name = "signin_lbl";
            this.signin_lbl.Size = new System.Drawing.Size(320, 114);
            this.signin_lbl.TabIndex = 0;
            this.signin_lbl.Text = "Login";
            // 
            // signup_btn
            // 
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.signup_btn.Location = new System.Drawing.Point(277, 417);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(124, 22);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "Create Account";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(465, 516);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.showpassword_chkBox);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signin_lbl);
            this.Controls.Add(this.username_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LogInPage";
            this.Text = "Property Finder System";
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
        private System.Windows.Forms.Label signin_lbl;
        private System.Windows.Forms.Button signup_btn;
    }
}

