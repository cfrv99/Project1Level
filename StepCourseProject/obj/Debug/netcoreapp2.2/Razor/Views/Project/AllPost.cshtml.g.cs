#pragma checksum "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1219acd67abc7110ba93ee71c02d2c077f27c31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_AllPost), @"mvc.1.0.view", @"/Views/Project/AllPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/AllPost.cshtml", typeof(AspNetCore.Views_Project_AllPost))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1219acd67abc7110ba93ee71c02d2c077f27c31", @"/Views/Project/AllPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738b64eb8913d01cc083d047dd8cebf859d2aed5", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_AllPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AllPostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ClientView/images/resources/us-pic.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bid_now"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
  
    ViewData["Title"] = "AllPost";
    //Layout = "_Layout.cshtml";


#line default
#line hidden
            BeginContext(117, 103, true);
            WriteLiteral("\r\n<div class=\"search-sec\">\r\n    <div class=\"container\">\r\n        <div class=\"search-box\">\r\n            ");
            EndContext();
            BeginContext(220, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1219acd67abc7110ba93ee71c02d2c077f27c317283", async() => {
                BeginContext(226, 150, true);
                WriteLiteral("\r\n                <input type=\"text\" name=\"search\" placeholder=\"Search keywords\">\r\n                <button type=\"submit\">Search</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(383, 605, true);
            WriteLiteral(@"
        </div><!--search-box end-->
    </div>
</div><!--search-sec end-->


<main>
    <div class=""main-section"">
        <div class=""container"">
            <div class=""main-section-data"">
                <div class=""row"">
                    <div class=""col-lg-3"">
                        <div class=""filter-secs"">
                            <div class=""filter-heading"">
                                <h3>Filters</h3>
                                <a href=""#"" title="""">Clear all filters</a>
                            </div><!--filter-heading end-->
                            ");
            EndContext();
            BeginContext(989, 45, false);
#line 31 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                       Write(await Component.InvokeAsync("LeftFilterMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 236, true);
            WriteLiteral("\r\n                        </div><!--filter-secs end-->\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"main-ws-sec\">\r\n                            <div class=\"posts-section\">\r\n");
            EndContext();
#line 37 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
            BeginContext(1369, 241, true);
            WriteLiteral("                                    <div class=\"post-bar\">\r\n                                        <div class=\"post_topbar\">\r\n                                            <div class=\"usy-dt\">\r\n                                                ");
            EndContext();
            BeginContext(1610, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1219acd67abc7110ba93ee71c02d2c077f27c3110751", async() => {
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
            BeginContext(1669, 130, true);
            WriteLiteral("\r\n                                                <div class=\"usy-name\">\r\n                                                    <h3>");
            EndContext();
            BeginContext(1800, 17, false);
#line 45 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                   Write(item.PostUserName);

#line default
#line hidden
            EndContext();
            BeginContext(1817, 550, true);
            WriteLiteral(@"</h3>
                                                    <span><img src=""images/clock.png"" alt="""">3 min ago</span>
                                                </div>
                                            </div>
                                            <div class=""ed-opts"">
                                                <a href=""#"" title="""" class=""ed-opts-open""><i class=""la la-ellipsis-v""></i></a>
                                                <ul class=""ed-options"">
                                                    <li>");
            EndContext();
            BeginContext(2367, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1219acd67abc7110ba93ee71c02d2c077f27c3113099", async() => {
                BeginContext(2461, 14, true);
                WriteLiteral("Author Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                                                                               WriteLiteral(item.PostUserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2479, 691, true);
            WriteLiteral(@"</li>

                                                </ul>
                                            </div>
                                        </div>
                                        <div class=""epi-sec"">
                                            <ul class=""descp"">
                                                <li><img src=""images/icon8.png"" alt=""""><span>Developer</span></li>
                                                <li><img src=""images/icon9.png"" alt=""""><span>India</span></li>
                                            </ul>
                                            <ul class=""bk-links"">

                                                <li>");
            EndContext();
            BeginContext(3170, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1219acd67abc7110ba93ee71c02d2c077f27c3116544", async() => {
                BeginContext(3268, 30, true);
                WriteLiteral("<i class=\"la la-envelope\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                                                                               WriteLiteral(item.PostUserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3302, 59, true);
            WriteLiteral("</li>\r\n                                                <li>");
            EndContext();
            BeginContext(3361, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1219acd67abc7110ba93ee71c02d2c077f27c3119361", async() => {
                BeginContext(3459, 7, true);
                WriteLiteral("Bid Now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3470, 372, true);
            WriteLiteral(@"</li>
                                            </ul>
                                        </div>
                                        <div class=""job_descp"">
                                            <h3>Simple Classified Site</h3>
                                            <ul class=""job-dt"">
                                                <li><span>$");
            EndContext();
            BeginContext(3843, 15, false);
#line 71 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                      Write(item.StartPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3858, 4, true);
            WriteLiteral(" - $");
            EndContext();
            BeginContext(3863, 13, false);
#line 71 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                                          Write(item.EndPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3876, 112, true);
            WriteLiteral("</span></li>\r\n                                            </ul>\r\n                                            <p>");
            EndContext();
            BeginContext(3989, 13, false);
#line 73 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                          Write(item.PostDesc);

#line default
#line hidden
            EndContext();
            BeginContext(4002, 183, true);
            WriteLiteral(" <a href=\"#\" title=\"\">view more</a></p>\r\n                                            <ul class=\"skill-tags\">\r\n                                                <li><a href=\"#\" title=\"\">");
            EndContext();
            BeginContext(4186, 14, false);
#line 75 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                                    Write(item.SkillName);

#line default
#line hidden
            EndContext();
            BeginContext(4200, 754, true);
            WriteLiteral(@"</a></li>

                                            </ul>
                                        </div>
                                        <div class=""job-status-bar"">
                                            <ul class=""like-com"">
                                                <li>
                                                    <a href=""#"" class=""active""><i class=""fas fa-heart""></i> Like</a>
                                                    <img src=""images/liked-img.png"" alt="""">
                                                    <span>25</span>
                                                </li>
                                                <li><a href=""#"" class=""com""><i class=""fas fa-comment-alt""></i> Bids ");
            EndContext();
            BeginContext(4955, 14, false);
#line 86 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                                                                                               Write(item.CountBids);

#line default
#line hidden
            EndContext();
            BeginContext(4969, 250, true);
            WriteLiteral("</a></li>\r\n                                            </ul>\r\n                                            <a href=\"#\"><i class=\"fas fa-eye\"></i>Views 50</a>\r\n                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 91 "C:\Users\Murad\Desktop\stepProjectsCourse-master2\StepCourseProject\Views\Project\AllPost.cshtml"
                                }

#line default
#line hidden
            BeginContext(5254, 6739, true);
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""right-sidebar"">
                            <div class=""widget widget-about"">
                                <img src=""images/wd-logo.png"" alt="""">
                                <h3>Track Time on Workwise</h3>
                                <span>Pay only for the Hours worked</span>
                                <div class=""sign_link"">
                                    <h3><a href=""sign-in.html"" title="""">Sign up</a></h3>
                                    <a href=""#"" title="""">Learn More</a>
                                </div>
                            </div><!--widget-about end-->
                            <div class=""widget widget-jobs"">
                                <div class=""sd-title"">
                                    <h3>Top Jobs</h3>
                                    <i class=""la la-ellipsis-v"">");
            WriteLiteral(@"</i>
                                </div>
                                <div class=""jobs-list"">
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                                            <h3>Senior Product Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                                        </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                                        </div>
                                    </div><!--job-info end-->
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                                            <h3>Senior UI / UX Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
    ");
            WriteLiteral(@"                                    </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                                        </div>
                                    </div><!--job-info end-->
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                                            <h3>Junior Seo Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                                        </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                                        </div>
                                    </div><!--job-info end-->
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                ");
            WriteLiteral(@"                            <h3>Senior PHP Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                                        </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                                        </div>
                                    </div><!--job-info end-->
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                                            <h3>Senior Developer Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                                        </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                                        </div>
                            ");
            WriteLiteral(@"        </div><!--job-info end-->
                                </div><!--jobs-list end-->
                            </div><!--widget-jobs end-->
                            <div class=""widget widget-jobs"">
                                <div class=""sd-title"">
                                    <h3>Most Viewed This Week</h3>
                                    <i class=""la la-ellipsis-v""></i>
                                </div>
                                <div class=""jobs-list"">
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                                            <h3>Senior Product Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                                        </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                           ");
            WriteLiteral(@"             </div>
                                    </div><!--job-info end-->
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                                            <h3>Senior UI / UX Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                                        </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                                        </div>
                                    </div><!--job-info end-->
                                    <div class=""job-info"">
                                        <div class=""job-details"">
                                            <h3>Junior Seo Designer</h3>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit..</p>
                           ");
            WriteLiteral(@"             </div>
                                        <div class=""hr-rate"">
                                            <span>$25/hr</span>
                                        </div>
                                    </div><!--job-info end-->
                                </div><!--jobs-list end-->
                            </div><!--widget-jobs end-->
                        </div><!--right-sidebar end-->
                    </div>
                </div>
            </div><!-- main-section-data end-->
        </div>
    </div>
</main>
<script>

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AllPostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
