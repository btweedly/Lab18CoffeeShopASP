#pragma checksum "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b4b20bcd9cbc2b21e8152f6dee64f13b534f418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegisterUser_Index), @"mvc.1.0.view", @"/Views/RegisterUser/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegisterUser/Index.cshtml", typeof(AspNetCore.Views_RegisterUser_Index))]
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
#line 1 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\_ViewImports.cshtml"
using Lab18CoffeeShop;

#line default
#line hidden
#line 2 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\_ViewImports.cshtml"
using Lab18CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4b20bcd9cbc2b21e8152f6dee64f13b534f418", @"/Views/RegisterUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe600a813aeb241e28f2cba4f76963bde4e3ff07", @"/Views/_ViewImports.cshtml")]
    public class Views_RegisterUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18CoffeeShop.Register>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
  
    ViewData["Title"] = "Registration Form";

#line default
#line hidden
            BeginContext(55, 27, true);
            WriteLiteral("\r\n<h1>Registration</h1>\r\n\r\n");
            EndContext();
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
 using (var form = Html.BeginForm())
{

#line default
#line hidden
            BeginContext(158, 55, true);
            WriteLiteral("    <div class=\"fields\">\r\n        <div>\r\n\r\n            ");
            EndContext();
            BeginContext(214, 30, false);
#line 15 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(244, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(259, 32, false);
#line 16 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(291, 47, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(339, 27, false);
#line 20 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(366, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(381, 29, false);
#line 21 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(410, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(456, 30, false);
#line 24 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(486, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(501, 32, false);
#line 25 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(533, 78, true);
            WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" value=\"Submit\" />\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
}

#line default
#line hidden
            BeginContext(614, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18CoffeeShop.Register> Html { get; private set; }
    }
}
#pragma warning restore 1591
