#pragma checksum "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Home\AuthorDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c25a4e559e845816bfca2f6a6748d8f5d77133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AuthorDetails), @"mvc.1.0.view", @"/Views/Home/AuthorDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c25a4e559e845816bfca2f6a6748d8f5d77133", @"/Views/Home/AuthorDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead8ec691b5c3125bd9e70b52a1387d937d81768", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AuthorDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Home\AuthorDetails.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section style=\"padding-bottom: 0px \">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-8\">\n                <div>\n                    <h3 style=\"font-weight: 700;\"><a href=\"#\">");
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Home\AuthorDetails.cshtml"
                                                         Write(Model.Authors.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                    <div class=""color-div"">
                        <div class=""color-blue"" style=""background-color:#2167B0;height:0.5rem;""></div>
                        <div class=""color-orange"" style=""background-color:#ED6425;height:0.5rem;""></div>
                        <div class=""color-pink"" style=""background-color:#DE2763;height:0.5rem;""></div>
                    </div>
                    <br>
                    <p>");
#nullable restore
#line 15 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Home\AuthorDetails.cshtml"
                  Write(Model.Authors.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n            <div class=\"col-lg-4\">\n                <img style=\"border-radius: 200px; float: right\"");
            BeginWriteAttribute("src", " src=\"", 910, "\"", 936, 1);
#nullable restore
#line 19 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Home\AuthorDetails.cshtml"
WriteAttributeValue("", 916, Model.Authors.Image, 916, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
    </div>
</section>

<div class=""listing-area pt-120 pb-120"">
    <div class=""container"">
        <h3 style=""font-weight: 700; border-bottom: solid black 1px; margin-bottom: 50px""><a href=""#"">Yazara ait yazılar</a></h3>
        <div class=""row"">
            <div class=""col-xl-12 col-lg-8 col-md-6"">
                <div class=""popular-directorya-area fix"">
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""properties pb-20"">
                                <div class=""properties__card"">
                                    <div class=""properties__img overlay1"">
                                        <a href=""#""><img src=""img/case_study/2.png""");
            BeginWriteAttribute("alt", " alt=\"", 1698, "\"", 1704, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                        <div class=""icon"">
                                            <h3 style=""font-size: 1em; padding: 5px; background: #07233d; color: white; border-radius: 8px"">Kategori</h3>
                                        </div>
                                    </div>
                                    <div class=""properties__caption"">
                                        <h3 style=""font-weight: 700""><a href=""#"">Introduction to Wordpress 5.0</a></h3>
                                        <p>
                                            A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a
                                            paradisematic country, in which roasted parts of sentences...
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
         ");
            WriteLiteral("       </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 57 "C:\Users\muhammetkaya\Desktop\MKAYA\sonhub-master\HalicHub\Views\Home\AuthorDetails.cshtml"
Write(await Html.PartialAsync("_Footer"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
