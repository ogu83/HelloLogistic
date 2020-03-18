#pragma checksum "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2838534a83e95160d69798395f15d7a190cddaef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CalculatePartDetails), @"mvc.1.0.view", @"/Views/Home/CalculatePartDetails.cshtml")]
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
#line 1 "/home/oguz/projects/helloLogistic/Views/_ViewImports.cshtml"
using helloLogistic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/oguz/projects/helloLogistic/Views/_ViewImports.cshtml"
using helloLogistic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2838534a83e95160d69798395f15d7a190cddaef", @"/Views/Home/CalculatePartDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ea139a5ade125c7663543183cca9506b83d1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CalculatePartDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
  
    ViewData["Title"] = "Calculate Part Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 6 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Box Id</td>
                <th scope=""col"">Part Number</td>
                <th scope=""col"">Part Weight</td>
                <th scope=""col"">Part Cost</td>
            </tr>            
        </thead>
        <tbody>
");
#nullable restore
#line 19 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
         foreach (var part in Model.Parts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>                \n                <td>");
#nullable restore
#line 22 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
               Write(part.BoxId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
               Write(part.PartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
               Write(part.PartWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
               Write(part.PartCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 27 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n        <tfoot>\n            <tr>\n                <th scope=\"col\" colspan=\"3\">Total:</td>                \n                <th scope=\"col\">");
#nullable restore
#line 32 "/home/oguz/projects/helloLogistic/Views/Home/CalculatePartDetails.cshtml"
                           Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>            \n        </tfoot>\n    </table>    \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591