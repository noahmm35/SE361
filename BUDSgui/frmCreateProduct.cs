using System.Data.SqlClient;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace BUDSgui
{
    public partial class frmCreateProduct : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        private User userCP;
        int initStock = 0;

        public frmCreateProduct(ref User newuser, bool mod)
        {
            userCP = newuser;
            InitializeComponent();
            fillIDcbo();
            fillMatcbo();

            llbProdname.Hide();
            txtProdName.Hide();
            lblQuan.Hide();
            txtItemStock.Hide();
            lblQuality.Hide();
            cboQuality.Hide();
            lblDS.Hide();
            cboDS.Hide();
            btnImport.Enabled = false;

            if (mod == true)
            {
                pnlModifyProd.Visible = true;
                lblPCWelcome.Text = "Update Product";
            }
            else
            {
                pnlModifyProd.Visible = false;
            }

            if (userCP.UserType == "qualityAnalyzer" || userCP.UserType == "deliveryManager")
            {
                btnUpdateProductMaterials.Hide();
                btndeletProduct.Hide();
                btnUpdateProd.Location = new System.Drawing.Point(203, 239);
            }
            else
            {
                //they have complete access
            }

        }

        private void fillIDcbo()
        {
            connection.open();
            string queryString = "Select prodID from Products";
            SqlCommand cmdl = new SqlCommand(queryString, connection.Connection);
            using (SqlDataReader reader = cmdl.ExecuteReader())
            {
                while (reader.Read())
                {
                    cboProdID.Items.Add(reader.GetInt32(0));
                }
            }
            connection.close();
        }

        private void fillMatcbo()
        {
            connection.open();
            string queryString = "Select itemName from RawMaterials";
            SqlCommand cmdl = new SqlCommand(queryString, connection.Connection);
            using (SqlDataReader reader = cmdl.ExecuteReader())
            {
                while (reader.Read())
                {
                    cboMaterial3.Items.Add(reader.GetString(0));
                    cboMaterial1.Items.Add(reader.GetString(0));
                    cboMaterial2.Items.Add(reader.GetString(0));
                }
            }
            connection.close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            import();
            importHelp(userCP);
            initStock = Convert.ToInt32(txtItemStock.Text);
        }

        private void importHelp(User newuser)
        {
            string check = newuser.UserType;

            llbProdname.Show();
            txtProdName.Show();
            lblQuan.Show();
            txtItemStock.Show();
            lblQuality.Show();
            cboQuality.Show();
            lblDS.Show();
            cboDS.Show();

            if (check == "productManager" || check == "admin")
            {
                //complete access
            }
            else if (check == "qualityAnalyzer")
            {
                txtProdName.Enabled = false;
                txtItemStock.Enabled = false;
                cboDS.Enabled = false;
            }
            else if (check == "deliveryManager")
            {
                txtProdName.Enabled = false;
                txtItemStock.Enabled = false;
                cboQuality.Enabled = false;
            }
        }
        private void import()
        {
            connection.open();
            string queryString = "Select * from Products where prodID =" + cboProdID.Text + ";";
            SqlCommand cmdl = new SqlCommand(queryString, connection.Connection);
            if (cboProdID.Text != null)
            {
                using (SqlDataReader reader = cmdl.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtProdName.Text = reader.GetString(1);
                        string value = Convert.ToString(reader.GetInt32(2));
                        txtItemStock.Text = value;
                        cboDS.Text = reader.GetString(3);
                        cboQuality.Text = reader.GetString(4);
                    }
                }
                connection.close();
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            int stock = Convert.ToInt32(txtQuantity.Text);
            product.ProdName = txtProductName.Text;
            product.ProdStock = stock;
            bool check1 = true;
            bool check2 = true;
            bool check3 = true;
            //I still think keep add product but the use if statments below to calculate and alter quantity of raw materials 
            RawMaterial mat = new RawMaterial();
            if (product.ProdName != String.Empty && product.ProdStock >= 1)
            {
                if (cboMaterial1.Text != String.Empty && Convert.ToInt32(nudQuantityMat1.Text) >= 1)
                {
                    //if this doesnt work txt me and I can change it, but rn the first page still creates a product and this one handles Quantity of 
                    //RawMaterial m1 = new RawMaterial();
                    mat.ItemName = cboMaterial1.Text;
                    check1 = mat.updateStock(Convert.ToInt32(nudQuantityMat1.Text), Convert.ToInt32(txtQuantity.Text));

                    if (cboMaterial2.Text != String.Empty)
                    {
                        //call fucntion
                        //RawMaterial m2 = new RawMaterial();
                        mat.ItemName = cboMaterial2.Text;
                        check2 = mat.updateStock(Convert.ToInt32(nudQuantityMat2.Text), Convert.ToInt32(txtQuantity.Text));
                    }

                    if (cboMaterial3.Text != String.Empty)
                    {
                        //call function
                        //RawMaterial m3 = new RawMaterial();
                        mat.ItemName = cboMaterial3.Text;
                        check3 = mat.updateStock(Convert.ToInt32(nudQuantityMat3.Text), Convert.ToInt32(txtQuantity.Text));
                    }

                    if (check1 == true && check2 == true && check3 == true)

                        product.addProduct();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a material and quantity to create product!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name and quantity for your new product!");
            }

        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProdStock = Convert.ToInt32(txtItemStock.Text);
            product.ProdID = Convert.ToInt32(cboProdID.Text);
            product.ProdName = txtProdName.Text;
            product.ProdQuality = cboQuality.Text;
            product.ProdStatus = cboDS.Text;

            product.updateProduct();
            product.updateProductQuality();
            product.updateProductStatus();
            this.Hide();
        }

        private void btnUpdateProductMaterials_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProdID = Convert.ToInt32(cboProdID.Text);
            product.ProdName = txtProdName.Text;
            frmPRMInteractions PRMInteractions = new frmPRMInteractions(ref product, Convert.ToInt32(txtItemStock.Text), initStock) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlModifyProd.Controls.Add(PRMInteractions);
            PRMInteractions.BringToFront();
            PRMInteractions.Show();
        }


        //this can be changed, just have it to make sure people use the ID import for update materials
        private void cboProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdateProd.Enabled = true;
            btnUpdateProductMaterials.Enabled = true;
            btnImport.Enabled = true;
        }

        private void btndeletProduct_Click_1(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProdID = Convert.ToInt32(cboProdID.Text);
            product.deleteProduct();
            this.Hide();
        }
    }
}

