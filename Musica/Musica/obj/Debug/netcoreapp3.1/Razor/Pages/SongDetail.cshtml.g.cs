#pragma checksum "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\SongDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1bcb2b85da445eadf176b60f0ef25794255b6f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Musica.Pages.Pages_SongDetail), @"mvc.1.0.razor-page", @"/Pages/SongDetail.cshtml")]
namespace Musica.Pages
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
#line 1 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\_ViewImports.cshtml"
using Musica;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1bcb2b85da445eadf176b60f0ef25794255b6f7", @"/Pages/SongDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dea8dd4e53b237de4d1479dadf1f32b2bf4bd50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SongDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\SongDetail.cshtml"
  
    ViewData["Title"] = "Song detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <b style=\"color:#ffffff;font-size:2.5em;\">");
#nullable restore
#line 7 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\SongDetail.cshtml"
                                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n</div>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <b style=\"color:#000000;font-size:2.4em;\">");
#nullable restore
#line 12 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\SongDetail.cshtml"
                                                 Write(Model.Song.full_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            <br />\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 387, "\"", 409, 1);
#nullable restore
#line 14 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\SongDetail.cshtml"
WriteAttributeValue("", 394, Model.Song.url, 394, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 14 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\SongDetail.cshtml"
                                                 Write(Model.Song.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" on Genius</a>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
#nullable restore
#line 19 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\SongDetail.cshtml"
       Write(Html.Raw(Model.Song.Lyrics));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musica.Pages.SongDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.Pages.SongDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.Pages.SongDetailModel>)PageContext?.ViewData;
        public Musica.Pages.SongDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591