using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeverBVSTT.Models
{
    public class PulicRepository
    {
        AppRepository acc = new AppRepository();
        public int DangKyTK(ThongTinDangKy obj)
        {
            int kq = 0;
            // kie tra user da ton tai?            
            acc.AccessData.Begin_transaction();
            try
            {
                kq = acc.AccessData.Upp_DangKy(obj);
                acc.AccessData.Commit_transaction();
                return kq;
            }
            catch (Exception EX)
            {
                string loi = EX.ToString();
                acc.AccessData.RollBack_transaction();
                return 0;
            }
        }
        public int DangKyEmail(ThongTinDangKy obj)
        {
            int kq = 0;
            // kie tra user da ton tai?            
            acc.AccessData.Begin_transaction();
            try
            {
                kq = acc.AccessData.Upp_Email(obj);
                acc.AccessData.Commit_transaction();
                return kq;
            }
            catch (Exception EX)
            {
                string loi = EX.ToString();
                acc.AccessData.RollBack_transaction();
                return 0;
            }
        }
        
        public int DanhMucCuaHang(DMCuaHang obj)
        {
            int kq = 0;
            // kie tra user da ton tai?            
            acc.AccessData.Begin_transaction();
            try
            {
                kq = acc.AccessData.Upp_DMCuaHang(obj);
                acc.AccessData.Commit_transaction();
                return kq;
            }
            catch (Exception EX)
            {
                // lỗi tại đây lên mạng tìm
                string loi = EX.ToString();
                acc.AccessData.RollBack_transaction();
                return 0;
            }
        }
        //danh muc danh gia
        public int DanhMucDanhGia(DMDanhGia obj)
        {
            int kq = 0;
            // kie tra user da ton tai?            
            acc.AccessData.Begin_transaction();
            try
            {
                kq = acc.AccessData.Upp_DMDanhGia(obj);
                acc.AccessData.Commit_transaction();
                return kq;
            }
            catch (Exception EX)
            {
                // lỗi tại đây lên mạng tìm
                string loi = EX.ToString();
                acc.AccessData.RollBack_transaction();
                return 0;
            }
        }
    }
}
