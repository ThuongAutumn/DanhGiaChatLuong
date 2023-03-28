using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeverBVSTT.Models
{
    public class ThongTinDangKy
    {
        public long id { get; set; }
        public string id_ch { get; set; }
        //[Required(ErrorMessage = "Bạn chưa nhập user")]
        public string User { get; set; }
        //[Required(ErrorMessage = "Bạn chưa nhập mã")]
        public string TenDN { get; set; }
        // bắc buộc phải có khi khởi tạo
        [Required(ErrorMessage = "Bạn chưa nhập Email")]
        public string Email { get; set; }
        public string Pass { get; set; }
        public bool PassAgain { get; set; }
        public string Phone { get; set; }
        public string code { get; set; }
        public string trangthai { get; set; }

    }
}
