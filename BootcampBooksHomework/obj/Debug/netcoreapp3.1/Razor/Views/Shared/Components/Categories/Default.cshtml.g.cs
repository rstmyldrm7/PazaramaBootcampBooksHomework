#pragma checksum "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\Shared\Components\Categories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d88cf7f8907ffd23a9e70eb89da80484656d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.cshtml")]
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
#line 1 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\_ViewImports.cshtml"
using BootcampBooksHomework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\_ViewImports.cshtml"
using BootcampBooksHomework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\_ViewImports.cshtml"
using BootcampBooksHomeworkDTO.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d88cf7f8907ffd23a9e70eb89da80484656d81", @"/Views/Shared/Components/Categories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9aa3ed98d70464ccf22bf8ace32f12c3f4f55dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"list-group\">\r\n    <a href=\"/Book/List\"");
            BeginWriteAttribute("class", " class=\"", 74, "\"", 163, 3);
            WriteAttributeValue("", 82, "list-group-item", 82, 15, true);
            WriteAttributeValue(" ", 97, "list-group-item-action", 98, 23, true);
#nullable restore
#line 3 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue(" ", 120, ViewBag.SelectedGenre==null?"active":"", 121, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tüm Kategoriler</a>\r\n");
#nullable restore
#line 4 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\Shared\Components\Categories\Default.cshtml"
     foreach(var category in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 294, 2);
            WriteAttributeValue("", 263, "/Book/List/", 263, 11, true);
#nullable restore
#line 6 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue("", 274, category.CategoryId, 274, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 295, "\"", 410, 3);
            WriteAttributeValue("", 303, "list-group-item", 303, 15, true);
            WriteAttributeValue(" ", 318, "list-group-item-action", 319, 23, true);
#nullable restore
#line 6 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue(" ", 341, ViewBag.SelectedGenre==category.CategoryId.ToString()?"active":"", 342, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 7 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\Shared\Components\Categories\Default.cshtml"
               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n");
#nullable restore
#line 9 "C:\Users\rustem.yildirim\source\repos\BootcampBooksHomework\BootcampBooksHomework\Views\Shared\Components\Categories\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
