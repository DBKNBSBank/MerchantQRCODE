#pragma checksum "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b046fc70d030dccc0375f513865f330f76900d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\_ViewImports.cshtml"
using MerchantQRPortalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\_ViewImports.cshtml"
using MerchantQRPortalCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b046fc70d030dccc0375f513865f330f76900d", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66be83b862e3f7acc75f1cc21eec512cf8088071", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MerchantQRPortalCore.ViewModels.SignInViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Login</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
 using (Html.BeginForm("Login", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 17 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
       Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 21 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
           Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
           Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 29 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", @type = "password" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 36 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
       Write(Html.LabelFor(model => model.UserRole, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 38 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
           Write(Html.DropDownList("RoleName",
                        new SelectList(Enum.GetValues(typeof(MerchantQRPortalCore.ViewModels.UserRole))),
                        "Select Role",
                        new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
           Write(Html.ValidationMessageFor(model => model.UserRole, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Log In\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\kaunda.dum\Documents\Visual Studio 2019\Projects\MerchantQRPortalCoreApp\MerchantQRPortalCore\MerchantQRPortalCore\Views\Home\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MerchantQRPortalCore.ViewModels.SignInViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
