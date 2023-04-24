namespace BUDSgui
{
    partial class frmCreateMaterial
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
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.pnlTopColor = new System.Windows.Forms.Panel();
            this.lblMCWelcome = new System.Windows.Forms.Label();
            this.pnlModifyMat = new System.Windows.Forms.Panel();
            this.txtItemStock = new System.Windows.Forms.NumericUpDown();
            this.cboMatQuality = new System.Windows.Forms.ComboBox();
            this.lblMQuality = new System.Windows.Forms.Label();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.cboMatID = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnUpdateMat = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlTopColor.SuspendLayout();
            this.pnlModifyMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnCreateProduct.FlatAppearance.BorderSize = 0;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProduct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateProduct.Location = new System.Drawing.Point(169, 324);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(237, 41);
            this.btnCreateProduct.TabIndex = 17;
            this.btnCreateProduct.Text = "Create Material";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(98, 218);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 18);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(169, 153);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(265, 23);
            this.txtMaterialName.TabIndex = 14;
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterialName.Location = new System.Drawing.Point(56, 158);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(104, 18);
            this.lblMaterialName.TabIndex = 13;
            this.lblMaterialName.Text = "Material Name";
            // 
            // pnlTopColor
            // 
            this.pnlTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.pnlTopColor.Controls.Add(this.lblMCWelcome);
            this.pnlTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopColor.Location = new System.Drawing.Point(0, 0);
            this.pnlTopColor.Name = "pnlTopColor";
            this.pnlTopColor.Size = new System.Drawing.Size(553, 109);
            this.pnlTopColor.TabIndex = 12;
            // 
            // lblMCWelcome
            // 
            this.lblMCWelcome.AutoSize = true;
            this.lblMCWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMCWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMCWelcome.Location = new System.Drawing.Point(75, 31);
            this.lblMCWelcome.Name = "lblMCWelcome";
            this.lblMCWelcome.Size = new System.Drawing.Size(389, 55);
            this.lblMCWelcome.TabIndex = 10;
            this.lblMCWelcome.Text = "Material Creation";
            // 
            // pnlModifyMat
            // 
            this.pnlModifyMat.Controls.Add(this.txtItemStock);
            this.pnlModifyMat.Controls.Add(this.cboMatQuality);
            this.pnlModifyMat.Controls.Add(this.lblMQuality);
            this.pnlModifyMat.Controls.Add(this.btnDeleteMaterial);
            this.pnlModifyMat.Controls.Add(this.cboMatID);
            this.pnlModifyMat.Controls.Add(this.btnImport);
            this.pnlModifyMat.Controls.Add(this.btnUpdateMat);
            this.pnlModifyMat.Controls.Add(this.lblID);
            this.pnlModifyMat.Controls.Add(this.label1);
            this.pnlModifyMat.Controls.Add(this.txtMatName);
            this.pnlModifyMat.Controls.Add(this.label2);
            this.pnlModifyMat.Location = new System.Drawing.Point(0, 115);
            this.pnlModifyMat.Name = "pnlModifyMat";
            this.pnlModifyMat.Size = new System.Drawing.Size(553, 305);
            this.pnlModifyMat.TabIndex = 18;
            // 
            // txtItemStock
            // 
            this.txtItemStock.Location = new System.Drawing.Point(153, 115);
            this.txtItemStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtItemStock.Name = "txtItemStock";
            this.txtItemStock.Size = new System.Drawing.Size(265, 23);
            this.txtItemStock.TabIndex = 31;
            // 
            // cboMatQuality
            // 
            this.cboMatQuality.FormattingEnabled = true;
            this.cboMatQuality.Items.AddRange(new object[] {
            "Not Set",
            "Useless",
            "Useful"});
            this.cboMatQuality.Location = new System.Drawing.Point(153, 159);
            this.cboMatQuality.Name = "cboMatQuality";
            this.cboMatQuality.Size = new System.Drawing.Size(265, 23);
            this.cboMatQuality.TabIndex = 30;
            // 
            // lblMQuality
            // 
            this.lblMQuality.AutoSize = true;
            this.lblMQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMQuality.Location = new System.Drawing.Point(94, 159);
            this.lblMQuality.Name = "lblMQuality";
            this.lblMQuality.Size = new System.Drawing.Size(53, 18);
            this.lblMQuality.TabIndex = 29;
            this.lblMQuality.Text = "Quality";
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnDeleteMaterial.FlatAppearance.BorderSize = 0;
            this.btnDeleteMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMaterial.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteMaterial.Location = new System.Drawing.Point(292, 229);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(237, 41);
            this.btnDeleteMaterial.TabIndex = 28;
            this.btnDeleteMaterial.Text = "Delete Material";
            this.btnDeleteMaterial.UseVisualStyleBackColor = false;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // cboMatID
            // 
            this.cboMatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatID.FormattingEnabled = true;
            this.cboMatID.Location = new System.Drawing.Point(153, 23);
            this.cboMatID.Name = "cboMatID";
            this.cboMatID.Size = new System.Drawing.Size(265, 23);
            this.cboMatID.TabIndex = 27;
            this.cboMatID.SelectedIndexChanged += new System.EventHandler(this.cboMatID_SelectedIndexChanged);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnImport.Location = new System.Drawing.Point(440, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(72, 23);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnUpdateMat
            // 
            this.btnUpdateMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnUpdateMat.FlatAppearance.BorderSize = 0;
            this.btnUpdateMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdateMat.Location = new System.Drawing.Point(21, 229);
            this.btnUpdateMat.Name = "btnUpdateMat";
            this.btnUpdateMat.Size = new System.Drawing.Size(237, 41);
            this.btnUpdateMat.TabIndex = 25;
            this.btnUpdateMat.Text = "Update Material";
            this.btnUpdateMat.UseVisualStyleBackColor = false;
            this.btnUpdateMat.Click += new System.EventHandler(this.btnUpdateMat_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(125, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantity";
            // 
            // txtMatName
            // 
            this.txtMatName.Location = new System.Drawing.Point(153, 69);
            this.txtMatName.MaxLength = 30;
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.Size = new System.Drawing.Size(265, 23);
            this.txtMatName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Material Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(169, 219);
            this.txtQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(265, 23);
            this.txtQuantity.TabIndex = 32;
            // 
            // frmCreateMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 407);
            this.Controls.Add(this.pnlModifyMat);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.pnlTopColor);
            this.Controls.Add(this.txtQuantity);
            this.Name = "frmCreateMaterial";
            this.Text = "frmCreateMaterial";
            this.pnlTopColor.ResumeLayout(false);
            this.pnlTopColor.PerformLayout();
            this.pnlModifyMat.ResumeLayout(false);
            this.pnlModifyMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCreateProduct;
        private Label lblQuantity;
        private TextBox txtMaterialName;
        private Label lblMaterialName;
        private Panel pnlTopColor;
        private Label lblMCWelcome;
        private Panel pnlModifyMat;
        private Button btnImport;
        private Button btnUpdateMat;
        private Label lblID;
        private Label label1;
        private TextBox txtMatName;
        private Label label2;
        private ComboBox cboMatID;
        private Button btnDeleteMaterial;
        private ComboBox cboMatQuality;
        private Label lblMQuality;
        private NumericUpDown txtItemStock;
        private NumericUpDown txtQuantity;
    }
}