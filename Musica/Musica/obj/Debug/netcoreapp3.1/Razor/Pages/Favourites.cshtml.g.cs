#pragma checksum "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ecf333e56d450f1b70538450d193eec9f9196c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Musica.Pages.Pages_Favourites), @"mvc.1.0.razor-page", @"/Pages/Favourites.cshtml")]
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
#line 1 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\_ViewImports.cshtml"
using Musica;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ecf333e56d450f1b70538450d193eec9f9196c", @"/Pages/Favourites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dea8dd4e53b237de4d1479dadf1f32b2bf4bd50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Favourites : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Users/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-black-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Users/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
  
    ViewData["Title"] = "Favourites";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function showArtists() {
        var artists = document.getElementById(""showArtists"");
        var songs = document.getElementById(""showSongs"");

        var favA = document.getElementById(""favArtists"");
        var favS = document.getElementById(""favSongs"");

        favA.style.display = ""block"";
        favS.style.display = ""none"";

        artists.classList.add(""shadow"");
        songs.classList.remove(""shadow"");

    }

    function showSongs() {
        var artists = document.getElementById(""showArtists"");
        var songs = document.getElementById(""showSongs"");

        var favA = document.getElementById(""favArtists"");
        var favS = document.getElementById(""favSongs"");

        favA.style.display = ""none"";
        favS.style.display = ""block"";

        artists.classList.remove(""shadow"");
        songs.classList.add(""shadow"");
    }

    function setFavouriteArtist(pId, uId) {
        var el = document.getElementById('favourite');

        if (el.clas");
            WriteLiteral(@"sList.contains(""bi-star-fill"")) {

            fetch('/Favourites?handler=DeleteFavouriteArtist&userId=' + uId + '&artistId=' + pId)
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

    function setFavouriteSong(pId, uId) {
        var el = document.getElementById(pId + 'favourite');

        if (el.classList.contains(""bi-star-fill"")) {

            fetch('/Favourites?handler=DeleteFavouriteSong&userId=' + uId + '&songId=' + pId)
                .then(r => {

                    el.classList.add(""bi-star"");
                    el.classList.remove(""bi-star-fill"");

                });

 ");
            WriteLiteral(@"       } else {

            fetch('/Favourites?handler=SetFavouriteSong&userId=' + uId + '&songId=' + pId)
                .then(r => {

                    el.classList.add(""bi-star-fill"");
                    el.classList.remove(""bi-star"");

                });
        }

    }
</script>

");
#nullable restore
#line 89 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
 if (Model.User == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center mt-5\">\r\n        <p>You are not logged in! ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ecf333e56d450f1b70538450d193eec9f9196c6836", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" or ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ecf333e56d450f1b70538450d193eec9f9196c8074", async() => {
                WriteLiteral("Log in");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 94 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <b style=\"color:#ffffff;font-size:2.5em;\">");
#nullable restore
#line 98 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
                                             Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col m-3 p-2 rounded border shadow text-center"" id=""showArtists"">
                <a href=""javascript:showArtists()"" class=""nav-link"" style=""color:black"">Artists</a>
            </div>
            <div class=""col m-3 p-2 rounded border text-center"" id=""showSongs"">
                <a href=""javascript:showSongs()"" class=""nav-link"" style=""color:black"">Songs</a>
            </div>
        </div>
    </div>
    <div id=""favArtists"" style=""display:block;"" class=""m-3"">
");
#nullable restore
#line 111 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
         foreach (var a in Model.FavArtists)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container"">
                <div class=""row"">
                    <div class=""col rounded border shadow m-2"">
                        <div class=""row"">
                            <div class=""col-4 mt-2 mb-2"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 3699, "\"", 3717, 1);
#nullable restore
#line 118 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 3705, a.image_url, 3705, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded float-left\"");
            BeginWriteAttribute("alt", " alt=\"", 3745, "\"", 3762, 2);
#nullable restore
#line 118 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 3751, a.name, 3751, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3758, "img", 3759, 4, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:100px;max-width:100px\">\r\n                            </div>\r\n                            <div class=\"col mt-2\">\r\n                                <b><i>");
#nullable restore
#line 121 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
                                 Write(a.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></b>\r\n                            </div>\r\n                            <div class=\"col text-right mt-2 mr-3\">\r\n                                <span class=\"float-right\">\r\n                                    <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 4170, "\"", 4238, 6);
            WriteAttributeValue("", 4177, "javascript:setFavouriteArtist(\'", 4177, 31, true);
#nullable restore
#line 125 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 4208, a.id, 4208, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4213, "\',", 4213, 2, true);
            WriteAttributeValue(" ", 4215, "\'", 4216, 2, true);
#nullable restore
#line 125 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 4217, Model.GetUser().Id, 4217, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4236, "\')", 4236, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""bi bi-star-fill"" style=""font-size: 2rem; ""></i>
                                    </a>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 134 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div id=\"favSongs\" style=\"display:none;\">\r\n");
#nullable restore
#line 137 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
         foreach (var s in Model.FavSongs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container"">
                <div class=""row"">
                    <div class=""col rounded border shadow m-2"">
                        <div class=""row"">
                            <div class=""col-4 mt-2 mb-2"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 4964, "\"", 4989, 1);
#nullable restore
#line 144 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 4970, s.header_image_url, 4970, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded float-left\"");
            BeginWriteAttribute("alt", " alt=\"", 5017, "\"", 5040, 2);
#nullable restore
#line 144 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 5023, s.full_title, 5023, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5036, "img", 5037, 4, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:100px;max-width:100px\">\r\n                            </div>\r\n                            <div class=\"col mt-2\">\r\n                                <b><i>");
#nullable restore
#line 147 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
                                 Write(s.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></b>\r\n                                <br />\r\n                                <i>");
#nullable restore
#line 149 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
                              Write(s.artist_names);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                            </div>\r\n                            <div class=\"col text-right mt-2 mr-3\">\r\n                                <span class=\"float-right\">\r\n                                    <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 5545, "\"", 5612, 7);
            WriteAttributeValue("", 5552, "javascript:", 5552, 11, true);
            WriteAttributeValue(" ", 5563, "setFavouriteSong(\'", 5564, 19, true);
#nullable restore
#line 153 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 5582, s.id, 5582, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5587, "\',", 5587, 2, true);
            WriteAttributeValue(" ", 5589, "\'", 5590, 2, true);
#nullable restore
#line 153 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
WriteAttributeValue("", 5591, Model.GetUser().Id, 5591, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5610, "\')", 5610, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""bi bi-star-fill"" style=""font-size: 2rem; ""></i>
                                    </a>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 162 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 164 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Favourites.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musica.FavouritesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.FavouritesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.FavouritesModel>)PageContext?.ViewData;
        public Musica.FavouritesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
