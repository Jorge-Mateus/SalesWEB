#pragma checksum "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd222eda9a25131328a040b7aea03176ec47c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Details), @"mvc.1.0.view", @"/Views/Sellers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Details.cshtml", typeof(AspNetCore.Views_Sellers_Details))]
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
#line 1 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC;

#line default
#line hidden
#line 2 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC.Models;

#line default
#line hidden
#line 3 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd222eda9a25131328a040b7aea03176ec47c6f", @"/Views/Sellers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5150cd2d7d19d24d1348b46b916bd50b46ddf22", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalesWebMVC.Models.Seller>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 122, true);
            WriteLiteral("\r\n\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Seller</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 36, false);
#line 15 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(238, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(283, 40, false);
#line 18 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(323, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(368, 37, false);
#line 21 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(405, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(450, 41, false);
#line 24 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(491, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(536, 41, false);
#line 27 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(577, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(622, 45, false);
#line 30 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(667, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(712, 42, false);
#line 33 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(754, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(799, 46, false);
#line 36 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(845, 44, true);
            WriteLiteral(";\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(890, 42, false);
#line 39 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(932, 44, true);
            WriteLiteral(";\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(977, 51, false);
#line 42 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 48, true);
            WriteLiteral(";\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1076, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd222eda9a25131328a040b7aea03176ec47c6f9400", async() => {
                BeginContext(1146, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Jorge\Documents\GitHub\SalesWEB\SalesWebMvc\SalesWebMVC\Views\Sellers\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1154, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1160, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd222eda9a25131328a040b7aea03176ec47c6f11816", async() => {
                BeginContext(1207, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalesWebMVC.Models.Seller> Html { get; private set; }
    }
}
#pragma warning restore 1591
