#pragma checksum "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d4c3c147da542b1b98a6858f7e7461f941c6e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Client/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Client/Views/Home/Details.cshtml", typeof(AspNetCore.Areas_Client_Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d4c3c147da542b1b98a6858f7e7461f941c6e4", @"/Areas/Client/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c248f66d921df3e9f7744130ea1869dd48ec8f9f", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StepCourseProject.Areas.Client.Models.PostDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("person image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptBid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/images/liked-img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";



#line default
#line hidden
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
 foreach (var item in Model.Bids)
{


#line default
#line hidden
            BeginContext(149, 189, true);
            WriteLiteral("    <div class=\"main-ws-sec\">\r\n        <div class=\"posts-section\">\r\n            <div class=\"post-bar\">\r\n                <div class=\"post_topbar\">\r\n                    <div class=\"usy-dt\">\r\n");
            EndContext();
#line 16 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
                         if (item.AppUser.ImageUrl != null)
                        {

#line default
#line hidden
            BeginContext(426, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(454, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47d4c3c147da542b1b98a6858f7e7461f941c6e47097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 496, "~/img/", 496, 6, true);
#line 18 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 502, item.AppUser.ImageUrl, 502, 22, false);

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
            BeginContext(545, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(633, 118, true);
            WriteLiteral("                            <img style=\"width:50px;height:50px;\" src=\"images/resources/us-pic.png\" alt=\"bolt image\">\r\n");
            EndContext();
#line 24 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"

                        }

#line default
#line hidden
            BeginContext(780, 80, true);
            WriteLiteral("                        <div class=\"usy-name\">\r\n                            <h3>");
            EndContext();
            BeginContext(861, 21, false);
#line 27 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
                           Write(item.AppUser.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(882, 76, true);
            WriteLiteral("</h3>\r\n                            <span><img src=\"images/clock.png\" alt=\"\">");
            EndContext();
            BeginContext(959, 31, false);
#line 28 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
                                                                Write(item.BidDate.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(990, 335, true);
            WriteLiteral(@"</span>
                        </div>
                    </div>

                </div>
                <div class=""epi-sec"">
                    <ul class=""descp"">
                        <li><img src=""images/icon8.png"" alt=""""><span>Developer</span></li>
                        <li><img src=""images/icon9.png"" alt=""""><span>");
            EndContext();
            BeginContext(1326, 17, false);
#line 36 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
                                                                Write(item.AppUser.City);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 258, true);
            WriteLiteral(@"</span></li>
                    </ul>
                    <ul class=""bk-links"">
                       
                        <li><a href=""#"" title=""""><i class=""la la-envelope"" ></i></a></li>
                        <li>
                            ");
            EndContext();
            BeginContext(1601, 409, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47d4c3c147da542b1b98a6858f7e7461f941c6e411617", async() => {
                BeginContext(1665, 67, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"bidId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1732, "\"", 1748, 1);
#line 43 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
WriteAttributeValue("", 1740, item.Id, 1740, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1749, 71, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"postId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1820, "\"", 1840, 1);
#line 44 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
WriteAttributeValue("", 1828, item.PostId, 1828, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1841, 162, true);
                WriteLiteral(" />\r\n\r\n                                <input type=\"submit\" style=\"margin-top:-10px;\" class=\"btn btn-success\"  value=\"Accept Now\" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2010, 223, true);
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n                <div class=\"job_descp\">\r\n                    <h3>Simple Classified Site</h3>\r\n                    <ul class=\"job-dt\">\r\n                        <li><span>$");
            EndContext();
            BeginContext(2234, 20, false);
#line 53 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
                              Write(item.Post.StartPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2254, 4, true);
            WriteLiteral(" - $");
            EndContext();
            BeginContext(2259, 18, false);
#line 53 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
                                                       Write(item.Post.EndPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2277, 90, true);
            WriteLiteral("</span></li>\r\n                    </ul>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(2368, 25, false);
#line 56 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"
                   Write(item.Post.PostDescription);

#line default
#line hidden
            EndContext();
            BeginContext(2393, 271, true);
            WriteLiteral(@"


                </div>
                <div class=""job-status-bar"">
                    <ul class=""like-com"">
                        <li>
                            <a href=""#"" class=""active""><i class=""fas fa-heart""></i> Like</a>
                            ");
            EndContext();
            BeginContext(2664, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47d4c3c147da542b1b98a6858f7e7461f941c6e416659", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2712, 449, true);
            WriteLiteral(@"
                            <span>25</span>
                        </li>
                        <li><a href=""#"" class=""com""><i class=""fas fa-comment-alt""></i> Comments 15</a></li>
                    </ul>
                    <a href=""#""><i class=""fas fa-eye""></i>Views 50</a>
                </div>
            </div><!--post-bar end-->
          
            
        </div><!--posts-section end-->
    </div><!--main-ws-sec end-->
");
            EndContext();
#line 76 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Areas\Client\Views\Home\Details.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StepCourseProject.Areas.Client.Models.PostDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
