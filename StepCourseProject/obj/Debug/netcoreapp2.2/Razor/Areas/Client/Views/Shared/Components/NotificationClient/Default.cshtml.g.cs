#pragma checksum "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756fac806ea8ed1ec2440e515f423bd3fa6dd450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Shared_Components_NotificationClient_Default), @"mvc.1.0.view", @"/Areas/Client/Views/Shared/Components/NotificationClient/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Client/Views/Shared/Components/NotificationClient/Default.cshtml", typeof(AspNetCore.Areas_Client_Views_Shared_Components_NotificationClient_Default))]
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
#line 1 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\_ViewImports.cshtml"
using StepCourseProject;

#line default
#line hidden
#line 2 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\_ViewImports.cshtml"
using StepCourseProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756fac806ea8ed1ec2440e515f423bd3fa6dd450", @"/Areas/Client/Views/Shared/Components/NotificationClient/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c248f66d921df3e9f7744130ea1869dd48ec8f9f", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Shared_Components_NotificationClient_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StepCourseProject.Entites.Notification>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/images/icon7.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/images/resources/ny-img1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(182, 68, true);
            WriteLiteral("<li>\r\n    <a href=\"#\" title=\"\" class=\"not-box-open\">\r\n        <span>");
            EndContext();
            BeginContext(250, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "756fac806ea8ed1ec2440e515f423bd3fa6dd4504916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(294, 32, true);
            WriteLiteral("</span>\r\n        Notification \r\n");
            EndContext();
#line 9 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
         if (ViewBag.Count != 0)
        {


#line default
#line hidden
            BeginContext(373, 40, true);
            WriteLiteral("        <span class=\"badge badge-light\">");
            EndContext();
            BeginContext(414, 13, false);
#line 12 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                                   Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(427, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 13 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(447, 237, true);
            WriteLiteral("      \r\n    </a>\r\n    <div class=\"notification-box noti\" id=\"notification\">\r\n        <div class=\"nt-title\">\r\n            <h4>Settings</h4>\r\n            <a href=\"#\" title=\"\">Clear all</a>\r\n        </div>\r\n        <div class=\"nott-list\">\r\n");
            EndContext();
#line 22 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
             if (ViewBag.Count != 0)
            {

                

#line default
#line hidden
#line 25 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
            BeginContext(806, 108, true);
            WriteLiteral("                    <div class=\"notfication-details\">\r\n                        <div class=\"noty-user-img\">\r\n");
            EndContext();
#line 30 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                             if (item.AppUser.ImageUrl != null)
                            {


#line default
#line hidden
            BeginContext(1012, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1044, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "756fac806ea8ed1ec2440e515f423bd3fa6dd4508685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1054, "~/img/", 1054, 6, true);
#line 33 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
AddHtmlAttributeValue("", 1060, item.AppUser.ImageUrl, 1060, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1091, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1189, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1221, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "756fac806ea8ed1ec2440e515f423bd3fa6dd45010828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1277, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1310, 142, true);
            WriteLiteral("                        </div>\r\n                        <div class=\"notification-info\">\r\n                            <h3><a href=\"#\" title=\"\">");
            EndContext();
            BeginContext(1453, 21, false);
#line 41 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                                                Write(item.AppUser.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1474, 7, true);
            WriteLiteral("</a>   ");
            EndContext();
            BeginContext(1482, 21, false);
#line 41 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                                                                             Write(item.NotificationText);

#line default
#line hidden
            EndContext();
            BeginContext(1503, 94, true);
            WriteLiteral("</h3>\r\n\r\n                        </div><!--notification-info -->\r\n                    </div>\r\n");
            EndContext();
#line 45 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1616, 137, true);
            WriteLiteral("                <div class=\"view-all-nots\">\r\n                    <a href=\"#\" title=\"\">View All Notification</a>\r\n                </div>\r\n");
            EndContext();
#line 49 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(1803, 132, true);
            WriteLiteral("                <div class=\"view-all-nots\">\r\n                    <a href=\"#\" title=\"\">No notifications</a>\r\n                </div>\r\n");
            EndContext();
#line 56 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1950, 84, true);
            WriteLiteral("\r\n\r\n        </div><!--nott-list end-->\r\n    </div><!--notification-box end-->\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StepCourseProject.Entites.Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
