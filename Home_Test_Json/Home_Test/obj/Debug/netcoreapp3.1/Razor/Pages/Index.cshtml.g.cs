#pragma checksum "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838ffc8fd35b5a13c6fa79196645d80774ca364c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Home_Test.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Home_Test.Pages
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
#line 1 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\_ViewImports.cshtml"
using Home_Test;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838ffc8fd35b5a13c6fa79196645d80774ca364c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73faf29b052093ad654ebaa76f9836887745c133", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to Magpie Analitics</h1>
    
</div>
<style>
    table, th, td {
        border: 1px solid black;
        border-collapse: collapse;
    }

    th, td {
        
        text-align: center;
    }
</style>
<div>
    <h2>
        <table align=""center"">
            <th>
                Date
            </th>
            <th>
                Trade Code
            </th>
            <th>
                High
            </th>
            <th>
                Low
            </th>
            <th>
                Open
            </th>
            <th>
                Close
            </th>
            <th>
                Action
            </th>

");
#nullable restore
#line 47 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
             foreach (var data1 in Model.data)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
                   Write(data1.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
                   Write(data1.trade_code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
                   Write(data1.high);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
                   Write(data1.low);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
                   Write(data1.open);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
                   Write(data1.close);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 73 "E:\Study\magpie home test\Home_Test\Home_Test\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n    </h2>\r\n</div>\r\n\r\n");
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
