#pragma checksum "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9b1a2c7340e8ba797d14395d8da61530084780"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_ContactMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/ContactMessage.cshtml")]
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
#line 1 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9b1a2c7340e8ba797d14395d8da61530084780", @"/Areas/Admin/Views/Message/ContactMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df65dbbaa4db0fea072c28a6075528efad53181f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Message_ContactMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/Admin/AdminPanel/font-awesome/css/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Areas/Admin/Views/Message/MessageMenuPartialView.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
  
    ViewData["Title"] = "ContactMessage";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ee9b1a2c7340e8ba797d14395d8da615300847804623", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"wrapper wrapper-content\">\r\n    <div class=\"row\">\r\n\r\n        <!--MessageMenuPartialView-->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee9b1a2c7340e8ba797d14395d8da615300847805861", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <div class=""col-lg-9 animated fadeInRight"">
            <div class=""mail-box-header"">

                <h2>
                    Gelen Mesajlar <i class=""fa fa-medium""></i>
                </h2>
                <div class=""mail-tools tooltip-demo m-t-md"">

                    <button class=""btn btn-white btn-sm"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 809, "\"", 816, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color:black"" class=""fa fa-refresh"">  Yenile</a>
                    </button>
                </div>
            </div>
            <div class=""mail-box table-responsive"">

                <table class=""table  table-hover table-mail"">
                    <tbody>
");
#nullable restore
#line 32 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr class=""read"">
                                <td><span class=""label label-success float-right""><i class=""fa fa-medium ""></i></span></td>
                                <td class=""mail-ontact"">
                                    <strong>");
#nullable restore
#line 37 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
                                       Write(item.ContactUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </td>\r\n                                <td class=\"mail-subject\"><b>Konu : </b> ");
#nullable restore
#line 39 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
                                                                   Write(item.ContactSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /></td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 1663, "\"", 1671, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-paperclip\"></i><a");
            BeginWriteAttribute("href", " href=\"", 1706, "\"", 1758, 2);
            WriteAttributeValue("", 1713, "/Admin/Message/MessageDetails/", 1713, 30, true);
#nullable restore
#line 40 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
WriteAttributeValue("", 1743, item.ContactId, 1743, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mesajı Oku.</a></td>\r\n                                <td class=\"text-right mail-date\">\r\n                                    ");
#nullable restore
#line 42 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
                                Write(((DateTime)item.ContactDate).ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-danger\" style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 2101, "\"", 2152, 2);
            WriteAttributeValue("", 2108, "/Admin/Message/MessageRemove/", 2108, 29, true);
#nullable restore
#line 45 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
WriteAttributeValue("", 2137, item.ContactId, 2137, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Sil\r\n                                    </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Areas\Admin\Views\Message\ContactMessage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
