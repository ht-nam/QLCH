namespace QLCH
{
    partial class ChinhSua
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btXoaDS = new System.Windows.Forms.Button();
            this.btSubmitHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btThemSP = new System.Windows.Forms.Button();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.tbidDH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::QLCH.Properties.Resources._5937125;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btXoaDS);
            this.panel1.Controls.Add(this.btSubmitHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btThemSP);
            this.panel1.Controls.Add(this.tbSL);
            this.panel1.Controls.Add(this.cbbTenHang);
            this.panel1.Controls.Add(this.tbidDH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 509);
            this.panel1.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbPrice.Location = new System.Drawing.Point(53, 440);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(314, 28);
            this.lbPrice.TabIndex = 27;
            this.lbPrice.Text = "Tổng cộng: 0";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(32, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btXoaDS
            // 
            this.btXoaDS.AutoSize = true;
            this.btXoaDS.ForeColor = System.Drawing.Color.Red;
            this.btXoaDS.Location = new System.Drawing.Point(310, 418);
            this.btXoaDS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoaDS.Name = "btXoaDS";
            this.btXoaDS.Size = new System.Drawing.Size(89, 23);
            this.btXoaDS.TabIndex = 24;
            this.btXoaDS.Text = "Xóa danh sách";
            this.btXoaDS.UseVisualStyleBackColor = true;
            this.btXoaDS.Click += new System.EventHandler(this.btXoaDS_Click);
            // 
            // btSubmitHD
            // 
            this.btSubmitHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmitHD.ForeColor = System.Drawing.Color.ForestGreen;
            this.btSubmitHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSubmitHD.Location = new System.Drawing.Point(157, 472);
            this.btSubmitHD.Name = "btSubmitHD";
            this.btSubmitHD.Size = new System.Drawing.Size(111, 36);
            this.btSubmitHD.TabIndex = 23;
            this.btSubmitHD.Text = "Hoàn thành";
            this.btSubmitHD.UseVisualStyleBackColor = true;
            this.btSubmitHD.Click += new System.EventHandler(this.btSubmitHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(137, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chỉnh sửa hóa đơn";
            // 
            // btThemSP
            // 
            this.btThemSP.AutoSize = true;
            this.btThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemSP.Location = new System.Drawing.Point(278, 149);
            this.btThemSP.Name = "btThemSP";
            this.btThemSP.Size = new System.Drawing.Size(75, 35);
            this.btThemSP.TabIndex = 21;
            this.btThemSP.Text = "Thêm";
            this.btThemSP.UseVisualStyleBackColor = true;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);
            // 
            // tbSL
            // 
            this.tbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSL.Location = new System.Drawing.Point(188, 152);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(68, 26);
            this.tbSL.TabIndex = 20;
            this.tbSL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSL_KeyDown);
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Location = new System.Drawing.Point(188, 96);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(177, 28);
            this.cbbTenHang.TabIndex = 19;
            this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
            // 
            // tbidDH
            // 
            this.tbidDH.Enabled = false;
            this.tbidDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidDH.Location = new System.Drawing.Point(188, 43);
            this.tbidDH.Name = "tbidDH";
            this.tbidDH.Size = new System.Drawing.Size(172, 26);
            this.tbidDH.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên hàng: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID đơn hàng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(419, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChinhSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChinhSua";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThemSP;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.ComboBox cbbTenHang;
        private System.Windows.Forms.TextBox tbidDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoaDS;
        private System.Windows.Forms.Button btSubmitHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbPrice;
    }
}