#pragma checksum "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c423c7530c54d71adf6fe4d7095ff5e18a8c5d35"
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
#line 1 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\_ViewImports.cshtml"
using Musica;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c423c7530c54d71adf6fe4d7095ff5e18a8c5d35", @"/Pages/Artists.cshtml")]
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
#line 3 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
  
    ViewData["Title"] = "Search artist";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c423c7530c54d71adf6fe4d7095ff5e18a8c5d354592", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-7\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c423c7530c54d71adf6fe4d7095ff5e18a8c5d354922", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 9 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
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
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col\">\r\n            <input type=\"submit\" class=\"btn btn-primary mb-3\" value=\"Search\">\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
     if (Model.Artist != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"rounded border shadow mt-2\">\r\n            <h2 class=\"text-center\">");
#nullable restore
#line 18 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
                               Write(Model.Artist.Artist.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <div class=\"row\">\r\n                <div class=\"col ml-3 mb-3\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 677, "\"", 713, 1);
#nullable restore
#line 21 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 683, Model.Artist.Artist.image_url, 683, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded float-start\"");
                BeginWriteAttribute("alt", " alt=\"", 742, "\"", 777, 2);
#nullable restore
#line 21 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 748, Model.Artist.Artist.name, 748, 25, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 773, "img", 774, 4, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"max-height:42vh;max-width:42vh\">\r\n                </div>\r\n                <div class=\"col\">\r\n                    <p>                 description</p>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 958, "\"", 989, 1);
#nullable restore
#line 25 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 965, Model.Artist.Artist.url, 965, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" target=""_blank"">Lyrics by genius</a>
                </div>
            </div>

        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm rounded border shadow mt-3 mr-1"">
                    <h4>Famous Tracks</h4>
");
#nullable restore
#line 34 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
                     foreach (var song in Model.Artist.Songs)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <hr />\r\n                        <div class=\"row\">\r\n                            <div class=\"col-3 mb-1\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1520, "\"", 1558, 1);
#nullable restore
#line 39 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 1526, song.header_image_thumbnail_url, 1526, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\"");
                BeginWriteAttribute("alt", " alt=\"", 1575, "\"", 1596, 2);
#nullable restore
#line 39 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
WriteAttributeValue("", 1581, song.title, 1581, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1592, "img", 1593, 4, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"max-height:70px;max-width:70px\">\r\n                            </div>\r\n                            <div class=\"col\">\r\n                                <b><i>");
#nullable restore
#line 42 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
                                 Write(song.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></b>\r\n                                <br />\r\n                                <i>");
#nullable restore
#line 44 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
                              Write(song.artist_names);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 47 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"col rounded border shadow mt-3 ml-1\">\r\n                    <h4>Discography</h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 54 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Artists.cshtml"
    }

#line default
#line hidden
#nullable disable
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