using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
//using Oracle.ManagedDataAccess.Client;
//using Oracle.ManagedDataAccess.Types;
using Microsoft.Extensions.Configuration;
using System.IO;
using SeverBVSTT.Models;
using System.Data.SqlClient;

namespace SeverBVSTT.Models
{
    public class AccessData : BaseRepository
    {
        public AccessData(string connectionString) : base(connectionString)
        {
        }
        //    string sConn;
        SqlTransaction trans;
        SqlConnection con;
        SqlCommand cmd;
        // du lieu vao 
        DataSet dsx = null;
        SqlDataAdapter dest;
        //    OracleDataReader datard;
        SqlDataAdapter destx;
        SqlConnection conx;

        SqlCommand cmdx;
       

        public void Begin_transaction()
        {
            //GoiChuoiKN();
            con = new SqlConnection(connectionString);
            con.Open();
            trans = con.BeginTransaction();
        }
        //    // xac nhận với data
        public void Commit_transaction()
        {
            trans.Commit();
            con.Close();
            con.Dispose();
            cmd.Dispose();
            trans.Dispose();
        }
        //Lỗi xác nhận với data
        public void RollBack_transaction()
        {
            trans.Rollback();
            con.Close();
            con.Dispose();
            cmd.Dispose();
            trans.Dispose();
        }


        public DataSet get_data(string sql)
        {
            if (dsx != null)
            {
                dsx.Dispose();
                dsx = null;
            }
            dsx = new DataSet();

            if (conx == null || conx.State != ConnectionState.Open)
            {
                conx = new SqlConnection(connectionString);
                conx.Open();
            }
            cmdx = new SqlCommand(sql, conx);
            cmdx.CommandType = CommandType.Text;
            destx = new SqlDataAdapter(cmdx);
            dsx = new DataSet();
            //MessageBox.Show(sql);
            destx.Fill(dsx);
            cmdx.Dispose();
            conx.Close();
            conx.Dispose();
            return dsx;
        }

        public void get_data_close_conecc()
        {
            cmdx.Dispose();
            conx.Close();
            conx.Dispose();
        }
        public void GayLoi()
        {
            int i = 1;
            int k = i / 0;
        }
        // update thanh vien


        //public int upd_dm_kshl(DM_KhaoSatHaiLong obj)
        //{
        //    int irec = 0;
        //    string sql1 = "UPDATE hgsoft_pm.kiosk_dm_kshl set ";//public
        //    if (obj.noidung != null)
        //    {
        //        sql1 = sql1 + " noidung = :noidung";
        //    }
        //    if (obj.ghichu != null)
        //    {
        //        sql1 = sql1 + " ,ghichu = :ghichu";
        //    }
        //    sql1 = sql1 + " ,ngayud = sysdate";
        //    sql1 = sql1 + " where MA = " + obj.ma + "";
        //    cmd = new OracleCommand(sql1, con);
        //    cmd.Transaction = trans;
        //    cmd.CommandType = CommandType.Text;
        //    if (obj.noidung != null)
        //    {
        //        cmd.Parameters.Add("noidung", OracleDbType.NVarchar2, 500).Value = obj.noidung;
        //    }
        //    if (obj.ghichu != null)
        //    {
        //        cmd.Parameters.Add("ghichu", OracleDbType.NVarchar2, 500).Value = obj.ghichu;
        //    }
        //    irec = cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    if (irec == 0)
        //    {
        //        // thuc hiện thao tác insert
        //        string sql2 = "insert into kiosk_dm_kshl (ma,noidung,ngayud,ghichu) values ";
        //        sql2 = sql2 + "(:ma,:noidung,sysdate,:ghichu)";
        //        cmd = new OracleCommand(sql2, con);
        //        cmd.Transaction = trans;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.Add("id", OracleDbType.Int32).Value = obj.ma;
        //        cmd.Parameters.Add("noidung", OracleDbType.NVarchar2, 1000).Value = obj.noidung;
        //        cmd.Parameters.Add("ghichu", OracleDbType.NVarchar2, 1000).Value = obj.ghichu;
        //        irec = cmd.ExecuteNonQuery();
        //        cmd.Dispose();
        //    }
        //    return irec;
        //}
        public int Upp_DangKy(ThongTinDangKy obj)
        {
            int irec = 0;
            if (obj.id_ch == null)
            {
                obj.id_ch = "";
            }
            byte[] passr = Helper.Hash(obj.User, obj.Pass);
            string sql1 = "UPDATE login_ch set id_ch=@id_ch, username=@username";//public            
            sql1 = sql1 + " where id = " + obj.id + "";
            cmd = new SqlCommand(sql1, con);
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id_ch", SqlDbType.NVarChar, 100).Value = obj.id_ch;
            cmd.Parameters.Add("username", SqlDbType.NVarChar, 100).Value = obj.User;
            irec = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (irec == 0)
            {
                // thuc hiện thao tác insert
                string sql2 = "insert into login_ch (id,ten,email,password) values ";
                sql2 = sql2 + "(@id,@ten,@email,@password)";
                cmd = new SqlCommand(sql2, con);
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", SqlDbType.BigInt).Value = obj.id;
                cmd.Parameters.Add("ten", SqlDbType.NVarChar, 500).Value = obj.TenDN;
                cmd.Parameters.Add("email", SqlDbType.NVarChar, 100).Value = obj.Email;
                cmd.Parameters.Add("password", SqlDbType.Binary, 64).Value = passr;

                irec = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return irec;
        }
        public int Upp_Email(ThongTinDangKy obj)
        {
            int irec = 0;
            if (obj.id == null)
            {
                obj.id = 0;
            }
            //byte[] passr = Helper.Hash(obj.Email, obj.code);
            string sql1 = "UPDATE login_ch set  email=@email";//public            
            sql1 = sql1 + " where id = " + obj.id + "";
            cmd = new SqlCommand(sql1, con);
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", SqlDbType.NVarChar, 100).Value = obj.Email;
            irec = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (irec == 0)
            {
                // thuc hiện thao tác insert
                string sql2 = "INSERT INTO login_ch (id,ten,email,code,password) values ";
                sql2 = sql2 + "(@id,@ten,@email,@code,@password)";
                cmd = new SqlCommand(sql2, con);
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", SqlDbType.BigInt).Value = obj.id;
                cmd.Parameters.Add("ten", SqlDbType.NVarChar, 500).Value = obj.TenDN;
                cmd.Parameters.Add("email", SqlDbType.NVarChar, 100).Value = obj.Email;
                cmd.Parameters.Add("code", SqlDbType.NVarChar, 100).Value = obj.code;
                cmd.Parameters.Add("password", SqlDbType.Binary, 64).Value = Helper.Hash(obj.Email, obj.Pass);
                irec = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return irec;
        }

        public int Upp_DMCuaHang(DMCuaHang obj)
        {
            /// updat hay indssett có 3 buoc 
            /// 1. khai báo câu sql
            /// 2. khai báo Parameters
            /// 3 thực thi
            int irec = 0;
            int kiemtra = 0;// thứ thứ tự có buến ko
            //byte[] radom = Helper.Hash(obj.id_chinhanh, obj.ten);
            // kieu byte lafmm sao lam id? data id kiểu j?
            string sql1 = "UPDATE cua_hang set";//public            
            if (obj.id_chinhanh != null)
            {
                sql1 = sql1 + " id_chinhanh=@id_chinhanh";
            }
            else
            {
                kiemtra = 1;
            }
            if (obj.ten != null)
            {
                if (kiemtra == 1)
                {
                    sql1 = sql1 + " ten=@ten";
                }
                else
                {
                    sql1 = sql1 + " ,ten=@ten";
                }
            }
            // viet tiep
            if (obj.lienhe != null)
            {
                sql1 = sql1 + " ,lienhe =@lienhe";
            }
            if (obj.diachi != null)
            {
                sql1 = sql1 + " ,diachi =@diachi";
            }
            if (obj.maps_link != null)
            {
                sql1 = sql1 + " ,maps_link = @maps_link";
            }
            if (obj.maps_toado != null)
            {
                sql1 = sql1 + " ,maps_toado = @maps_toado";
            }
            if (obj.trangweb != null)
            {
                sql1 = sql1 + " ,trangweb = @trangweb";
            }
            if (obj.youtobe != null)
            {
                sql1 = sql1 + " ,youtobe =@youtobe";
            }
            if (obj.facebook != null)
            {
                sql1 = sql1 + " ,facebook = @facebook";
            }
            if (obj.tiktok != null)
            {
                sql1 = sql1 + " ,tiktok = @tiktok";
            }
            if (obj.linhvuc != null)
            {
                sql1 = sql1 + " ,linhvuc = @linhvuc";
            }
            //làm cái này chứ ko phải cái trên,
            // cái trên là kho có gì gắn thành trắng luôn update vào nó xóa mất của người ta

            // ten=@ten, lienhe =@lienhe, maps_link = @maps_link


            sql1 = sql1 + " where id = " + obj.id + "";
            // cho này chạy toi xem sql1 nó ra đúng ko
            cmd = new SqlCommand(sql1, con);//////1//////////////
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", SqlDbType.BigInt).Value = obj.id;///2
            if (obj.id_chinhanh != null)
            {
                cmd.Parameters.Add("id_chinhanh", SqlDbType.NVarChar, 100).Value = obj.id_chinhanh;
            }
            if (obj.ten != null)
            {
                cmd.Parameters.Add("ten", SqlDbType.NVarChar, 100).Value = obj.ten;
            }
            if (obj.lienhe != null)
            {
                cmd.Parameters.Add("lienhe", SqlDbType.NVarChar, 200).Value = obj.lienhe;
            }
            if (obj.diachi != null)
            {
                cmd.Parameters.Add("diachi", SqlDbType.NVarChar, 200).Value = obj.diachi;
            }
            if (obj.maps_link != null)
            {
                cmd.Parameters.Add("maps_link", SqlDbType.NVarChar, 200).Value = obj.maps_link;
            }
            if (obj.maps_toado != null)
            {
                cmd.Parameters.Add("maps_toado", SqlDbType.NVarChar, 200).Value = obj.maps_toado;
            }
            if (obj.trangweb != null)
            {
                cmd.Parameters.Add("trangweb", SqlDbType.NVarChar, 100).Value = obj.trangweb;
            }
            if (obj.youtobe != null)
            {
                cmd.Parameters.Add("youtobe", SqlDbType.NVarChar, 200).Value = obj.youtobe;
            }
            if (obj.facebook != null)
            {
                cmd.Parameters.Add("facebook", SqlDbType.NVarChar, 200).Value = obj.facebook;
            }
            if (obj.tiktok != null)
            {
                cmd.Parameters.Add("tiktok", SqlDbType.NVarChar, 200).Value = obj.tiktok;
            }
            if (obj.linhvuc != null)
            {
                cmd.Parameters.Add("linhvuc", SqlDbType.NVarChar, 100).Value = obj.linhvuc;
            }
            ///chổ này có thì khai báo Parameters ko có thi thôi
            irec = cmd.ExecuteNonQuery();////3
            cmd.Dispose();
            if (irec == 0)
            {
                //null - ""
                if (obj.id_chinhanh == null)
                {
                    obj.id_chinhanh = "";
                }
                if (obj.ten == null)
                {
                    obj.ten = "";
                }
                if (obj.lienhe == null)
                {
                    obj.lienhe = "";
                }
                if (obj.diachi == null)
                {
                    obj.diachi = "";
                }
                if (obj.maps_link == null)
                {
                    obj.maps_link = "";
                }
                if (obj.maps_toado == null)
                {
                    obj.maps_toado = "";
                }
                if (obj.trangweb == null)
                {
                    obj.trangweb = "";
                }
                if (obj.youtobe == null)
                {
                    obj.youtobe = "";
                }
                if (obj.facebook == null)
                {
                    obj.facebook = "";
                }
                if (obj.tiktok == null)
                {
                    obj.tiktok = "";
                }
                if (obj.linhvuc == null)
                {
                    obj.linhvuc = "";
                }
                // thuc hiện thao tác insert
                string sql2 = "insert into cua_hang (id, id_chinhanh,ten,lienhe,diachi,maps_link,maps_toado,trangweb,youtobe,facebook,tiktok,linhvuc) values ";
                sql2 = sql2 + "(@id,@id_chinhanh,@ten,@lienhe,@diachi,@maps_link,@maps_toado,@trangweb,@youtobe,@facebook,@tiktok,@linhvuc)";
                cmd = new SqlCommand(sql2, con);
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", SqlDbType.BigInt).Value = obj.id;
                cmd.Parameters.Add("id_chinhanh", SqlDbType.NVarChar, 100).Value = obj.id_chinhanh;
                cmd.Parameters.Add("ten", SqlDbType.NVarChar, 100).Value = obj.ten;
                cmd.Parameters.Add("lienhe", SqlDbType.NVarChar, 200).Value = obj.lienhe;
                cmd.Parameters.Add("diachi", SqlDbType.NVarChar, 200).Value = obj.diachi;

                cmd.Parameters.Add("maps_link", SqlDbType.NVarChar, 200).Value = obj.maps_link;
                cmd.Parameters.Add("maps_toado", SqlDbType.NVarChar, 200).Value = obj.maps_toado;
                cmd.Parameters.Add("trangweb", SqlDbType.NVarChar, 100).Value = obj.trangweb;

                cmd.Parameters.Add("youtobe", SqlDbType.NVarChar, 200).Value = obj.youtobe;
                cmd.Parameters.Add("facebook", SqlDbType.NVarChar, 200).Value = obj.facebook;
                cmd.Parameters.Add("tiktok", SqlDbType.NVarChar, 200).Value = obj.tiktok;
                cmd.Parameters.Add("linhvuc", SqlDbType.NVarChar, 100).Value = obj.linhvuc;
                irec = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return irec;
        }

        public int Upp_DMDanhGia(DMDanhGia obj)
        {
            /// updat hay indssett có 3 buoc 
            /// 1. khai báo câu sql
            /// 2. khai báo Parameters
            /// 3 thực thi
            int irec = 0;
            int kiemtra = 0;// thứ thứ tự có buến ko
            //byte[] radom = Helper.Hash(obj.id_chinhanh, obj.ten);
            string sql1 = "UPDATE dmdanhgia set";//public            
            if (obj.id_ch != null)
            {
                sql1 = sql1 + " id_ch=@id_ch";
            }
            else
            {
                kiemtra = 1;
            }
            if (obj.noidung != null)
            {
                if (kiemtra == 1)
                {
                    sql1 = sql1 + " noidung=@noidung";
                }
                else
                {
                    sql1 = sql1 + " ,noidung=@noidung";
                }
            }
            // viet tiep
            if (obj.trangthai != null)
            {
                sql1 = sql1 + " ,trangthai =@trangthai";
            }
            if (obj.diem != null)
            {
                sql1 = sql1 + " ,diem =@diem";
            }
            // cái trên là kho có gì gắn thành trắng luôn update vào nó xóa mất của người ta

            // ten=@ten, lienhe =@lienhe, maps_link = @maps_link

            sql1 = sql1 + " where id = " + obj.id + "";
            // cho này chạy toi xem sql1 nó ra đúng ko
            cmd = new SqlCommand(sql1, con);//////1//////////////
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", SqlDbType.BigInt).Value = obj.id;///2
            if (obj.id_ch != null)
            {
                cmd.Parameters.Add("id_ch", SqlDbType.NVarChar, 100).Value = obj.id_ch;
            }
            if (obj.noidung != null)
            {
                cmd.Parameters.Add("noidung", SqlDbType.NVarChar, 500).Value = obj.noidung;
            }
            if (obj.trangthai != null)
            {
                cmd.Parameters.Add("trangthai", SqlDbType.NVarChar, 500).Value = obj.trangthai;
            }
            if (obj.diem != null)
            {
                cmd.Parameters.Add("diem", SqlDbType.Int).Value = obj.diem;
            }

            ///chổ này có thì khai báo Parameters ko có thi thôi
            irec = cmd.ExecuteNonQuery();////3
            cmd.Dispose();
            if (irec == 0)
            {
                //null - ""
                if (obj.id_ch == null)
                {
                    obj.id_ch = "";
                }
                if (obj.noidung == null)
                {
                    obj.noidung = "";
                }
                if (obj.trangthai == null)
                {
                    obj.trangthai = "";
                }
                if (obj.diem == null)
                {
                    obj.diem = 0;
                }



                // thuc hiện thao tác insert
                string sql2 = "insert into dmdanhgia (id, id_ch,noidung,trangthai,diem) VALUES ";
                sql2 = sql2 + "(@id,@id_ch,@noidung,@trangthai,@diem)";
                cmd = new SqlCommand(sql2, con);
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", SqlDbType.BigInt).Value = obj.id;
                cmd.Parameters.Add("id_ch", SqlDbType.NVarChar, 100).Value = obj.id_ch;
                cmd.Parameters.Add("noidung", SqlDbType.NVarChar, 500).Value = obj.noidung;
                cmd.Parameters.Add("trangthai", SqlDbType.NVarChar, 500).Value = obj.trangthai;
                cmd.Parameters.Add("diem", SqlDbType.Int).Value = obj.diem;

                irec = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return irec;
        }

        public DataSet SignIn(string email, string pwd)
        {
            DataSet ds = get_data("Select * from login_ch where email = '" + email + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (dsx != null)
                {
                    dsx.Dispose();
                    dsx = null;
                }
                dsx = new DataSet();

                if (con == null || con.State != ConnectionState.Open)
                {
                    con = new SqlConnection(connectionString);
                    con.Open();
                }
                // bat dau que rry
                string sql = "select* from login_ch where email = @email and password = @pass";
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 200).Value = email;// email
                cmd.Parameters.Add("@pass", SqlDbType.Binary, 64).Value = Helper.Hash(email, pwd);// pass
                dest = new SqlDataAdapter(cmd);
                dsx = new DataSet();
                //MessageBox.Show(sql);
                dest.Fill(dsx);
                cmd.Dispose();
                con.Close();
                con.Dispose();
                return dsx;

            }
            else
            {
                return dsx;
            }

        }

    }

}