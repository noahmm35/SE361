using System.Data.SqlClient;

namespace BUDSgui
{
    public class User
    {
        DatabaseConnection c = new DatabaseConnection();
        private string userID_;
        private string username_;
        private string password_;
        private string userType_;

        public User()
        {
            userID_ = string.Empty;
            username_ = string.Empty;
            password_ = string.Empty;
            userType_ = string.Empty;
        }

        public string UserType
        {
            get { return userType_; }
            set
            {
                if (value.Length > 30)
                    throw new ArgumentException("Invalid User Type!");
                userType_ = value;
            }
        }

        public string Username
        {
            get { return username_; }
            set 
            { username_ = value; }
        }

        public string Password
        {
            get { return password_; }
            set { password_ = value; }
        }

        public string UserID
        {
            get { return userID_; }
            set {userID_ = value; }
        }

        public bool validateCredentials()
        {
            c.open();

            string queryString = "Select COUNT(*) from Users where Username = '" + username_ + "' and UserPassword = '" + password_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int v = (int)cmd.ExecuteScalar();

            c.close();

            if (v > 0)
                return true;
            else
                return false;
        }

        public void deleteUser(String userid)
        {
            c.open();

            if (!idExists(userid))
            {
                MessageBox.Show("ID number not present in database, please try again!");
                return;
            }
            else
            {
                string queryString = "delete from Users where UserID='" + userid + "';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                cmd.ExecuteNonQuery();
            }

            c.close();
        }

        public void addUser(String userid, String usertype)
        {
            c.open();

            if (idExists(userid))
            {
                MessageBox.Show("That ID Number already exists! Reference the table below!");
                return;
            }
            else
            {
                string queryString = "insert into Users values ('" + userid + "', '" + null + "', '" + null + "', '" + usertype + "');";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                cmd.ExecuteNonQuery();
            }

            c.close();
        }

        public void registerUser(string username, string nPassword, string UserID)
        {
            DatabaseConnection connection = new DatabaseConnection();
            connection.open();
            string queryString = "UPDATE Users set Username = '" + username + "', UserPassword = '" + nPassword + "' where UserID = '" + UserID + "';";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            cmd.ExecuteNonQuery();
            connection.close();

        }

        public void forgotPassword(string nPassword, string UserID)
        {
            DatabaseConnection connection = new DatabaseConnection();
            connection.open();
            string queryString = "UPDATE Users set UserPassword = '" + nPassword + "' where UserID = '" + UserID + "';";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            cmd.ExecuteNonQuery();
            connection.close();
        }

        public String getUserType(string username, string password)
        {
            c.open();
            string queryString = "select UserType from Users where Username = '" + username + "' AND UserPassword = '" + password + "' ;";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            string v = (string)cmd.ExecuteScalar();
            c.close();
            return v;
        }

        public bool idExists(string id)
        {
            string queryString = "select count(*) from Users where UserID = '" + id + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int v = (int)cmd.ExecuteScalar();

            if (v > 0)
                return true;
            else
                return false;
        }

        public bool loginCheck(string id)
        {
            // check for id existing and username being null w/ said id
            // if username != null, id is already in use and is not suitable for new account

            c.open();

            string queryString = "select count(*) from Users where UserID = '" + id + "' and Username='';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int rowsAffected = (int)cmd.ExecuteScalar();
            bool b = idExists(id);
            c.close();

            if (rowsAffected > 0)
            {             
                return true;
            }
            else
            {
                if (b)
                    MessageBox.Show("This ID is already taken by another associate! Ensure info was entered correctly and/or contact an admin for assistance",
                        "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("ID number does not currently exist... Ensure info was entered correctly and/or contact an admin for assistance",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }           
        }

        public int countUsers()
        {
            c.open();
            string queryString = "select count(*) from Users;";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int v = (int)cmd.ExecuteScalar();
            c.close();
            return v;
        }

        public string retrieveID(string username)
        {
            string id = string.Empty;
            c.open();

            string queryString = "select userID from Users where Username = '" + username + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            id = (string)cmd.ExecuteScalar();

            c.close();
            return id;
        }
    }
}
