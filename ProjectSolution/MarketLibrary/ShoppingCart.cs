using System;
using System.Collections.Generic;

namespace MarketLibrary
{
    /// <summary>
    /// Lớp đại diện cho một mặt hàng trong giỏ.
    /// </summary>
    public class Item
    {
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public decimal ThanhTien
        {
            get { return SoLuong * DonGia; }
        }
    }

    /// <summary>
    /// Lớp giỏ hàng, chứa danh sách mặt hàng và xử lý tính tiền.
    /// </summary>
    public class ShoppingCart
    {
        private List<Item> danhSach = new List<Item>();

        /// <summary>
        /// Thêm mặt hàng vào giỏ.
        /// </summary>
        public void ThemHang(string ten, int soluong, decimal dongia)
        {
            if (string.IsNullOrEmpty(ten)) throw new ArgumentException("Tên hàng không hợp lệ");
            if (soluong <= 0) throw new ArgumentException("Số lượng phải > 0");
            if (dongia < 0) throw new ArgumentException("Đơn giá không hợp lệ");

            Item item = new Item
            {
                Ten = ten,
                SoLuong = soluong,
                DonGia = dongia
            };

            danhSach.Add(item);
        }

        /// <summary>
        /// Lấy danh sách các mặt hàng trong giỏ.
        /// </summary>
        public List<Item> LayDanhSach()
        {
            return danhSach;
        }

        /// <summary>
        /// Tính tổng tiền, có khuyến mãi nếu > 500,000 VND.
        /// </summary>
        public decimal TinhTongTien()
        {
            decimal tong = 0;
            foreach (Item item in danhSach)
            {
                tong += item.ThanhTien;
            }

            // Khuyến mãi: nếu tổng > 500,000 thì giảm 5%
            if (tong > 500000)
            {
                tong = tong * 0.95m;
            }

            return tong;
        }

        /// <summary>
        /// Xuất hóa đơn dạng text (cho console dùng).
        /// </summary>
        public string XuatHoaDon()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("=== HÓA ĐƠN ĐI CHỢ ===");
            int stt = 1;
            foreach (Item item in danhSach)
            {
                sb.AppendLine(string.Format(
                    "{0}. {1} x{2} = {3:N0} VND",
                    stt, item.Ten, item.SoLuong, item.ThanhTien));
                stt++;
            }
            sb.AppendLine("------------------------------");
            sb.AppendLine("TỔNG: " + TinhTongTien().ToString("N0") + " VND");
            sb.AppendLine("Bản quyền © Tên bạn – 2025");

            return sb.ToString();
        }
    }
}
