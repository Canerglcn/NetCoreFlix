#pragma checksum "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc737badda976412f47ea985dd4c815a7e8ae94e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__AdminLayout), @"mvc.1.0.view", @"/Views/_AdminLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_AdminLayout.cshtml", typeof(AspNetCore.Views__AdminLayout))]
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
#line 1 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc737badda976412f47ea985dd4c815a7e8ae94e", @"/Views/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32427bc2d537372dc03e269d6608ba219017b74", @"/Views/_ViewImports.cshtml")]
    public class Views__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FavoriteMovies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(61, 526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc737badda976412f47ea985dd4c815a7e8ae94e4384", async() => {
                BeginContext(67, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(140, 13, false);
#line 7 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(153, 427, true);
                WriteLiteral(@"</title>
    <link href=""/node_modules/bootstrap/dist/css/bootstrap.css"" rel=""stylesheet"" />
    <script src=""/node_modules/jquery/dist/jquery.min.js""></script>
    <script src=""/node_modules/bootstrap/dist/js/bootstrap.js""></script>
    <script src=""/node_modules/jquery-validation/dist/jquery.validate.js""></script>
    <script src=""/node_modules/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(587, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(589, 1876, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc737badda976412f47ea985dd4c815a7e8ae94e6457", async() => {
                BeginContext(595, 808, true);
                WriteLiteral(@"
    <div class=""col-md-12"">
        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <a class=""navbar-brand"" href=""/"">NetCoreFlix</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/"">Home <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item"">
                        ");
                EndContext();
                BeginContext(1403, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc737badda976412f47ea985dd4c815a7e8ae94e7686", async() => {
                    BeginContext(1473, 12, true);
                    WriteLiteral("FavoriteList");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1489, 323, true);
                WriteLiteral(@"
                    </li>
                    <li class=""nav-item dropdown"" style=""margin-left:1300px;"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                           Welcome ");
                EndContext();
                BeginContext(1813, 18, false);
#line 31 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
                              Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1831, 151, true);
                WriteLiteral("\r\n                        </a>\r\n                        <div class=\"dropdown-menu\" aria-labelledby=\"navbarDropdownMenuLink\">\r\n                         ");
                EndContext();
                BeginContext(1983, 42, false);
#line 34 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
                    Write(await Component.InvokeAsync("UserSummary"));

#line default
#line hidden
                EndContext();
                BeginContext(2025, 215, true);
                WriteLiteral("\r\n                            \r\n                        </div>\r\n                    </li>\r\n                  \r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n\r\n    </div>\r\n    <div class=\"mainbox\">\r\n");
                EndContext();
#line 47 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
         if (TempData["message"] != null)
        {

#line default
#line hidden
                BeginContext(2294, 55, true);
                WriteLiteral("            <div class=\"alert alert-info\" role=\"alert\">");
                EndContext();
                BeginContext(2350, 19, false);
#line 49 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
                                                  Write(TempData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(2369, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 50 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
        }

#line default
#line hidden
                BeginContext(2388, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2397, 12, false);
#line 51 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\_AdminLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2409, 49, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-12\"></div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2465, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
