#pragma checksum "C:\Users\trung\Documents\GitHub\TeamWork\Thuenhatro\ThuenhatroClient\Views\User\ConfirmCodeEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721bd96adb339dc2372221771699dade2e861133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ConfirmCodeEmail), @"mvc.1.0.view", @"/Views/User/ConfirmCodeEmail.cshtml")]
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
#line 1 "C:\Users\trung\Documents\GitHub\TeamWork\Thuenhatro\ThuenhatroClient\Views\_ViewImports.cshtml"
using ThuenhatroClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\trung\Documents\GitHub\TeamWork\Thuenhatro\ThuenhatroClient\Views\_ViewImports.cshtml"
using ThuenhatroClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721bd96adb339dc2372221771699dade2e861133", @"/Views/User/ConfirmCodeEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd9fb3d2ce37ee2f9b2b06fff8fb71d32be6d0b1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ConfirmCodeEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThuenhatroClient.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\trung\Documents\GitHub\TeamWork\Thuenhatro\ThuenhatroClient\Views\User\ConfirmCodeEmail.cshtml"
  
    ViewData["Title"] = "Xác nhận Email";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-1\"></div>\r\n        <div class=\"col-sm-8\">\r\n            <h3>Vui lòng xác thưc tài khoản Email</h3>\r\n            <div class=\"Log\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721bd96adb339dc2372221771699dade2e8611334470", async() => {
                WriteLiteral(@"
                    <p>Mã xác thực đã được gửi đến <b>Email</b>. Vui long nhập mã vào bên dưới để tiếp tục</p>
                    <p>Mã xác thực:</p>
                    <input type=""text"" name=""uid"" />
                    <br />
                    <input style=""margin-top:6px;width:260px;border-radius:3px;text-indent:0px"" type=""submit"" value=""Xác thực tài khoản, miễn phí"" class=""badge-success"" />
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\trung\Documents\GitHub\TeamWork\Thuenhatro\ThuenhatroClient\Views\User\ConfirmCodeEmail.cshtml"
AddHtmlAttributeValue("", 322, Url.Action("ConfirmCodeEmail", "User"), 322, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p>Bạn vẫn chưa nhận được mã xác thực?</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721bd96adb339dc2372221771699dade2e8611337008", async() => {
                WriteLiteral("\r\n                    <input style=\"margin-top:6px;width:120px;border-radius:3px;text-indent:0px;background-color:darkslategrey; color:white\" type=\"submit\" value=\"Gửi lại mã\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\trung\Documents\GitHub\TeamWork\Thuenhatro\ThuenhatroClient\Views\User\ConfirmCodeEmail.cshtml"
AddHtmlAttributeValue("", 932, Url.Action("ResentCode", "User"), 932, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <br />
                <p>Hãy gọi <b>0354072542</b> để được hổ trợ nếu bạn gặp khó khăn trong quá trình xác minh tài khoản.</p>
            </div>

            <div class=""col-sm-2"">
            </div>
            <div class=""col-sm-1""></div>
        </div>

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
                </div>
            </div>
        </div>
    </div>
    <div class=""TCG"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <div>
                    <h5>Cho thuê phòng trọ</h5>
                 ");
            WriteLiteral(@"   <ul>
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
                    <li><a href=""#"">Cho thuê nhà nguyên căn Bình Dương</a></li>
                    <li><a href=""#"">Cho thuê nhà nguyên căn Đà Nẵng</a></li>
                    <li> <a href=""#"">Cho thuê nhà nguyên căn Huế</a></li>
                </ul>
            </div>
            <div");
            WriteLiteral(@" class=""col-sm-4"">
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
