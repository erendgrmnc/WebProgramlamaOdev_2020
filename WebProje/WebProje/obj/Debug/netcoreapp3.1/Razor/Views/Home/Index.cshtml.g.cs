#pragma checksum "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5eb77720683890fa57cca843b81bcfb9951e00b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5eb77720683890fa57cca843b81bcfb9951e00b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebProje.Models.Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 10 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
Write(localizer["Index"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"pokemons-container row d-flex\">\r\n");
#nullable restore
#line 13 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
     foreach (var pokemon in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 col-sm-6\">\r\n            <div class=\"card pokemon-card\" data-pokemonid=\"");
#nullable restore
#line 25 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
                                                      Write(pokemon.POKEMON_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <h3 class=\"card-header\">");
#nullable restore
#line 26 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
                                   Write(pokemon.POKEMON_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1169, "\"", 1199, 1);
#nullable restore
#line 28 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
WriteAttributeValue("", 1175, pokemon.POKEMON_IMG_URL, 1175, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block user-select-none"" width=""100%"" height=""200"" aria-label=""Placeholder: Image cap"" focusable=""false"" role=""img"" preserveAspectRatio=""xMidYMid slice"" viewBox=""0 0 318 180"" style=""font-size:1.125rem;text-anchor:middle"">
                <rect width=""100%"" height=""100%"" fill=""#868e96""></rect>
                <text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em""></text>

                <div class=""card-footer text-muted"">
                    ");
#nullable restore
#line 33 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
               Write(pokemon.POKEMON_PRICE);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
                                      Write(localizer["$"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 45 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
                    
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script>
    $(document).ready(function () {

        goToPokemonPage();
    })

    function goToPokemonPage() {
        $('.pokemon-card').click(function () {
            let pokemonid = $(this).attr('data-pokemonid');

            window.location.href = '");
#nullable restore
#line 58 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\Home\Index.cshtml"
                               Write(Url.Action("Index","Pokemon"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?id=\' + pokemonid;\r\n\r\n\r\n        });\r\n    }\r\n\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebProje.Models.Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
