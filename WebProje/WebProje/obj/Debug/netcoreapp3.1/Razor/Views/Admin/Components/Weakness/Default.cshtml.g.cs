#pragma checksum "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155e70511a49b5df9ee8db6189e01ff0b7624024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Components_Weakness_Default), @"mvc.1.0.view", @"/Views/Admin/Components/Weakness/Default.cshtml")]
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
#line 1 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155e70511a49b5df9ee8db6189e01ff0b7624024", @"/Views/Admin/Components/Weakness/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Components_Weakness_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebProje.Models.Weakness>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 4 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
     foreach (var weakness in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex flex-row justify-content-start"">
                    <div class=""d-flex flex-row justify-content-between"">
                        <div>ID:</div>
                        <div>");
#nullable restore
#line 11 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
                        Write(weakness.WEAKNESS_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"d-flex flex-row justify-content-between ml-2\">\r\n                        <div>Zayıflık Adı:</div>\r\n                        <div>");
#nullable restore
#line 15 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
                        Write(weakness.WEAKNESS_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>

            </div>
            <div class=""card-footer"">
                <div class=""d-flex flex-row justify-content-between"">
                    <button class=""btn btn-lg btn-danger weakness-delete-button"" data-weaknessid=""");
#nullable restore
#line 22 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
                                                                                             Write(weakness.WEAKNESS_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sil</button>\r\n                    <button type=\"button\" class=\"btn btn-lg btn-warning\" data-toggle=\"modal\" data-target=\"#editWeaknessModal-");
#nullable restore
#line 23 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
                                                                                                                        Write(weakness.WEAKNESS_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Düzenle\r\n                    </button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <!-- Modal -->\r\n        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1268, "\"", 1312, 2);
            WriteAttributeValue("", 1273, "editWeaknessModal-", 1273, 18, true);
#nullable restore
#line 31 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
WriteAttributeValue("", 1291, weakness.WEAKNESS_ID, 1291, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"">Pokemon Zayıflığını Düzenle</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control weakness-name-input""");
            BeginWriteAttribute("value", " value=\"", 2047, "\"", 2078, 1);
#nullable restore
#line 42 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
WriteAttributeValue("", 2055, weakness.WEAKNESS_NAME, 2055, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required />
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                        <button type=""button"" class=""btn btn-primary weakness-edit-submit"" data-weaknessid=""");
#nullable restore
#line 47 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"
                                                                                                       Write(weakness.WEAKNESS_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Kaydet</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 52 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Admin\Components\Weakness\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebProje.Models.Weakness>> Html { get; private set; }
    }
}
#pragma warning restore 1591
