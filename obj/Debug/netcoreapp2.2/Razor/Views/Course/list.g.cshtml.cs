#pragma checksum "C:\Users\DTIISIK\testApps\CourseApp\Views\Course\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a422fc8c22d450e942bece1f6fd6badfc66ab4d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_list), @"mvc.1.0.view", @"/Views/Course/list.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/list.cshtml", typeof(AspNetCore.Views_Course_list))]
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
#line 1 "C:\Users\DTIISIK\testApps\CourseApp\Views\_ViewImports.cshtml"
using CourseApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a422fc8c22d450e942bece1f6fd6badfc66ab4d4", @"/Views/Course/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46550fe38bd3f331f621aef139e2ffed6d31579", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(57, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a422fc8c22d450e942bece1f6fd6badfc66ab4d44048", async() => {
                BeginContext(63, 277, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Liste</title>
    <link rel=""stylesheet"" href=""/modules/bootstrap/dist/css/bootstrap.min.css"">
    ");
                EndContext();
                BeginContext(340, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a422fc8c22d450e942bece1f6fd6badfc66ab4d44718", async() => {
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
                BeginContext(386, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(397, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(399, 1056, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a422fc8c22d450e942bece1f6fd6badfc66ab4d46852", async() => {
                BeginContext(405, 604, true);
                WriteLiteral(@"
        <div class=""container m-4"">
            <div class=""card mx-auto"" style=""width:500px"">
                <div class=""card-header"">
                    Kursa Katılanlar
                </div>
                <table class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <td>Name</td>
                                <td>Email</td>
                                <td>Phone   </td>
                                <td>Confirm</td>
                            </tr>
                        </thead>
");
                EndContext();
#line 28 "C:\Users\DTIISIK\testApps\CourseApp\Views\Course\list.cshtml"
                         foreach (var student in Model)
                        {

#line default
#line hidden
                BeginContext(1091, 39, true);
                WriteLiteral(" <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1131, 12, false);
#line 30 "C:\Users\DTIISIK\testApps\CourseApp\Views\Course\list.cshtml"
                           Write(student.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1143, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1183, 13, false);
#line 31 "C:\Users\DTIISIK\testApps\CourseApp\Views\Course\list.cshtml"
                           Write(student.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1196, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1236, 13, false);
#line 32 "C:\Users\DTIISIK\testApps\CourseApp\Views\Course\list.cshtml"
                           Write(student.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(1249, 42, true);
                WriteLiteral("   </td>\r\n                            <td>");
                EndContext();
                BeginContext(1292, 15, false);
#line 33 "C:\Users\DTIISIK\testApps\CourseApp\Views\Course\list.cshtml"
                           Write(student.Confirm);

#line default
#line hidden
                EndContext();
                BeginContext(1307, 42, true);
                WriteLiteral("</td>\r\n                            </tr>\r\n");
                EndContext();
#line 35 "C:\Users\DTIISIK\testApps\CourseApp\Views\Course\list.cshtml"

                        }

#line default
#line hidden
                BeginContext(1378, 70, true);
                WriteLiteral("            </table>\r\n            </div>\r\n        </div>\r\n     \r\n   \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1455, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591