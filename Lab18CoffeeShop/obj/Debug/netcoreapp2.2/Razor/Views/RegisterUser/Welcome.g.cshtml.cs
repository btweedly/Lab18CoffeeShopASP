#pragma checksum "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d8b21b82c0a72136f166f1d4c6fcd3015a72eb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegisterUser_Welcome), @"mvc.1.0.view", @"/Views/RegisterUser/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegisterUser/Welcome.cshtml", typeof(AspNetCore.Views_RegisterUser_Welcome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d8b21b82c0a72136f166f1d4c6fcd3015a72eb1", @"/Views/RegisterUser/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe600a813aeb241e28f2cba4f76963bde4e3ff07", @"/Views/_ViewImports.cshtml")]
    public class Views_RegisterUser_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18CoffeeShop.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(158, 61, true);
            WriteLiteral("\r\n<p style=\"color: burlywood;\">Welcome to your user profile, ");
            EndContext();
            BeginContext(220, 15, false);
#line 10 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Welcome.cshtml"
                                                      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(235, 151, true);
            WriteLiteral("!</p>\r\n<br />\r\n<p style=\"color:burlywood;\">We have the following information listed for you:</p>\r\n\r\n<ul style=\"color: burlywood;\">\r\n    <p>First Name: ");
            EndContext();
            BeginContext(387, 15, false);
#line 15 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Welcome.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(402, 30, true);
            WriteLiteral("</p>\r\n    \r\n    <p>Last Name: ");
            EndContext();
            BeginContext(433, 14, false);
#line 17 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Welcome.cshtml"
             Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(447, 29, true);
            WriteLiteral("</p>\r\n    \r\n    <p>Username: ");
            EndContext();
            BeginContext(477, 14, false);
#line 19 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Welcome.cshtml"
            Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(491, 35, true);
            WriteLiteral("</p>\r\n    \r\n    <p>Favorite Drink: ");
            EndContext();
            BeginContext(527, 19, false);
#line 21 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Welcome.cshtml"
                  Write(Model.FavoriteDrink);

#line default
#line hidden
            EndContext();
            BeginContext(546, 19, true);
            WriteLiteral("</p>\r\n</ul>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18CoffeeShop.Models.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
