#pragma checksum "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2add212f021c432bb652a017cbd557c4cc2a0031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rate_FilmDetails), @"mvc.1.0.view", @"/Views/Rate/FilmDetails.cshtml")]
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
#line 1 "C:\Users\julek\source\repos\Movies\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\julek\source\repos\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2add212f021c432bb652a017cbd557c4cc2a0031", @"/Views/Rate/FilmDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_Rate_FilmDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies.Models.Film>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml"
   var averageRate = Model.rates.Count > 0 ? Model.rates.Average() : 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <h2>");
#nullable restore
#line 5 "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml"
   Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <p><b>Producer:</b> ");
#nullable restore
#line 6 "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml"
                   Write(Model.producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p><b>Director:</b> ");
#nullable restore
#line 7 "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml"
                   Write(Model.director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p><b>Release date:</b> ");
#nullable restore
#line 8 "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml"
                       Write(Model.releaseDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <span><b>Details:</b><BR />");
#nullable restore
#line 9 "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml"
                          Write(Model.openingCrawl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    <p><b>Average rate:</b> ");
#nullable restore
#line 10 "C:\Users\julek\source\repos\Movies\Movies\Views\Rate\FilmDetails.cshtml"
                       Write(averageRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
