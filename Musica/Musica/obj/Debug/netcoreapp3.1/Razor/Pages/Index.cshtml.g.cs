#pragma checksum "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "820c3457a4fbc02f163ed5047308997dd7ba09d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Musica.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"820c3457a4fbc02f163ed5047308997dd7ba09d3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dea8dd4e53b237de4d1479dadf1f32b2bf4bd50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Index.cshtml"
 if (Model.User == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""height: 90vh"" class=""bg3"">
        <div class=""container pt-5"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""row"">
                        <div class=""col pt-5"">
                            <b style=""color:#ffffff;font-size:2.5em;"">Register</b>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col pt-3"">
                            <h5 style=""color:#ffffff;"">Become a new user</h5>
                        </div>
                    </div>
                    <div class=""row pt-5"">
                        <div class=""col p-5 text-right"">
                            <a class=""btn pr-5 pl-5 btn-dark btn-lg badge-pill shadow btn1"" href=""/Users/Register"">REGISTER</a>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
");
#nullable restore
#line 33 "C:\Users\giuggioli.17210\Documents\GitHub\Musica\Musica\Musica\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""background-image: linear-gradient(324deg,#f3245d -5%,#feb71d 100%); height: 90vh"">
    <div class=""container pt-5"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""row"">
                    <div class=""col pt-5"">
                        <b style=""color:#ffffff;font-size:2.5em;"">Search your favourite Artists</b>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col pt-3"">
                        <h5 style=""color:#ffffff;"">Find data, informations and songs about your favourite artists</h5>
                    </div>
                </div>
                <div class=""row pt-5"">
                    <div class=""col p-5 text-right"">
                        <a class=""btn pr-5 pl-5 btn-dark btn-lg badge-pill shadow btn1"" href=""/Artists"">SEARCH NOW</a>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>

<div style="" height: 97v");
            WriteLiteral(@"h"" class=""bg2"">
    <div class=""container pt-5"">
        <div class=""row"">
            <div class=""col"" style=""text-decoration-color:#ffffff;"">
                <div class=""row"">
                    <div class=""col pt-2"">
                        <b style=""color:#ffffff;font-size:2.5em;"">Search Songs</b>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col pt-2"">
                        <h5 style=""color:#ffffff;"">Find lyrics about your favourites songs</h5>

                    </div>
                </div>
                <div class=""row pt-5"">
                    <div class=""col p-5 text-right"">
                        <a class=""btn pr-5 pl-5 btn-dark btn-lg badge-pill shadow btn1"" href=""/Songs"">SEARCH NOW</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
