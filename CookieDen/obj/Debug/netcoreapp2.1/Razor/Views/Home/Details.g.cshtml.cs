#pragma checksum "C:\Users\madhulika.a.pandey\Documents\Downloads\SampleCode\CookieDen\CookieDen\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf93a20d687c5c66538150066f09256cb68f1890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CookieDen.Pages.Home.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(CookieDen.Pages.Home.Views_Home_Details))]
namespace CookieDen.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\madhulika.a.pandey\Documents\Downloads\SampleCode\CookieDen\CookieDen\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\madhulika.a.pandey\Documents\Downloads\SampleCode\CookieDen\CookieDen\Views\_ViewImports.cshtml"
using CookieDen.Areas.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf93a20d687c5c66538150066f09256cb68f1890", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1253d69f7a2fe9bf4a01e92bf24d30c3fc50d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CookieDen.Models.Cookie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(40, 10, false);
#line 3 "C:\Users\madhulika.a.pandey\Documents\Downloads\SampleCode\CookieDen\CookieDen\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(50, 13, true);
            WriteLiteral("</h1>\r\n\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 63, "\"", 84, 1);
#line 5 "C:\Users\madhulika.a.pandey\Documents\Downloads\SampleCode\CookieDen\CookieDen\Views\Home\Details.cshtml"
WriteAttributeValue("", 69, Model.ImageUrl, 69, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(85, 9, true);
            WriteLiteral(" />\r\n<h3>");
            EndContext();
            BeginContext(95, 21, false);
#line 6 "C:\Users\madhulika.a.pandey\Documents\Downloads\SampleCode\CookieDen\CookieDen\Views\Home\Details.cshtml"
Write(Model.FullDescription);

#line default
#line hidden
            EndContext();
            BeginContext(116, 5, true);
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CookieDen.Models.Cookie> Html { get; private set; }
    }
}
#pragma warning restore 1591
