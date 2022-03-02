using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCH
{
    public partial class HoaDon : Form
    {
        string cnt = "Data Source = DESKTOP-IKJI0OQ\\SQLEXPRESS; Initial Catalog = QLCH; Integrated Security = True";
        public HoaDon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(cnt))
            {
                string saveBill = "INSERT into SanPham (id, name, quantity, price) VALUES (@id, @name, @quantity, @price)";
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = saveBill;
                    cmd.Parameters.AddWithValue("@id", idDonHang);
                    cmd.Parameters.AddWithValue("@name", tenHang);
                    cmd.Parameters.AddWithValue("@quantity", soLuong);
                    cmd.Parameters.AddWithValue("@price", donGia);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
