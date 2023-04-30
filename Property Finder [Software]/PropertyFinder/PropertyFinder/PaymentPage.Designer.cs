namespace PropertyFinder
{
    partial class PaymentPage
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
            this.creditcard_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.pay_btn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credit Card ID";
            // 
            // creditcard_txtBox
            // 
            this.creditcard_txtBox.Location = new System.Drawing.Point(496, 183);
            this.creditcard_txtBox.Name = "creditcard_txtBox";
            this.creditcard_txtBox.Size = new System.Drawing.Size(273, 34);
            this.creditcard_txtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(496, 240);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(273, 34);
            this.password_txtBox.TabIndex = 4;
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.pay_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.White;
            this.pay_btn.Location = new System.Drawing.Point(307, 305);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(462, 54);
            this.pay_btn.TabIndex = 2;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Image = global::PropertyFinder.Properties.Resources.PikPng_com_logout_png_5199120__2_;
            this.logout.Location = new System.Drawing.Point(22, 21);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(123, 33);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 41;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(391, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 69);
            this.label3.TabIndex = 42;
            this.label3.Text = "Payment";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1121, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.creditcard_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pay_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PaymentPage";
            this.Text = "PaymentPage";
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox creditcard_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Label label3;
    }
}