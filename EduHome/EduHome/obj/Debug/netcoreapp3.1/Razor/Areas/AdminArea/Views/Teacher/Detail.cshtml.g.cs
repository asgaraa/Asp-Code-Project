#pragma checksum "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee38a0217daee05701003f97eab56e5c360d1e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Teacher_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Teacher/Detail.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome.Utilities.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome.Utilities.File;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee38a0217daee05701003f97eab56e5c360d1e8", @"/Areas/AdminArea/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97d923741b64ea5bedb218d05258511762872757", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm my-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Poster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 250px; height: 150px; border-radius: unset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Slider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
   ViewData["Title"] = "Detail";
    int count = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <h4>Poster</h4>
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""header d-flex justify-content-between my-5"">
                        <h1 class=""card-title my-3"">Posters</h1>
                        <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee38a0217daee05701003f97eab56e5c360d1e86924", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>




                    </div>
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <h6> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bee38a0217daee05701003f97eab56e5c360d1e88795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1046, "~/assets/img/teacher/", 1046, 21, true);
#nullable restore
#line 27 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 1067, Model.teacher.Image, 1067, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </h6>\r\n                                    <h6>");
#nullable restore
#line 28 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 29 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 30 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 31 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 32 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 33 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 34 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 35 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 36 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                   Write(Model.teacher.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                     foreach (var skill in Model.skills)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                               <h6>");
#nullable restore
#line 40 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                              Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <h6>");
#nullable restore
#line 41 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                               Write(Model.percents[count]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>");
#nullable restore
#line 41 "C:\Users\hp\Desktop\layihe\EduHome\EduHome\Areas\AdminArea\Views\Teacher\Detail.cshtml"
                                                                               count++;
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                                <tr>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee38a0217daee05701003f97eab56e5c360d1e814713", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </tr>\r\n                            </tbody>\r\n\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeacherDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
