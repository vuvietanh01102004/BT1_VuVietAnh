namespace MarketDesktop
{
    partial class MainForm
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
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(85, 20);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(150, 20);
            this.txtTenHang.TabIndex = 0;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(300, 20);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(60, 20);
            this.numSoLuong.TabIndex = 1;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(440, 20);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(570, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(20, 320);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(100, 30);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(20, 60);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.Size = new System.Drawing.Size(625, 240);
            this.dgvGioHang.TabIndex = 5;
            this.dgvGioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellContentClick);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(150, 327);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(96, 17);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền: 0";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(20, 23);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(56, 13);
            this.lblTenHang.TabIndex = 7;
            this.lblTenHang.Text = "Tên hàng:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(250, 23);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(380, 23);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(47, 13);
            this.lblDonGia.TabIndex = 9;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(674, 371);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.txtTenHang);
            this.Name = "MainForm";
            this.Text = "Máy Tính Tiền Đi Chợ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
    }
}
