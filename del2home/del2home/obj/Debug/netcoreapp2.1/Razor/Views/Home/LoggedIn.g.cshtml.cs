#pragma checksum "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\LoggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d095218ff5511eae80952cf8ff8fbddc4b65038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoggedIn), @"mvc.1.0.view", @"/Views/Home/LoggedIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LoggedIn.cshtml", typeof(AspNetCore.Views_Home_LoggedIn))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d095218ff5511eae80952cf8ff8fbddc4b65038", @"/Views/Home/LoggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ae12886bd9d7dc4e61fb3923ab0304c64cb4f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LoggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\LoggedIn.cshtml"
  
    ViewData["Title"] = "Logged In";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(50, 17, false);
#line 4 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\LoggedIn.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(67, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(79, 19, false);
#line 5 "C:\Users\fifz\source\repos\del2home\del2home\Views\Home\LoggedIn.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(98, 53, true);
            WriteLiteral("</h3>\r\n\r\n<p>This will be one of the other pages</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
