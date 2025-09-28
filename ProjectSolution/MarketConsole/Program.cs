using System;
using MarketLibrary;

namespace MarketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // để in tiếng Việt
            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine("=== MÁY TÍNH TIỀN ĐI CHỢ (Console) ===");
            Console.WriteLine("Nhập các mặt hàng. Gõ 'x' để dừng.");

            while (true)
            {
                Console.Write("Tên hàng (hoặc x để thoát): ");
                string ten = Console.ReadLine();
                if (ten.ToLower() == "x") break;

                Console.Write("Số lượng: ");
                int soluong;
                while (!int.TryParse(Console.ReadLine(), out soluong) || soluong <= 0)
                {
                    Console.Write("Nhập lại số lượng (>0): ");
                }

                Console.Write("Đơn giá: ");
                decimal dongia;
                while (!decimal.TryParse(Console.ReadLine(), out dongia) || dongia < 0)
                {
                    Console.Write("Nhập lại đơn giá (>=0): ");
                }

                cart.ThemHang(ten, soluong, dongia);
                Console.WriteLine("=> Đã thêm vào giỏ!\n");
            }

            Console.WriteLine();
            Console.WriteLine(cart.XuatHoaDon());

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
