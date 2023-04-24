namespace BUDSgui
{
    public partial class frmRegsiter : Form
    {
        User rUser = new User();
        public frmRegsiter(bool check)
        {
            InitializeComponent();
            if (check == true)
            {
                lblWelcome.Text = "Create new Password";
                txtNewUsername.Visible = false;
                lblUsername.Visible = false;
                btnUpdate.Visible = false;
                txtNewPassword.Location = new Point(62, 164);
                lblPassword.Location = new Point(46, 141);
            }
            else
            {
                btnAlternateLogin.Visible = false;
            }
        }

        private void lblReturnToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegsiter_Click(object sender, EventArgs e)
        {
            if(txtNewUsername.Text == string.Empty || txtNewPassword.Text == string.Empty || txtUserID.Text == string.Empty)
            {
                MessageBox.Show("Please fill out all fields, none can be blank!","Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(rUser.loginCheck(txtUserID.Text))
            {
                string nUsername = txtNewUsername.Text;
                string nPassword = txtNewPassword.Text;
                string UserID = txtUserID.Text;
                rUser.registerUser(nUsername, nPassword, UserID);
                this.Close();
            }
        }

        private void btnAlternateLogin_Click(object sender, EventArgs e)
        {
            string nPassword = txtNewPassword.Text;
            string UserID = txtUserID.Text;
            rUser.forgotPassword(nPassword, UserID);
            this.Close();
        }
       
    }
}
