namespace BUDSgui
{
    partial class frmRegsiter
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
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblReturnToLogin = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnAlternateLogin = new System.Windows.Forms.Button();
            this.pnlHoldtext = new System.Windows.Forms.Panel();
            this.pnlHoldtext.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(62, 164);
            this.txtNewUsername.MaxLength = 20;
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(328, 23);
            this.txtNewUsername.TabIndex = 16;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(62, 222);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(328, 23);
            this.txtNewPassword.TabIndex = 15;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(442, 48);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Create Username and Password";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(46, 141);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(51, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(62, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(328, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnRegsiter_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(100, 100);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 20);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Have an account?";
            // 
            // lblReturnToLogin
            // 
            this.lblReturnToLogin.AutoSize = true;
            this.lblReturnToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturnToLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReturnToLogin.Location = new System.Drawing.Point(285, 322);
            this.lblReturnToLogin.Name = "lblReturnToLogin";
            this.lblReturnToLogin.Size = new System.Drawing.Size(105, 15);
            this.lblReturnToLogin.TabIndex = 17;
            this.lblReturnToLogin.Text = "Have an account?";
            this.lblReturnToLogin.Click += new System.EventHandler(this.lblReturnToLogin_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(62, 108);
            this.txtUserID.MaxLength = 7;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(328, 23);
            this.txtUserID.TabIndex = 19;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserID.Location = new System.Drawing.Point(46, 85);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(30, 20);
            this.lblUserID.TabIndex = 18;
            this.lblUserID.Text = "ID:";
            // 
            // btnAlternateLogin
            // 
            this.btnAlternateLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnAlternateLogin.FlatAppearance.BorderSize = 0;
            this.btnAlternateLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlternateLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlternateLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAlternateLogin.Location = new System.Drawing.Point(62, 274);
            this.btnAlternateLogin.Name = "btnAlternateLogin";
            this.btnAlternateLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAlternateLogin.Size = new System.Drawing.Size(328, 45);
            this.btnAlternateLogin.TabIndex = 20;
            this.btnAlternateLogin.Text = "Change Password";
            this.btnAlternateLogin.UseVisualStyleBackColor = false;
            this.btnAlternateLogin.Click += new System.EventHandler(this.btnAlternateLogin_Click);
            // 
            // pnlHoldtext
            // 
            this.pnlHoldtext.Controls.Add(this.lblWelcome);
            this.pnlHoldtext.Location = new System.Drawing.Point(6, 17);
            this.pnlHoldtext.Name = "pnlHoldtext";
            this.pnlHoldtext.Size = new System.Drawing.Size(442, 48);
            this.pnlHoldtext.TabIndex = 21;
            // 
            // frmRegsiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblReturnToLogin);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAlternateLogin);
            this.Controls.Add(this.pnlHoldtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegsiter";
            this.Text = "Regsiter";
            this.pnlHoldtext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Label lblWelcome;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnUpdate;
        private Label lblLogin;
        private Label lblReturnToLogin;
        private TextBox txtUserID;
        private Label lblUserID;
        private Button btnAlternateLogin;
        private Panel pnlHoldtext;
    }
}