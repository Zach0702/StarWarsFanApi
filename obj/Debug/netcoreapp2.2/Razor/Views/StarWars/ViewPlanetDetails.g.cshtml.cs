#pragma checksum "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b09e8c8320b1f97d3f9e759cae15ac40ed6e624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_ViewPlanetDetails), @"mvc.1.0.view", @"/Views/StarWars/ViewPlanetDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StarWars/ViewPlanetDetails.cshtml", typeof(AspNetCore.Views_StarWars_ViewPlanetDetails))]
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
#line 1 "C:\Users\olivi\source\repos\StarWarsFan\Views\_ViewImports.cshtml"
using StarWarsFan;

#line default
#line hidden
#line 2 "C:\Users\olivi\source\repos\StarWarsFan\Views\_ViewImports.cshtml"
using StarWarsFan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b09e8c8320b1f97d3f9e759cae15ac40ed6e624", @"/Views/StarWars/ViewPlanetDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0c799ed099698ff766eff6a61081cdac132b08", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_ViewPlanetDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarWarsFan.Models.PlanetDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StarWars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAllPlanets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
  
    ViewData["Title"] = "ViewPlanetDetails";

#line default
#line hidden
            BeginContext(105, 131, true);
            WriteLiteral("\r\n<h1>Selected Planet Details!</h1>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(237, 40, false);
#line 14 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(277, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(341, 36, false);
#line 17 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(377, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 51, false);
#line 20 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.rotation_period));

#line default
#line hidden
            EndContext();
            BeginContext(491, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(555, 47, false);
#line 23 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.rotation_period));

#line default
#line hidden
            EndContext();
            BeginContext(602, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(665, 50, false);
#line 26 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.orbital_period));

#line default
#line hidden
            EndContext();
            BeginContext(715, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(779, 46, false);
#line 29 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.orbital_period));

#line default
#line hidden
            EndContext();
            BeginContext(825, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(888, 44, false);
#line 32 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.diameter));

#line default
#line hidden
            EndContext();
            BeginContext(932, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(996, 40, false);
#line 35 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.diameter));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1099, 43, false);
#line 38 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.climate));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1206, 39, false);
#line 41 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.climate));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1308, 43, false);
#line 44 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.gravity));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1415, 39, false);
#line 47 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.gravity));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1517, 43, false);
#line 50 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.terrain));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1624, 39, false);
#line 53 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.terrain));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1726, 49, false);
#line 56 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.surface_water));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1839, 45, false);
#line 59 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.surface_water));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1947, 46, false);
#line 62 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.population));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2057, 42, false);
#line 65 "C:\Users\olivi\source\repos\StarWarsFan\Views\StarWars\ViewPlanetDetails.cshtml"
       Write(Html.DisplayFor(model => model.population));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 58, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <\r\n        ");
            EndContext();
            BeginContext(2157, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b09e8c8320b1f97d3f9e759cae15ac40ed6e62412618", async() => {
                BeginContext(2253, 18, true);
                WriteLiteral("Add Another Planet");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2275, 17, true);
            WriteLiteral("\r\n    <\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarWarsFan.Models.PlanetDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
