using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PakinProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageBase64 { get; set; } // ทำให้เป็น nullable
                                                 // เพิ่ม IFormFile สำหรับการอัปโหลดภาพ
        [NotMapped] // ทำให้ไม่ถูกจัดเก็บในฐานข้อมูล
        public IFormFile? UploadedImage { get; set; }
    }

}
