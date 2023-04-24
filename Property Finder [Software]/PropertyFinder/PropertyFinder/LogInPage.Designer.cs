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
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(12, 95);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(130, 29);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "User name";
            // 
            // username_txtBox
            // 
            this.username_txtBox.Location = new System.Drawing.Point(17, 127);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(281, 34);
            this.username_txtBox.TabIndex = 1;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(12, 183);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(120, 29);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password";
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(17, 215);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(281, 34);
            this.password_txtBox.TabIndex = 1;
            // 
            // showpassword_chkBox
            // 
            this.showpassword_chkBox.AutoSize = true;
            this.showpassword_chkBox.Location = new System.Drawing.Point(304, 217);
            this.showpassword_chkBox.Name = "showpassword_chkBox";
            this.showpassword_chkBox.Size = new System.Drawing.Size(96, 33);
            this.showpassword_chkBox.TabIndex = 2;
            this.showpassword_chkBox.Text = "Show";
            this.showpassword_chkBox.UseVisualStyleBackColor = true;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(144, 298);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(95, 38);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Don\'t hava an account !\r\n";
            // 
            // createaccount_lbl
            // 
            this.createaccount_lbl.AutoSize = true;
            this.createaccount_lbl.Location = new System.Drawing.Point(102, 417);
            this.createaccount_lbl.Name = "createaccount_lbl";
            this.createaccount_lbl.Size = new System.Drawing.Size(176, 29);
            this.createaccount_lbl.TabIndex = 0;
            this.createaccount_lbl.Text = "Create Account";
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 554);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.showpassword_chkBox);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.createaccount_lbl);
            this.Controls.Add(this.label1);
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
    }
}

