using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SeverBVSTT.Models;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Claims;

namespace SeverBVSTT.Controllers
{
    public class HomeController : BaseController
    {        
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult dang_ky(ThongTinDangKy obj)
        {
            int kq = 0;
            if (obj.id == 0)
            {
                obj.id = Helper.RandomLong();
            }
            PulicRepository pc = new PulicRepository();

            kq = pc.DangKyTK(obj);

            return Json(kq);

        }
        
        //await _notificationsMessageHandler.SendMessageToAll(obj, b);
        public IActionResult SignOut()
        {//Dang xuat yeu cau cookie thoat 
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }
        // Thông tin động json///////////////////////////////

        // chuẩn//// đã kiểm tra đã thành công
        [HttpPost]
        public IActionResult check_email(ThongTinDangKy obj)
        {
            int kq = 0;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = app.AccessData.get_data("select * from login_ch where email = '" + obj.Email + "'");
            dt = ds.Tables[0];
            // kiem tra query rồi có hàng  trong bảng hay không có thì có dữ liệu email đã được đăng ký
            if (dt.Rows.Count > 0) { kq = 1; }
            else
            {
                kq = 0;
            }
            // kiểm tra dt có dòng không, datatable.row
            // newu dt.row.count > 0 thì email đã có kq = 1
            if (kq == 0)
            {
                // email chua co
                // radome id

                obj.id = Helper.RandomLong();
                long ktma = Helper.RandomLong();
                string Str1 = ktma.ToString().Substring(0, 6);
                obj.code = Str1;

                PulicRepository pc1 = new PulicRepository();
                kq = pc1.DangKyEmail(obj);
                return Json(kq);

                // radome code, căt 6 số
                // luu data
                // trả về yêu cầu check email
                // email đã co trả về
            }
            else
            {

            }

            if (obj.id == 0)
            {
                obj.id = Helper.RandomLong();
            }
            PulicRepository pc = new PulicRepository();
            kq = pc.DangKyEmail(obj);
            return Json(kq);
        }
        [HttpPost]
        public IActionResult DangNhap(MaBV obj)
        {
            if (ModelState.IsValid)
            {                
                string email = obj.User.Replace(" ", "");
                string password = obj.Ma.Replace(" ", "");
                // bắt đầu kiển tra trong da ta có hay không tai khoan su dung emlai và mat khau dung chưa
                int kq = 0;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                string sql = "";/// tim  cách selece where
                ds = app.AccessData.get_data(sql);
                dt = ds.Tables[0];
                // kiem tra query rồi có hàng  trong bảng hay không có thì có dữ liệu email đã được đăng ký
                if (dt.Rows.Count > 0) { kq = 1; } else
                {
                    kq = 0;
                }

                /// bên duioiws rác chưa phân loai de danh tai chế


                obj.Ma = obj.Ma.Replace(" ", "");
                string matkhau = GoiJson("pass1");
                string str = GoiJson("user");
                string[] arrListStr = str.Split('-');

                if (obj.Ma == matkhau)
                {
                    int i = 0;
                    foreach (var item in arrListStr)
                    {
                        if (arrListStr[i] == obj.User)
                        {

                            long Id = Helper.RandomLong();
                            ClaimsIdentity claims = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, Id.ToString()));// id phân biệt
                            claims.AddClaim(new Claim(ClaimTypes.Name, obj.User));// mã đăng nhập
                            claims.AddClaim(new Claim(ClaimTypes.Role, "hgsoft"));// phân quyền
                            AuthenticationProperties properties = new AuthenticationProperties
                            {
                                AllowRefresh = true,
                                IsPersistent = obj.Remember,
                            };
                            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claims), properties);
                            return Json("1");
                        }
                        i = i + 1;
                    }
                    return Json("0");
                }
                else
                {
                    return Json("0");
                }
            }
            else
            {
                return Json("2");
            }
        }
        public string GoiJson(string key)
        {
            string GiaTri;
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            GiaTri = configuration.GetConnectionString(key);
            return GiaTri;
        }
    }
}