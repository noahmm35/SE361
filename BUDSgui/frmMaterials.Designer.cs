namespace BUDSgui
{
    partial class frmMaterials
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
            this.btnModMat = new System.Windows.Forms.Button();
            this.btncreateMat = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlHoldingtotmat = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumMaterials = new System.Windows.Forms.Label();
            this.pnlProductNum = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlResizingMaterials = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlHoldingtotmat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModMat
            // 
            this.btnModMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btnModMat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModMat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModMat.Image = global::BUDSgui.Properties.Resources.icons8_create_100;
            this.btnModMat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModMat.Location = new System.Drawing.Point(457, 31);
            this.btnModMat.Name = "btnModMat";
            this.btnModMat.Size = new System.Drawing.Size(196, 160);
            this.btnModMat.TabIndex = 16;
            this.btnModMat.Text = "Modify existing materials";
            this.btnModMat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModMat.UseVisualStyleBackColor = false;
            this.btnModMat.Click += new System.EventHandler(this.btnModMat_Click);
            // 
            // btncreateMat
            // 
            this.btncreateMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(133)))), ((int)(((byte)(68)))));
            this.btncreateMat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncreateMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreateMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncreateMat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncreateMat.Image = global::BUDSgui.Properties.Resources.icons8_create_100;
            this.btncreateMat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncreateMat.Location = new System.Drawing.Point(27, 31);
            this.btncreateMat.Name = "btncreateMat";
            this.btncreateMat.Size = new System.Drawing.Size(196, 160);
            this.btncreateMat.TabIndex = 16;
            this.btncreateMat.Text = "Create a new material";
            this.btncreateMat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncreateMat.UseVisualStyleBackColor = false;
            this.btncreateMat.Click += new System.EventHandler(this.btncreateMat_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(28, 282);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(646, 192);
            this.dgvProduct.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // pnlHoldingtotmat
            // 
            this.pnlHoldingtotmat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlHoldingtotmat.Controls.Add(this.label2);
            this.pnlHoldingtotmat.Controls.Add(this.panel2);
            this.pnlHoldingtotmat.Controls.Add(this.label4);
            this.pnlHoldingtotmat.Controls.Add(this.panel3);
            this.pnlHoldingtotmat.Controls.Add(this.lblNumMaterials);
            this.pnlHoldingtotmat.Location = new System.Drawing.Point(245, 31);
            this.pnlHoldingtotmat.Name = "pnlHoldingtotmat";
            this.pnlHoldingtotmat.Size = new System.Drawing.Size(82, 75);
            this.pnlHoldingtotmat.TabIndex = 13;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total materials";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(106, -40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 70);
            this.panel3.TabIndex = 4;
            // 
            // lblNumMaterials
            // 
            this.lblNumMaterials.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNumMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumMaterials.Location = new System.Drawing.Point(0, 0);
            this.lblNumMaterials.Name = "lblNumMaterials";
            this.lblNumMaterials.Size = new System.Drawing.Size(82, 75);
            this.lblNumMaterials.TabIndex = 0;
            this.lblNumMaterials.Text = "6";
            this.lblNumMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProductNum
            // 
            this.pnlProductNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlProductNum.Location = new System.Drawing.Point(412, 64);
            this.pnlProductNum.Name = "pnlProductNum";
            this.pnlProductNum.Size = new System.Drawing.Size(0, 0);
            this.pnlProductNum.TabIndex = 12;
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
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Update table";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlResizingMaterials
            // 
            this.pnlResizingMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResizingMaterials.Location = new System.Drawing.Point(0, 0);
            this.pnlResizingMaterials.Name = "pnlResizingMaterials";
            this.pnlResizingMaterials.Size = new System.Drawing.Size(686, 486);
            this.pnlResizingMaterials.TabIndex = 22;
            // 
            // frmMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 486);
            this.Controls.Add(this.btnModMat);
            this.Controls.Add(this.btncreateMat);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pnlHoldingtotmat);
            this.Controls.Add(this.pnlProductNum);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlResizingMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaterials";
            this.Text = "frmMaterials";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlHoldingtotmat.ResumeLayout(false);
            this.pnlHoldingtotmat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnModMat;
        private Button btncreateMat;
        private DataGridView dgvProduct;
        private DateTimePicker dateTimePicker1;
        private Panel pnlHoldingtotmat;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Label lblNumMaterials;
        private Panel pnlProductNum;
        private Button btnRefresh;
        private Panel pnlResizingMaterials;
    }
}