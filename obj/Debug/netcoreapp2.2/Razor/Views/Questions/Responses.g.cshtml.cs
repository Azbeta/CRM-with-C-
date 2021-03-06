#pragma checksum "D:\Projects\CRM\Views\Questions\Responses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43f593314a99c48e368134b7fb251238cb14e40e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Responses), @"mvc.1.0.view", @"/Views/Questions/Responses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Responses.cshtml", typeof(AspNetCore.Views_Questions_Responses))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43f593314a99c48e368134b7fb251238cb14e40e", @"/Views/Questions/Responses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03934a8a7d47f2a43fed5950159610447dac5492", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Responses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.EntityModels.Response>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddResponseAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
  
    ViewData["Title"] = "Responses";

#line default
#line hidden
            BeginContext(97, 146, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    ");
            EndContext();
            BeginContext(243, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43f593314a99c48e368134b7fb251238cb14e40e3843", async() => {
                BeginContext(276, 186, true);
                WriteLiteral(" <button type=\"button\" class=\"btn btn-primary waves-effect waves-light float-right mb-3\" data-toggle=\"modal\" data-animation=\"bounce\" data-target=\".bs-example-modal-lg\">+ Add New</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(466, 407, true);
            WriteLiteral(@"
                    <h4 class=""header-title mt-0 mb-3"">All Customers</h4>
                    <div class=""table-responsive dash-social"">
                        <table id=""datatable"" class=""table"">
                            <thead class=""thead-light"">
                         
                                <tr>
                                    <th>
                                        ");
            EndContext();
            BeginContext(874, 47, false);
#line 18 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(921, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(1049, 54, false);
#line 21 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                   Write(Html.DisplayNameFor(model => model.IsMetadataRequired));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(1231, 54, false);
#line 24 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                   Write(Html.DisplayNameFor(model => model.IsFillableByClient));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 208, true);
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 31 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(1590, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1723, 46, false);
#line 35 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1909, 40, false);
#line 38 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IsEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2089, 53, false);
#line 41 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IsFillableByClient));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 134, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        \r\n                                    </tr>\r\n");
            EndContext();
#line 45 "D:\Projects\CRM\Views\Questions\Responses.cshtml"
                                }

#line default
#line hidden
            BeginContext(2311, 136, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        </div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.EntityModels.Response>> Html { get; private set; }
    }
}
#pragma warning restore 1591
