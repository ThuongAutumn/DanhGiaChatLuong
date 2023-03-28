using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeverBVSTT.Models
{
    public class DMDanhGia
    {
       
        public long id { get; set; }
        public string id_ch { get; set; }
        public string noidung { get; set; }
        public string trangthai { get; set; }
        public int diem { get; set; }

    }
}
