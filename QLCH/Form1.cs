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
        HoaDon hd = new HoaDon();
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataTable db = null;
        public Form1()
        {
            InitializeComponent();
            GetData();
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
                //Vinh: DESKTOP-IKJI0OQ\SQLEXPRESS
                string cnt = "Data Source = DESKTOP-KNN7K79; Initial Catalog = QLCH; Integrated Security = True";
                conn = new SqlConnection(cnt);
                string query = "Select idHD as N'Mã hóa đơn', date as N'Ngày', sum(price * slSP) as N'Thành tiền' from HoaDon_SanPham hs join HoaDon hd on hs.idHD = hd.id join SanPham sp on hs.idSp = sp.id group by idHD, date";
                //string query = "select * from HoaDon";
                adapter = new SqlDataAdapter(query, conn);
                db = new DataTable();
                adapter.Fill(db);
                dataGridView1.DataSource = db;
                dataGridView1.BackgroundColor = Color.FromArgb(255, 251, 215, 227);
                panel2.Hide();
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
            hd.ShowDialog();
        }
    }
}
