#pragma checksum "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02fe9788aca7b2934f906c1542c76cd9854c7135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderItem_Edit), @"mvc.1.0.view", @"/Views/OrderItem/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fe9788aca7b2934f906c1542c76cd9854c7135", @"/Views/OrderItem/Edit.cshtml")]
    public class Views_OrderItem_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
  
    ViewData["Title"] = "Edit Order Item";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var products = ViewData["Products"] as List<EntregableAndres.Entity.Product>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-4\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <form asp-action=\"Edit\" method=\"post\">\r\n        <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 330, "\"", 347, 1);
#nullable restore
#line 11 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
WriteAttributeValue("", 338, Model.Id, 338, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"OrderId\">Order ID</label>\r\n            <input type=\"number\" class=\"form-control\" id=\"OrderId\" name=\"OrderId\"");
            BeginWriteAttribute("value", " value=\"", 521, "\"", 543, 1);
#nullable restore
#line 15 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
WriteAttributeValue("", 529, Model.OrderId, 529, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"ProductId\">Product</label>\r\n            <select class=\"form-control\" id=\"ProductId\" name=\"ProductId\" required>\r\n");
#nullable restore
#line 21 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
                 foreach (var product in products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 844, "\"", 863, 1);
#nullable restore
#line 23 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
WriteAttributeValue("", 852, product.Id, 852, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
                                            Write(product.Id == Model.ProductId ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
                                                                                              Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 24 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"Quantity\">Quantity</label>\r\n            <input type=\"number\" class=\"form-control\" id=\"Quantity\" name=\"Quantity\"");
            BeginWriteAttribute("value", " value=\"", 1169, "\"", 1192, 1);
#nullable restore
#line 30 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
WriteAttributeValue("", 1177, Model.Quantity, 1177, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"UnitPrice\">Unit Price</label>\r\n            <input type=\"number\" class=\"form-control\" id=\"UnitPrice\" name=\"UnitPrice\"");
            BeginWriteAttribute("value", " value=\"", 1399, "\"", 1423, 1);
#nullable restore
#line 35 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
WriteAttributeValue("", 1407, Model.UnitPrice, 1407, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" step=\"0.01\" required />\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1549, "\"", 1589, 1);
#nullable restore
#line 39 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Edit.cshtml"
WriteAttributeValue("", 1556, Url.Action("Index", "OrderItem"), 1556, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Back</a>\r\n    </form>\r\n</div>\r\n");
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
