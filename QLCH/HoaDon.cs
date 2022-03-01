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
        SqlConnection sc;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        public HoaDon()
        {
            InitializeComponent();
            string cnt = @"Data Source = DESKTOP-IKJI0OQ\SQLEXPRESS; Initial Catalog = QLCH; Integrated Security = True";
            sc = new SqlConnection(cnt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(idDonHang.Text == "" || tenHang.Text == "" || int.Parse(soLuong.Text) == 0 || int.Parse(donGia.Text) == 0)
            {
                MessageBox.Show("Hay dien vao form");
            }
            else
            {
                try
                {
                    sc.Open();
                    cmd = new SqlCommand("insert into SanPham (id, name, quantity, price) values ('"+idDonHang.Text+"','" + tenHang.Text + "','"+ int.Parse(soLuong.Text) + "','"+ int.Parse(donGia.Text) + "'",sc);
                    cmd.ExecuteNonQuery();
                    sc.Close();
                    MessageBox.Show("Da them thanh cong");

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        //public void display()
        //{

        //}
    }
}
