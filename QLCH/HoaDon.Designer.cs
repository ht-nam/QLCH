﻿namespace QLCH
{
    partial class HoaDon
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
            this.btXoaDS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThemSP = new System.Windows.Forms.Button();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.tbidDH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btSubmitHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BackgroundImage = global::QLCH.Properties.Resources.Lovely_Fluid_In_Soft_Pink_Background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btXoaDS);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btThemSP);
            this.panel1.Controls.Add(this.tbSL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbTenHang);
            this.panel1.Controls.Add(this.tbidDH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btSubmitHD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 709);
            this.panel1.TabIndex = 0;
            // 
            // btXoaDS
            // 
            this.btXoaDS.AutoSize = true;
            this.btXoaDS.ForeColor = System.Drawing.Color.Red;
            this.btXoaDS.Location = new System.Drawing.Point(391, 623);
            this.btXoaDS.Name = "btXoaDS";
            this.btXoaDS.Size = new System.Drawing.Size(106, 26);
            this.btXoaDS.TabIndex = 19;
            this.btXoaDS.Text = "Xóa danh sách";
            this.btXoaDS.UseVisualStyleBackColor = true;
            this.btXoaDS.Click += new System.EventHandler(this.btXoaDS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(47, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(427, 279);
            this.dataGridView1.TabIndex = 18;
            // 
            // btThemSP
            // 
            this.btThemSP.AutoSize = true;
            this.btThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemSP.Location = new System.Drawing.Point(352, 279);
            this.btThemSP.Margin = new System.Windows.Forms.Padding(4);
            this.btThemSP.Name = "btThemSP";
            this.btThemSP.Size = new System.Drawing.Size(100, 43);
            this.btThemSP.TabIndex = 17;
            this.btThemSP.Text = "Thêm";
            this.btThemSP.UseVisualStyleBackColor = true;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);
            // 
            // tbSL
            // 
            this.tbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSL.Location = new System.Drawing.Point(233, 283);
            this.tbSL.Margin = new System.Windows.Forms.Padding(4);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(89, 30);
            this.tbSL.TabIndex = 16;
            this.tbSL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSL_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng:";
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Location = new System.Drawing.Point(233, 214);
            this.cbbTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(235, 33);
            this.cbbTenHang.TabIndex = 14;
            this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
            // 
            // tbidDH
            // 
            this.tbidDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidDH.Location = new System.Drawing.Point(233, 149);
            this.tbidDH.Margin = new System.Windows.Forms.Padding(4);
            this.tbidDH.Name = "tbidDH";
            this.tbidDH.Size = new System.Drawing.Size(228, 30);
            this.tbidDH.TabIndex = 13;
            this.tbidDH.Leave += new System.EventHandler(this.tbidDH_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID đơn hàng:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSubmitHD
            // 
            this.btSubmitHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmitHD.ForeColor = System.Drawing.Color.ForestGreen;
            this.btSubmitHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSubmitHD.Location = new System.Drawing.Point(187, 650);
            this.btSubmitHD.Margin = new System.Windows.Forms.Padding(4);
            this.btSubmitHD.Name = "btSubmitHD";
            this.btSubmitHD.Size = new System.Drawing.Size(148, 44);
            this.btSubmitHD.TabIndex = 9;
            this.btSubmitHD.Text = "Hoàn thành";
            this.btSubmitHD.UseVisualStyleBackColor = true;
            this.btSubmitHD.Click += new System.EventHandler(this.btSubmitHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(148, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 709);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSubmitHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbidDH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTenHang;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThemSP;
        private System.Windows.Forms.Button btXoaDS;
    }
}