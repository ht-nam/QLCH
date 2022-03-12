using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Configuration;
namespace QLCH
{
    public partial class Form1 : Form
    {
        IFirebaseConfig fbCf = new FirebaseConfig()
        {
            AuthSecret = "QhNihnCtn3mTIG47KS1ET0tUpQ8wfW9hMXQnkhLW",
            BasePath = "https://htnam-72b75-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        string pw = "";
        HoaDon hd = null;
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        SqlCommand cmd = null;
        DataTable db = null;
        HienThi ht = null;
        string ID;
        ChinhSua cs;
        List<SanPham> sanPhams = new List<SanPham>();

        public Form1()
        {
            InitializeComponent();
            GetData();
            panel2.Hide();
        }
        ~Form1()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                client = new FirebaseClient(fbCf);
                FirebaseResponse testCon = client.Get("Store");
                if (testCon.StatusCode.ToString() != "OK")
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void GetData()
        {
            try
            {
                //Nam: DESKTOP-KNN7K79
                //Vinh: DESKTOP-IKJI0OQ\\SQLEXPRESS
                string cnt = "Data Source = DESKTOP-IKJI0OQ\\SQLEXPRESS; Initial Catalog = QLCH; Integrated Security = True";
                conn = new SqlConnection(cnt);
                conn.Open();

                string query = "Select idHD as N'Mã hóa đơn', date as N'Ngày', sum(price * slSP) as N'Thành tiền' from HoaDon_SanPham hs join HoaDon hd on hs.idHD = hd.id join SanPham sp on hs.idSp = sp.id group by idHD, date";
                //string query = "select * from HoaDon";

                adapter = new SqlDataAdapter(query, conn);
                db = new DataTable();
                adapter.Fill(db);
                dataGridView1.DataSource = db;
                dataGridView1.BackgroundColor = Color.FromArgb(255, 251, 215, 227);
                panel2.Hide();


                using (SqlCommand cmd = new SqlCommand() { })
                {
                    cmd.CommandText = "Select * from SanPham";
                    cmd.Connection = conn;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sanPhams.Add(new SanPham() { ID=reader["id"].ToString(), Name = (string)reader["name"].ToString(), Price = Convert.ToInt32(reader["price"].ToString()) });
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database");
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (pw != tbPW.Text)
            {
                MessageBox.Show("Wrong id or password");
            }
            else
            {
                MessageBox.Show("Success");
                panel1.Hide();
                panel2.Show();
            }
        }

        private void tbID_Leave(object sender, EventArgs e)
        {
            if (tbID.Text != "")
            {
                try
                {
                    new Thread(() =>
                   {
                       FirebaseResponse response = client.Get("Store/" + tbID.Text);
                       if (response.StatusCode.ToString() != "OK")
                           throw new Exception();
                       pw = response.ResultAs<string>();
                   }).Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection error");
                }
            }
        }

        private void tbPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hd = new HoaDon(sanPhams);
            hd.ShowDialog();
            db.Clear();
            adapter.Fill(db);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from HoaDon_SanPham where idHD = '" + ID + "'",conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from HoaDon where id = '" + ID + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa hóa đơn thành công");
                db.Clear();
                adapter.Fill(db);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            button2.Enabled = true;
            tbShowID.Text = ID.Trim();
            tbShowPr.Text = dataGridView1.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            tbID.Text = "";
            tbPW.Text = "";
            panel1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbShowID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần sửa");
            }
            else
            {
                ht = new HienThi(ID, tbID.Text);
                ht.ShowDialog();
                db.Clear();
                adapter.Fill(db);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbShowID.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần sửa");
            }
            else
            {
                cs = new ChinhSua(ID,sanPhams);
                cs.ShowDialog();
                db.Clear();
                adapter.Fill(db);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cnt = "Data Source = DESKTOP-IKJI0OQ\\SQLEXPRESS; Initial Catalog = QLCH; Integrated Security = True";
            conn = new SqlConnection(cnt);
            string query = "Select idHD, date, sum(price * slSP) from HoaDon_SanPham hs join HoaDon hd on hs.idHD = hd.id and idHD like '" + txt_search.Text + "%' join SanPham sp on hs.idSp = sp.id group by idHD, date";
            conn.Open();
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(query, conn);
            db = new DataTable();
            adapter.Fill(db);
            dataGridView1.DataSource = db;
            conn.Close();
        }
    }
}
