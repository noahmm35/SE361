namespace BUDSgui
{
    partial class specialAccess
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
            this.lblSWelcome = new System.Windows.Forms.Label();
            this.lblAdminAccess = new System.Windows.Forms.Label();
            this.lblCreateNewUser = new System.Windows.Forms.Label();
            this.lblEmplyeeID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.datagridUsers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cboxRole = new System.Windows.Forms.ComboBox();
            this.pnlResizingSpecial = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsers)).BeginInit();
            this.pnlResizingSpecial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSWelcome
            // 
            this.lblSWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSWelcome.AutoSize = true;
            this.lblSWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSWelcome.Location = new System.Drawing.Point(3, 167);
            this.lblSWelcome.Name = "lblSWelcome";
            this.lblSWelcome.Size = new System.Drawing.Size(110, 25);
            this.lblSWelcome.TabIndex = 0;
            this.lblSWelcome.Text = "Database:";
            // 
            // lblAdminAccess
            // 
            this.lblAdminAccess.AutoSize = true;
            this.lblAdminAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminAccess.Location = new System.Drawing.Point(3, 9);
            this.lblAdminAccess.Name = "lblAdminAccess";
            this.lblAdminAccess.Size = new System.Drawing.Size(154, 25);
            this.lblAdminAccess.TabIndex = 1;
            this.lblAdminAccess.Text = "Admin Access:";
            // 
            // lblCreateNewUser
            // 
            this.lblCreateNewUser.AutoSize = true;
            this.lblCreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateNewUser.Location = new System.Drawing.Point(28, 34);
            this.lblCreateNewUser.Name = "lblCreateNewUser";
            this.lblCreateNewUser.Size = new System.Drawing.Size(129, 20);
            this.lblCreateNewUser.TabIndex = 3;
            this.lblCreateNewUser.Text = "Create new user:";
            // 
            // lblEmplyeeID
            // 
            this.lblEmplyeeID.AutoSize = true;
            this.lblEmplyeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmplyeeID.Location = new System.Drawing.Point(42, 70);
            this.lblEmplyeeID.Name = "lblEmplyeeID";
            this.lblEmplyeeID.Size = new System.Drawing.Size(104, 20);
            this.lblEmplyeeID.TabIndex = 4;
            this.lblEmplyeeID.Text = "Employee ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserID.Location = new System.Drawing.Point(152, 71);
            this.txtUserID.MaxLength = 7;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(333, 23);
            this.txtUserID.TabIndex = 5;
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeRole.Location = new System.Drawing.Point(42, 100);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Size = new System.Drawing.Size(104, 20);
            this.lblEmployeeRole.TabIndex = 7;
            this.lblEmployeeRole.Text = "Employe role:";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.ForeColor = System.Drawing.Color.Black;
            this.btnCreateUser.Location = new System.Drawing.Point(506, 67);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(152, 28);
            this.btnCreateUser.TabIndex = 8;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // datagridUsers
            // 
            this.datagridUsers.AllowUserToAddRows = false;
            this.datagridUsers.AllowUserToDeleteRows = false;
            this.datagridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUsers.Location = new System.Drawing.Point(42, 229);
            this.datagridUsers.Name = "datagridUsers";
            this.datagridUsers.ReadOnly = true;
            this.datagridUsers.RowHeadersWidth = 62;
            this.datagridUsers.RowTemplate.Height = 25;
            this.datagridUsers.Size = new System.Drawing.Size(588, 191);
            this.datagridUsers.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(42, 195);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 28);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Location = new System.Drawing.Point(506, 101);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(152, 28);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete user";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // cboxRole
            // 
            this.cboxRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxRole.FormattingEnabled = true;
            this.cboxRole.Items.AddRange(new object[] {
            "qualityAnalyzer",
            "reportManager",
            "deliveryManager",
            "stockManager",
            "productManager",
            "admin"});
            this.cboxRole.Location = new System.Drawing.Point(152, 100);
            this.cboxRole.Name = "cboxRole";
            this.cboxRole.Size = new System.Drawing.Size(333, 23);
            this.cboxRole.TabIndex = 14;
            // 
            // pnlResizingSpecial
            // 
            this.pnlResizingSpecial.AutoSize = true;
            this.pnlResizingSpecial.Controls.Add(this.lblAdminAccess);
            this.pnlResizingSpecial.Controls.Add(this.btnRefresh);
            this.pnlResizingSpecial.Controls.Add(this.lblSWelcome);
            this.pnlResizingSpecial.Controls.Add(this.btnDeleteUser);
            this.pnlResizingSpecial.Controls.Add(this.lblCreateNewUser);
            this.pnlResizingSpecial.Controls.Add(this.btnCreateUser);
            this.pnlResizingSpecial.Controls.Add(this.lblEmplyeeID);
            this.pnlResizingSpecial.Controls.Add(this.lblEmployeeRole);
            this.pnlResizingSpecial.Controls.Add(this.txtUserID);
            this.pnlResizingSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResizingSpecial.Location = new System.Drawing.Point(0, 0);
            this.pnlResizingSpecial.Name = "pnlResizingSpecial";
            this.pnlResizingSpecial.Size = new System.Drawing.Size(670, 446);
            this.pnlResizingSpecial.TabIndex = 15;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstruction.Location = new System.Drawing.Point(51, 86);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(86, 12);
            this.lblInstruction.TabIndex = 15;
            this.lblInstruction.Text = "(Up to 7 numbers)";
            // 
            // specialAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(670, 446);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.cboxRole);
            this.Controls.Add(this.datagridUsers);
            this.Controls.Add(this.pnlResizingSpecial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "specialAccess";
            this.Text = "Special Access";
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsers)).EndInit();
            this.pnlResizingSpecial.ResumeLayout(false);
            this.pnlResizingSpecial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSWelcome;
        private Label lblAdminAccess;
        private Label lblCreateNewUser;
        private Label lblEmplyeeID;
        private TextBox txtUserID;
        private Label lblEmployeeRole;
        private Button btnCreateUser;
        private DataGridView datagridUsers;
        private Button btnRefresh;
        private Button btnDeleteUser;
        private ComboBox cboxRole;
        private Panel pnlResizingSpecial;
        private Label lblInstruction;
    }
}