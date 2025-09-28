using System;
using System.Web;
using MarketLibrary;
using System.Collections.Generic;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json";

        string itemsData = Request.Form["items"];
        ShoppingCart cart = new ShoppingCart();

        if (!string.IsNullOrEmpty(itemsData))
        {
            string[] items = itemsData.Split(';');
            foreach (string it in items)
            {
                if (string.IsNullOrEmpty(it)) continue;

                string[] parts = it.Split('|');
                if (parts.Length == 3)
                {
                    string ten = parts[0];
                    int soluong;
                    decimal dongia;

                    if (int.TryParse(parts[1], out soluong) &&
                        decimal.TryParse(parts[2], out dongia))
                    {
                        try { cart.ThemHang(ten, soluong, dongia); }
                        catch { }
                    }
                }
            }
        }

        // Trả JSON
        List<Item> ds = cart.LayDanhSach();
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("{");
        sb.Append("\"ChiTiet\":[");

        for (int i = 0; i < ds.Count; i++)
        {
            Item it = ds[i];
            sb.Append("{");
            sb.AppendFormat("\"Ten\":\"{0}\",\"SoLuong\":{1},\"ThanhTien\":{2}",
                EscapeJson(it.Ten), it.SoLuong, it.ThanhTien);
            sb.Append("}");
            if (i < ds.Count - 1) sb.Append(",");
        }

        sb.Append("],");
        sb.AppendFormat("\"TongTien\":\"{0}\"", cart.TinhTongTien().ToString("N0"));
        sb.Append("}");

        Response.Write(sb.ToString());
        Context.ApplicationInstance.CompleteRequest();
    }

    private string EscapeJson(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        return s.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }
}