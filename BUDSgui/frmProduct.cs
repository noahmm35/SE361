namespace BUDSgui
{
    public partial class frmProduct : Form
    {
        Product p = new Product();
        tables dbt = new tables();
        BindingSource productBindingSource = new BindingSource();
        private User? userP;
        public frmProduct(ref User newuser, int frmHeight, int formWidth)
        {
            this.Height = frmHeight;
            this.Width = formWidth;

            userP = newuser;
            InitializeComponent();
            checkRole(userP);
            string value = Convert.ToString(p.countProducts());
            lblNumProducts.Text = value;
            productBindingSource.DataSource = dbt.getAllproducts();
            dgvProduct.DataSource = productBindingSource;
        }

        private void btnCreateP_Click(object sender, EventArgs e)
        {
            frmCreateProduct frmCreateProduct = new frmCreateProduct(ref userP, false);
            frmCreateProduct.Show();
        }

        private void btnModP_Click(object sender, EventArgs e)
        {
            frmCreateProduct frmCreateProduct = new frmCreateProduct(ref userP, true);
            frmCreateProduct.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string value = Convert.ToString(p.countProducts());
            lblNumProducts.Text = value;
            productBindingSource.DataSource = dbt.getAllproducts();
            dgvProduct.DataSource = productBindingSource;
        }
        public void checkRole(User newuser)
        {
            string check = newuser.UserType;
            if (check == "productManager")
            {
                //has complete access
            }
            else if (check == "qualityAnalyzer")
            {
                btnCreateP.Visible = false;
                btnModP.Location = new Point(27, 31);
                btnModP.Anchor = AnchorStyles.Top| AnchorStyles.Left;
            }
            else if (check == "deliveryManager")
            {
                btnCreateP.Visible = false;
                btnModP.Location = new Point(27, 31);
                btnModP.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
            else
            {
                //nothing here
            }
        }


    }
}
