#pragma checksum "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\Video\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0aa277daac2b9e894d4576fddb20209655decb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Video_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Video/Default.cshtml")]
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
#line 1 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\_ViewImports.cshtml"
using HalicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\_ViewImports.cshtml"
using Halic.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aa277daac2b9e894d4576fddb20209655decb9", @"/Views/Shared/Components/Video/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead8ec691b5c3125bd9e70b52a1387d937d81768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Video_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""countdown spad set-bg"" data-setbg=""/img/team-bg.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title team__title"">
                    <h2 style=""color: white; text-align: left;"">HALİÇ TV</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\Video\Default.cshtml"
             foreach (var item in Model.Videos)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\Video\Default.cshtml"
Write(await Html.PartialAsync("_Video", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\Video\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-lg-12 p-0"" style=""margin-top: 100px;"">
            <div class=""team__btn"">
                <a href=""#"" class=""primary-btn"">Tüm Videolar</a>
            </div>
        </div>
        <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-body"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                        <div class=""embed-responsive embed-responsive-16by9"">
                            <iframe class=""embed-responsive-item""");
            BeginWriteAttribute("src", " src=\"", 1340, "\"", 1346, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"video\" allowscriptaccess=\"always\" allow=\"autoplay\"></iframe>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
