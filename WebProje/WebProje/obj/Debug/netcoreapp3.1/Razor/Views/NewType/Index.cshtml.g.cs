#pragma checksum "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\NewType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8547a74f6b1e87edea2788ff6b0bcb935689b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewType_Index), @"mvc.1.0.view", @"/Views/NewType/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8547a74f6b1e87edea2788ff6b0bcb935689b2", @"/Views/NewType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_NewType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\NewType\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yeni Pokemon Tipi</h1>
<div class=""form-group"">
    <input id=""pokemon-type-name-input"" class=""form-control"" type=""text"" required placeholder=""Pokemon Tipi İsmini Giriniz"" />
    <button id=""pokemon-type-submit"" class=""form-control btn btn-lg btn-primary my-3"">Oluştur</button>
</div>


<script>
    $(document).ready(function () {
        newType();
    });

    function newType() {
        $('#pokemon-type-submit').on('click', function () {
            let type = {};
            type.TYPE_NAME = $('#pokemon-type-name-input').val();


            $.ajax({
            url: '");
#nullable restore
#line 26 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\NewType\Index.cshtml"
             Write(Url.Action("NewType","NewType"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""POST"",
            data: { type: type},
            success: function (data) {
                if (data == ""başarılı"") {
                    swal({
                        title: ""Başarılı !"",
                        text: ""Pokemon Tipi Başarıyla Oluşturuldu!"",
                        icon: ""success"",
                        button: ""Tamam"",
                    }).then(function () {
                        window.location.href = '");
#nullable restore
#line 37 "C:\Users\Eren Değirmenci\Source\Repos\erendgrmnc\WebOdev\WebProje\WebProje\Views\NewType\Index.cshtml"
                                           Write(Url.Action("Index","NewType"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n                    });\r\n                }\r\n                else\r\n                    alert(\"Onaylama Başarısız!\");\r\n            }\r\n            });\r\n\r\n        })\r\n\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
