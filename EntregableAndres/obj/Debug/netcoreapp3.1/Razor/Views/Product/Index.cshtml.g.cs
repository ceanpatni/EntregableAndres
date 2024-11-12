#pragma checksum "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c72f88805edd8297272500616c72af6405d5e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c72f88805edd8297272500616c72af6405d5e6", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntregableAndres.Entity.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Listado de Productos";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var errorMessage = TempData["ErrorMessage"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
 if (!string.IsNullOrEmpty(errorMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        ");
#nullable restore
#line 12 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
   Write(errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>");
#nullable restore
#line 13 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 14 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<!-- Enlace para crear un nuevo producto -->\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 428, "\"", 467, 1);
#nullable restore
#line 18 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
WriteAttributeValue("", 435, Url.Action("Create", "Product"), 435, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Nuevo Producto</a>
</p>

<!-- Tabla para mostrar los productos -->
<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nombre</th>
            <th>Acciones</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
               Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <!-- Enlace para ver los detalles del producto -->\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1019, "\"", 1084, 1);
#nullable restore
#line 38 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
WriteAttributeValue("", 1026, Url.Action("Details", "Product", new { id = product.Id }), 1026, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Detalles</a>\r\n\r\n                    <!-- Enlace para editar el producto -->\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1268, 1);
#nullable restore
#line 41 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
WriteAttributeValue("", 1213, Url.Action("Edit", "Product", new { id = product.Id }), 1213, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Editar</a>\r\n\r\n                    <!-- Formulario para eliminar el producto -->\r\n                    <form");
            BeginWriteAttribute("action", " action=\"", 1400, "\"", 1466, 1);
#nullable restore
#line 44 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
WriteAttributeValue("", 1409, Url.Action("Delete", "Product", new { id = product.Id }), 1409, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" method=""post"" style=""display:inline;"">
                        <button type=""submit"" class=""btn btn-danger"" onclick=""return confirm('¿Estás seguro de eliminar este producto?')"">Eliminar</button>
                    </form>
                </td>
            </tr>
");
#nullable restore
#line 49 "C:\Users\cesar\source\repos\EntregableAndres\EntregableAndres\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntregableAndres.Entity.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
