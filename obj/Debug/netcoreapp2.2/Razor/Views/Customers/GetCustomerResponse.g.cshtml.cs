#pragma checksum "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331b0721bce71759c1779b66d88f847918e1fa71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_GetCustomerResponse), @"mvc.1.0.view", @"/Views/Customers/GetCustomerResponse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/GetCustomerResponse.cshtml", typeof(AspNetCore.Views_Customers_GetCustomerResponse))]
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
#line 1 "D:\Projects\CRM\Views\_ViewImports.cshtml"
using CRM;

#line default
#line hidden
#line 2 "D:\Projects\CRM\Views\_ViewImports.cshtml"
using CRM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"331b0721bce71759c1779b66d88f847918e1fa71", @"/Views/Customers/GetCustomerResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03934a8a7d47f2a43fed5950159610447dac5492", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_GetCustomerResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.EntityModels.CustomerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
  
    ViewData["Title"] = "GetCustomerResponse";

#line default
#line hidden
            BeginContext(116, 513, true);
            WriteLiteral(@"
<h1>Get Customer Response</h1>
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
            
                <h4 class=""header-title mt-0 mb-3"">Customers Response</h4>
                <div class=""table-responsive dash-social"">
                    <table id=""datatable"" class=""table"">
                        <thead class=""thead-light"">
                            <tr>
                                <th>
                                    ");
            EndContext();
            BeginContext(630, 41, false);
#line 19 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                               Write(Html.DisplayNameFor(model => model.Query));

#line default
#line hidden
            EndContext();
            BeginContext(671, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(787, 44, false);
#line 22 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                               Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(831, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(947, 41, false);
#line 25 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(988, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1104, 42, false);
#line 28 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                               Write(Html.DisplayNameFor(model => model.Answer));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 145, true);
            WriteLiteral("\r\n                                </th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 34 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1380, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1501, 40, false);
#line 38 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Query));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1669, 43, false);
#line 41 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1840, 40, false);
#line 44 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2008, 41, false);
#line 47 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Answer));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 86, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 51 "D:\Projects\CRM\Views\Customers\GetCustomerResponse.cshtml"
                            }

#line default
#line hidden
            BeginContext(2166, 116, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    </div>\r\n</div>\r\n</div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.EntityModels.CustomerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591