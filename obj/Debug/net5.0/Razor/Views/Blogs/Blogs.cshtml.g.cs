#pragma checksum "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\Blogs\Blogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa336bf81aaba6fdaefb3f8f0e921acbfae5134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Blogs), @"mvc.1.0.view", @"/Views/Blogs/Blogs.cshtml")]
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
#line 1 "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\_ViewImports.cshtml"
using VivesBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\_ViewImports.cshtml"
using VivesBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa336bf81aaba6fdaefb3f8f0e921acbfae5134", @"/Views/Blogs/Blogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283c94428cd1b85644eeef6f7ed959bf50b67970", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Blogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VivesBlog.Models.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\Blogs\Blogs.cshtml"
  
    ViewBag.Title = "Blogs";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table\">\r\n    <tr>\r\n        <th>Titel</th>\r\n        <th>Inhoud</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\Blogs\Blogs.cshtml"
     foreach (var blog in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\Blogs\Blogs.cshtml"
           Write(blog.Titel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\Blogs\Blogs.cshtml"
           Write(blog.Inhoud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "D:\Vives\Projecten Rider - WebDev\VivesBlog\Views\Blogs\Blogs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VivesBlog.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591