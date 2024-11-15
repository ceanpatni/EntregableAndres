#pragma checksum "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c23143e7feb64f308b737b4b0569f7bc637c79a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c23143e7feb64f308b737b4b0569f7bc637c79a", @"/Views/Order/Details.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntregableAndres.Entity.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Order Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order Details</h1>\r\n\r\n<div>\r\n    <h4>Order Date: ");
#nullable restore
#line 11 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
               Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p>Total Amount: ");
#nullable restore
#line 12 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
                Write(Model.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Customer ID: ");
#nullable restore
#line 13 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
               Write(Model.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<h3>Order Items</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Product</th>\r\n            <th>Quantity</th>\r\n            <th>Unit Price</th>\r\n            <th>Total</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
         foreach (var item in Model.OrderItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
                Write(item.Quantity * item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 872, "\"", 908, 1);
#nullable restore
#line 39 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Details.cshtml"
WriteAttributeValue("", 879, Url.Action("Index", "Order"), 879, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Back to Orders</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntregableAndres.Entity.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
