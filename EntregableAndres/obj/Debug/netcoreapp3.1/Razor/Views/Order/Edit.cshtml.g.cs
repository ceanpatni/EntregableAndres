#pragma checksum "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e887308b3831382f228d98a4c03ef446025831c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Edit), @"mvc.1.0.view", @"/Views/Order/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e887308b3831382f228d98a4c03ef446025831c8", @"/Views/Order/Edit.cshtml")]
    public class Views_Order_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntregableAndres.Entity.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Edit.cshtml"
  
    ViewData["Title"] = "Edit Order";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Order</h1>\r\n\r\n<form asp-action=\"Edit\" method=\"post\">\r\n\r\n    <!-- Campo oculto para el Id del producto -->\r\n    <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 285, "\"", 302, 1);
#nullable restore
#line 13 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Edit.cshtml"
WriteAttributeValue("", 293, Model.Id, 293, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <!-- Campo para el nombre del producto -->\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Name</label>\r\n        <input type=\"text\" name=\"Name\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 489, "\"", 513, 1);
#nullable restore
#line 18 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Edit.cshtml"
WriteAttributeValue("", 497, Model.OrderDate, 497, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <span asp-validation-for=\"Name\" class=\"text-danger\"></span>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label asp-for=\"TotalAmount\" class=\"control-label\"></label>\r\n        <input type=\"text\" name=\"TotalAmount\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 767, "\"", 793, 1);
#nullable restore
#line 24 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Edit.cshtml"
WriteAttributeValue("", 775, Model.TotalAmount, 775, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label asp-for=\"CustomerId\" class=\"control-label\"></label>\r\n        <input type=\"text\" name=\"CustomerId\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 976, "\"", 1001, 1);
#nullable restore
#line 29 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Edit.cshtml"
WriteAttributeValue("", 984, Model.CustomerId, 984, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-warning\">Save Changes</button>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1100, "\"", 1136, 1);
#nullable restore
#line 33 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Order\Edit.cshtml"
WriteAttributeValue("", 1107, Url.Action("Index", "Order"), 1107, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Cancel</a>\r\n</form>\r\n");
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
