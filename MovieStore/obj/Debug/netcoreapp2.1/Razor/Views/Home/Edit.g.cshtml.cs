#pragma checksum "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "132a1e8da3442048ccdf119851e400b8cc505135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Edit.cshtml", typeof(AspNetCore.Views_Home_Edit))]
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
#line 1 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\_ViewImports.cshtml"
using MovieStore;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\_ViewImports.cshtml"
using MovieStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"132a1e8da3442048ccdf119851e400b8cc505135", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a8c2dc702b202c6daeaeb5df09bdab9162bf52c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(59, 17, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n");
            EndContext();
#line 7 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
 using (@Html.BeginForm("SaveChanges","Home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(149, 24, false);
#line 9 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(180, 25, false);
#line 10 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(207, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(246, 58, false);
#line 12 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(m => m.Title, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(304, 16, true);
            WriteLiteral("<br />\r\n        ");
            EndContext();
            BeginContext(321, 60, false);
#line 13 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.TextBoxFor(m => m.Title, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(381, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(392, 76, false);
#line 14 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.ValidationMessageFor(m => m.Title, "", new { @class = "label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(468, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(521, 61, false);
#line 17 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(m => m.Director, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(582, 16, true);
            WriteLiteral("<br />\r\n        ");
            EndContext();
            BeginContext(599, 63, false);
#line 18 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.TextBoxFor(m => m.Director, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(662, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(673, 42, false);
#line 19 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.ValidationMessageFor(m => m.Director));

#line default
#line hidden
            EndContext();
            BeginContext(715, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(768, 64, false);
#line 22 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(m => m.Description, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(832, 16, true);
            WriteLiteral("<br />\r\n        ");
            EndContext();
            BeginContext(849, 66, false);
#line 23 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.TextBoxFor(m => m.Description, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(915, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(926, 45, false);
#line 24 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.ValidationMessageFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(971, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1024, 58, false);
#line 27 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(m => m.Price, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 16, true);
            WriteLiteral("<br />\r\n        ");
            EndContext();
            BeginContext(1099, 60, false);
#line 28 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.TextBoxFor(m => m.Price, new { @class = "form-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1170, 39, false);
#line 29 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
   Write(Html.ValidationMessageFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 56, true);
            WriteLiteral("\r\n    </div>\r\n    <input value=\"Save\" type=\"submit\" />\r\n");
            EndContext();
#line 32 "C:\Users\Asus\Desktop\practicingCoding\MVC\MovieStore\MovieStore\Views\Home\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1268, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
