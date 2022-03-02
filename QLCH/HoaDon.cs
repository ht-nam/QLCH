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
        //Nam: DESKTOP-KNN7K79
        //Vinh: DESKTOP-IKJI0OQ\SQLEXPRESS
        string cnt = "Data Source = DESKTOP-KNN7K79; Initial Catalog = QLCH; Integrated Security = True";
        List<SanPham> sanPhams = new List<SanPham>();
        List<SelectedSP> selectedSPs = new List<SelectedSP>();

        public HoaDon(List<SanPham> sps)
        {
            InitializeComponent();
            sanPhams = sps;
            dataGridView1.DataSource = selectedSPs;
            foreach(SanPham sp in sanPhams)
            {
                cbbTenHang.Items.Add(sp);
            }
            cbbTenHang.DisplayMember = "name";
            tbSL.Enabled = false;
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
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
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

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenHang.SelectedIndex > -1)
                tbSL.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(tbSL.Text, out int sl);
            if (sl > 0 && check == true)
            {
                SanPham a = cbbTenHang.SelectedItem as SanPham;
                int i = selectedSPs.FindIndex(sp => sp.Name == a.Name);
                if (i == -1)
                {
                    selectedSPs.Add(new SelectedSP() { Name = a.Name, ID = a.ID, Qty = Convert.ToInt32(tbSL.Text), Price = Convert.ToInt32(tbSL.Text) * a.Price });
                } else
                {
                    selectedSPs[i].Qty += sl;
                    selectedSPs[i].Price = selectedSPs[i].Qty * a.Price;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = selectedSPs;
            } else
            {
                MessageBox.Show("Số lượng không hợp lệ");
            }
        }
    }

    public class SelectedSP
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}
