#pragma checksum "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6e29afc8ac138d624bbfb1c4044a243f7ca812"
// <auto-generated/>
#pragma warning disable 1591
namespace LaymarClientSide.Client.Pages.Configuracion
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client;

#line default
#line hidden
#line 7 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Shared;

#line default
#line hidden
#line 8 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 9 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Helpers;

#line default
#line hidden
#line 10 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Shared;

#line default
#line hidden
#line 11 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 12 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#line 13 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#line 14 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#line 1 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 2 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
           [Authorize(Roles = "Admin, Configuracion")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/AumentoDePrecios")]
    public partial class AumentoPreciosComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"mt-2\">\r\n    <strong>\r\n        <span class=\"badge badge-light\">\r\n            <strong>AUMENTO DE PRECIOS</strong>\r\n        </span>\r\n    </strong>\r\n</h2>");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group mb-2 col-md-6 mt-2 px-0");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "input-group input-group-sm mb-1 mt-1");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\" id=\"inputGroup-sizing-sm\">Aumento porcentual de rentabilidad</span>\r\n        </div>\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "number");
            __builder.AddAttribute(10, "step", "0.01");
            __builder.AddAttribute(11, "class", "form-control ");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 20 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                             aumentoPorcentualRentabilidad

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => aumentoPorcentualRentabilidad = __value, aumentoPorcentualRentabilidad, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "input-group mb-3");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "input-group-prepend");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "btn btn-outline-secondary");
            __builder.AddContent(26, 
#line 27 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                  criterioBusqueda == String.Empty ? "Nombre" : criterioBusqueda

#line default
#line hidden
            );
            __builder.AddContent(27, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<button type=\"button\" class=\"btn btn-outline-secondary dropdown-toggle dropdown-toggle-split\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n            <span class=\"sr-only\">Toggle Dropdown</span>\r\n        </button>\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "dropdown-menu");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "dropdown-item");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 32 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                 () => criterioBusqueda = "Codigo"

#line default
#line hidden
            ));
            __builder.AddContent(36, "Codigo");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "dropdown-item");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 33 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                 () => criterioBusqueda = "Nombre"

#line default
#line hidden
            ));
            __builder.AddContent(41, "Nombre");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "dropdown-item");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 34 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                 () => criterioBusqueda = "Proveedor"

#line default
#line hidden
            ));
            __builder.AddContent(46, "Proveedor");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "text");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 39 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                                           (KeyboardEventArgs e) => { FiltrarProducto(e); }

#line default
#line hidden
            ));
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 39 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                          cadenafiltroBusqueda

#line default
#line hidden
            ));
            __builder.AddAttribute(55, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cadenafiltroBusqueda = __value, cadenafiltroBusqueda));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.OpenElement(58, "table");
            __builder.AddAttribute(59, "class", "table table-sm");
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.AddMarkupContent(61, @"<thead>
        <tr class=""bg-dark text-white"">
            <th>Código</th>
            <th>Nombre/Talle/Color/Marca</th>
            <th>Proveedor</th>
            <th>P. Costo</th>
            <th>% Rentabilidad</th>
            <th>P. Venta</th>
            <th>Acciones</th>

        </tr>

    </thead>
    ");
            __builder.OpenElement(62, "tbody");
            __builder.AddMarkupContent(63, "\r\n\r\n");
#line 59 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
         foreach (Producto producto in productosFiltrados)
        {


#line default
#line hidden
            __builder.AddContent(64, "            ");
            __builder.OpenElement(65, "tr");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#line 63 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                     producto.ProductoId

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "td");
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "h5");
            __builder.AddAttribute(73, "class", "mt-1");
            __builder.AddMarkupContent(74, "\r\n\r\n                        ");
            __builder.OpenElement(75, "span");
            __builder.AddAttribute(76, "class", "badge badge-light text-center");
            __builder.AddContent(77, 
#line 67 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                     producto.nombre

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "span");
            __builder.AddAttribute(80, "class", "badge badge-light text-center");
            __builder.AddContent(81, 
#line 68 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                     producto.talle

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n                        ");
            __builder.OpenElement(83, "span");
            __builder.AddAttribute(84, "class", "badge badge-light text-center");
            __builder.AddContent(85, " ");
            __builder.AddContent(86, 
#line 70 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                      producto.color

#line default
#line hidden
            );
            __builder.AddContent(87, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.OpenElement(89, "span");
            __builder.AddAttribute(90, "class", "badge badge-light text-center");
            __builder.AddContent(91, " ");
            __builder.AddContent(92, 
#line 71 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                      producto.marca

#line default
#line hidden
            );
            __builder.AddContent(93, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "td");
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "span");
            __builder.AddAttribute(100, "class", "badge badge-light text-center");
            __builder.AddContent(101, " ");
            __builder.AddContent(102, 
#line 75 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                  producto.proveedor.razonSocial

#line default
#line hidden
            );
            __builder.AddContent(103, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "td");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "type", "number");
            __builder.AddAttribute(109, "class", "form-control col-md-8");
            __builder.AddAttribute(110, "style", "height:1.5rem");
            __builder.AddAttribute(111, "step", "0.01");
            __builder.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 77 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                                       producto.precioUnitario

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.precioUnitario = __value, producto.precioUnitario, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                ");
            __builder.OpenElement(115, "td");
            __builder.AddMarkupContent(116, "\r\n                    ");
            __builder.OpenElement(117, "h5");
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.OpenElement(119, "span");
            __builder.AddAttribute(120, "class", "badge badge-light ");
            __builder.AddContent(121, 
#line 80 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                           producto.porcentajeRentabilidad

#line default
#line hidden
            );
            __builder.AddContent(122, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#line 81 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                         if (aumentoPorcentualRentabilidad != 0 && aumentoPorcentualRentabilidad != 0.00)
                        {

#line default
#line hidden
            __builder.AddMarkupContent(124, "                            <i class=\"fas fa-arrow-right mx-2\"></i> ");
            __builder.OpenElement(125, "span");
            __builder.AddAttribute(126, "class", "badge badge-info mr-2");
            __builder.AddContent(127, 
#line 83 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                          producto.porcentajeRentabilidad + aumentoPorcentualRentabilidad

#line default
#line hidden
            );
            __builder.AddContent(128, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#line 84 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"

                        }

#line default
#line hidden
            __builder.AddContent(130, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                ");
            __builder.OpenElement(133, "td");
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.OpenElement(135, "h5");
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.OpenElement(137, "span");
            __builder.AddAttribute(138, "class", "badge badge-light ");
            __builder.AddContent(139, "$ ");
            __builder.AddContent(140, 
#line 90 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                             producto.precioUnitario * (producto.porcentajeRentabilidad / 100 + 1)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n");
#line 91 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                         if (aumentoPorcentualRentabilidad != 0 && aumentoPorcentualRentabilidad != 0.00)
                        {

#line default
#line hidden
            __builder.AddMarkupContent(142, "                            <i class=\"fas fa-arrow-right mx-2\"></i>");
            __builder.OpenElement(143, "span");
            __builder.AddAttribute(144, "class", "badge badge-info mr-2");
            __builder.AddContent(145, "$ ");
            __builder.AddContent(146, 
#line 93 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                           producto.precioUnitario * ((producto.porcentajeRentabilidad + aumentoPorcentualRentabilidad) / 100 + 1)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n");
#line 94 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                        }

#line default
#line hidden
            __builder.AddContent(148, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                ");
            __builder.OpenElement(151, "th");
            __builder.AddMarkupContent(152, "\r\n                    ");
            __builder.OpenElement(153, "button");
            __builder.AddAttribute(154, "class", "btn text-danger  border border-solid rounded");
            __builder.AddAttribute(155, "title", "Eliminar");
            __builder.AddAttribute(156, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 98 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                            (() => productosFiltrados.Remove(producto))

#line default
#line hidden
            ));
            __builder.AddMarkupContent(157, "<i class=\"far fa-trash-alt text-danger\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n");
#line 102 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
        }

#line default
#line hidden
            __builder.AddContent(161, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n\r\n");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "col-md-12 mx-0 row");
            __builder.AddMarkupContent(166, "\r\n\r\n    ");
            __builder.OpenElement(167, "button");
            __builder.AddAttribute(168, "class", "btn btn-success col-md-12 mx-0 row");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 108 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                  ModalConfirmToggle

#line default
#line hidden
            ));
            __builder.AddContent(170, "Guardar modificaciones");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "col-md-12 d-flex justify-content-end mt-3");
            __builder.AddMarkupContent(175, "\r\n    ");
            __builder.OpenElement(176, "button");
            __builder.AddAttribute(177, "class", "btn btn-info");
            __builder.AddAttribute(178, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 111 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                           DescargarListaPrecios

#line default
#line hidden
            ));
            __builder.AddMarkupContent(179, " <i class=\"fas fa-file-excel mr-2\"></i>  Descargar Lista Precios");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n\r\n");
            __builder.OpenElement(182, "div");
            __builder.AddAttribute(183, "class", "modal p-0 fade");
            __builder.AddAttribute(184, "id", "modalConfirm");
            __builder.AddAttribute(185, "data-backdrop", "static");
            __builder.AddAttribute(186, "tabindex", "-1");
            __builder.AddAttribute(187, "role", "dialog");
            __builder.AddMarkupContent(188, "\r\n    ");
            __builder.OpenElement(189, "div");
            __builder.AddAttribute(190, "class", "modal-dialog ");
            __builder.AddAttribute(191, "role", "document");
            __builder.AddMarkupContent(192, "\r\n        ");
            __builder.OpenElement(193, "div");
            __builder.AddAttribute(194, "class", "modal-content");
            __builder.AddMarkupContent(195, "\r\n            ");
            __builder.OpenElement(196, "div");
            __builder.AddAttribute(197, "class", "modal-header");
            __builder.AddMarkupContent(198, "\r\n                ");
            __builder.AddMarkupContent(199, "<h5 class=\"modal-title\">CONFIRMAR</h5>\r\n                ");
            __builder.OpenElement(200, "button");
            __builder.AddAttribute(201, "type", "button");
            __builder.AddAttribute(202, "class", "close");
            __builder.AddAttribute(203, "data-dismiss", "modal");
            __builder.AddAttribute(204, "aria-label", "Close");
            __builder.AddAttribute(205, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 119 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                      (async () => { await ModalConfirmToggle(); })

#line default
#line hidden
            ));
            __builder.AddMarkupContent(206, "\r\n                    ");
            __builder.AddMarkupContent(207, "<span aria-hidden=\"true\">&times;</span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n            ");
            __builder.OpenElement(210, "div");
            __builder.AddAttribute(211, "class", "modal-body p-3 m-2");
            __builder.AddAttribute(212, "data-spy", "scroll");
            __builder.AddMarkupContent(213, "\r\n\r\n                ");
            __builder.AddMarkupContent(214, "<p><strong>¿Desea guardar las modicaciones?</strong></p>\r\n                ");
            __builder.OpenElement(215, "div");
            __builder.AddAttribute(216, "class", "col-md-12 d-flex justify-content-center mt-4");
            __builder.AddContent(217, " ");
            __builder.OpenElement(218, "button");
            __builder.AddAttribute(219, "class", "btn btn-success col-md-4");
            __builder.AddAttribute(220, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 127 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                                                async () => {await EditarPrecios(); await ModalConfirmToggle(); }

#line default
#line hidden
            ));
            __builder.AddContent(221, "OK");
            __builder.CloseElement();
            __builder.OpenElement(222, "button");
            __builder.AddAttribute(223, "class", "btn btn-light ml-2 col-md-4");
            __builder.AddAttribute(224, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 127 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
                                                                                                                                                                                                                                                                      ModalConfirmToggle

#line default
#line hidden
            ));
            __builder.AddContent(225, "CANCELAR");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(227, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(228, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(229, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 134 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Configuracion\AumentoPreciosComponent.razor"
       
    List<Producto> productos = new List<Producto>();
    List<Producto> productosFiltrados = new List<Producto>();
    public string criterioBusqueda { get; set; } = "Nombre";
    public string cadenafiltroBusqueda { get; set; } = String.Empty;
    public double aumentoPorcentualRentabilidad { get; set; }


    protected override async Task OnInitializedAsync()
    {

        await ListarProductos();
    }
    protected async Task ListarProductos()
    {

        productos = await http.GetJsonAsync<List<Producto>>("/api/Producto/Listar");
        productosFiltrados = productos;

    }

    protected void FiltrarProducto(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            if (cadenafiltroBusqueda != "" && cadenafiltroBusqueda != string.Empty)
            {
                try
                {
                    if (criterioBusqueda == "Codigo")
                    {
                        productosFiltrados = productos.Where(x => x.ProductoId.ToString().ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }
                    if (criterioBusqueda == "Nombre")
                    {
                        productosFiltrados = productos.Where(x => x.nombre.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }
                    if (criterioBusqueda == "Marca")
                    {
                        productosFiltrados = productos.Where(x => x.marca.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }
                    if (criterioBusqueda == "Proveedor")
                    {
                        productosFiltrados = productos.Where(x => x.proveedor.razonSocial.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }

                }
                catch (Exception)
                {


                }

            }
            else { productosFiltrados = productos; }
        }
    }

    protected async Task EditarPrecios()
    {

        foreach (Producto producto in productosFiltrados)
        {

            producto.porcentajeRentabilidad += aumentoPorcentualRentabilidad;

        }

        await http.PostJsonAsync("api/Producto/EditarPrecios", productosFiltrados);
        await ListarProductos();
        aumentoPorcentualRentabilidad = 0.00;
        cadenafiltroBusqueda = String.Empty;
        await Alerta("top-end", "success", "Se realizaron las modificaciones con éxito");
    }

    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el comprobante con éxito")
    {
        await js.InvokeAsync<object>("alerta", posicion, icono, mensaje);
    }

    public async Task ModalConfirmToggle()
    {
        await js.InvokeAsync<object>("ModalConfirmToggle");
    }


    protected async void DescargarListaPrecios()
    {

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add($"LISTA DE PRECIOS");

            // Use LINQ to project data into the worksheet
            worksheet.DefaultColWidth = 24;
            worksheet.DefaultRowHeight = 13.2;
           
            worksheet.Cells["A1:J100"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells["A1:J100"].Style.Fill.BackgroundColor.SetColor(Color.White);
        

            var encabezado = worksheet.Cells[1, 1, 2, 6];
            encabezado.Style.Font.Bold = true;
            encabezado.Merge = true;
            encabezado.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            encabezado.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            encabezado.Style.Font.Size = 18;
            encabezado.Value = $"LISTA DE PRECIOS - {DateTime.Now.AddHours(-3)}";

            var tableBody = worksheet.Cells[$"A4:F{4 + productosFiltrados.Count}"];
            tableBody.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            tableBody.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            tableBody.Style.Fill.PatternType = ExcelFillStyle.Solid;
            tableBody.Style.Fill.BackgroundColor.SetColor(Color.White);
            tableBody.Style.Font.Color.SetColor(Color.Black);



            var header = worksheet.Cells["A4:F4"];
            worksheet.Cells["A4"].Value = "CODIGO";
            worksheet.Cells["B4"].Value = "NOMBRE";
            worksheet.Cells["C4"].Value = "TALLE";
            worksheet.Cells["D4"].Value = "MARCA";
            worksheet.Cells["E4"].Value = "PROVEEDOR";
            worksheet.Cells["F4"].Value = "PRECIO VENTA";
            header.Style.Font.Bold = true;
            header.Style.Font.Color.SetColor(Color.Black);
            header.Style.Font.Bold = true;
            header.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            header.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            header.Style.Fill.PatternType = ExcelFillStyle.Solid;
            header.Style.Fill.BackgroundColor.SetColor(Color.AliceBlue);


            for (int i = 0; i < productosFiltrados.Count; i++)

            {
                worksheet.Cells[$"A{5 + i}"].Value = productosFiltrados[i].codigo;
                worksheet.Cells[$"B{5 + i}"].Value = productosFiltrados[i].nombre;
                worksheet.Cells[$"C{5 + i}"].Value = productosFiltrados[i].talle;
                worksheet.Cells[$"D{5 + i}"].Value = productosFiltrados[i].marca;
                worksheet.Cells[$"E{5 + i}"].Value = productosFiltrados[i].proveedor.razonSocial;
                worksheet.Cells[$"F{5 + i}"].Value = productosFiltrados[i].precioUnitario * (productosFiltrados[i].porcentajeRentabilidad / 100 + 1);

            }




            worksheet.Column(6).Style.Numberformat.Format = "$#,##0.00";
            worksheet.Column(7).Style.Numberformat.Format = "0.00%";
            worksheet.Column(8).Style.Font.Size = 24;




            await js.InvokeAsync<object>("saveAsFile", $"Lista de precios.xlsx", package.GetAsByteArray());

        }

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
