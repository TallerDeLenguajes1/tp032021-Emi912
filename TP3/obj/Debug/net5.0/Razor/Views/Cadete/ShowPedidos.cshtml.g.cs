#pragma checksum "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f935c3e405ace26a9db9e56d85cd7c4826e84028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadete_ShowPedidos), @"mvc.1.0.view", @"/Views/Cadete/ShowPedidos.cshtml")]
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
#line 1 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\_ViewImports.cshtml"
using TP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\_ViewImports.cshtml"
using TP3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f935c3e405ace26a9db9e56d85cd7c4826e84028", @"/Views/Cadete/ShowPedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805290efd515f623b80b9e3b7371ea4fe94a1859", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadete_ShowPedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP3.Models.Cadete>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Pedidos de ");
#nullable restore
#line 8 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"
          Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nro Pedido</th>
            <th scope=""col"">Cliente</th>
            <th scope=""col"">Direccion</th>
            <th scope=""col"">Telefono</th>
            <th scope=""col"">Estado</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"
         foreach (var item in @Model.ListadoPedidos)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"
                           Write(item.NroPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"
               Write(item.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"
               Write(item.Cliente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"
               Write(item.Cliente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"
               Write(item.EstadoPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Emilio\source\repos\tp032021-Emi912\TP3\Views\Cadete\ShowPedidos.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP3.Models.Cadete> Html { get; private set; }
    }
}
#pragma warning restore 1591
