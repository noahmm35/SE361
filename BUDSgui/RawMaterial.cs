using System.Data.SqlClient;

namespace BUDSgui
{
    internal class RawMaterial
    {
        DatabaseConnection c = new DatabaseConnection();
        private int id_;
        private string name_;
        private int stock_;
        private string status_;

        //currently used for the creation of raw materials in Raw Materials table
        public RawMaterial()
        {
            id_ = 0;
            name_ = string.Empty;
            stock_ = 0;
            status_ = string.Empty;
        }

        public RawMaterial(int id, string name, int stock, string status)
        {
            id_ = id;
            name_ = name;
            stock_ = stock;
            status_ = status;
        }

        public int ItemID
        {
            get { return id_; }
            set { id_ = value; }
        }

        public string ItemName
        {
            get { return name_; }
            set
            {
                if (value.Length > 20)
                    throw new ArgumentException("Invalid Material Name!");
                name_ = value;
            }
        }

        public int ItemStock
        {
            get { return stock_; }
            set { stock_ = value; }
        }

        public string ItemStatus
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
                    throw new ArgumentException("Invalid Material Status!");
                status_ = value;
            }
        }

        public void addMaterial()
        {
            c.open();
            string queryString = "INSERT INTO RawMaterials(itemName, itemStock, itemStatus) VALUES ('" + name_ + "', '" + stock_ + "','Not Set');";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();
            c.close();
        }
        public void updateMaterial()
        {
            c.open();

            if (!idExists(ItemID))
            {
                MessageBox.Show("ID number not present in database, please try again!");
                return;
            }

            string queryString = "update RawMaterials Set itemName = '" + name_ + "', itemStock = '" + stock_ + "' where itemID = '" + id_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();
            c.close();
        }

        public bool updateStock(int adj, int pQuan)
        {
            c.open();

            //n1 sorry made changes to this so that making 10 notebooks that require 10 pieecs of paper takes 100 paper out of raw materials
            string queryString = "Update RawMaterials set itemStock = CASE " +
                "WHEN itemStock - " + adj * pQuan + " >= 0 THEN itemStock - " + adj * pQuan +
                " ELSE itemStock END Where itemName = '" + name_ + "' and itemStock - " + adj * pQuan + ">= 0;";

            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int rowsAFfected = cmd.ExecuteNonQuery();

            if (rowsAFfected == 0)
            {
                MessageBox.Show("Not enough material available to handle change for " + ItemName + "!");
                c.close();
                return false;
            }

            c.close();
            return true;
        }

        public bool updateStock(int adj)
        {
            c.open();

            string queryString = "Update RawMaterials set itemStock = CASE " +
                "WHEN itemStock - " + adj + " >= 0 THEN itemStock - " + adj +
                " ELSE itemStock END Where itemName = '" + name_ + "' and itemStock - " + adj + ">= 0;";

            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int rowsAFfected = cmd.ExecuteNonQuery();

            if (rowsAFfected == 0)
            {
                MessageBox.Show("Not enough material available to handle change for " + ItemName + "!");
                c.close();
                return false;
            }

            c.close();
            return true;
        }

        public void updateMaterialStatus()
        {
            c.open();

            if (!idExists(ItemID))
            {
                MessageBox.Show("ID number not present in database, please try again!");
                return;
            }

            string queryString = "update RawMaterials set itemStatus = '" + status_ + "' where itemID = '" + id_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();
            c.close();
        }

        public void deleteMaterial()
        {
            c.open();

            if (!idExists(ItemID))
            {
                MessageBox.Show("ID number not present in database, please try again!");
                return;
            }

            string queryString = "delete from RawMaterials where itemID = '" + id_ + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            cmd.ExecuteNonQuery();

            c.close();
        }

        public int countMaterials()
        {
            c.open();
            string queryString = "Select COUNT(*) from RawMaterials;";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int v = (int)cmd.ExecuteScalar();
            c.close();
            return v;
        }

        public int countMaterialStatus(int selection) // 1 == good, 2 == bad, 3 == not Set
        {
            int v;
            c.open();
            if(selection == 1)
            {
                string queryString = "Select COUNT(*) from RawMaterials where itemStatus = 'Good';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            else if(selection == 2)
            {
                string queryString = "Select COUNT(*) from RawMaterials where itemStatus = 'Bad';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            else
            {
                string queryString = "Select COUNT(*) from RawMaterials where itemStatus = 'Not Set';";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            c.close();
            return v;
        }

        public int countMaterialStockStatus(int selection) // 1 == good, 2 == bad, 3 == not Set
        {
            int v;
            c.open();
            if (selection == 1)
            {
                string queryString = "Select COUNT(*) from RawMaterials where itemStock > 50;";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            else
            {
                string queryString = "Select COUNT(*) from RawMaterials where itemStock < 50;";
                SqlCommand cmd = new SqlCommand(queryString, c.Connection);
                v = (int)cmd.ExecuteScalar();
            }
            c.close();
            return v;
        }

        public bool idExists(int id)
        {
            string queryString = "select count(*) from RawMaterials where itemID = '" + id + "';";
            SqlCommand cmd = new SqlCommand(queryString, c.Connection);
            int v = (int)cmd.ExecuteScalar();

            if (v > 0)
                return true;
            else
                return false;
        }
    }
}
