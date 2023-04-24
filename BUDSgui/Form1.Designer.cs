namespace BUDSgui
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBUDS = new System.Windows.Forms.Label();
            this.pboxIcon = new System.Windows.Forms.PictureBox();
            this.pnlChange = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblRegsiter = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIcon)).BeginInit();
            this.pnlChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.lblBUDS);
            this.panel1.Controls.Add(this.pboxIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 140);
            this.panel1.TabIndex = 0;
            // 
            // lblBUDS
            // 
            this.lblBUDS.AutoSize = true;
            this.lblBUDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBUDS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBUDS.Location = new System.Drawing.Point(161, 32);
            this.lblBUDS.Name = "lblBUDS";
            this.lblBUDS.Size = new System.Drawing.Size(210, 73);
            this.lblBUDS.TabIndex = 1;
            this.lblBUDS.Text = "BUDS";
            // 
            // pboxIcon
            // 
            this.pboxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pboxIcon.Image")));
            this.pboxIcon.Location = new System.Drawing.Point(55, 22);
            this.pboxIcon.Name = "pboxIcon";
            this.pboxIcon.Size = new System.Drawing.Size(100, 92);
            this.pboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxIcon.TabIndex = 0;
            this.pboxIcon.TabStop = false;
            // 
            // pnlChange
            // 
            this.pnlChange.BackColor = System.Drawing.Color.White;
            this.pnlChange.Controls.Add(this.txtPassword);
            this.pnlChange.Controls.Add(this.txtUsername);
            this.pnlChange.Controls.Add(this.lblWelcome);
            this.pnlChange.Controls.Add(this.lblForgotPassword);
            this.pnlChange.Controls.Add(this.lblRegsiter);
            this.pnlChange.Controls.Add(this.lblUsername);
            this.pnlChange.Controls.Add(this.lblPassword);
            this.pnlChange.Controls.Add(this.btnLogin);
            this.pnlChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlChange.Location = new System.Drawing.Point(0, 140);
            this.pnlChange.Name = "pnlChange";
            this.pnlChange.Size = new System.Drawing.Size(450, 360);
            this.pnlChange.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 188);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(328, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(61, 133);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(328, 21);
            this.txtUsername.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(78, 47);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(293, 33);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Login to your account";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblForgotPassword.Location = new System.Drawing.Point(258, 319);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(131, 15);
            this.lblForgotPassword.TabIndex = 4;
            this.lblForgotPassword.Text = "Forgot your password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // lblRegsiter
            // 
            this.lblRegsiter.AutoSize = true;
            this.lblRegsiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegsiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegsiter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRegsiter.Location = new System.Drawing.Point(254, 304);
            this.lblRegsiter.Name = "lblRegsiter";
            this.lblRegsiter.Size = new System.Drawing.Size(135, 15);
            this.lblRegsiter.TabIndex = 3;
            this.lblRegsiter.Text = "Don\'t have an account?";
            this.lblRegsiter.Click += new System.EventHandler(this.lblRegsiter_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(56, 110);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(56, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(61, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(328, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.pnlChange);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.frmLogin_Shown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIcon)).EndInit();
            this.pnlChange.ResumeLayout(false);
            this.pnlChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlChange;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblForgotPassword;
        private Label lblRegsiter;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblWelcome;
        private Label lblBUDS;
        private PictureBox pboxIcon;
    }
}