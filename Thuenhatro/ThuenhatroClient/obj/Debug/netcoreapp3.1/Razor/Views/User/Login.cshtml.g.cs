#pragma checksum "C:\Users\lenovo\OneDrive\Desktop\TeamWork\TeamWork\Thuenhatro\TeamWork\Thuenhatro\ThuenhatroClient\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac9760a7dd864afae188291e8362f8f6ebe141b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lenovo\OneDrive\Desktop\TeamWork\TeamWork\Thuenhatro\TeamWork\Thuenhatro\ThuenhatroClient\Views\_ViewImports.cshtml"
using ThuenhatroClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Desktop\TeamWork\TeamWork\Thuenhatro\TeamWork\Thuenhatro\ThuenhatroClient\Views\_ViewImports.cshtml"
using ThuenhatroClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac9760a7dd864afae188291e8362f8f6ebe141b", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd9fb3d2ce37ee2f9b2b06fff8fb71d32be6d0b1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThuenhatroClient.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\OneDrive\Desktop\TeamWork\TeamWork\Thuenhatro\TeamWork\Thuenhatro\ThuenhatroClient\Views\User\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    ");
#nullable restore
#line 6 "C:\Users\lenovo\OneDrive\Desktop\TeamWork\TeamWork\Thuenhatro\TeamWork\Thuenhatro\ThuenhatroClient\Views\User\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""row"">
        <div class=""col-sm-1""></div>
        <div class=""col-sm-4"">
            <h3>Đăng nhập</h3>
            <div class=""Log"">
                <label>Tài Khoản</label>
                <br />
                <input type=""text"" name=""uid"" />
                <br />
                <label>Mật khẩu</label>
                <br />
                <input type=""password"" name=""upass"" />
                <br />
                <input style=""margin-top:6px;"" type=""submit"" value=""Đăng nhập"" class=""badge-success"" />
            </div>
            <div style=""text-align:center"">
                <a href=""#"">Bạn quên mật khẩu?</a>&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <a href=""#"">Tạo tài khoản mới</a>
            </div>
        </div>
        <div class=""col-sm-2"">
            <div class=""here"">
                <div class=""text"">
                    <span>Hoặc</span>
                </div>

            </div>
        </div>
        <div class=""col-sm-4"">
            <");
            WriteLiteral(@"p style=""margin-top:50px"">
                Đăng nhập bằng Facebook hoặc Google
            </p>
            <div class=""FG"">
                <div class=""facebook"">
                    <a href=""http://facebook.com"">Đăng nhập bằng Facebook</a>
                </div>
                <br />

                <div class=""Google"">
                    <a href=""http://google.com"">Đăng nhập bằng Google+</a>
                </div>
            </div>
        </div>
        <div class=""col-sm-1""></div>
    </div>
    <br />
    <hr />
    <div class=""GT"">
        <div class=""row"" style=""text-align:center"">
            <div class=""col-sm-12"">
                <h4>Bạn đang có phòng trọ / căn hộ cho thuê?</h4>
                <br />
                <p>Không phải lo tìm người cho thuê, phòng trống kéo dài</p>
         
                <div style=""width:100%;  background-color: #c60e25; padding:10px; margin-top:0px"">
                    <a style=""color:white;"" href=""#"">Đăng tin ngay</a>
              ");
            WriteLiteral(@"  </div>
            </div>
        </div>
    </div>
    <div class=""TCG"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <div>
                    <h5>Cho thuê phòng trọ</h5>
                    <ul>
                        <li><a href=""#"">Cho thuê phòng trọ TP.HCM</a></li>
                        <li> <a href=""#"">Cho thuê phòng trọ Đồng Nai</a></li>
                        <li><a href=""#"">Cho thuê phòng trọ Bình Dương</a></li>
                        <li><a href=""#"">Cho thuê phòng trọ Đà Nẵng</a></li>
                        <li> <a href=""#"">cho thuê phòng trọ Huế</a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-sm-4"">
                <h5>Cho thuê nhà nguyên căn</h5>
                <ul>
                    <li><a href=""#"">Cho thuê nhà nguyên căn TP.HCM</a></li>
                    <li> <a href=""#"">Cho thuê nhà nguyên căn Đồng Nai</a></li>
                    <li><a href=""#"">Cho thuê nhà nguyên căn ");
            WriteLiteral(@"Bình Dương</a></li>
                    <li><a href=""#"">Cho thuê nhà nguyên căn Đà Nẵng</a></li>
                    <li> <a href=""#"">Cho thuê nhà nguyên căn Huế</a></li>
                </ul>
            </div>
            <div class=""col-sm-4"">
                <h5>Tìm người ở ghép</h5>
                <ul>
                    <li><a href=""#"">Tìm người ở ghép TP.HCM</a></li>
                    <li> <a href=""#"">Tìm người ở ghép Đồng Nai</a></li>
                    <li><a href=""#"">Tìm người ở ghép Bình Dương</a></li>
                    <li><a href=""#"">Tìm người ở ghép Đà Nẵng</a></li>
                    <li> <a href=""#"">Tìm người ở ghép Huế</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThuenhatroClient.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591