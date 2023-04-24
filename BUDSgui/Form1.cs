namespace BUDSgui
{
    public partial class frmLogin : Form
    {
        private User newUser;
        private int LoginAttempts = 1;

        public frmLogin()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            newUser = new User();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmRegsiter frmRegsiter = new frmRegsiter(true) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlChange.Controls.Add(frmRegsiter);
            frmRegsiter.BringToFront();
            frmRegsiter.Show();
        }

        private void lblRegsiter_Click(object sender, EventArgs e)
        {
            frmRegsiter frmRegsiter = new frmRegsiter(false) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlChange.Controls.Add(frmRegsiter);
            frmRegsiter.BringToFront();
            frmRegsiter.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please fill out necessary fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPassword.Text;
            newUser.UserID = newUser.retrieveID(newUser.Username);

            if (newUser.validateCredentials())
            {
                this.Hide();
                newUser.UserType = newUser.getUserType(newUser.Username, newUser.Password);
                frmMainpage frmMainpage = new frmMainpage(ref newUser);
                frmMainpage.Show();
            }
            else if (LoginAttempts == 3)
            {
                MessageBox.Show("Three invalid login attempts, use your ID to change your password");
                frmRegsiter frmRegsiter = new frmRegsiter(true) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlChange.Controls.Add(frmRegsiter);
                frmRegsiter.BringToFront();
                frmRegsiter.Show();
                LoginAttempts = 1;
            }
            else
            {
                MessageBox.Show("Login credentials invalid, ensure that everything was entered correctly!");
                LoginAttempts++;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmLogin_Shown_1(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}