#pragma checksum "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\Shared\Components\Service\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acbfb9001e132df818db74b1b4619265a5197812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Service_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Service/Default.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Accaunt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Utilities.Paginations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbfb9001e132df818db74b1b4619265a5197812", @"/Views/Shared/Components/Service/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad51d8e63beeafe0998922d32e6170e4727a34f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Service_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\Shared\Components\Service\Default.cshtml"
  
    ViewData["Title"] = "Default";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"service-area two pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\Shared\Components\Service\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-service\">\r\n                        <h3><a href=\"teacher.html\">");
#nullable restore
#line 13 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\Shared\Components\Service\Default.cshtml"
                                              Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                        <p>");
#nullable restore
#line 14 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\Shared\Components\Service\Default.cshtml"
                      Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\hp\Desktop\layihe\EduHome\Asp-Code-Project\EduHome\EduHome\Views\Shared\Components\Service\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
