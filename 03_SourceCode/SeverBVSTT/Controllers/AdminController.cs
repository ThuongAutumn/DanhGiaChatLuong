using Microsoft.AspNetCore.Mvc;
using SeverBVSTT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SeverBVSTT.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //load vitri
        public IActionResult dm_cuahang(DMCuaHang obj)
        {
            DataSet ds = new DataSet();
            ds = app.AccessData.get_data("select * from cua_hang");
            DataTable dt = ds.Tables[0];
            return Json(dt);
        }
        [HttpPost]

        //load vitri
        public IActionResult udp_dm_cuahang(DMCuaHang obj)
        {

            // từ trình duyệt web - > xuoongs api này -> vò lớp (1)PulicRepository -> (2)apccetdata -- updata vào data            
            //1. tùy vào nhuu cầu có thể tạo lớp khác để hạn chế quyền
            // làm việc với apccetdata chừng nòa xong mới xác nhận ko thì trả lỗi về
            //2. lớp làm việc trục tiếp data/
            // qua nhiều lớp mỗi lớp một việc/ ngăn cản việc hack trực tiếp d

            KQCallAPI kqtv = new KQCallAPI();

            int kq = 0;
            if (obj.id == 0)
            {
                obj.id = Helper.RandomLong();
            }
            // id đã đươc tao tai đưy]kiem tra khong co tao roi
            PulicRepository pc = new PulicRepository();

            kq = pc.DanhMucCuaHang(obj);
            kqtv.i_TrangThai_0_1 = kq;
            kqtv.ghichu = "ghi chú";
            return Json(kqtv);



            //DataSet ds = new DataSet();
            //ds = app.AccessData.get_data("select * from cua_hang");
            //DataTable dt = ds.Tables[0];
            //return Json(dt);
        }
        // qqerỷy ///////////////////////////////////////////////////////////////////////////////////
        [HttpPost]
        //load vitri
        // cho ddaayy la cho trueyn vao biben 0 kia tryen vao day
        public IActionResult load_dm_cuahang(DMCuaHang obj)
        {

            // từ trình duyệt web - > xuoongs api này -> vò lớp (1)PulicRepository -> (2)apccetdata -- updata vào data            
            //1. tùy vào nhuu cầu có thể tạo lớp khác để hạn chế quyền
            // làm việc với apccetdata chừng nòa xong mới xác nhận ko thì trả lỗi về
            //2. lớp làm việc trục tiếp data/
            // qua nhiều lớp mỗi lớp một việc/ ngăn cản việc hack trực tiếp d

            //KQCallAPI kqtv = new KQCallAPI();

            //int kq = 0;
            //if (obj.id == 0)
            //{
            //    obj.id = Helper.RandomLong();
            //}
            //// id đã đươc tao tai đưy]kiem tra khong co tao roi
            //PulicRepository pc = new PulicRepository();

            //kq = pc.DanhMucCuaHang(obj);
            //kqtv.i_TrangThai_0_1 = kq;
            //kqtv.ghichu = "jshkfhakjhdfkakjdsfhkjasd";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = app.AccessData.get_data("select CONVERT(VARCHAR(50), id) AS id, id_chinhanh, ten, lienhe, diachi, maps_link, maps_toado, trangweb, youtobe, facebook, tiktok, linhvuc from cua_hang;");
            dt = ds.Tables[0];
            return Json(dt);



            //DataSet ds = new DataSet();
            //ds = app.AccessData.get_data("select * from cua_hang");
            //DataTable dt = ds.Tables[0];
            //return Json(dt);
        }
        // danh muc cuc hang////////////////////////////////////////////


        public IActionResult dm_danh_gia()
        {
            return View();
        }
        [HttpPost]

        public IActionResult dm_danhgia(DMDanhGia obj)
        {
            DataSet ds = new DataSet();
            ds = app.AccessData.get_data("select * from dmdanhgia");
            DataTable dt = ds.Tables[0];
            return Json(dt);
        }
        [HttpPost]

        //load vitri
        public IActionResult udp_dm_danhgia(DMDanhGia obj)
        {
            // từ trình duyệt web - > xuoongs api này -> vò lớp (1)PulicRepository -> (2)apccetdata -- updata vào data            
            //1. tùy vào nhuu cầu có thể tạo lớp khác để hạn chế quyền
            // làm việc với apccetdata chừng nòa xong mới xác nhận ko thì trả lỗi về
            //2. lớp làm việc trục tiếp data/
            // qua nhiều lớp mỗi lớp một việc/ ngăn cản việc hack trực tiếp d

            KQCallAPI kqtv = new KQCallAPI();

            int kq = 0;
            if (obj.id == 0)
            {
                obj.id = Helper.RandomLong();
            }
            // id đã đươc tao tai đây kiem tra khong co tao roi
            PulicRepository pc = new PulicRepository();

            kq = pc.DanhMucDanhGia(obj);
            kqtv.i_TrangThai_0_1 = kq;
            kqtv.ghichu = "ghichu";
            return Json(kqtv);
            //DataSet ds = new DataSet();
            //ds = app.AccessData.get_data("select * from dmdanhgia");
            //DataTable dt = ds.Tables[0];
            //return Json(dt);
        }
        public IActionResult load_dm_danhgia(DMDanhGia obj)
        {
            // phai lấy được id đăng nhập theo cua hang
            //string id = "13526352862736748";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            //ds = app.AccessData.get_data("select CONVERT(VARCHAR(50), id) AS id, id_ch, noidung, trangthai, diem from dmdanhgia where id_ch ="+id+"");
            ds = app.AccessData.get_data("select CONVERT(VARCHAR(50), id) AS id, id_ch, noidung, trangthai, diem from dmdanhgia");
            dt = ds.Tables[0];
            return Json(dt);
        }
    }

}
