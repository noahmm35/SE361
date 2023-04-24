using System.Diagnostics;

namespace BUDSgui
{
    public partial class frmMainpage : Form
    {
        private User? mainUser;
        private int frmHeight;
        private int frmWidth;

        public frmMainpage()
        {
            InitializeComponent();
        }

        public frmMainpage(ref User newuser)
        {
            InitializeComponent();
            this.FormClosing += FrmMainPage_FormClosing;
            mainUser = newuser;
            lblWelcome.Text = "Welcome " + newuser.Username;
            checkRole(mainUser);

            frmHeight = pnlMainChanges.Height;
            frmWidth = pnlMainChanges.Width;

            frmDashboard frmDashboard = new frmDashboard(ref mainUser, frmHeight, frmWidth) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlMainChanges.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmHeight = pnlMainChanges.Height;
            frmWidth = pnlMainChanges.Width;
            frmDashboard frmDashboard = new frmDashboard(ref mainUser, frmHeight, frmWidth) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlMainChanges.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmHeight = pnlMainChanges.Height;
            frmWidth = pnlMainChanges.Width;
            frmProduct frmProduct = new frmProduct(ref mainUser, frmHeight, frmWidth) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlMainChanges.Controls.Add(frmProduct);
            frmProduct.BringToFront();
            frmProduct.Show();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            frmHeight = pnlMainChanges.Height;
            frmWidth = pnlMainChanges.Width;
            frmMaterials material = new frmMaterials(ref mainUser, frmHeight, frmWidth) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlMainChanges.Controls.Add(material);
            material.BringToFront();
            material.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmHeight = pnlMainChanges.Height;
            frmWidth = pnlMainChanges.Width;
            specialAccess specialAccess = new specialAccess(ref mainUser, frmHeight, frmWidth) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlMainChanges.Controls.Add(specialAccess);
            specialAccess.BringToFront();
            specialAccess.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void checkRole(User newuser)
        {
            string check = newuser.UserType;
            if (check == "stockManager")
            {
                btnAdmin.Visible = false;
                btnProducts.Visible = false;
                btnWarehouse.Location = new Point(3, 182);
            }
            else if (check == "productManager")
            {
                btnAdmin.Visible = false;
            }
            else if (check == "qualityAnalyzer")
            {
                btnAdmin.Visible = false;
                btnWarehouse.Visible = false;
            }
            else if (check == "deliveryManager")
            {
                btnAdmin.Visible = false;
                btnWarehouse.Visible = false;
            }
            else
            {
                //nothing here
            }
        }

        private void FrmMainPage_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
