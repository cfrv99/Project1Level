#pragma checksum "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fa6c798a693b44cf8567cda6c59dfa73ce25b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MessageInbox_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessageInbox/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MessageInbox/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MessageInbox_Default))]
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
#line 1 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\_ViewImports.cshtml"
using StepCourseProject;

#line default
#line hidden
#line 2 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\_ViewImports.cshtml"
using StepCourseProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa6c798a693b44cf8567cda6c59dfa73ce25b7b", @"/Views/Shared/Components/MessageInbox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738b64eb8913d01cc083d047dd8cebf859d2aed5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MessageInbox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessageListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("sunil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 28, true);
            WriteLiteral("<div class=\"inbox_chat\">\r\n\r\n");
            EndContext();
            BeginContext(172, 28, true);
            WriteLiteral("    <!--active_chat-->\r\n\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(243, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(251, 963, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa6c798a693b44cf8567cda6c59dfa73ce25b7b5036", async() => {
                BeginContext(336, 18, true);
                WriteLiteral("\r\n            <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 354, "\"", 424, 2);
                WriteAttributeValue("", 362, "chat_list", 362, 9, true);
#line 12 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
WriteAttributeValue(" ", 371, item.UserId==ViewBag.Active ? "active_chat" : "" , 372, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(425, 91, true);
                WriteLiteral(">\r\n                <div class=\"chat_people\">\r\n\r\n                    <div class=\"chat_img\"> ");
                EndContext();
                BeginContext(516, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fa6c798a693b44cf8567cda6c59dfa73ce25b7b6097", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 526, "~/img/", 526, 6, true);
#line 15 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
AddHtmlAttributeValue("", 532, item.ImageUrl, 532, 14, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(560, 110, true);
                WriteLiteral(" </div>\r\n                    <div class=\"chat_ib\">\r\n                        <h5>\r\n                            ");
                EndContext();
                BeginContext(671, 23, false);
#line 18 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
                       Write(item.MessagerSenderName);

#line default
#line hidden
                EndContext();
                BeginContext(694, 55, true);
                WriteLiteral(" <span class=\"chat_date\">\r\n                            ");
                EndContext();
                BeginContext(750, 12, false);
#line 19 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
                       Write(ViewBag.Date);

#line default
#line hidden
                EndContext();
                BeginContext(762, 1, true);
                WriteLiteral(" ");
                EndContext();
#line 19 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
                                           if (item.OnlineStatus == true)
                            {

#line default
#line hidden
                BeginContext(825, 62, true);
                WriteLiteral("<span class=\"ml-2 badge badge-success badge-counter\">  </span>");
                EndContext();
#line 20 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
                                                                                           }
                            else {

#line default
#line hidden
                BeginContext(924, 63, true);
                WriteLiteral(" <span class=\"ml-2 badge badge-danger badge-counter\">  </span> ");
                EndContext();
#line 21 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
                                                                                                 }

#line default
#line hidden
                BeginContext(990, 109, true);
                WriteLiteral("                        </span>\r\n                    </h5>\r\n                    <p>\r\n                        ");
                EndContext();
                BeginContext(1100, 16, false);
#line 25 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
                   Write(item.MessageText);

#line default
#line hidden
                EndContext();
                BeginContext(1116, 94, true);
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"
                                                                   WriteLiteral(item.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1214, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Shared\Components\MessageInbox\Default.cshtml"

}

#line default
#line hidden
            BeginContext(1221, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<StepCourseProject.Entites.AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessageListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
