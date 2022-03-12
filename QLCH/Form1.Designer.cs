namespace QLCH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShowID = new System.Windows.Forms.TextBox();
            this.tbShowPr = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbPW = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbShowID);
            this.panel2.Controls.Add(this.tbShowPr);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 466);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(53, 23);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(66, 28);
            this.txt_search.TabIndex = 9;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(610, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thành tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(610, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID hóa đơn";
            // 
            // tbShowID
            // 
            this.tbShowID.Enabled = false;
            this.tbShowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShowID.Location = new System.Drawing.Point(464, 84);
            this.tbShowID.Margin = new System.Windows.Forms.Padding(2);
            this.tbShowID.Name = "tbShowID";
            this.tbShowID.Size = new System.Drawing.Size(224, 28);
            this.tbShowID.TabIndex = 6;
            this.tbShowID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbShowPr
            // 
            this.tbShowPr.Enabled = false;
            this.tbShowPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShowPr.Location = new System.Drawing.Point(464, 141);
            this.tbShowPr.Margin = new System.Windows.Forms.Padding(2);
            this.tbShowPr.Name = "tbShowPr";
            this.tbShowPr.Size = new System.Drawing.Size(224, 28);
            this.tbShowPr.TabIndex = 5;
            this.tbShowPr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::QLCH.Properties.Resources.icons8_repair_50;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(584, 202);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 53);
            this.button5.TabIndex = 1;
            this.button5.Text = "Sửa hóa đơn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::QLCH.Properties.Resources.icons8_print_50;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(584, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xuất hóa đơn";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::QLCH.Properties.Resources.icons8_cherry_blossom_48;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(626, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Đăng xuất";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QLCH.Properties.Resources.icons8_delete_64;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(464, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa hóa đơn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::QLCH.Properties.Resources.icons8_add_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(464, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 400);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.lbPW);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.tbPW);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 466);
            this.panel1.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(116, 219);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(107, 26);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.BackColor = System.Drawing.Color.Transparent;
            this.lbPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPW.Location = new System.Drawing.Point(26, 143);
            this.lbPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(75, 20);
            this.lbPW.TabIndex = 3;
            this.lbPW.Text = "Mật khẩu";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(26, 72);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(101, 20);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Mã cửa hàng";
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPW.Location = new System.Drawing.Point(38, 166);
            this.tbPW.Margin = new System.Windows.Forms.Padding(2);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(164, 28);
            this.tbPW.TabIndex = 1;
            this.tbPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPW_KeyDown);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(38, 95);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(164, 28);
            this.tbID.TabIndex = 0;
            this.tbID.Leave += new System.EventHandler(this.tbID_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLCH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbShowID;
        private System.Windows.Forms.TextBox tbShowPr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

