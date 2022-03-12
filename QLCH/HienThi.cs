using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLCH
{
    public partial class HienThi : Form
    {
        //Nam: DESKTOP-KNN7K79
        //Vinh: DESKTOP-IKJI0OQ\SQLEXPRESS
        string cnt = "Data Source = DESKTOP-KNN7K79; Initial Catalog = QLCH; Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataTable dt = null;
        List<SelectedSP> addedSanPham = new List<SelectedSP>();
        private string id = "";
        private string loginID = "";
        public HienThi(string id, string loginID)
        {
            InitializeComponent();
            if (id != "")
            {
                MessageBox.Show("Bạn đang xem hóa đơn với id: " + id);
                this.id = id.Trim();
                tbID.Text += this.id;
                this.loginID = loginID.Trim();
                label_Name.Text += this.loginID;
                getDGVdata();
            }
            else
            {
                this.Close();
            }
        }

        private void HienThi_Load(object sender, EventArgs e)
        {

        }
        private void getDGVdata()
        {
            using (SqlConnection connection = new SqlConnection(cnt))
            {
                using (SqlCommand cmd = new SqlCommand() { })
                {
                    connection.Open();
                    cmd.CommandText = "Select * from HoaDon_SanPham join SanPham on idSP = id where idHD = '" + id + "'";
                    cmd.Connection = connection;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        addedSanPham.Add(new SelectedSP() { ID = reader["id"].ToString(), Name = reader["name"].ToString(), Qty = Convert.ToInt32(reader["slSP"].ToString()), Price = Convert.ToInt32(reader["price"].ToString()) * Convert.ToInt32(reader["slSP"].ToString()) });
                        lbPriceS.Text = "Tổng cộng: " + (Convert.ToInt32(lbPriceS.Text.Split(':').Last().Trim()) + Convert.ToInt32(reader["price"].ToString()) * Convert.ToInt32(reader["slSP"].ToString()));
                        lbPriceS.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    dataGridView1.DataSource = addedSanPham;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.Columns["ID"].Visible = false;
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
