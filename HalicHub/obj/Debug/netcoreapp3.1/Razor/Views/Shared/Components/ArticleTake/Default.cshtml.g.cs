#pragma checksum "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\ArticleTake\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ac627fc8609b039d5d5c08b6b2ed066b699178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ArticleTake_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ArticleTake/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ac627fc8609b039d5d5c08b6b2ed066b699178", @"/Views/Shared/Components/ArticleTake/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead8ec691b5c3125bd9e70b52a1387d937d81768", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ArticleTake_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\ArticleTake\Default.cshtml"
 foreach (var item in Model.Articles)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4\">\n        ");
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\ArticleTake\Default.cshtml"
   Write(await Html.PartialAsync("_Article", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Shared\Components\ArticleTake\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591