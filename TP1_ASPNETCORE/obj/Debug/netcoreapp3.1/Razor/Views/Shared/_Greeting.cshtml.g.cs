#pragma checksum "C:\Users\Lenovo\Desktop\TP1_ASPNETCORE\TP1_ASPNETCORE\Views\Shared\_Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6116ac84b0722fe211e9989507cd75ec5c3a95e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Greeting), @"mvc.1.0.view", @"/Views/Shared/_Greeting.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\TP1_ASPNETCORE\TP1_ASPNETCORE\Views\_ViewImports.cshtml"
using TP1_ASPNETCORE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\TP1_ASPNETCORE\TP1_ASPNETCORE\Views\_ViewImports.cshtml"
using TP1_ASPNETCORE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6116ac84b0722fe211e9989507cd75ec5c3a95e6", @"/Views/Shared/_Greeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4be7e59c51d37a3055507012b2bf93c07fafb0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Greeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>Hello, world!</div>\r\n<div>Today is ");
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\TP1_ASPNETCORE\TP1_ASPNETCORE\Views\Shared\_Greeting.cshtml"
         Write(DateTime.Now.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
