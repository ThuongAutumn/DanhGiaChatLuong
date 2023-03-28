using Microsoft.AspNetCore.Mvc;
using SeverBVSTT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SeverBVSTT.Controllers
{
    public class DanhGiaStoreController : BaseController
    {
       
        public IActionResult Index(String code, String ten)
        {
            DMCuaHang cd = new DMCuaHang();
            try
            {
                cd.id = long.Parse(code.ToString());
                cd.ten = ten;

            }
            catch (Exception){    throw; }
            return View(cd);
        }

        public IActionResult dm_danh_gia(String code)
        {
            DMDanhGia cd = new DMDanhGia();
            try
            {
                cd.id = long.Parse(code.ToString());
            }
            catch (Exception) { throw; }
            return View(cd);
        }
        public IActionResult load_dm_cuahang(DMCuaHang obj)
        {

            // từ trình duyệt web - > xuoongs api này -> vò lớp (1)PulicRepository -> (2)apccetdata -- updata vào data            
            //1. tùy vào nhuu cầu có thể tạo lớp khác để hạn chế quyền
            // làm việc với apccetdata chừng nòa xong mới xác nhận ko thì trả lỗi về
            //2. lớp làm việc trục tiếp data/
            // qua nhiều lớp mỗi lớp một việc/ ngăn cản việc hack trực tiếp d

            
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = app.AccessData.get_data("select * from dmdanhgia where id_ch = '"+obj.id+"'");
            dt = ds.Tables[0];
            return Json(dt);
        }

    }
}
