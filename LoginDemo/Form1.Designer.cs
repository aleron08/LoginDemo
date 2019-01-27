namespace LoginDemo
{
    partial class Form1
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
            this.tip = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(255, 33);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(248, 20);
            this.tip.TabIndex = 0;
            this.tip.TabStop = true;
            this.tip.Text = "Please Login(accoun:aa;pwd:123)";
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Location = new System.Drawing.Point(206, 101);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(70, 20);
            this.account.TabIndex = 1;
            this.account.Text = "account:";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Location = new System.Drawing.Point(195, 173);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(81, 20);
            this.pwd.TabIndex = 3;
            this.pwd.Text = "password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(316, 101);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(187, 26);
            this.textAccount.TabIndex = 4;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(316, 170);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(187, 26);
            this.textPwd.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.account);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.TextBox textPwd;
    }
}

