#pragma checksum "C:\Users\prepod\source\repos\DeliveryServiceFromGit\DeliveryService\DeliveryService\Views\Home\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ccacd581a02827cf5402b77cf30d9c4f5b8fc9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetails), @"mvc.1.0.view", @"/Views/Home/ProductDetails.cshtml")]
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
#line 1 "C:\Users\prepod\source\repos\DeliveryServiceFromGit\DeliveryService\DeliveryService\Views\_ViewImports.cshtml"
using DeliveryService.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ccacd581a02827cf5402b77cf30d9c4f5b8fc9e", @"/Views/Home/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52cc750fde2fb2cc94a355f5e382fa70b655435", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\prepod\source\repos\DeliveryServiceFromGit\DeliveryService\DeliveryService\Views\Home\ProductDetails.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>");
#nullable restore
#line 4 "C:\Users\prepod\source\repos\DeliveryServiceFromGit\DeliveryService\DeliveryService\Views\Home\ProductDetails.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 5 "C:\Users\prepod\source\repos\DeliveryServiceFromGit\DeliveryService\DeliveryService\Views\Home\ProductDetails.cshtml"
Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 6 "C:\Users\prepod\source\repos\DeliveryServiceFromGit\DeliveryService\DeliveryService\Views\Home\ProductDetails.cshtml"
Write(Model.CategoryEntity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
