namespace FourWindsCustomerList
{
    partial class formLogin
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
            this.textboxUser = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancelLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxUser
            // 
            this.textboxUser.Location = new System.Drawing.Point(151, 56);
            this.textboxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxUser.Name = "textboxUser";
            this.textboxUser.Size = new System.Drawing.Size(148, 26);
            this.textboxUser.TabIndex = 0;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(151, 92);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(148, 26);
            this.textboxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogin.Location = new System.Drawing.Point(224, 142);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 43);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancelLogin
            // 
            this.buttonCancelLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelLogin.Location = new System.Drawing.Point(143, 142);
            this.buttonCancelLogin.Name = "buttonCancelLogin";
            this.buttonCancelLogin.Size = new System.Drawing.Size(75, 43);
            this.buttonCancelLogin.TabIndex = 5;
            this.buttonCancelLogin.Text = "Cancel";
            this.buttonCancelLogin.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelLogin;
            this.ClientSize = new System.Drawing.Size(414, 241);
            this.Controls.Add(this.buttonCancelLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxUser;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancelLogin;
    }
}