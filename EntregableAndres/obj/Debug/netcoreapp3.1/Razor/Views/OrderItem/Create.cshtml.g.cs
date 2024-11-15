#pragma checksum "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72c5549a9d9ba72c1cd937b5dbf73b5a3380b4fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderItem_Create), @"mvc.1.0.view", @"/Views/OrderItem/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c5549a9d9ba72c1cd937b5dbf73b5a3380b4fd", @"/Views/OrderItem/Create.cshtml")]
    public class Views_OrderItem_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntregableAndres.Entity.OrderItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
  
    ViewData["Title"] = "Create Order Item";
    Layout = "~/Views/Shared/_Layout.cshtml";
    // Verifica si ViewData["Products"] es null
    var products = ViewData["Products"] as IEnumerable<EntregableAndres.Entity.Product>;

    if (products == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger\">\r\n    No se pudieron cargar los productos. Intenta de nuevo más tarde.\r\n</div> ");
#nullable restore
#line 13 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-4\">\r\n    <h1>");
#nullable restore
#line 17 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

    <form asp-action=""Create"" method=""post"">
        <div class=""form-group"">
            <label for=""OrderId"">Order ID</label>
            <input type=""number"" class=""form-control"" id=""OrderId"" name=""OrderId"" required />
        </div>

        <div class=""form-group"">
            <label for=""ProductId"">Product</label>
            <select class=""form-control"" id=""ProductId"" name=""ProductId"" required>
");
#nullable restore
#line 28 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
                 if (products != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
                     foreach (var product in products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1083, "\"", 1102, 1);
#nullable restore
#line 32 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
WriteAttributeValue("", 1091, product.Id, 1091, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
                                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 33 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
        </div>

        <div class=""form-group"">
            <label for=""Quantity"">Quantity</label>
            <input type=""number"" class=""form-control"" id=""Quantity"" name=""Quantity"" required />
        </div>

        <div class=""form-group"">
            <label for=""UnitPrice"">Unit Price</label>
            <input type=""number"" class=""form-control"" id=""UnitPrice"" name=""UnitPrice"" step=""0.01"" required />
        </div>

        <button type=""submit"" class=""btn btn-primary"">Save</button>
        <a");
            BeginWriteAttribute("href", " href=\"", 1713, "\"", 1753, 1);
#nullable restore
#line 49 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\OrderItem\Create.cshtml"
WriteAttributeValue("", 1720, Url.Action("Index", "OrderItem"), 1720, 33, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntregableAndres.Entity.OrderItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
