using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapvn
{
    public class SanPham
    {
        public string MaSanPham {  get; set; }
        public string TenSanPham {  get; set; }
        public int  DonGia {  get; set; }  
        public int  SoLuong {  get; set; }

        public SanPham()
        {

        }

        public SanPham(string maSanPham, string tenSanPham, int donGia, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public void ThanhTien()
        {
            var thanhtien = this.DonGia * this.SoLuong;
            Console.WriteLine("Thanh tien: " + thanhtien);
        }

        public void In()
        {
            Console.WriteLine("Ma san pham: " + this.MaSanPham);
            Console.WriteLine("Ten san pham: " + this.TenSanPham);
            Console.WriteLine("Don gia : " + this.DonGia);
            Console.WriteLine("So luowng: " + this.SoLuong);
        }
    }
}
