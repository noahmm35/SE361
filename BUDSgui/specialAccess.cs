namespace BUDSgui
{
    public partial class specialAccess : Form
    {
        BindingSource userBindingSource = new BindingSource();
        User registerUser = new User();
        tables dbt = new tables();
        private User? userS;

        public specialAccess()
        {
            InitializeComponent();
        }

        public specialAccess(ref User newuser, int frmHeight, int formWidth)
        {
            this.Height = frmHeight;
            this.Width = formWidth;

            userS = newuser;
            InitializeComponent();

            userBindingSource.DataSource = dbt.getAllusers();
            datagridUsers.DataSource = userBindingSource;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || cboxRole.Text == "")
                MessageBox.Show("Please fill out required boxes!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                registerUser.UserID = txtUserID.Text;
                registerUser.UserType = cboxRole.Text;
                registerUser.addUser(registerUser.UserID, registerUser.UserType);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //UserDAO Users = new UserDAO();
            userBindingSource.DataSource = dbt.getAllusers();
            datagridUsers.DataSource = userBindingSource;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {   
            if (txtUserID.Text == "")
                MessageBox.Show("Please make sure User ID field is filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtUserID.Text == userS.UserID)
            {
                MessageBox.Show("You cannot delete yourself silly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                registerUser.UserID = txtUserID.Text;
                registerUser.deleteUser(registerUser.UserID);
            }
        }

        
    }
}
