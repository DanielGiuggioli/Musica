#pragma checksum "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a18e0f7adff408a9c5a14bf16ed48a76d7c2b63a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Musica.Pages.Pages_Artists), @"mvc.1.0.razor-page", @"/Pages/Artists.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a18e0f7adff408a9c5a14bf16ed48a76d7c2b63a", @"/Pages/Artists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dea8dd4e53b237de4d1479dadf1f32b2bf4bd50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Artists : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search an artist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
  
    ViewData["Title"] = "Search artist";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
 if (Model.GetUser() != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
    function setFavouriteArtist(pId, uId) {
        var el = document.getElementById('favourite');

        if (el.classList.contains(""bi-star-fill"")) {

                fetch('/publish/Favourites?handler=DeleteFavouriteArtist&userId=' + uId +'&artistId=' + pId)
                .then(r => {

                        el.classList.add(""bi-star"");
                        el.classList.remove(""bi-star-fill"");

                });

        } else {

            fetch('/publish/Favourites?handler=SetFavouriteArtist&userId=' + uId + '&artistId=' + pId)
                .then(r => {

                        el.classList.add(""bi-star-fill"");
                        el.classList.remove(""bi-star"");

                });
    }

    }
    </script>
");
#nullable restore
#line 35 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <b style=\"color:#ffffff;font-size:2.5em;\">");
#nullable restore
#line 37 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n</div>\r\n<div style=\"padding-bottom: 15px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a18e0f7adff408a9c5a14bf16ed48a76d7c2b63a6261", async() => {
                WriteLiteral("\r\n        <div class=\"container mt-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-7\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a18e0f7adff408a9c5a14bf16ed48a76d7c2b63a6657", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 44 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchedArtist);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col\">\r\n                    <input type=\"submit\" class=\"btn btn-dark mb-3\" value=\"Search\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
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
#line 58 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                                                                 Write(Model.Artist.Artist.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                        </div>\r\n");
#nullable restore
#line 60 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                         if (Model.GetUser() != null && Model.GetUser().IsVerified)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col\">\r\n                                <span class=\"float-right\">\r\n                                    <a class=\"text-dark\"");
                BeginWriteAttribute("href", " href=\"", 2153, "\"", 2237, 6);
                WriteAttributeValue("", 2160, "javascript:setFavouriteArtist(", 2160, 30, true);
#nullable restore
#line 64 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 2190, Model.Artist.Artist.id, 2190, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2213, ",", 2213, 1, true);
                WriteAttributeValue(" ", 2214, "\'", 2215, 2, true);
#nullable restore
#line 64 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 2216, Model.GetUser().Id, 2216, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2235, "\')", 2235, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <i id=\"favourite\" class=\"bi bi-star\" style=\"font-size: 2.3em;\"></i>\r\n                                    </a>\r\n                                </span>\r\n                            </div>\r\n");
#nullable restore
#line 69 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col text-center mt-3\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 2655, "\"", 2691, 1);
#nullable restore
#line 73 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 2661, Model.Artist.Artist.image_url, 2661, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid float-start\"");
                BeginWriteAttribute("alt", " alt=\"", 2722, "\"", 2757, 2);
#nullable restore
#line 73 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 2728, Model.Artist.Artist.name, 2728, 25, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2753, "img", 2754, 4, true);
                EndWriteAttribute();
                WriteLiteral(@" style=""max-height:350px;max-width:350px"">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col text-center"">
                            <div class=""m-3"">
                                <b>");
#nullable restore
#line 80 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                              Write(Model.Artist.Artist.GetDescription());

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                            </div>\r\n                            <div class=\"justify-content-end\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3216, "\"", 3247, 1);
#nullable restore
#line 83 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 3223, Model.Artist.Artist.url, 3223, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 83 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
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
#line 93 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                     foreach (var song in Model.Artist.Songs)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-3 mb-1\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 3914, "\"", 3942, 1);
#nullable restore
#line 98 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 3920, song.header_image_url, 3920, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 3969, "\"", 3990, 2);
#nullable restore
#line 98 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 3975, song.title, 3975, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3986, "img", 3987, 4, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"max-height:70px;max-width:70px\">\r\n                            </div>\r\n                            <div class=\"col\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 4150, "\"", 4188, 2);
                WriteAttributeValue("", 4157, "/publish/SongDetail?id=", 4157, 23, true);
#nullable restore
#line 101 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 4180, song.id, 4180, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color:black\"><b><i>");
#nullable restore
#line 101 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                                                                                               Write(song.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></b></a>\r\n                                <br />\r\n                                <i>");
#nullable restore
#line 103 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                              Write(song.artist_names);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 107 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 110 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Artists.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musica.ArtistsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.ArtistsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.ArtistsModel>)PageContext?.ViewData;
        public Musica.ArtistsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
