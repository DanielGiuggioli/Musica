#pragma checksum "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b21d8585d9c068e4f589291b6d4a6e8ebdce4e82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Musica.Pages.Pages_Songs), @"mvc.1.0.razor-page", @"/Pages/Songs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b21d8585d9c068e4f589291b6d4a6e8ebdce4e82", @"/Pages/Songs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dea8dd4e53b237de4d1479dadf1f32b2bf4bd50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Songs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search a song"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
  
    ViewData["Title"] = "Search song";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b21d8585d9c068e4f589291b6d4a6e8ebdce4e824575", async() => {
                WriteLiteral("\r\n    <div class=\"container mt-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-7\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b21d8585d9c068e4f589291b6d4a6e8ebdce4e824955", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 10 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchedSong);

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
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                <input type=\"submit\" class=\"btn btn-primary mb-3\" value=\"Search\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
     if (Model.Songs != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
         foreach (var s in Model.Songs)
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
                BeginWriteAttribute("src", " src=\"", 856, "\"", 881, 1);
#nullable restore
#line 27 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
WriteAttributeValue("", 862, s.header_image_url, 862, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded float-left\"");
                BeginWriteAttribute("alt", " alt=\"", 909, "\"", 932, 2);
#nullable restore
#line 27 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
WriteAttributeValue("", 915, s.full_title, 915, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 928, "img", 929, 4, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"max-height:100px;max-width:100px\">\r\n                            </div>\r\n                            <div class=\"col mt-2\">\r\n                                <b><i>");
#nullable restore
#line 30 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
                                 Write(s.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></b>\r\n                                <br />\r\n                                <i>");
#nullable restore
#line 32 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
                              Write(s.artist_names);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</i>
                            </div>
                            <div class=""col text-right mt-2 mr-3"">
                                <span class=""float-right"">
                                    <a class=""text-dark"" href=""javascript: setFavourite()"">
                                        <i class=""bi bi-star"" style=""font-size: 2rem; ""></i>
                                    </a>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 45 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\giugg\source\repos\Musica\Musica\Musica\Pages\Songs.cshtml"
         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musica.SongsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.SongsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Musica.SongsModel>)PageContext?.ViewData;
        public Musica.SongsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
