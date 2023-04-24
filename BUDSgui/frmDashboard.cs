using System.Data;
using System.Data.SqlClient;
using ClosedXML.Excel;

namespace BUDSgui
{
    public partial class frmDashboard : Form
    {
        Product p = new Product();
        User u = new User();
        RawMaterial r = new RawMaterial();
        private User userDash;

        DatabaseConnection connection = new DatabaseConnection();
        public frmDashboard(ref User newUser, int frmHeight, int formWidth)
        {
            userDash = newUser;

            InitializeComponent();

            this.Height = frmHeight;
            this.Width= formWidth;

            checkRole(userDash);
        }

        private void btnGRMT_Click(object sender, EventArgs e)
        {
            ReportGeneration();
        }

        private void ReportGeneration()
        {
            var productTable = new DataTable();
            var materialTable = new DataTable();

            productTable.TableName = "Products";
            materialTable.TableName = "Materials";

            connection.open();
            using (var da = new SqlDataAdapter("SELECT * from RawMaterials", connection.Connection))
            {
                da.Fill(materialTable);
            }
            using (var da = new SqlDataAdapter("SELECT * from Products", connection.Connection))
            {
                da.Fill(productTable);
            }
            connection.close();

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(materialTable);
                            workbook.Worksheets.Add(productTable);

                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have successfully exported your data to an Excel file", "Message", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
            }

        }

        private void checkRole(User newuser)
        {
            string value;
            string check = newuser.UserType;
            if (check == "stockManager")
            {
                value = Convert.ToString(r.countMaterials());
                LblD1.Text = value;

                value = Convert.ToString(r.countMaterialStockStatus(1));
                lblD2.Text = value;
                lblL2.Text = "Low Stock Materials";

                value = Convert.ToString(r.countMaterialStockStatus(2));
                lblD3.Text = value;
                lblL3.Text = "High Stock Materials";

                value = Convert.ToString(p.countProductQuality(2));
                lblD4.Text = value;
                lblL4.Text = "Total Bad Products";
            }
            else if (check == "productManager")
            {
                value = Convert.ToString(p.countProducts());
                lblD2.Text = value;

                value = Convert.ToString(r.countMaterials());
                LblD1.Text = value;

                value = Convert.ToString(r.countMaterialStatus(3));
                lblD3.Text = value;
                lblL3.Text = "Materials Not-Set";

                value = Convert.ToString(r.countMaterialStatus(2));
                lblD3.Text = value;
                lblL3.Text = "Bad Materials";
            }
            else if (check == "qualityAnalyzer")
            {
                value = Convert.ToString(p.countProducts());
                LblD1.Text = value;
                lblL1.Text = "Total Products";

                value = Convert.ToString(p.countProductQuality(3));
                lblD2.Text = value;
                lblL2.Text = "Products Not-Set";

                value = Convert.ToString(p.countProductQuality(1));
                lblD3.Text = value;
                lblL3.Text = "Total Good Products";

                value = Convert.ToString(p.countProductQuality(2));
                lblD4.Text = value;
                lblL4.Text = "Total Bad Products";
            }
            else if (check == "deliveryManager")
            {
                value = Convert.ToString(p.countProducts());
                LblD1.Text = value;
                lblL1.Text = "Total Products";

                value = Convert.ToString(p.countProductStatus(3));
                lblD2.Text = value;
                lblL2.Text = "Products Not-Set";

                value = Convert.ToString(p.countProductStatus(1));
                lblD3.Text = value;
                lblL3.Text = "Total Good Products";

                value = Convert.ToString(p.countProductStatus(2));
                lblD4.Text = value;
                lblL4.Text = "Total Bad Products";
            }
            else if(check == "admin")
            {
                value = Convert.ToString(p.countProducts());
                lblD2.Text = value;

                value = Convert.ToString(r.countMaterials());
                LblD1.Text = value;

                value = Convert.ToString(u.countUsers());
                lblD3.Text = value;

                value = Convert.ToString(p.countProductQuality(1));
                lblD4.Text = value;
                lblL4.Text = "Total Good Products";
            }
        }
    }
}
