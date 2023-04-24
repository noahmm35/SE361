using System.Data.SqlClient;

namespace BUDSgui
{
    public class Product
    {
        DatabaseConnection c = new DatabaseConnection();
        private int id_;
        private string name_;
        private string quality_;
        private string status_;
        private int stock_;


        //currently used for the creation of products within Product table
        public Product()
        {
            id_ = 0;
            name_ = string.Empty;
            quality_ = string.Empty;
            status_ = string.Empty;
            stock_ = 0;
        }

        public Product(int id, string name, int stock, string quality, string status)
        {
            id_ = id;
            name_ = name;
            stock_ = stock;
            quality_ = quality;
            status_ = status;
        }

        public int ProdID
        {
            get { return id_; }
            set { id_ = value; }
        }

        public string ProdName
        {
            get { return name_; }
            set
            {
                if (value.Length! > 25)
                    throw new ArgumentException("Invalid Product Name (Too Long), please try again!");
                name_ = value;
            }
        }

        public int ProdStock
        {
            get { return stock_; }
            set { stock_ = value; }
        }

        public string ProdStatus
        {
            get
            {
                if (status_ == null)
                    return string.Empty;
                else
                    return status_;
            }
            set
            {
                if (value.Length > 20)
                    throw new ArgumentException("Invalid Product Status!");
                status_ = value;
            }
        }

        public string ProdQuality
        {
            get { return quality_; }
            set
            {
                if (value.Length > 20)
                    throw new ArgumentException("Invalid Product Quality!");
                quality_ = value;
            }
        }

        public void addProduct()
        {
            c.open();
            string queryString = "insert into Products(prodName, prodStock, prodStatus, prodQuality) values('" + name_ + "', '" + stock_ + "', 'Not Set', 'Not Set');";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();
            c.close();
        }

        public void deleteProduct()
        {
            c.open();

            if (!idExists(ProdID))
            {
                MessageBox.Show("ID number not found! Please reference table below!");
                return;
            }

            string queryString = "delete from Products where prodID = '" + id_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();

            c.close();
        }

        public void updateProduct()
        {
            c.open();

            if (!idExists(ProdID))
            {
                MessageBox.Show("ID number not present in database, please try again!");
                return;
            }

            string queryString = "update Products Set prodName = '" + name_ + "', prodStock = '" + stock_ + "' where prodId = '" + id_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();
            c.close();
        }

        public void updateProductStatus()
        {
            c.open();

            if (!idExists(ProdID))
            {
                MessageBox.Show("ID number not present in database, please try again!");
                return;
            }

            string queryString = "update Products set prodStatus = '" + status_ + "' where prodID = '" + id_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();
            c.close();
        }

        public void updateProductQuality()
        {
            c.open();

            if (!idExists(ProdID))
            {
                MessageBox.Show("ID number not present in database, please try again!");
                return;
            }

            string queryString = "update Products set prodQuality = '" + quality_ + "' where prodID = '" + id_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();
            c.close();
        }

        public int countProducts()
        {
            c.open();
            string queryString = "Select COUNT(*) from Products;";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int v = (int)cmd.ExecuteScalar();
            c.close();
            return v;
        }

        public bool idExists(int id)
        {
            string queryString = "select count(*) from Products where prodID = '" + id + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int v = (int)cmd.ExecuteScalar();

            if (v > 0)
                return true;
            else
                return false;
        }

        public int countProductStatus(int selection)
        {
            int v;
            c.open();
            if (selection == 1)
            {
                string queryString = "Select COUNT(*) from Products where prodStatus = 'Useful';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            else if (selection == 2)
            {
                string queryString = "Select COUNT(*) from Products where prodStatus = 'Useless';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            else
            {
                string queryString = "Select COUNT(*) from Products where prodStatus = 'Not Set';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            c.close();
            return v;
        }

        public int countProductQuality(int selection)
        {
            int v;
            c.open();
            if (selection == 1)
            {
                string queryString = "Select COUNT(*) from Products where prodQuality = 'Good';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            else if (selection == 2)
            {
                string queryString = "Select COUNT(*) from Products where prodQuality = 'Bad';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            else
            {
                string queryString = "Select COUNT(*) from Products where prodQuality = 'Not Set';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            c.close();
            return v;
        }

        public int retrieveQuantity()
        {
            return 1;
        }
    }
}
