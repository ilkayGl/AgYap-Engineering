#pragma checksum "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcab36cdb674f6549778a3b7033b477bbc1169d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\_ViewImports.cshtml"
using AgYapıPresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\_ViewImports.cshtml"
using AgYapıPresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcab36cdb674f6549778a3b7033b477bbc1169d4", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e7a44e6a910658dad515cd340ad9e4778d59d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactLocation>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .button {
        display: inline-block;
        padding: 15px 25px;
        font-size: 15px;
        cursor: pointer;
        text-align: center;
        text-decoration: none;
        outline: none;
        color: #fff;
        background-color: #4CAF50;
        border: none;
        border-radius: 15px;
        box-shadow: 0 9px #999;
    }

        .button:hover {
            background-color: #3e8e41
        }

        .button:active {
            background-color: #3E8E41;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }
</style>
<main id=""main"">



    <!-- ======= Breadcrumbs ======= -->
    <div class=""breadcrumbs d-flex align-items-center"" style=""background-image: url('/Template/UI/UpConstruction/assets/img/breadcrumbs-bg.jpg');"">
        <div class=""container position-relative d-flex flex-column align-items-center"" data-aos=""fade"">
");
#nullable restore
#line 40 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>");
#nullable restore
#line 42 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
               Write(item.ContactTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 43 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <ol>
                <li><a href=""/Home/Index"">AnaSayfa</a></li>
                <li>İletişim</li>
            </ol>

        </div>
    </div><!-- End Breadcrumbs -->
    <!-- ======= Contact Section ======= -->
    <section id=""contact"" class=""contact"">

        <div class=""container"" data-aos=""fade-up"" data-aos-delay=""100"">

            <div class=""row gy-4"">
");
#nullable restore
#line 58 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-6"">
                        <div class=""info-item  d-flex flex-column justify-content-center align-items-center"">
                            <i class=""bi bi-map""></i>
                            <h3>Adresimiz</h3>
                            <p>");
#nullable restore
#line 64 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
                          Write(item.ContactAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <!-- End Info Item -->\r\n");
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6"">
                        <div class=""info-item d-flex flex-column justify-content-center align-items-center"">
                            <i class=""bi bi-envelope""></i>
                            <h3>Mail Adresimiz</h3>
                            <p>");
#nullable restore
#line 74 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
                          Write(item.ContactEMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <!-- End Info Item -->\r\n");
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6"">
                        <div class=""info-item  d-flex flex-column justify-content-center align-items-center"">
                            <i class=""bi bi-telephone""></i>
                            <h3>Bizi Arayın</h3>
                            <p>");
#nullable restore
#line 84 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
                          Write(item.ContactPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                    <!-- End Info Item -->\r\n");
#nullable restore
#line 89 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n            <div class=\"row gy-4 mt-1\">\r\n");
#nullable restore
#line 94 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-6 \">\r\n                        <iframe");
            BeginWriteAttribute("src", " src=\"", 3180, "\"", 3210, 1);
#nullable restore
#line 97 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
WriteAttributeValue("", 3186, item.ContactMapLocation, 3186, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" style=\"border:0; width: 100%; height: 384px;\" allowfullscreen></iframe>\r\n                    </div>\r\n");
            WriteLiteral("                    <!-- End Google Maps -->\r\n");
#nullable restore
#line 101 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Contact\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"col-lg-6 info-item d-flex flex-column justify-content-center align-items-center\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcab36cdb674f6549778a3b7033b477bbc1169d411318", async() => {
                WriteLiteral(@"
                        <div class=""row gy-4 "">
                            <div class=""col-lg-6 form-group"">
                                <br />
                                <input type=""text"" name=""ContactUserName"" class=""form-control"" placeholder=""Ad Soyad"" required>
                            </div>
                            <div class=""col-lg-6 form-group"">
                                <br />
                                <input type=""email"" class=""form-control"" name=""ContactMail"" placeholder=""Mail Adresi"" required>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <br />
                            <input type=""text"" class=""form-control"" name=""ContactSubject"" placeholder=""Konu"" required>
                        </div>
                        <div class=""form-group"">
                            <br />
                            <textarea class=""form-control"" name=""ContactMessage"" ");
                WriteLiteral(@"rows=""5"" placeholder=""Mesajınız"" required></textarea>
                        </div>

                        <div class=""text-center""><button style=""vertical-align:middle"" class=""button my-2"" type=""submit"">Mesaj Gönder</button></div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div><!-- End Contact Form -->\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Contact Section -->\r\n\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactLocation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
