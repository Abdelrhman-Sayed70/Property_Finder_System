namespace PropertyFinder
{
    partial class Payment_Pagecs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.creditcardid_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.pay_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 30);
            this.textBox1.TabIndex = 0;
            // 
            // creditcardid_lbl
            // 
            this.creditcardid_lbl.AutoSize = true;
            this.creditcardid_lbl.Location = new System.Drawing.Point(120, 107);
            this.creditcardid_lbl.Name = "creditcardid_lbl";
            this.creditcardid_lbl.Size = new System.Drawing.Size(136, 25);
            this.creditcardid_lbl.TabIndex = 1;
            this.creditcardid_lbl.Text = "Credit Card ID";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(120, 197);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(98, 25);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "Password";
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(125, 225);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(131, 30);
            this.password_txtBox.TabIndex = 0;
            // 
            // pay_btn
            // 
            this.pay_btn.Location = new System.Drawing.Point(157, 377);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(152, 43);
            this.pay_btn.TabIndex = 3;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(79, 37);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // Payment_Pagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 605);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.creditcardid_lbl);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payment_Pagecs";
            this.Text = "Payment_Pagecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label creditcardid_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button back_btn;
    }
}