#pragma checksum "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3ea1a49dbf2b1ec662a4d1ef5105436000d6df6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\fifz\source\repos\del2home\del2home\Views\_ViewImports.cshtml"
using del2home;

#line default
#line hidden
#line 2 "C:\Users\fifz\source\repos\del2home\del2home\Views\_ViewImports.cshtml"
using del2home.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ea1a49dbf2b1ec662a4d1ef5105436000d6df6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ae12886bd9d7dc4e61fb3923ab0304c64cb4f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<del2home.Models.Home>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ace.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ACE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#line 5 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(141, 23, false);
#line 7 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(166, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(170, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7eac174676dc477899569a91f2d47b95", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(231, 60, true);
            WriteLiteral("\r\n    <table align=\"center\">\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(292, 30, false);
#line 11 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
           Write(Html.LabelFor(a => a.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(322, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(346, 32, false);
#line 12 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(a => a.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(378, 41, true);
            WriteLiteral("</td>\r\n            <td><font color=\"red\">");
            EndContext();
            BeginContext(420, 42, false);
#line 13 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
                             Write(Html.ValidationMessageFor(a => a.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(462, 59, true);
            WriteLiteral("</font></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(522, 30, false);
#line 16 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
           Write(Html.LabelFor(a => a.Password));

#line default
#line hidden
            EndContext();
            BeginContext(552, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(576, 33, false);
#line 17 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
           Write(Html.PasswordFor(a => a.Password));

#line default
#line hidden
            EndContext();
            BeginContext(609, 41, true);
            WriteLiteral("</td>\r\n            <td><font color=\"red\">");
            EndContext();
            BeginContext(651, 42, false);
#line 18 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
                             Write(Html.ValidationMessageFor(a => a.Password));

#line default
#line hidden
            EndContext();
            BeginContext(693, 224, true);
            WriteLiteral("</font></td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td><input type=\"submit\" value=\"Login\" /></td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n    <center><font class=\"remlist\" color=\"red\">");
            EndContext();
            BeginContext(918, 28, false);
#line 26 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
                                         Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(946, 18, true);
            WriteLiteral("</font></center>\r\n");
            EndContext();
#line 27 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<del2home.Models.Home> Html { get; private set; }
    }
}
#pragma warning restore 1591
