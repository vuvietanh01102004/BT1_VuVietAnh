using System;
using System.Windows.Forms;
using MarketLibrary;

namespace MarketDesktop
{
    public partial class MainForm : Form
    {
        private ShoppingCart cart = new ShoppingCart();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvGioHang.AutoGenerateColumns = false;
            dgvGioHang.Columns.Add("Ten", "Tên hàng");
            dgvGioHang.Columns.Add("SoLuong", "Số lượng");
            dgvGioHang.Columns.Add("DonGia", "Đơn giá");
            dgvGioHang.Columns.Add("ThanhTien", "Thành tiền");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtTenHang.Text.Trim();
                int soluong = (int)numSoLuong.Value;
                decimal dongia = decimal.Parse(txtDonGia.Text);

                cart.ThemHang(ten, soluong, dongia);

                HienThiGioHang();
                txtTenHang.Clear();
                txtDonGia.Clear();
                numSoLuong.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal tong = cart.TinhTongTien();
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VND";
        }

        private void HienThiGioHang()
        {
            dgvGioHang.Rows.Clear();
            foreach (Item item in cart.LayDanhSach())
            {
                dgvGioHang.Rows.Add(item.Ten, item.SoLuong,
                    item.DonGia.ToString("N0"), item.ThanhTien.ToString("N0"));
            }
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
