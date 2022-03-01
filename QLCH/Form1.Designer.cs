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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 420);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QLCH.Properties.Resources.icons8_delete_64;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(527, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::QLCH.Properties.Resources.icons8_add_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(527, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm sản phẩm";
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 400);
            this.dataGridView1.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(707, 420);
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
            this.ClientSize = new System.Drawing.Size(707, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
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
    }
}

