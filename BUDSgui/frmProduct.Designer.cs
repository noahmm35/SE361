namespace BUDSgui
{
    partial class frmProduct
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
            this.pnlProductNum = new System.Windows.Forms.Panel();
            this.lblTlProducts = new System.Windows.Forms.Label();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.pnlHoldingtotProducts = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnCreateP = new System.Windows.Forms.Button();
            this.btnModP = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlHoldingtotProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductNum
            // 
            this.pnlProductNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlProductNum.Location = new System.Drawing.Point(351, 76);
            this.pnlProductNum.Name = "pnlProductNum";
            this.pnlProductNum.Size = new System.Drawing.Size(0, 0);
            this.pnlProductNum.TabIndex = 1;
            // 
            // lblTlProducts
            // 
            this.lblTlProducts.AutoSize = true;
            this.lblTlProducts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTlProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTlProducts.Location = new System.Drawing.Point(4, 62);
            this.lblTlProducts.Name = "lblTlProducts";
            this.lblTlProducts.Size = new System.Drawing.Size(75, 13);
            this.lblTlProducts.TabIndex = 7;
            this.lblTlProducts.Text = "Total products";
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNumProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumProducts.Location = new System.Drawing.Point(0, 0);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(82, 75);
            this.lblNumProducts.TabIndex = 0;
            this.lblNumProducts.Text = "6";
            this.lblNumProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHoldingtotProducts
            // 
            this.pnlHoldingtotProducts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlHoldingtotProducts.Controls.Add(this.label2);
            this.pnlHoldingtotProducts.Controls.Add(this.panel2);
            this.pnlHoldingtotProducts.Controls.Add(this.lblTlProducts);
            this.pnlHoldingtotProducts.Controls.Add(this.panel3);
            this.pnlHoldingtotProducts.Controls.Add(this.lblNumProducts);
            this.pnlHoldingtotProducts.Location = new System.Drawing.Point(245, 31);
            this.pnlHoldingtotProducts.Name = "pnlHoldingtotProducts";
            this.pnlHoldingtotProducts.Size = new System.Drawing.Size(82, 75);
            this.pnlHoldingtotProducts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(106, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 70);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(106, -40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 70);
            this.panel3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(28, 282);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(646, 192);
            this.dgvProduct.TabIndex = 4;
            // 
            // btnCreateP
            // 
            this.btnCreateP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnCreateP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateP.Image = global::BUDSgui.Properties.Resources.icons8_create_100;
            this.btnCreateP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateP.Location = new System.Drawing.Point(27, 31);
            this.btnCreateP.Name = "btnCreateP";
            this.btnCreateP.Size = new System.Drawing.Size(196, 160);
            this.btnCreateP.TabIndex = 5;
            this.btnCreateP.Text = "Create a new product";
            this.btnCreateP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateP.UseVisualStyleBackColor = false;
            this.btnCreateP.Click += new System.EventHandler(this.btnCreateP_Click);
            // 
            // btnModP
            // 
            this.btnModP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnModP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModP.Image = global::BUDSgui.Properties.Resources.icons8_create_100;
            this.btnModP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModP.Location = new System.Drawing.Point(457, 31);
            this.btnModP.Name = "btnModP";
            this.btnModP.Size = new System.Drawing.Size(196, 160);
            this.btnModP.TabIndex = 6;
            this.btnModP.Text = "Modify an existing product";
            this.btnModP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModP.UseVisualStyleBackColor = false;
            this.btnModP.Click += new System.EventHandler(this.btnModP_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::BUDSgui.Properties.Resources.icons8_update_left_rotation_50;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(245, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 75);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Update table";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 486);
            this.panel4.TabIndex = 23;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 486);
            this.Controls.Add(this.btnModP);
            this.Controls.Add(this.btnCreateP);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pnlHoldingtotProducts);
            this.Controls.Add(this.pnlProductNum);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.pnlHoldingtotProducts.ResumeLayout(false);
            this.pnlHoldingtotProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlProductNum;
        private Panel pnlHoldingtotProducts;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvProduct;
        private Panel panel2;
        private Panel panel3;
        private Label lblTlProducts;
        private Label lblNumProducts;
        private Label label2;
        private Button btnCreateP;
        private Button btnModP;
        private Button btnRefresh;
        private Panel panel4;
    }
}