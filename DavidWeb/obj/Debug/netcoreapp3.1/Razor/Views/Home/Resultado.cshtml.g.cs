#pragma checksum "C:\Users\DarkSlayer\source\repos\DavidSpecFlowTest\DavidWeb\Views\Home\Resultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec1fe8c1efb13ab7228e76c024de3fffbc970ecb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resultado), @"mvc.1.0.view", @"/Views/Home/Resultado.cshtml")]
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
#line 1 "C:\Users\DarkSlayer\source\repos\DavidSpecFlowTest\DavidWeb\Views\_ViewImports.cshtml"
using DavidWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DarkSlayer\source\repos\DavidSpecFlowTest\DavidWeb\Views\_ViewImports.cshtml"
using DavidWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec1fe8c1efb13ab7228e76c024de3fffbc970ecb", @"/Views/Home/Resultado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8f67f03e4655032450330f71863e6c3179f473", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<label name=\"resultado\">");
#nullable restore
#line 1 "C:\Users\DarkSlayer\source\repos\DavidSpecFlowTest\DavidWeb\Views\Home\Resultado.cshtml"
                   Write(ViewBag.Persona);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>");
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
