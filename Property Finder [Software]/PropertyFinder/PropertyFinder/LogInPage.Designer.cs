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
            this.createaccount_lbl = new System.Windows.Forms.Label();
            this.systemname = new System.Windows.Forms.Label();
            this.signin_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(230, 148);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(124, 29);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username";
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(235, 180);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(281, 34);
            this.username_txtBox.TabIndex = 1;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(230, 226);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(120, 29);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password";
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(235, 258);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(281, 34);
            this.password_txtBox.TabIndex = 1;
            this.password_txtBox.TextChanged += new System.EventHandler(this.password_txtBox_TextChanged);
            // 
            // showpassword_chkBox
            // 
            this.showpassword_chkBox.AutoSize = true;
            this.showpassword_chkBox.Location = new System.Drawing.Point(522, 260);
            this.showpassword_chkBox.Name = "showpassword_chkBox";
            this.showpassword_chkBox.Size = new System.Drawing.Size(96, 33);
            this.showpassword_chkBox.TabIndex = 2;
            this.showpassword_chkBox.Text = "Show";
            this.showpassword_chkBox.UseVisualStyleBackColor = true;
            this.showpassword_chkBox.CheckedChanged += new System.EventHandler(this.showpassword_chkBox_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(351, 344);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(95, 38);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Don\'t hava an account !\r\n";
            // 
            // createaccount_lbl
            // 
            this.createaccount_lbl.AutoSize = true;
            this.createaccount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccount_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.createaccount_lbl.Location = new System.Drawing.Point(290, 425);
            this.createaccount_lbl.Name = "createaccount_lbl";
            this.createaccount_lbl.Size = new System.Drawing.Size(190, 29);
            this.createaccount_lbl.TabIndex = 0;
            this.createaccount_lbl.Text = "Create Account";
            // 
            // systemname
            // 
            this.systemname.AutoSize = true;
            this.systemname.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemname.ForeColor = System.Drawing.Color.Blue;
            this.systemname.Location = new System.Drawing.Point(199, 9);
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
            this.signin_lbl.Location = new System.Drawing.Point(356, 86);
            this.signin_lbl.Name = "signin_lbl";
            this.signin_lbl.Size = new System.Drawing.Size(90, 32);
            this.signin_lbl.TabIndex = 0;
            this.signin_lbl.Text = "Login";
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 606);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.showpassword_chkBox);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.createaccount_lbl);
            this.Controls.Add(this.systemname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signin_lbl);
            this.Controls.Add(this.username_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LogInPage";
            this.Text = "LogInPage";
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
        private System.Windows.Forms.Label createaccount_lbl;
        private System.Windows.Forms.Label systemname;
        private System.Windows.Forms.Label signin_lbl;
    }
}

