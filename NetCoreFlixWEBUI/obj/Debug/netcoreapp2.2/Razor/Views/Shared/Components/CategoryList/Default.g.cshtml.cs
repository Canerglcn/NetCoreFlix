#pragma checksum "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0eee272a0831a2a6cfd61ec94e55a78cdd4cba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0eee272a0831a2a6cfd61ec94e55a78cdd4cba8", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32427bc2d537372dc03e269d6608ba219017b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCoreFlixWEBUI.Models.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 28, true);
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
            EndContext();
#line 4 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories)
    {
        var css = "list-group-item";
        if (category.CategoryId==Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
            BeginContext(286, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 296, "\"", 344, 2);
            WriteAttributeValue("", 303, "/home/index?category=", 303, 21, true);
#line 11 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 324, category.CategoryId, 324, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 345, "\"", 357, 1);
#line 11 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 353, css, 353, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(358, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(360, 13, false);
#line 11 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                    Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(373, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 12 "C:\Users\skype\Desktop\Software-Projects\NetCoreFlix\NetCoreFlixWEBUI\NetCoreFlixWEBUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(386, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreFlixWEBUI.Models.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
