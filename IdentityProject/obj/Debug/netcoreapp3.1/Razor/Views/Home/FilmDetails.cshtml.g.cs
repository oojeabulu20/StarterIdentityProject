#pragma checksum "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5800041b2721b19daeef8ade93eee5c2b584f1c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FilmDetails), @"mvc.1.0.view", @"/Views/Home/FilmDetails.cshtml")]
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
#line 1 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\_ViewImports.cshtml"
using IdentityProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\_ViewImports.cshtml"
using IdentityProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5800041b2721b19daeef8ade93eee5c2b584f1c7", @"/Views/Home/FilmDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83698f56d0929d2e02697daf39a4bbebb1a9ec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FilmDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityProject.Models.Film>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml"
  
    ViewData["Title"] = @Model.FilmTitle;
    ViewData["PageHeading"] = @Model.FilmTitle;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section>\r\n\r\n    <div class=\"mainImage\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5800041b2721b19daeef8ade93eee5c2b584f1c73616", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 201, "~/images/", 201, 9, true);
#nullable restore
#line 12 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml"
AddHtmlAttributeValue("", 210, Model.FilmImage, 210, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml"
AddHtmlAttributeValue("", 233, Model.FilmTitle, 233, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"filmInfo\">\r\n        <h2>");
#nullable restore
#line 16 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml"
       Write(Model.FilmTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>");
#nullable restore
#line 17 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml"
      Write(Model.FilmDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Certificate: ");
#nullable restore
#line 18 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml"
                   Write(Model.FilmCertificate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Streaming Price: &pound;");
#nullable restore
#line 19 "C:\Users\LabStudent-55-504266\source\repos\StarterIdentityProject\IdentityProject\Views\Home\FilmDetails.cshtml"
                               Write((Model.FilmPrice).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        \r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityProject.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
