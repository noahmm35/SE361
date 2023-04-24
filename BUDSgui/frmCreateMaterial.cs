using System.Data.SqlClient;

namespace BUDSgui
{
    public partial class frmCreateMaterial : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        private User? userCM;
        public frmCreateMaterial()
        {
            InitializeComponent();
            btnImport.Enabled = false;
        }

        public frmCreateMaterial(bool create, ref User newuser)
        {
            userCM = newuser;
            InitializeComponent();
            checkRole(userCM);
            if (create == true)
            {
                pnlModifyMat.Visible = false;
            }
            else
            {
                pnlModifyMat.Visible = true;
                fillcbo();
            }

            btnImport.Enabled = false;
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            RawMaterial mat = new RawMaterial();

            int stock = Convert.ToInt32(txtQuantity.Text);
            mat.ItemName = txtMaterialName.Text;
            mat.ItemStock = stock;

            mat.addMaterial();
            this.Hide();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            import();
        }

        private void btnUpdateMat_Click(object sender, EventArgs e)
        {
            RawMaterial material = new RawMaterial();
            material.ItemStock = Convert.ToInt32(txtItemStock.Text);
            material.ItemID = Convert.ToInt32(cboMatID.Text);
            material.ItemName = txtMatName.Text;
            material.ItemStatus = cboMatQuality.Text;

            material.updateMaterial();

            if(cboMatQuality.Text != String.Empty)
            {
                material.updateMaterialStatus();
            }
            this.Close();
        }

        private void fillcbo()
        {
            db.open();
            string queryString = "Select itemID from RawMaterials";
            SqlCommand cmdl = new SqlCommand(queryString, db.Connection);
            using (SqlDataReader reader = cmdl.ExecuteReader())
            {
                while (reader.Read())
                {
                    cboMatID.Items.Add(reader.GetInt32(0));
                }
            }
            db.close();
        }

        private void import()
        {
            db.open();
            string queryString = "Select * from RawMaterials where ItemID =" + cboMatID.Text + ";";
            SqlCommand cmdl = new SqlCommand(queryString, db.Connection);
            using (SqlDataReader reader = cmdl.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtMatName.Text = reader.GetString(1);
                    string value = Convert.ToString(reader.GetInt32(2));
                    txtItemStock.Text = value;
                    //cboStatus.Text = reader.GetString(3);
                }
            }
            db.close();
        }
        public void checkRole(User newuser)
        {
            string check = newuser.UserType;
            if (check == "stockManager")
            {
                //complete access
                cboMatQuality.Hide();
                lblMQuality.Hide();
            }
            else if (check == "productManager")
            {
                txtMatName.Enabled = false;
            }
            else
            {
                //nothing here
            }
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            RawMaterial material = new RawMaterial();
            material.ItemID = Convert.ToInt32(cboMatID.Text);
            material.deleteMaterial();
            this.Hide();
        }

        private void cboMatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnImport.Enabled = true;
        }

    }
}
