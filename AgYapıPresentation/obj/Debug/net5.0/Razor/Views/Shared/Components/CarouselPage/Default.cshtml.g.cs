#pragma checksum "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf0e2b48a6bdf6ceac39d6f998dfbc069b0f7880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CarouselPage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CarouselPage/Default.cshtml")]
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
#line 1 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf0e2b48a6bdf6ceac39d6f998dfbc069b0f7880", @"/Views/Shared/Components/CarouselPage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e7a44e6a910658dad515cd340ad9e4778d59d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CarouselPage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Carousel>>
    #nullable disable
    {
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
        private global::AspNetCore.Views_Shared_Components_CarouselPage_Default.__Generated__Carousel2PageViewComponentTagHelper __Carousel2PageViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"hero\" class=\"hero\">\r\n\r\n    <div id=\"hero-carousel\" class=\"carousel slide\" data-bs-ride=\"carousel\" data-bs-interval=\"3000\">\r\n");
#nullable restore
#line 7 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""info d-flex align-items-center"">
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-6 text-center"">
                            <h2 data-aos=""fade-down"">");
#nullable restore
#line 13 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /><span>");
#nullable restore
#line 13 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml"
                                                                        Write(item.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <p data-aos=\"fade-up\">");
#nullable restore
#line 14 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml"
                                             Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a data-aos=\"fade-up\" data-aos-delay=\"200\" href=\"#hizmet\" class=\"btn-get-started\">");
#nullable restore
#line 15 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml"
                                                                                                         Write(item.ButtonTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\User\Masaustu\AgYapı\AgYapıPresentation\Views\Shared\Components\CarouselPage\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:carousel2-page", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf0e2b48a6bdf6ceac39d6f998dfbc069b0f78805995", async() => {
            }
            );
            __Carousel2PageViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Shared_Components_CarouselPage_Default.__Generated__Carousel2PageViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__Carousel2PageViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Carousel>> Html { get; private set; } = default!;
        #nullable disable
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:carousel2-page")]
        public class __Generated__Carousel2PageViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__Carousel2PageViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Carousel2Page", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                return args;
            }
        }
    }
}
#pragma warning restore 1591
