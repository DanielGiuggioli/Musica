#pragma checksum "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90fb3710055193be8e3a82066a5ae3b9727ed506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Musica.Pages.Pages_ArtistDetail), @"mvc.1.0.razor-page", @"/Pages/ArtistDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90fb3710055193be8e3a82066a5ae3b9727ed506", @"/Pages/ArtistDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dea8dd4e53b237de4d1479dadf1f32b2bf4bd50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArtistDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
  
    ViewData["Title"] = "Artist detail";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
 if (Model.GetUser() != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
    function setFavouriteArtist(pId, uId) {
        var el = document.getElementById('favourite');

        if (el.classList.contains(""bi-star-fill"")) {

                fetch('/Favourites?handler=DeleteFavouriteArtist&userId=' + uId +'&artistId=' + pId)
                .then(r => {

                        el.classList.add(""bi-star"");
                        el.classList.remove(""bi-star-fill"");

                });

        } else {

            fetch('/Favourites?handler=SetFavouriteArtist&userId=' + uId + '&artistId=' + pId)
                .then(r => {

                        el.classList.add(""bi-star-fill"");
                        el.classList.remove(""bi-star"");

                });
    }

    }
    </script>
");
#nullable restore
#line 35 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <b style=\"color:#ffffff;font-size:2.5em;\">");
#nullable restore
#line 37 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n</div>\r\n<div style=\"padding-bottom: 15px;\">\r\n");
#nullable restore
#line 40 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
         if (Model.Artist != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row m-2"">
                <div class=""col-md rounded border shadow bg5 mt-3 mr-2"">
                    <div class=""row"">
                        <div class=""col pl-3"">
                            <b style=""color:#000000;font-size:2.4em;"">");
#nullable restore
#line 46 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                                                                 Write(Model.Artist.Artist.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </div>\r\n");
#nullable restore
#line 48 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                         if (Model.GetUser() == null || !Model.GetUser().IsVerified)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col\">\r\n                                <span class=\"float-right\">\r\n                                    <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1692, "\"", 1776, 6);
            WriteAttributeValue("", 1699, "javascript:setFavouriteArtist(", 1699, 30, true);
#nullable restore
#line 52 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 1729, Model.Artist.Artist.id, 1729, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1752, ",", 1752, 1, true);
            WriteAttributeValue(" ", 1753, "\'", 1754, 2, true);
#nullable restore
#line 52 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 1755, Model.GetUser().Id, 1755, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1774, "\')", 1774, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i id=\"favourite\" class=\"bi bi-star-fill\" style=\"font-size: 2.3em;\"></i>\r\n                                    </a>\r\n                                </span>\r\n                            </div>\r\n");
#nullable restore
#line 57 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col text-center mt-3\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2199, "\"", 2235, 1);
#nullable restore
#line 61 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 2205, Model.Artist.Artist.image_url, 2205, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid float-start\"");
            BeginWriteAttribute("alt", " alt=\"", 2266, "\"", 2301, 2);
#nullable restore
#line 61 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 2272, Model.Artist.Artist.name, 2272, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2297, "img", 2298, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""max-height:350px;max-width:350px"">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col text-center"">
                            <div class=""m-3"">
                                <b>");
#nullable restore
#line 68 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                              Write(Model.Artist.Artist.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"justify-content-end\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2760, "\"", 2791, 1);
#nullable restore
#line 71 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 2767, Model.Artist.Artist.url, 2767, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 71 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                                                                              Write(Model.Artist.Artist.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" on  genius</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md rounded border shadow bg5 ml-2 mt-3"">
                    <div class=""text-center p-1"">
                        <b style=""color:#000000;font-size:2.1em;"">Famous tracks</b>
                    </div>
                    <hr />
");
#nullable restore
#line 81 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                     foreach (var song in Model.Artist.Songs)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-3 mb-1\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3458, "\"", 3486, 1);
#nullable restore
#line 86 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 3464, song.header_image_url, 3464, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3513, "\"", 3534, 2);
#nullable restore
#line 86 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 3519, song.title, 3519, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3530, "img", 3531, 4, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:70px;max-width:70px\">\r\n                            </div>\r\n                            <div class=\"col\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3694, "\"", 3724, 2);
            WriteAttributeValue("", 3701, "/SongDetail?id=", 3701, 15, true);
#nullable restore
#line 89 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
WriteAttributeValue("", 3716, song.id, 3716, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black\"><b><i>");
#nullable restore
#line 89 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                                                                                       Write(song.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></b></a>\r\n                                <br />\r\n                                <i>");
#nullable restore
#line 91 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                              Write(song.artist_names);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 95 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 98 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\ArtistDetail.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musica.Pages.ArtistDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.Pages.ArtistDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.Pages.ArtistDetailModel>)PageContext?.ViewData;
        public Musica.Pages.ArtistDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
