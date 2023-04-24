namespace BUDSgui
{
    public partial class frmMaterials : Form
    {
        tables dbt = new tables();
        BindingSource mbs = new BindingSource();
        private User userM;
        public frmMaterials(ref User newuser, int frmHeight, int formWidth)
        {
            this.Height = frmHeight;
            this.Width = formWidth;

            userM = newuser;
            InitializeComponent();


            checkRole(userM);
            string value = Convert.ToString(dbt.countMaterials());
            lblNumMaterials.Text = value;
            mbs.DataSource = dbt.getAllMaterials();
            dgvProduct.DataSource = mbs;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string value = Convert.ToString(dbt.countMaterials());
            lblNumMaterials.Text = value;
            mbs.DataSource = dbt.getAllMaterials();
            dgvProduct.DataSource = mbs;
        }

        private void btncreateMat_Click(object sender, EventArgs e)
        {
            frmCreateMaterial frmCreateMaterial = new frmCreateMaterial(true, ref userM);
            frmCreateMaterial.Show();
        }

        private void btnModMat_Click(object sender, EventArgs e)
        {
            frmCreateMaterial frmCreateMaterial = new frmCreateMaterial(false, ref userM);
            frmCreateMaterial.Show();
        }

        public void checkRole(User newuser)
        {
            string check = newuser.UserType;
            if (check == "stockManager")
            {
                //nothing they have full access
            }
            else if (check == "productManager")
            {
                btncreateMat.Visible = false;
                btnModMat.Location = new Point(27, 31);
                btnModMat.Anchor= AnchorStyles.Top| AnchorStyles.Left;
            }
            else
            {
                //nothing here
            }
        }
    }
}
