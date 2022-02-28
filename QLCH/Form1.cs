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

        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataTable db = null;

        public Form1()
        {
            InitializeComponent();
            panel2.Hide();
            //Nam: DESKTOP-KNN7K79
            //Vinh: sahdjh
            string cnt = "Data Source = DESKTOP-KNN7K79; Initial Catalog = QLCH; Integrated Security = True";
            conn = new SqlConnection(cnt);
            //string query = "Select * from ";
            //adapter = new SqlDataAdapter(query, conn);
            //adapter.Fill(db);
            //dataGridView1.DataSource = db;
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
            catch (Exception ex) {
                MessageBox.Show("Connection error");
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (pw != tbPW.Text)
            {
                MessageBox.Show("Wrong id or password");
            } else
            {
                panel1.Hide();
                panel2.Show();
            }
        }

        private void tbID_Leave(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = client.Get("Store/" + tbID.Text);
                if (response.StatusCode.ToString() != "OK")
                    throw new Exception();
                pw = response.ResultAs<string>();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void tbPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
            }
        }
    }
}
