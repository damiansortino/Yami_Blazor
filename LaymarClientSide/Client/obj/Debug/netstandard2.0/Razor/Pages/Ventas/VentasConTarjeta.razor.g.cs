#pragma checksum "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "272ef3ecf804b621626b84f44b35da1be3c935a5"
// <auto-generated/>
#pragma warning disable 1591
namespace LaymarClientSide.Client.Pages.Ventas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client;

#line default
#line hidden
#line 7 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Shared;

#line default
#line hidden
#line 9 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Helpers;

#line default
#line hidden
#line 10 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Shared;

#line default
#line hidden
#line 11 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 12 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#line 13 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#line 14 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#line 1 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 4 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
using LaymarClientSide.Shared.Dtos;

#line default
#line hidden
#line 5 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 3 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/VentasTarjeta")]
    public partial class VentasConTarjeta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.AddMarkupContent(3, @"<h2 class=""mt-2"">
        <strong>
            <span class=""badge badge-light"">
                <strong>
                    <i class=""fas fa-credit-card text-info mr-2 px-0""></i>
                    VENTAS CON TARJETA
                </strong>
            </span>
        </strong>
    </h2>





    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "p-3 m-2 px-0");
                __builder2.AddAttribute(6, "data-spy", "scroll");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-12 row mx-0 px-0");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "input-group col-md-3 mb-3 mx-0 px-0");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, "<div class=\"input-group-prepend input-group-sm \">\r\n                    <span class=\"input-group-text \" id=\"basic-addon1\">Desde</span>\r\n                </div>\r\n                ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "date");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "value", 
#line 34 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                DateTime.Now.AddHours(-3).ToString("yyyy-MM-dd")

#line default
#line hidden
                );
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 34 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                                                                               async (ChangeEventArgs e)=> { fechaDesde = Convert.ToDateTime(e.Value.ToString()); await ListarVentas(); }

#line default
#line hidden
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "input-group mb-3 col-md-3");
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.AddMarkupContent(25, "<div class=\"input-group-prepend input-group-sm\">\r\n                    <span class=\"input-group-text\" id=\"basic-addon1\">Hasta</span>\r\n                </div>\r\n                ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "date");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "value", 
#line 40 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                DateTime.Now.AddHours(-3).ToString("yyyy-MM-dd")

#line default
#line hidden
                );
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 40 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                                                                               async (ChangeEventArgs e)=> { fechaHasta = Convert.ToDateTime(e.Value.ToString()); await ListarVentas(); }

#line default
#line hidden
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "input-group mb-3");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "input-group-prepend");
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "type", "button");
                __builder2.AddAttribute(42, "class", "btn btn-outline-secondary");
                __builder2.AddContent(43, 
#line 46 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                          criterioBusqueda == String.Empty ? "Razon Social" : criterioBusqueda

#line default
#line hidden
                );
                __builder2.AddContent(44, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.AddMarkupContent(46, @"<button type=""button"" class=""btn btn-outline-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <span class=""sr-only"">Toggle Dropdown</span>
                </button>
                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "dropdown-menu");
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "a");
                __builder2.AddAttribute(51, "class", "dropdown-item");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 51 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                         () => criterioBusqueda = "Codigo"

#line default
#line hidden
                ));
                __builder2.AddContent(53, "Codigo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenElement(55, "a");
                __builder2.AddAttribute(56, "class", "dropdown-item");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 52 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                         () => criterioBusqueda = "Razon Social"

#line default
#line hidden
                ));
                __builder2.AddContent(58, "Razon Social");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "input");
                __builder2.AddAttribute(63, "type", "text");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 56 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                                                                                   (KeyboardEventArgs e)=> {  FiltrarVenta(e); }

#line default
#line hidden
                ));
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 56 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                  cadenafiltroBusqueda

#line default
#line hidden
                ));
                __builder2.AddAttribute(67, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cadenafiltroBusqueda = __value, cadenafiltroBusqueda));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n\r\n            ");
                __builder2.OpenElement(69, "table");
                __builder2.AddAttribute(70, "class", "table table-striped mt-3");
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.AddMarkupContent(72, @"<thead class=""bg-dark text-white"">

                    <tr>
                        <th>Fecha</th>
                        <th>Código</th>
                        <th>Razon Social</th>
                        <th>Sucursal</th>
                        <th>Vendedor</th>
                        <th>Importe con Tarjeta</th>
                        <th>Importe Venta</th>
                        <th>Acciones</th>


                    </tr>
                </thead>
                ");
                __builder2.OpenElement(73, "tbody");
                __builder2.AddMarkupContent(74, "\r\n");
#line 76 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                     if (ventas.Count > 0)
                    {
                        

#line default
#line hidden
#line 78 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                         foreach (FacturaDto venta in ventasBuscadas)
                        {

#line default
#line hidden
                __builder2.AddContent(75, "                            ");
                __builder2.OpenElement(76, "tr");
                __builder2.AddMarkupContent(77, "\r\n                                ");
                __builder2.OpenElement(78, "td");
                __builder2.AddContent(79, 
#line 81 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                     venta.comprobante.fechaAlta

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                                ");
                __builder2.OpenElement(81, "td");
                __builder2.AddContent(82, 
#line 82 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                     venta.comprobante.codigo

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                ");
                __builder2.OpenElement(84, "td");
                __builder2.AddContent(85, 
#line 83 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                     venta.comprobante.personaJuridica.razonSocial

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                                ");
                __builder2.OpenElement(87, "td");
                __builder2.AddContent(88, 
#line 84 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                     venta.comprobante.sucursal.nombreSucursal

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                                ");
                __builder2.OpenElement(90, "td");
                __builder2.AddContent(91, 
#line 85 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                     venta.comprobante.UserName

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                ");
                __builder2.OpenElement(93, "td");
                __builder2.AddContent(94, "$ ");
                __builder2.AddContent(95, 
#line 86 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                       venta.comprobante.tarjeta

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n                                ");
                __builder2.OpenElement(97, "td");
                __builder2.AddContent(98, "$ ");
                __builder2.AddContent(99, 
#line 88 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                       venta.comprobante.importe

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n\r\n                                ");
                __builder2.OpenElement(101, "td");
                __builder2.OpenElement(102, "button");
                __builder2.AddAttribute(103, "class", "btn");
                __builder2.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 90 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                    async () => { await BuscarVenta(venta.comprobante.codigo); await ModalToggle(); cadenaBusqueda = Convert.ToString(venta.comprobante.codigo); }

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(105, "<i class=\"far fa-eye text-primary\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n");
#line 92 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                        }

#line default
#line hidden
#line 92 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                         

                    }

#line default
#line hidden
                __builder2.AddMarkupContent(108, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n            <div class=\"col-md-12 mx-0 row\"></div>\r\n            ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "col-md-12 mx-0 row bg-dark");
                __builder2.AddMarkupContent(113, "\r\n                ");
                __builder2.OpenElement(114, "h4");
                __builder2.AddAttribute(115, "class", "bg-dark text-white py-2 col-md-12 px-2");
                __builder2.AddMarkupContent(116, "<strong class=\"badge badge-light\">TOTAL VENDIDO CON TARJETA:</strong> ");
                __builder2.OpenElement(117, "strong");
                __builder2.AddAttribute(118, "class", "badge badge-light");
                __builder2.AddContent(119, "$ ");
                __builder2.AddContent(120, 
#line 100 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
                                                                                                                                                                              ventasBuscadas.Sum(x => x.comprobante.tarjeta)

#line default
#line hidden
                );
                __builder2.AddMarkupContent(121, " <i class=\"fas fa-credit-card text-info mr-2 px-0\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n\r\n\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 110 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Ventas\VentasConTarjeta.razor"
       
    public string cadenaBusqueda { get; set; }
    public string cadenafiltroBusqueda { get; set; } = String.Empty;
    public string criterioBusqueda { get; set; } = "Razon Social";
    public DateTime fechaDesde { get; set; } = DateTime.Now.AddHours(-3).Date;
    public DateTime fechaHasta { get; set; } = DateTime.Now.AddHours(-3).Date;
    public UserInfo user { get; set; }
    public List<FacturaDto> ventas { get; set; } = new List<FacturaDto>();
    public List<FacturaDto> ventasBuscadas { get; set; } = new List<FacturaDto>();
    public FacturaDto venta { get; set; } = new FacturaDto { comprobante = new Comprobante { personaJuridica = new Cliente(), sucursal = new Sucursal() }, detalles = new List<DetalleFactura>() };

    protected override async Task OnInitializedAsync()
    {

       


        await ListarVentas();



    }


    protected async Task ListarVentas()
    {
        ventas = await http.GetJsonAsync<List<FacturaDto>>($"/api/Comprobante/ListarVentasTarjeta/{fechaDesde.ToString("dd-MM-yyyy")}/{fechaHasta.ToString("dd-MM-yyyy")}");
        if (ventas.Count > 0)
        {
            venta = ventas.Last();
            cadenaBusqueda = Convert.ToString(venta.comprobante.codigo);
        }
        else
        {
            venta = new FacturaDto { comprobante = new Comprobante { personaJuridica = new Cliente(), sucursal = new Sucursal() }, detalles = new List<DetalleFactura>() };
            cadenaBusqueda = "";

        }
        ventasBuscadas = ventas;

    }



    protected async Task BuscarVenta(string codigo)
    {
        FacturaDto ventaEncontrada = null;
        try
        {
            ventaEncontrada = ventas.Where(x => x.comprobante.codigo == codigo).First();

        }
        catch (Exception)
        {

        }

        if (ventaEncontrada != null)
        {
            venta = ventaEncontrada;

        }
        else
        {
            cadenaBusqueda = Convert.ToString(venta.comprobante.codigo);
            await Alerta("top-end", "error", "Venta inexistente");

        }

    }




    protected void FiltrarVenta(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            if (cadenafiltroBusqueda != "" && cadenafiltroBusqueda != string.Empty)
            {
                try
                {
                    if (criterioBusqueda == "Codigo")
                    {
                        ventasBuscadas = ventas.Where(x => x.comprobante.codigo.ToString().ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }
                    if (criterioBusqueda == "Razon Social")
                    {
                        ventasBuscadas = ventas.Where(x => x.comprobante.personaJuridica.razonSocial.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }

                }
                catch (Exception)
                {


                }

            }
            else { ventasBuscadas = ventas; }
        }
    }


    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el producto con éxito")
    {
        await js.InvokeAsync<object>("alerta", posicion, icono, mensaje);
    }

    public async Task ModalToggle()
    {
        await js.InvokeAsync<object>("ModalToggle");
    }




#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
