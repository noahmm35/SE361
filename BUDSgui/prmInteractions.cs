using System.Data.SqlClient;

namespace BUDSgui
{
    public partial class frmPRMInteractions : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        int initStock = 0;
        public frmPRMInteractions(ref Product product, int Quantity, int init)
        {
            InitializeComponent();
            this.FormClosing += frmPRMInteractions_FormClosing;
            cboPRMID.Text = product.ProdID.ToString();
            txtPRMQuantity.Text = Convert.ToString(Quantity);
            cboPRMID.Enabled = false;
            txtPRMQuantity.Enabled = false;
            fillcbo();
            initStock = init;
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            btnUpdateProductMaterial_Click(sender, e);
        }

        private void fillcbo()
        {
            db.open();
            string queryString = "Select itemName from RawMaterials";
            SqlCommand cmdl = new SqlCommand(queryString, db.Connection);
            using (SqlDataReader reader = cmdl.ExecuteReader())
            {
                while (reader.Read())
                {
                    cboPRMMaterial1.Items.Add(reader.GetString(0));
                    cboPRMMaterial2.Items.Add(reader.GetString(0));
                    cboPRMMaterial3.Items.Add(reader.GetString(0));
                }
            }
            db.close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdateProductMaterial_Click(object sender, EventArgs e)
        {
            RawMaterial mat = new RawMaterial();

            if (Convert.ToInt32(txtPRMQuantity.Text) - initStock < 0)
                MessageBox.Show("Materials were not updated because product decreased! If material needs to increase, go to modify materials!", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                if (cboPRMMaterial1.Text != String.Empty)
                {
                    mat.ItemName = cboPRMMaterial1.Text;
                    mat.updateStock(Convert.ToInt32(nudQuantityMat1.Text), Convert.ToInt32(txtPRMQuantity.Text) - initStock);
                }

                if (cboPRMMaterial2.Text != String.Empty)
                {
                    mat.ItemName = cboPRMMaterial2.Text;
                    mat.updateStock(Convert.ToInt32(nudQuantityMat2.Text), Convert.ToInt32(txtPRMQuantity.Text) - initStock);
                }

                if (cboPRMMaterial3.Text != String.Empty)
                {
                    mat.ItemName = cboPRMMaterial3.Text;
                    mat.updateStock(Convert.ToInt32(nudQuantityMat3.Text), Convert.ToInt32(txtPRMQuantity.Text) - initStock);
                }
            }

            this.Hide();
        }

        private void frmPRMInteractions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
