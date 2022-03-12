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
        List<string> addedHoaDon = new List<string>();

        public HoaDon(List<SanPham> sps)
        {
            InitializeComponent();
            sanPhams = sps;
            dataGridView1.DataSource = selectedSPs;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns["ID"].Visible = false;
            foreach (SanPham sp in sanPhams)
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

        private void btSubmitHD_Click(object sender, EventArgs e)
        {
            if (tbidDH.Text == "")
            {
                MessageBox.Show("ID hóa đơn không được để trống");
                return;
            }
            if (selectedSPs.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn");
                return;
            }
            using (SqlConnection connection = new SqlConnection(cnt))
            {
                string addHD = String.Format("INSERT into HoaDon (id, date) VALUES ('{0}', '{1}')", tbidDH.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                using (SqlCommand cmd = new SqlCommand(addHD, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        foreach (SelectedSP sp in selectedSPs)
                        {
                            string addHDSP = String.Format("INSERT into HoaDon_SanPham (idHD, idSP, slSP) VALUES ('{0}', '{1}', {2})", tbidDH.Text, sp.ID, sp.Qty);
                            cmd.CommandText = addHDSP;
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Thêm hóa đơn thành công");
                        button2.PerformClick();
                        selectedSPs.Clear();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Thêm hóa đơn không thành công");
                        cmd.CommandText = "Delete HoaDon where id = '" + tbidDH + "'";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "Delete HoaDon_SanPham where id = '" + tbidDH + "'";
                        cmd.ExecuteNonQuery();
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


        private void tbidDH_Leave(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(cnt))
            {
                using (SqlCommand cmd = new SqlCommand() { })
                {
                    connection.Open();

                    cmd.CommandText = "Select * from HoaDon";
                    cmd.Connection = connection;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        addedHoaDon.Add(reader["id"].ToString());
                    }
                    for (int i = 0; i < addedHoaDon.Count; i++)
                    {
                        addedHoaDon[i] = addedHoaDon[i].Trim();
                    }
                    if (addedHoaDon.FindIndex(x => x == tbidDH.Text) != -1)
                    {
                        MessageBox.Show("ID hóa đơn đã tồn tại");
                        tbidDH.Text = "";
                    }
                    connection.Close();

                }
            }
        }

        private void tbSL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btThemSP.PerformClick();
            }
        }

        private void btXoaDS_Click(object sender, EventArgs e)
        {
            selectedSPs.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = selectedSPs;
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(tbSL.Text, out int sl);
            if (sl > 0 && check == true)
            {
                SanPham a = cbbTenHang.SelectedItem as SanPham;
                int i = selectedSPs.FindIndex(sp => sp.Name == a.Name);
                if (i == -1)
                {
                    selectedSPs.Add(new SelectedSP() { Name = a.Name, ID = a.ID, Qty = Convert.ToInt32(tbSL.Text), Price = Convert.ToInt32(tbSL.Text) * a.Price });
                }
                else
                {
                    selectedSPs[i].Qty += sl;
                    selectedSPs[i].Price = selectedSPs[i].Qty * a.Price;
                }
                lbPrice.Text = "Tổng cộng: " + (Convert.ToInt32(lbPrice.Text.Split(':').Last().Trim()) + Convert.ToInt32(tbSL.Text) * a.Price);
                lbPrice.TextAlign = ContentAlignment.MiddleCenter;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = selectedSPs;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.Columns["ID"].Visible = false;
            }
            else
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
