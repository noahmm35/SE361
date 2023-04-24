namespace BUDSgui
{
    partial class frmCreateProduct
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
            this.pnlTopColor = new System.Windows.Forms.Panel();
            this.lblPCWelcome = new System.Windows.Forms.Label();
            this.pnlModifyProd = new System.Windows.Forms.Panel();
            this.btndeletProduct = new System.Windows.Forms.Button();
            this.btnUpdateProductMaterials = new System.Windows.Forms.Button();
            this.txtItemStock = new System.Windows.Forms.NumericUpDown();
            this.cboDS = new System.Windows.Forms.ComboBox();
            this.lblDS = new System.Windows.Forms.Label();
            this.cboQuality = new System.Windows.Forms.ComboBox();
            this.cboProdID = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblQuan = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.llbProdname = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantityM1 = new System.Windows.Forms.Label();
            this.nudQuantityMat1 = new System.Windows.Forms.NumericUpDown();
            this.lblQuantityM2 = new System.Windows.Forms.Label();
            this.nudQuantityMat2 = new System.Windows.Forms.NumericUpDown();
            this.lblQuantityM3 = new System.Windows.Forms.Label();
            this.nudQuantityMat3 = new System.Windows.Forms.NumericUpDown();
            this.lblMaterial1 = new System.Windows.Forms.Label();
            this.cboMaterial3 = new System.Windows.Forms.ComboBox();
            this.lblMaterial3 = new System.Windows.Forms.Label();
            this.cboMaterial2 = new System.Windows.Forms.ComboBox();
            this.lblMaterial2 = new System.Windows.Forms.Label();
            this.cboMaterial1 = new System.Windows.Forms.ComboBox();
            this.lblDividerLine = new System.Windows.Forms.Label();
            this.pnlTopColor.SuspendLayout();
            this.pnlModifyProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityMat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityMat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityMat3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopColor
            // 
            this.pnlTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.pnlTopColor.Controls.Add(this.lblPCWelcome);
            this.pnlTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopColor.Location = new System.Drawing.Point(0, 0);
            this.pnlTopColor.Name = "pnlTopColor";
            this.pnlTopColor.Size = new System.Drawing.Size(553, 109);
            this.pnlTopColor.TabIndex = 0;
            // 
            // lblPCWelcome
            // 
            this.lblPCWelcome.AutoSize = true;
            this.lblPCWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPCWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPCWelcome.Location = new System.Drawing.Point(89, 31);
            this.lblPCWelcome.Name = "lblPCWelcome";
            this.lblPCWelcome.Size = new System.Drawing.Size(385, 55);
            this.lblPCWelcome.TabIndex = 10;
            this.lblPCWelcome.Text = "Product Creation";
            this.lblPCWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlModifyProd
            // 
            this.pnlModifyProd.Controls.Add(this.btndeletProduct);
            this.pnlModifyProd.Controls.Add(this.btnUpdateProductMaterials);
            this.pnlModifyProd.Controls.Add(this.txtItemStock);
            this.pnlModifyProd.Controls.Add(this.cboDS);
            this.pnlModifyProd.Controls.Add(this.lblDS);
            this.pnlModifyProd.Controls.Add(this.cboQuality);
            this.pnlModifyProd.Controls.Add(this.cboProdID);
            this.pnlModifyProd.Controls.Add(this.btnImport);
            this.pnlModifyProd.Controls.Add(this.btnUpdateProd);
            this.pnlModifyProd.Controls.Add(this.lblID);
            this.pnlModifyProd.Controls.Add(this.lblQuality);
            this.pnlModifyProd.Controls.Add(this.lblQuan);
            this.pnlModifyProd.Controls.Add(this.txtProdName);
            this.pnlModifyProd.Controls.Add(this.llbProdname);
            this.pnlModifyProd.Location = new System.Drawing.Point(0, 114);
            this.pnlModifyProd.Margin = new System.Windows.Forms.Padding(2);
            this.pnlModifyProd.Name = "pnlModifyProd";
            this.pnlModifyProd.Size = new System.Drawing.Size(553, 294);
            this.pnlModifyProd.TabIndex = 19;
            // 
            // btndeletProduct
            // 
            this.btndeletProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btndeletProduct.FlatAppearance.BorderSize = 0;
            this.btndeletProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndeletProduct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btndeletProduct.Location = new System.Drawing.Point(383, 231);
            this.btndeletProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btndeletProduct.Name = "btndeletProduct";
            this.btndeletProduct.Size = new System.Drawing.Size(142, 41);
            this.btndeletProduct.TabIndex = 73;
            this.btndeletProduct.Text = "Delete Product";
            this.btndeletProduct.UseVisualStyleBackColor = false;
            this.btndeletProduct.Click += new System.EventHandler(this.btndeletProduct_Click_1);
            // 
            // btnUpdateProductMaterials
            // 
            this.btnUpdateProductMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnUpdateProductMaterials.FlatAppearance.BorderSize = 0;
            this.btnUpdateProductMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProductMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProductMaterials.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdateProductMaterials.Location = new System.Drawing.Point(214, 231);
            this.btnUpdateProductMaterials.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProductMaterials.Name = "btnUpdateProductMaterials";
            this.btnUpdateProductMaterials.Size = new System.Drawing.Size(138, 41);
            this.btnUpdateProductMaterials.TabIndex = 32;
            this.btnUpdateProductMaterials.Text = "Update Materials";
            this.btnUpdateProductMaterials.UseVisualStyleBackColor = false;
            this.btnUpdateProductMaterials.Click += new System.EventHandler(this.btnUpdateProductMaterials_Click);
            // 
            // txtItemStock
            // 
            this.txtItemStock.Location = new System.Drawing.Point(152, 93);
            this.txtItemStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtItemStock.Name = "txtItemStock";
            this.txtItemStock.Size = new System.Drawing.Size(265, 23);
            this.txtItemStock.TabIndex = 31;
            // 
            // cboDS
            // 
            this.cboDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDS.FormattingEnabled = true;
            this.cboDS.Items.AddRange(new object[] {
            "Not Set",
            "Useful",
            "Useless"});
            this.cboDS.Location = new System.Drawing.Point(152, 180);
            this.cboDS.Name = "cboDS";
            this.cboDS.Size = new System.Drawing.Size(265, 23);
            this.cboDS.TabIndex = 30;
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDS.Location = new System.Drawing.Point(43, 185);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(106, 18);
            this.lblDS.TabIndex = 29;
            this.lblDS.Text = "Delivery Status";
            // 
            // cboQuality
            // 
            this.cboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuality.FormattingEnabled = true;
            this.cboQuality.Items.AddRange(new object[] {
            "Not Set",
            "Good",
            "Bad"});
            this.cboQuality.Location = new System.Drawing.Point(152, 137);
            this.cboQuality.Name = "cboQuality";
            this.cboQuality.Size = new System.Drawing.Size(265, 23);
            this.cboQuality.TabIndex = 28;
            // 
            // cboProdID
            // 
            this.cboProdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdID.FormattingEnabled = true;
            this.cboProdID.Location = new System.Drawing.Point(151, 16);
            this.cboProdID.Margin = new System.Windows.Forms.Padding(2);
            this.cboProdID.Name = "cboProdID";
            this.cboProdID.Size = new System.Drawing.Size(266, 23);
            this.cboProdID.TabIndex = 27;
            this.cboProdID.SelectedIndexChanged += new System.EventHandler(this.cboProdID_SelectedIndexChanged);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnImport.Location = new System.Drawing.Point(451, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(72, 23);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnUpdateProd.FlatAppearance.BorderSize = 0;
            this.btnUpdateProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdateProd.Location = new System.Drawing.Point(31, 231);
            this.btnUpdateProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(140, 41);
            this.btnUpdateProd.TabIndex = 25;
            this.btnUpdateProd.Text = "Update Product";
            this.btnUpdateProd.UseVisualStyleBackColor = false;
            this.btnUpdateProd.Click += new System.EventHandler(this.btnUpdateProd_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(124, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuality.Location = new System.Drawing.Point(96, 142);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(53, 18);
            this.lblQuality.TabIndex = 21;
            this.lblQuality.Text = "Quality";
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuan.Location = new System.Drawing.Point(84, 98);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(62, 18);
            this.lblQuan.TabIndex = 19;
            this.lblQuan.Text = "Quantity";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(152, 51);
            this.txtProdName.MaxLength = 30;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(265, 23);
            this.txtProdName.TabIndex = 18;
            // 
            // llbProdname
            // 
            this.llbProdname.AutoSize = true;
            this.llbProdname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbProdname.Location = new System.Drawing.Point(42, 56);
            this.llbProdname.Name = "llbProdname";
            this.llbProdname.Size = new System.Drawing.Size(104, 18);
            this.llbProdname.TabIndex = 17;
            this.llbProdname.Text = "Product Name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(70, 132);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(101, 18);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(180, 127);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(265, 23);
            this.txtProductName.TabIndex = 2;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarehouse.Location = new System.Drawing.Point(43, 317);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(0, 18);
            this.lblWarehouse.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(109, 164);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 18);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnCreateProduct.FlatAppearance.BorderSize = 0;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProduct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateProduct.Location = new System.Drawing.Point(153, 345);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(237, 41);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(180, 165);
            this.txtQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(265, 23);
            this.txtQuantity.TabIndex = 32;
            // 
            // lblQuantityM1
            // 
            this.lblQuantityM1.AutoSize = true;
            this.lblQuantityM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityM1.Location = new System.Drawing.Point(383, 238);
            this.lblQuantityM1.Name = "lblQuantityM1";
            this.lblQuantityM1.Size = new System.Drawing.Size(62, 18);
            this.lblQuantityM1.TabIndex = 56;
            this.lblQuantityM1.Text = "Quantity";
            // 
            // nudQuantityMat1
            // 
            this.nudQuantityMat1.Location = new System.Drawing.Point(451, 235);
            this.nudQuantityMat1.Name = "nudQuantityMat1";
            this.nudQuantityMat1.Size = new System.Drawing.Size(54, 23);
            this.nudQuantityMat1.TabIndex = 59;
            // 
            // lblQuantityM2
            // 
            this.lblQuantityM2.AutoSize = true;
            this.lblQuantityM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityM2.Location = new System.Drawing.Point(383, 265);
            this.lblQuantityM2.Name = "lblQuantityM2";
            this.lblQuantityM2.Size = new System.Drawing.Size(62, 18);
            this.lblQuantityM2.TabIndex = 60;
            this.lblQuantityM2.Text = "Quantity";
            // 
            // nudQuantityMat2
            // 
            this.nudQuantityMat2.Location = new System.Drawing.Point(451, 265);
            this.nudQuantityMat2.Name = "nudQuantityMat2";
            this.nudQuantityMat2.Size = new System.Drawing.Size(54, 23);
            this.nudQuantityMat2.TabIndex = 61;
            // 
            // lblQuantityM3
            // 
            this.lblQuantityM3.AutoSize = true;
            this.lblQuantityM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityM3.Location = new System.Drawing.Point(383, 294);
            this.lblQuantityM3.Name = "lblQuantityM3";
            this.lblQuantityM3.Size = new System.Drawing.Size(62, 18);
            this.lblQuantityM3.TabIndex = 62;
            this.lblQuantityM3.Text = "Quantity";
            // 
            // nudQuantityMat3
            // 
            this.nudQuantityMat3.Location = new System.Drawing.Point(451, 294);
            this.nudQuantityMat3.Name = "nudQuantityMat3";
            this.nudQuantityMat3.Size = new System.Drawing.Size(54, 23);
            this.nudQuantityMat3.TabIndex = 63;
            // 
            // lblMaterial1
            // 
            this.lblMaterial1.AutoSize = true;
            this.lblMaterial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterial1.Location = new System.Drawing.Point(31, 238);
            this.lblMaterial1.Name = "lblMaterial1";
            this.lblMaterial1.Size = new System.Drawing.Size(72, 18);
            this.lblMaterial1.TabIndex = 64;
            this.lblMaterial1.Text = "Material 1";
            // 
            // cboMaterial3
            // 
            this.cboMaterial3.FormattingEnabled = true;
            this.cboMaterial3.Location = new System.Drawing.Point(109, 294);
            this.cboMaterial3.Name = "cboMaterial3";
            this.cboMaterial3.Size = new System.Drawing.Size(234, 23);
            this.cboMaterial3.TabIndex = 65;
            // 
            // lblMaterial3
            // 
            this.lblMaterial3.AutoSize = true;
            this.lblMaterial3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterial3.Location = new System.Drawing.Point(31, 299);
            this.lblMaterial3.Name = "lblMaterial3";
            this.lblMaterial3.Size = new System.Drawing.Size(72, 18);
            this.lblMaterial3.TabIndex = 66;
            this.lblMaterial3.Text = "Material 3";
            // 
            // cboMaterial2
            // 
            this.cboMaterial2.FormattingEnabled = true;
            this.cboMaterial2.Location = new System.Drawing.Point(109, 265);
            this.cboMaterial2.Name = "cboMaterial2";
            this.cboMaterial2.Size = new System.Drawing.Size(234, 23);
            this.cboMaterial2.TabIndex = 68;
            // 
            // lblMaterial2
            // 
            this.lblMaterial2.AutoSize = true;
            this.lblMaterial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterial2.Location = new System.Drawing.Point(31, 270);
            this.lblMaterial2.Name = "lblMaterial2";
            this.lblMaterial2.Size = new System.Drawing.Size(72, 18);
            this.lblMaterial2.TabIndex = 67;
            this.lblMaterial2.Text = "Material 2";
            // 
            // cboMaterial1
            // 
            this.cboMaterial1.FormattingEnabled = true;
            this.cboMaterial1.Location = new System.Drawing.Point(109, 235);
            this.cboMaterial1.Name = "cboMaterial1";
            this.cboMaterial1.Size = new System.Drawing.Size(234, 23);
            this.cboMaterial1.TabIndex = 69;
            // 
            // lblDividerLine
            // 
            this.lblDividerLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDividerLine.Location = new System.Drawing.Point(0, 203);
            this.lblDividerLine.Name = "lblDividerLine";
            this.lblDividerLine.Size = new System.Drawing.Size(553, 10);
            this.lblDividerLine.TabIndex = 71;
            // 
            // frmCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 407);
            this.Controls.Add(this.pnlModifyProd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pnlTopColor);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboMaterial1);
            this.Controls.Add(this.lblMaterial2);
            this.Controls.Add(this.cboMaterial2);
            this.Controls.Add(this.lblMaterial3);
            this.Controls.Add(this.cboMaterial3);
            this.Controls.Add(this.lblMaterial1);
            this.Controls.Add(this.nudQuantityMat3);
            this.Controls.Add(this.lblQuantityM3);
            this.Controls.Add(this.nudQuantityMat2);
            this.Controls.Add(this.lblQuantityM2);
            this.Controls.Add(this.nudQuantityMat1);
            this.Controls.Add(this.lblQuantityM1);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.lblDividerLine);
            this.Name = "frmCreateProduct";
            this.Text = "Create product";
            this.pnlTopColor.ResumeLayout(false);
            this.pnlTopColor.PerformLayout();
            this.pnlModifyProd.ResumeLayout(false);
            this.pnlModifyProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityMat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityMat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityMat3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTopColor;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblWarehouse;
        private Label lblQuantity;
        private Button btnCreateProduct;
        private Label lblPCWelcome;
        private Panel pnlModifyProd;
        private ComboBox cboDS;
        private Label lblDS;
        private ComboBox cboQuality;
        private ComboBox cboProdID;
        private Button btnImport;
        private Button btnUpdateProd;
        private Label lblID;
        private Label lblQuality;
        private Label lblQuan;
        private TextBox txtProdName;
        private Label llbProdname;
        private NumericUpDown txtItemStock;
        private NumericUpDown txtQuantity;
        private Button btnUpdateProductMaterials;
        private Label lblQuantityM1;
        private NumericUpDown nudQuantityMat1;
        private Label lblQuantityM2;
        private NumericUpDown nudQuantityMat2;
        private Label lblQuantityM3;
        private NumericUpDown nudQuantityMat3;
        private Label lblMaterial1;
        private ComboBox cboMaterial3;
        private Label lblMaterial3;
        private ComboBox cboMaterial2;
        private Label lblMaterial2;
        private ComboBox cboMaterial1;
        private Label lblDividerLine;
        private Button btndeletProduct;
    }
}