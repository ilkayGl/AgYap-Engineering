#pragma checksum "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Shared\PartialViews\_SideBarPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf16c9919cbff020ea5f428ee1d426a71e89bd8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_PartialViews__SideBarPartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialViews/_SideBarPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf16c9919cbff020ea5f428ee1d426a71e89bd8b", @"/Areas/Admin/Views/Shared/PartialViews/_SideBarPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df65dbbaa4db0fea072c28a6075528efad53181f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_PartialViews__SideBarPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row border-bottom"">
    <nav class=""navbar navbar-static-top  "" role=""navigation"" style=""margin-bottom: 0"">
        <div class=""navbar-header"">
            <a class=""navbar-minimalize minimalize-styl-2 btn btn-primary "" href=""#""><i class=""fa fa-bars""></i> </a>
        </div>
        <ul class=""nav navbar-top-links navbar-right"">
            <li>
                <span class=""m-r-sm text-muted welcome-message"">Hoş Geldin <b>");
#nullable restore
#line 8 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Shared\PartialViews\_SideBarPartialView.cshtml"
                                                                         Write(ViewBag.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n            </li>\r\n            <li>\r\n                <a href=\"/Home/Index/\">\r\n                    <i class=\"fa fa-sign-out\"></i> Çıkış Yap\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
