#pragma checksum "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "295e747e2c8337ffa2dd09821dff9a64ac959c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Detail.cshtml")]
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
#line 1 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\_ViewImports.cshtml"
using BTLASPMONGO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\_ViewImports.cshtml"
using BTLASPMONGO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295e747e2c8337ffa2dd09821dff9a64ac959c35", @"/Areas/Admin/Views/News/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284a1f2bf1346af405739fab82caafc7cf133f05", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BTLASPMONGO.Models.DataModels.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""content mt-4"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"" style=""font-family: system-ui;"">
                            News Detail  |
");
#nullable restore
#line 17 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                             if (Model.status == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-warning mr-4\" style=\"line-height:unset;\">Approving</span>\r\n");
#nullable restore
#line 20 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                            }
                            else if (Model.status == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-primary mr-4\" style=\"line-height:unset;\">Writting</span>\r\n");
#nullable restore
#line 24 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                            }
                            else if (Model.status == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-success mr-4\" style=\"line-height:unset;\">Published</span>\r\n");
#nullable restore
#line 28 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                            }
                            else if (Model.status == 4)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-danger mr-4\" style=\"line-height:unset;\">lock</span>\r\n");
#nullable restore
#line 32 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-dark mr-4\" style=\"line-height:unset;\">No Status</span>\r\n");
#nullable restore
#line 36 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </h3>\r\n                        <span class=\"ml-3 mr-3\"> <span class=\"text-purple\">Creation time:</span>");
#nullable restore
#line 38 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                                                           Write(String.Format("{0: HH:mm , MM/dd/yyyy}", Model.published_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span> | \r\n                        <span class=\"ml-3 \"><span class=\"text-purple\"> Last modification time:</span> ");
#nullable restore
#line 39 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.last_modification_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <div class=\"card-tools\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "295e747e2c8337ffa2dd09821dff9a64ac959c357818", async() => {
                WriteLiteral(" <span class=\"badge bg-gradient-green\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Back To News List!\"><i class=\"fas fa-list\" style=\"font-size:25px;\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "295e747e2c8337ffa2dd09821dff9a64ac959c359176", async() => {
                WriteLiteral(" <span class=\"badge bg-info\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit!\"><i class=\"fas fa-edit\" style=\"font-size:25px;\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                   WriteLiteral(Model._id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""row mb-4"">
                            <div class=""col-4"">
                                <img style=""width:100%;""");
            BeginWriteAttribute("src", " src=\"", 2757, "\"", 2780, 2);
            WriteAttributeValue("", 2763, "/", 2763, 1, true);
#nullable restore
#line 49 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
WriteAttributeValue("", 2764, Model.picture, 2764, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"not found image\" class=\"img-fluid\">\r\n                            </div>\r\n                            <div class=\"col-8\">\r\n                                <span class=\"text-red\">");
#nullable restore
#line 52 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                  Write(Html.DisplayFor(model => model.news_category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h2 class=\"lead mb-0\"><b> ");
#nullable restore
#line 53 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                     Write(Html.DisplayFor(model => model.news_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                                <div>\r\n                                    <span class=\"text-info\">Published time</span> :\r\n");
#nullable restore
#line 56 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                     if (Model.published_time != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                   Write(Html.DisplayFor(model => model.published_time));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                                                       
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>00/00/0000</span>\r\n");
#nullable restore
#line 63 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-info ml-2 mb-1\" style=\"line-height:unset;\">");
#nullable restore
#line 64 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                                                                   Write(Html.DisplayFor(model => model.total_views));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Views)</span>\r\n                                </div>\r\n                                <p class=\"text-muted text-sm\">");
#nullable restore
#line 66 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                         Write(Html.DisplayFor(model => model.news_excerpt));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                <h2 class=\"lead mb-0 \" style=\"position: absolute; bottom: 0; right: 139px;\"><b>");
#nullable restore
#line 67 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                                                                                          Write(Html.DisplayFor(model => model.user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </b></h2>
                            </div>
                        </div>
                        <div style=""width: 77%; border: 1px solid #6d6a6a6b; margin: auto;""></div>
                        <h5 class=""mb-0"">
                            Content
                        </h5>
                        <div class=""card p-2"">
                            ");
#nullable restore
#line 75 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                       Write(Html.Raw(Model.news_content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-footer clearfix\">\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "295e747e2c8337ffa2dd09821dff9a64ac959c3516623", async() => {
                WriteLiteral(" <span class=\"badge bg-gradient-green\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Back To News List!\"><i class=\"fas fa-list\" style=\"font-size:25px;\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "295e747e2c8337ffa2dd09821dff9a64ac959c3517978", async() => {
                WriteLiteral(" <span class=\"badge bg-info\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit!\"><i class=\"fas fa-edit\" style=\"font-size:25px;\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\This PC\OneDrive\Desktop\BTLASPMONGO\Areas\Admin\Views\News\Detail.cshtml"
                                               WriteLiteral(Model._id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- /.col -->\r\n        </div>\r\n        <!-- /.row -->\r\n    </div>\r\n    <!-- /.container-fluid -->\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BTLASPMONGO.Models.DataModels.News> Html { get; private set; }
    }
}
#pragma warning restore 1591