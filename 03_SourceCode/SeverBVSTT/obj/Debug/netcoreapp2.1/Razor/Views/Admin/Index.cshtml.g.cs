#pragma checksum "E:\Nam4\Ky8\LVTN\TTTN\Code\Code\03_SourceCode\SeverBVSTT\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed00c7ee5ea38638279d32e192d1cb1a9904c1a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Nam4\Ky8\LVTN\TTTN\Code\Code\03_SourceCode\SeverBVSTT\Views\_ViewImports.cshtml"
using SeverBVSTT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed00c7ee5ea38638279d32e192d1cb1a9904c1a9", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca976f0d8528e059f8832bbf68482a8965c92d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/js.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Nam4\Ky8\LVTN\TTTN\Code\Code\03_SourceCode\SeverBVSTT\Views\Admin\Index.cshtml"
  
    Layout = "_LayoutHome";
    ViewData["Title"] = "Đánh giá hài lòng khách hàng";

#line default
#line hidden
            BeginContext(92, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(96, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed00c7ee5ea38638279d32e192d1cb1a9904c1a93803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(130, 141, true);
            WriteLiteral("\r\n    <script data-ad-client=\"ca-pub-5379163438190087\" async src=\"https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js\"></script>\r\n");
            EndContext();
            BeginContext(274, 2093, true);
            WriteLiteral(@"<div class=""container"">
    <label>Danh mục cửa hàng</label>
    <div class=""row"">

    </div>
    <div class=""row"">

    </div>
</div>
<!---model dang xuat-->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <h3>Bạn có chắc muốn đăng xuất?</h3>
            </div>
            <div class=""modal-footer"">
                <a href=""/Home/signout"" class=""btn btn-primary btn-lg active"" role=""button"" aria-pressed=""true"">Đăng Xuất</a>
                <a href=""#"" class=""btn btn-primary btn-lg active"" role=""button"" aria-pressed=""true"" data-bs-dismiss=""modal"">Đóng</a>
            </div>
        </div>
    </div>
</div>
<div class=""container"" style=""height:550px; overflow: scroll"">
    <table class=""table"">
        <thead>
            <tr>
                <td>
                    stt
");
            WriteLiteral(@"                </td>
                <td>
                    id
                </td>
                <td>
                    id chi nhánh
                </td>
                <td>
                    Tên
                </td>
                <td>
                    Liên hệ
                </td>
                <td>
                    Địa chỉ
                </td>
                <td>
                    Maps link
                </td>
                <td>
                    Maps toa độ
                </td>
                <td>
                    Trang web
                </td>
                <td>
                    Youtobe
                </td>
                <td>
                    Facebook
                </td>
                <td>
                    Tiktok
                </td>
                <td>
                    Lĩnh vực
                </td>
            </tr>
        </thead>
        <tbody id=""dm-tbody"">
        </tbody>
    </table>
</div>
");
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2367, "\"", 2375, 0);
            EndWriteAttribute();
            BeginContext(2376, 137, true);
            WriteLiteral(">\r\n        <div class=\"col-2\">\r\n            <label>ID:</label><label id=\"dmID\"></label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2513, "\"", 2521, 0);
            EndWriteAttribute();
            BeginContext(2522, 378, true);
            WriteLiteral(@">
        <div class=""col-6"">
            <label>
                Tên:
            </label>
            <input id=""dmTen"" class=""form-control"">
        </div>
        <div class=""col-6"">
            <label>
                Liên hệ:
            </label>
            <input id=""dmLienHe"" class=""form-control"">
        </div>
    </div>


    
    <div class=""row""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2900, "\"", 2908, 0);
            EndWriteAttribute();
            BeginContext(2909, 395, true);
            WriteLiteral(@">
        <div class=""col-6"">
            <label>
                Địa chỉ:
            </label>
            <input id=""dmDiaChi"" class=""form-control"">
        </div>
        <div class=""col-6"">
            <label>
                Maps link:
            </label>
            <input id=""dmMapsLink"" class=""form-control"">
        </div>
    </div>
          


    <div class=""row""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3304, "\"", 3312, 0);
            EndWriteAttribute();
            BeginContext(3313, 393, true);
            WriteLiteral(@">
        <div class=""col-6"">
            <label>
                Maps toado:
            </label>
            <input id=""dmMapsTaodo"" class=""form-control"">
        </div>
        <div class=""col-6"">
            <label>
                Trang web:
            </label>
            <input id=""dmTrangWeb"" class=""form-control"">
        </div>
    </div>
    

    <div class=""row""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3706, "\"", 3714, 0);
            EndWriteAttribute();
            BeginContext(3715, 381, true);
            WriteLiteral(@">
        <div class=""col-6"">
            <label>
                Youtobe:
            </label>
            <input id=""dmYoutobe"" class=""form-control"">
        </div>
        <div class=""col-6"">
            <label>
                Facebook:
            </label>
            <input id=""dmFacebook"" class=""form-control"">
        </div>
    </div>

    <div class=""row""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4096, "\"", 4104, 0);
            EndWriteAttribute();
            BeginContext(4105, 366, true);
            WriteLiteral(@">
        <div class=""col-6"">
            <label>
                Tiktok:
            </label>
            <input id=""dmTiktok"" class=""form-control"">
        </div>
        <div class=""col-6"">
            <label>
                Lĩnh vực:
            </label>
            <input id=""dmLinhVuc"" class=""form-control"">
        </div>
    </div>
    


");
            EndContext();
            BeginContext(4633, 16634, true);
            WriteLiteral(@"    <div class=""row justify-content-center"" style=""padding-top: 2%"">
        <div class=""col-5"">

            <button id=""btn-them"" class=""btn btn-info"" onclick=""btn_them()"">Thêm</button>
            <button id=""btn-sua"" class=""btn btn-warning"" onclick=""btn_sua()"">Sửa</button>
            <button id=""btnLuu"" class=""btn btn-success"" onclick=""btn_luu()"">Lưu</button>
            <button id=""btnBoQua"" class=""btn btn-success"" onclick=""btn_boqua()"">Bỏ qua</button>
            <button id=""btn-xoa"" class=""btn btn-danger"" onclick=""btn_xoa()"">Xóa</button>


        </div>
    </div>
</div>0
<script type=""text/javascript"">

    var Display = 0;// 0 mt// 1 điện thoại 2// tivi
    var dmID = document.getElementById(""dmID"").innerText;
    var dmTen = document.getElementById(""dmTen"").value;
    var dmLienHe = document.getElementById(""dmLienHe"").value;
    var dmDiaChi = document.getElementById(""dmDiaChi"").value;

    var dmMapsLink = document.getElementById(""dmMapsLink"").value;
    var dmMapsTaodo = do");
            WriteLiteral(@"cument.getElementById(""dmMapsTaodo"").value;
    var dmTrangWeb = document.getElementById(""dmTrangWeb"").value;

    var dmYoutobe = document.getElementById(""dmYoutobe"").value;
    var dmFacebook = document.getElementById(""dmFacebook"").value;
    var dmTiktok = document.getElementById(""dmTiktok"").value;
    var dmLinhVuc = document.getElementById(""dmLinhVuc"").value;

    var obj_dm = new Object();
    function loaddulieu() {
        dmID = document.getElementById(""dmID"").innerText;
        dmTen = document.getElementById(""dmTen"").value;
        dmLienHe = document.getElementById(""dmLienHe"").value;
        dmDiaChi = document.getElementById(""dmDiaChi"").value;

        dmMapsLink = document.getElementById(""dmMapsLink"").value;
        dmMapsTaodo = document.getElementById(""dmMapsTaodo"").value;
        dmTrangWeb = document.getElementById(""dmTrangWeb"").value;

        dmYoutobe = document.getElementById(""dmYoutobe"").value;
        dmFacebook = document.getElementById(""dmFacebook"").value;
      ");
            WriteLiteral(@"  dmTiktok = document.getElementById(""dmTiktok"").value;
        dmLinhVuc = document.getElementById(""dmLinhVuc"").value;
    }
    window.onload = function () { //window.onload su kien tu dong khi load xong
        var x = screen.width;
        var y = screen.height;
        if (x < 480) {
            Display = 1;
        } else if (y < 480) {
            Display = 1;
        } else {

        }
       
        
        load_noidung();//
        disabale_btn();
        disabale_input();
    };
    //tim kiem
    function td_tk_cd(block_show, block_close) {
        $(""#"" + block_close).toggle(300);
        $(""#"" + block_show).show(300);
    }

    function kiemtra() {
        return new Promise(function (resolve, reject) {
            try {

                /// lap trinh bat dong bo// tat ca cho doi dua het vao day
                resolve(1);
                
            } catch {
                reject(0); //  Promise ở trạng thái reject
            }
        });
    }

  ");
            WriteLiteral(@"  // query ////////////////////////////////////////////
    async function load_noidung() {
        /////?????????????????????
      //  alert(""b2"");
        let kq = await load_dm();
        alert(kq)
        if (kq == 1) {
            tb_themdm_();
        } else {
          //  alert(""b3"");
        }
    }
    // update ==================================================================================================
    function btn_them() {
        //mo nut luu
        document.getElementById(""btnLuu"").disabled = false;
        enable_input();

    }
    function btn_sua() {
        enable_btn();//
        
    }
    async function btn_luu() {
        alert('da vao luu');
        let kt = await kiemtra();
        if (kt == 1) {
            luu_();
        } else {
            alert(""Kiểm tra lại thông tin!"");
        }
    }
    function btn_boqua() {
        disabale_btn();
        disabale_input();
    }
    function btn_xoa(a) {
        return new Promise(function ");
            WriteLiteral(@"(resolve, reject) {
            try {
                loaddulieu();
                if (a == null) {
                    a = document.getElementById(""dm_cuahang"").innerText;
                }
                var o = {
                    'dm_cuahang': `${a}`
                };//icd_chinh
                ajax.post(o, '/khaosathailong/xoa_dm_cuahang', function (data) {
                    kq = JSON.parse(data);
                    if (kq.i_TrangThai_0_1 == ""1"") {
                        load_noidung();
                        btn_boqua();
                        alert(""Xóa thành công!"");
                        resolve(1);
                    } else {
                        alert(""Xóa không thành công!"");
                        resolve(0);
                    }
                });

            } catch {
                reject(0); //  Promise ở trạng thái reject
            }
        });
    }
    function luu_() {
        //alert("" da vao luu bat dau gắn du lieu vao biến dua xuong ");
            WriteLiteral(@"sever"");
        return new Promise(function (resolve, reject) {
            try {
                loaddulieu();
                var o = {
                    'id': `${dmID}`, 'ten': `${dmTen}`, 'lienhe': `${dmLienHe}`, 'diachi': `${dmDiaChi}`,
                    'maps_link': `${dmMapsLink}`, 'maps_toado': `${dmMapsTaodo}`, 'trangweb': `${dmTrangWeb}`,
                    'youtobe': `${dmYoutobe}`, 'facebook': `${dmFacebook}`, 'tiktok': `${dmTiktok}`, 'linhvuc': `${dmLinhVuc}`

                };//icd_chinh
                alert(0);
                ajax.post(o, '/admin/udp_dm_cuahang', function (data) {
                    alert(data);
                    kq = JSON.parse(data);
                    if (kq.i_TrangThai_0_1 == ""1"") {
                        alert(""Lưu thành công!"");
                        resolve(1);
                        load_noidung();
                        btn_boqua();
                        //document.getElementById(""b-ttbn"").disabled = false;
                    } ");
            WriteLiteral(@"else {
                        alert(""Lưu không thành công!"");
                        resolve(0);
                        //document.getElementById(""b-ttbn"").disabled = false;
                    }
                });
                //resolve(1); //  Promise ở trạng thái reject
            } catch {
                reject(0); //  Promise ở trạng thái reject
            }
        });
    }
    function load_dm() {
        return new Promise(function (resolve, reject) {
            try {
               
                var o = {
                    'id': `${dmID}`, 'ten': `${dmTen}`, 'lienhe': `${dmLienHe}`, 'diachi': `${dmDiaChi}`,
                    'maps_link': `${dmMapsLink}`, 'maps_toado': `${dmMapsTaodo}`, 'trangweb': `${dmTrangWeb}`,
                    'youtobe': `${dmYoutobe}`, 'facebook': `${dmFacebook}`, 'tiktok': `${dmTiktok}`, 'linhvuc': `${dmLinhVuc}`
                };//icd_chinh      
                /// loix taij day cos 2 casis bien 0
                ajax.post(o, '/adm");
            WriteLiteral(@"in/load_dm_cuahang', function (data) {
                    
                    //alert(data);
                    obj_dm = JSON.parse(data);
                    resolve(1);
                });
            } catch (e) {
                reject(0);
            }
        });
    }
    async function load_id() {

        let kq = await load_dm();
        if (kq == 1) {
            tb_themdm_();
        } else {
            alert(""lỗi load danh mục!"")
        }
    }
    function tb_themdm_() {

        /// cho nay no viet ra cai bang kia
        // dua vao json tra vien no viet ra obj.. dung vao key lay gia tri ra
        let dp = ""'"";
        let dm_tbody = document.getElementById(""dm-tbody"");// khai bao doi tuong bang cang thao tac



        $(""#dm-tbody"").empty();// xoas het cac dong troong bang do

        // bat dau chay for chay het mang doi tuong do
        for (var i = 0; i < obj_dm.length; i++) {
            // stt nay là tự tạo ăn theo thằng i chứ data ko có
          ");
            WriteLiteral(@"  let a = '<td>' + (i + 1) + '</td>'
            // trong json ve khongc co stt
            
            a = a + '<td>' + obj_dm[i].id + '</td>'
            a = a + '<td>' + obj_dm[i].id_chinhanh + '</td>'
            a = a + '<td>' + obj_dm[i].ten + '</td>'
            a = a + '<td>' + obj_dm[i].lienhe + '</td>'
            a = a + '<td>' + obj_dm[i].diachi + '</td>'

            a = a + '<td>' + obj_dm[i].maps_link + '</td>'
            a = a + '<td>' + obj_dm[i].maps_toado + '</td>'
            a = a + '<td>' + obj_dm[i].trangweb + '</td>'

            a = a + '<td>' + obj_dm[i].youtobe + '</td>'
            a = a + '<td>' + obj_dm[i].facebook + '</td>'
            a = a + '<td>' + obj_dm[i].tiktok + '</td>'
            a = a + '<td>' + obj_dm[i].linhvuc + '</td>'

            a = a + '<td class=""dm-xoa"" onclick=""btn_xoa(' + dp + '' + obj_dm[i].id + '' + dp + ')"">Xóa</td>'
            let str = '<tr class=""row_tb"" onclick=""chondm(' + dp + '' + obj_dm[i].id + '' + dp + ')"">' + a + '</tr>'");
            WriteLiteral(@";
            // chon cho nay// no gui luon id vao luôn rôi nen qua ham chondm nó biết là chọn ai
            $(dm_tbody).append(str)
            // cai mau xanh do duua vao row_tb
        }
    }
    async function chondm(a_) {
        //alert('may moi chon vao tao day; id cua tao la:  ' + a_)
        document.getElementById(""dmID"").innerText = a_;
        //document.getElementById(""btn-sua"").disabled = false;
        //document.getElementById(""btnLuu"").disabled = true;
        //document.getElementById(""btn-xoa"").disabled = true;
        for (var i = 0; i < obj_dm.length; i++) {
            if (a_ == obj_dm[i].id) {
                document.getElementById(""dmID"").value = obj_dm[i].ID;
                document.getElementById(""dmTen"").value = obj_dm[i].ten;
                document.getElementById(""dmLienHe"").value = obj_dm[i].lienhe;
                document.getElementById(""dmDiaChi"").value = obj_dm[i].diachi;


                document.getElementById(""dmMapsLink"").value = obj_dm[i].maps_l");
            WriteLiteral(@"ink;
                document.getElementById(""dmMapsTaodo"").value = obj_dm[i].maps_toado;
                document.getElementById(""dmTrangWeb"").value = obj_dm[i].trangweb;
                document.getElementById(""dmYoutobe"").value = obj_dm[i].youtobe;
                document.getElementById(""dmFacebook"").value = obj_dm[i].facebook;
                document.getElementById(""dmTiktok"").value = obj_dm[i].tiktok;
                document.getElementById(""dmLinhVuc"").value = obj_dm[i].linhvuc;
            }
        }
        document.getElementById(""btn-sua"").disabled = false;
    }
    function disabale_btn() {
        document.getElementById(""btn-sua"").disabled = true;
        document.getElementById(""btnLuu"").disabled = true;
        document.getElementById(""btn-xoa"").disabled = true;
    }
    function enable_btn() {
        document.getElementById(""btn-sua"").disabled = false;
        document.getElementById(""btnLuu"").disabled = false;
        document.getElementById(""btn-xoa"").disabled = fals");
            WriteLiteral(@"e;

        // inphut
        document.getElementById(""dmID"").disabled = false;
        document.getElementById(""dmTen"").disabled = false;
        document.getElementById(""dmLienHe"").disabled = false;
        document.getElementById(""dmDiaChi"").disabled = false;

        document.getElementById(""dmMapsLink"").disabled = false;
        document.getElementById(""dmMapsTaodo"").disabled = false;
        document.getElementById(""dmTrangWeb"").disabled = false;

        document.getElementById(""dmYoutobe"").disabled = false;
        document.getElementById(""dmFacebook"").disabled = false;
        document.getElementById(""dmTiktok"").disabled = false;
        document.getElementById(""dmLinhVuc"").disabled = false;
    }
    function disabale_input() {
        //document.getElementById(""kshl-ma"").innerText = """";
        //document.getElementById(""kshl-noidung"").value = """";
        //document.getElementById(""kshl-noidung"").disabled = true;
        //document.getElementById(""kshl-ghichu"").value = """";
   ");
            WriteLiteral(@"     //document.getElementById(""kshl-ghichu"").disabled = true;

        document.getElementById(""dmID"").innerText = """";
        document.getElementById(""dmTen"").value = """";
        document.getElementById(""dmTen"").disabled = true;
        document.getElementById(""dmLienHe"").value = """";
        document.getElementById(""dmLienHe"").disabled = true;
        document.getElementById(""dmDiaChi"").value = """";
        document.getElementById(""dmDiaChi"").disabled = true;

        document.getElementById(""dmMapsLink"").value = """";
        document.getElementById(""dmMapsLink"").disabled = true;
        document.getElementById(""dmMapsTaodo"").value = """";
        document.getElementById(""dmMapsTaodo"").disabled = true;
        document.getElementById(""dmTrangWeb"").value = """";
        document.getElementById(""dmTrangWeb"").disabled = true;

        document.getElementById(""dmYoutobe"").value = """";
        document.getElementById(""dmYoutobe"").disabled = true;
        document.getElementById(""dmFacebook"").value = ");
            WriteLiteral(@""""";
        document.getElementById(""dmFacebook"").disabled = true;
        document.getElementById(""dmTiktok"").value = """";
        document.getElementById(""dmTiktok"").disabled = true;
        document.getElementById(""dmLinhVuc"").value = """";
        document.getElementById(""dmLinhVuc"").disabled = true;


    }
    function enable_input() {
        //document.getElementById(""kshl-ma"").innerText = """";
        //document.getElementById(""kshl-noidung"").value = """";
        //document.getElementById(""kshl-noidung"").disabled = false;
        //document.getElementById(""kshl-ghichu"").value = """";
        //document.getElementById(""kshl-ghichu"").disabled = false;

        document.getElementById(""dmID"").innerText = """";
        document.getElementById(""dmTen"").value = """";
        document.getElementById(""dmTen"").disabled = false;
        document.getElementById(""dmLienHe"").value = """";
        document.getElementById(""dmLienHe"").disabled = false;
        document.getElementById(""dmDiaChi"").value = """";
            WriteLiteral(@"
        document.getElementById(""dmDiaChi"").disabled = false;

        document.getElementById(""dmMapsLink"").value = """";
        document.getElementById(""dmMapsLink"").disabled = false;
        document.getElementById(""dmMapsTaodo"").value = """";
        document.getElementById(""dmMapsTaodo"").disabled = false;
        document.getElementById(""dmTrangWeb"").value = """";
        document.getElementById(""dmTrangWeb"").disabled = false;

        document.getElementById(""dmYoutobe"").value = """";
        document.getElementById(""dmYoutobe"").disabled = false;
        document.getElementById(""dmFacebook"").value = """";
        document.getElementById(""dmFacebook"").disabled = false;
        document.getElementById(""dmTiktok"").value = """";
        document.getElementById(""dmTiktok"").disabled = false;
        document.getElementById(""dmLinhVuc"").value = """";
        document.getElementById(""dmLinhVuc"").disabled = false;
    }
</script>
<style>
    .xoatd {
        padding-bottom: 0;
        padding-top: 0;
");
            WriteLiteral(@"        margin-top: 0;
        margin-bottom: 0;
    }

    .left-center {
        justify-content: left;
        align-items: center;
        display: flex;
    }

    .right-center {
        justify-content: right;
        align-items: center;
        display: flex;
    }

    .center {
        justify-content: center;
        align-items: center;
        display: flex;
    }

    a_img {
        /*border-radius: 30px !important*/
    }

    input:checked ~ .checkmark {
        background-color: #2196F3;
    }

    .td-tk {
        margin: 0;
        padding-top: 2%;
        padding-bottom: 2%;
        border-bottom: solid;
        border-color: greenyellow
    }

    input {
        font-weight: bold;
        font-size: 20px !important
    }

    section {
        font-weight: bold;
        font-size: 20px !important
    }

    textarea {
        font-weight: bold;
        font-size: 20px !important
    }

    #test1 {
        position: absolute;
     ");
            WriteLiteral("   left: 0px;\r\n        bottom: 200px;\r\n    }\r\n  /*  hover là đua chuot vao*/\r\n    .row_tb:hover {\r\n        background-color: greenyellow;\r\n    }\r\n\r\n    .dm-xoa:hover {\r\n        background-color: red;\r\n        cursor: alias;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591