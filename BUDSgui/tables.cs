using System.Data.SqlClient;

namespace BUDSgui
{
    internal class tables
    {
        DatabaseConnection connection = new DatabaseConnection();

        public List<Product> getAllproducts()
        {
            List<Product> products = new List<Product>();
            connection.open();
            string queryString = "Select * from Products";
            SqlCommand cmd1 = new SqlCommand(queryString, connection.Connection);

            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        ProdID = reader.GetInt32(0),
                        ProdName = reader.GetString(1),
                        ProdStock = reader.GetInt32(2),
                        ProdStatus = reader.GetString(3),
                        ProdQuality = reader.GetString(4)
                    };
                    products.Add(product);
                }
            }
            connection.close();
            return products;
        }

        public List<RawMaterial> getAllMaterials()
        {
            List<RawMaterial> Materials = new List<RawMaterial>();
            connection.open();
            string queryString = "Select * from RawMaterials";
            SqlCommand cmdl = new SqlCommand(queryString, connection.Connection);

            using (SqlDataReader reader = cmdl.ExecuteReader())
            {
                while (reader.Read())
                {
                    RawMaterial Material = new RawMaterial
                    {
                        ItemID = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        ItemStock = reader.GetInt32(2),
                        ItemStatus = reader.GetString(3)
                    };
                    Materials.Add(Material);
                }
            }
            connection.close();
            return Materials;
        }

        public List<User> getAllusers()
        {
            List<User> users = new List<User>();
            connection.open();
            string queryString1 = "Select * from Users";
            SqlCommand cmd1 = new SqlCommand(queryString1, connection.Connection);

            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User
                    {
                        UserID = reader.GetString(0),
                        Password = reader.GetString(1),
                        Username = reader.GetString(2),
                        UserType = reader.GetString(3)
                    };
                    users.Add(user);
                }
            }
            connection.close();
            return users;
        }

        public void addProduct(string name, string material, int quantity)
        {
            connection.open();
            int total = countProductsInside();
            int ID = 1000000 + total;
            string queryString = "INSERT INTO Products VALUES ('" + ID + "', '" + name + "', 'Unknown', 'Unknown', '" + null + "', '" + material + "', '" + quantity + "' );";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            cmd.ExecuteNonQuery();
            connection.close();
        }

        public void addMaterial(string name, int quantity)
        {
            connection.open();
            int total = countMaterialsInside();
            int ID = 1 + total;
            string queryString = "INSERT INTO Raw_Materials VALUES ('" + ID + "', '" + name + "', '" + quantity + "' , 'Unknown','" + null + "');";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            cmd.ExecuteNonQuery();
            connection.close();
        }

        public int countProducts()
        {
            connection.open();
            string queryString = "Select COUNT(*) from Products;";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            int v = (int)cmd.ExecuteScalar();
            connection.close();
            return v;
        }

        private int countProductsInside()
        {
            string queryString = "Select COUNT(*) from Products;";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            int v = (int)cmd.ExecuteScalar();
            return v;
        }

        public int countMaterials()
        {
            connection.open();
            string queryString = "Select COUNT(*) from RawMaterials;";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            int v = (int)cmd.ExecuteScalar();
            connection.close();
            return v;
        }

        private int countMaterialsInside()
        {
            string queryString = "Select COUNT(*) from RawMaterials;";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            int v = (int)cmd.ExecuteScalar();
            return v;
        }

        public void deleteUser(String userid)
        {
            connection.open();
            string queryString = "delete from Users where UserID='" + userid + "';";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            cmd.ExecuteNonQuery();
            connection.close();
        }

        public void addUser(String userid, String usertype)
        {
            connection.open();
            string queryString = "insert into Users values ('" + userid + "', '" + null + "', '" + null + "', '" + usertype + "');";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            cmd.ExecuteNonQuery();
            connection.close();
        }

        public void updateMaterials(string name, int quantity, string status, int ID)
        {
            connection.open();
            string queryString = "update RawMaterials Set itemName = '" + name + "', itemStock = " + quantity + ", itemStatus ='" + status + "' where itemID = " + ID + ";";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            cmd.ExecuteNonQuery();
            connection.close();
        }

        public String getUserType(string username, string password)
        {
            connection.open();
            string queryString = "select UserType from Users where Username = '" + username + "' AND UserPassword = '" + password + "' ;";
            SqlCommand cmd = new SqlCommand(queryString, connection.Connection);
            string v = (string)cmd.ExecuteScalar();
            connection.close();
            return v;
        }
    }
}
