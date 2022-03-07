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
    public partial class ChinhSua : Form
    {
        private string id = "";
        //Nam: DESKTOP-KNN7K79
        //Vinh: DESKTOP-IKJI0OQ\SQLEXPRESS
        string cnt = "Data Source = DESKTOP-IKJI0OQ\\SQLEXPRESS; Initial Catalog = QLCH; Integrated Security = True";
        List<SanPham> sanPhams = new List<SanPham>();
        List<SelectedSP> addedSanPham = new List<SelectedSP>();

        public ChinhSua(string id, List<SanPham> sps)
        {
            InitializeComponent();
            if (id != "")
            {
                MessageBox.Show("Bạn đang chỉnh sửa hóa đơn với id: " + id);
                this.id = tbidDH.Text = id.Trim();
                sanPhams = sps;
                foreach (SanPham sp in sanPhams)
                {
                    cbbTenHang.Items.Add(sp);
                }
                cbbTenHang.DisplayMember = "name";
                getDGVdata();
                tbSL.Enabled = false;
            }
            else
            {
                this.Close();
            }
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
                        addedSanPham.Add(new SelectedSP() { ID =reader["id"].ToString(), Name =reader["name"].ToString(), Qty = Convert.ToInt32(reader["slSP"].ToString()), Price = Convert.ToInt32(reader["price"].ToString()) * Convert.ToInt32(reader["slSP"].ToString()) });
                        lbPrice.Text = "Tổng cộng: " + (Convert.ToInt32(lbPrice.Text.Split(':').Last().Trim()) + Convert.ToInt32(reader["price"].ToString()) * Convert.ToInt32(reader["slSP"].ToString()));
                        lbPrice.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    dataGridView1.DataSource=addedSanPham;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.Columns["ID"].Visible = false;
                    connection.Close();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addedSanPham.Clear();
            this.Hide();
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenHang.SelectedIndex > -1)
                tbSL.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbPrice.Text = "Tổng cộng: " + (Convert.ToInt32(lbPrice.Text.Split(':').Last().Trim()) - Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[3].Value));
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
            addedSanPham.RemoveAt(dataGridView1.SelectedCells[0].OwningRow.Index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = addedSanPham;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void btXoaDS_Click(object sender, EventArgs e)
        {
            addedSanPham.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = addedSanPham;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns["ID"].Visible = false;
            lbPrice.Text = "Tổng cộng: 0";
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(tbSL.Text, out int sl);
            if (sl > 0 && check == true)
            {
                SanPham a = cbbTenHang.SelectedItem as SanPham;
                int i = addedSanPham.FindIndex(sp => sp.Name == a.Name);
                if (i == -1)
                {
                    addedSanPham.Add(new SelectedSP() { Name = a.Name, ID = a.ID, Qty = Convert.ToInt32(tbSL.Text), Price = Convert.ToInt32(tbSL.Text) * a.Price });
                }
                else
                {
                    addedSanPham[i].Qty += sl;
                    addedSanPham[i].Price = addedSanPham[i].Qty * a.Price;
                }
                lbPrice.Text = "Tổng cộng: " + (Convert.ToInt32(lbPrice.Text.Split(':').Last().Trim()) + Convert.ToInt32(tbSL.Text) * a.Price);
                lbPrice.TextAlign = ContentAlignment.MiddleCenter;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = addedSanPham;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.Columns["ID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ");
            }
        }

        private void tbSL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btThemSP.PerformClick();
        }

        private void btSubmitHD_Click(object sender, EventArgs e)
        {
            if (addedSanPham.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn");
                return;
            }
            using (SqlConnection connection = new SqlConnection(cnt))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand() { Connection = connection };

                    foreach (SelectedSP sp in addedSanPham)
                    {
                        string delHDSP = String.Format("delete HoaDon_SanPham where idHD = '{0}' and idSP = '{1}'", id, sp.ID);
                        cmd.CommandText = delHDSP;
                        cmd.ExecuteNonQuery();
                        string addHDSP = String.Format("INSERT into HoaDon_SanPham (idHD, idSP, slSP) VALUES ('{0}', '{1}', {2})", id, sp.ID, sp.Qty);
                        cmd.CommandText = addHDSP;
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sửa hóa đơn thành công");
                    button1.PerformClick();
                    addedSanPham.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa hóa đơn không thành công");
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}