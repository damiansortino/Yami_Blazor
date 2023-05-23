// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaymarClientSide.Client.Pages.Ventas
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
#line 1 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ConsultaProductoComponent.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/ConsultaProducto")]
    public partial class ConsultaProductoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 191 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ConsultaProductoComponent.razor"
       
    public string cadenaBusqueda { get; set; }
    public string cadenafiltroBusqueda { get; set; } = String.Empty;
    public string criterioBusqueda { get; set; } = "Nombre";

    public Producto producto { get; set; } = new Producto();
    public List<Producto> productos { get; set; } = new List<Producto>();
    public List<Stock> stocks { get; set; } = new List<Stock>();
    public List<TipoMovimientoStock> tipoMovimientoStocks { get; set; } = new List<TipoMovimientoStock>();
    public List<Producto> productosBuscados { get; set; } = new List<Producto>();
    public List<MovimientoStock> movimientoStocks { get; set; } = new List<MovimientoStock>();


    protected override async Task OnInitializedAsync()
    {

        await ListarProductos();
        await ListarTipoMovimientoStock();
        if (productos.Count > 0)
        {
            cadenaBusqueda = Convert.ToString(producto.ProductoId);
        }

    }
    protected async Task ListarTipoMovimientoStock()
    {
        tipoMovimientoStocks = await http.GetJsonAsync<List<TipoMovimientoStock>>("/api/Stock/ListarTipoMovimientoStock");
    }

    protected async Task ListarProductos()
    {
        productos = await http.GetJsonAsync<List<Producto>>("/api/Producto/Listar");

    }

    protected async Task ListarStocks()
    {
        stocks = await http.GetJsonAsync<List<Stock>>("/api/Stock/Listar");

    }


    protected async Task BuscarProducto(int codigo)
    {
        Producto productoEncontrado = null;
        try
        {
            productoEncontrado = productos.Where(x => x.ProductoId == codigo).First();

        }
        catch (Exception)
        {

        }

        if (productoEncontrado != null)
        {
            producto = productoEncontrado;
            stocks = await http.GetJsonAsync<List<Stock>>($"/api/Stock/ListarPorProducto/{producto.ProductoId}");
            movimientoStocks = new List<MovimientoStock>();
            foreach (Stock stock in stocks)
            {
                movimientoStocks.AddRange(await http.GetJsonAsync<List<MovimientoStock>>($"/api/Stock/ListarMovimientoStock/{stock.StockId}"));
            }
            cadenaBusqueda = String.Empty;
        }
        else
        {
            cadenaBusqueda = Convert.ToString(producto.ProductoId);
            await Alerta("top-end", "error", "Producto inexistente");

        }

        await focusCodeBarString();
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
                        productosBuscados = productos.Where(x => x.ProductoId.ToString().ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }
                    if (criterioBusqueda == "Nombre")
                    {
                        productosBuscados = productos.Where(x => x.nombre.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }
                    if (criterioBusqueda == "Marca")
                    {
                        productosBuscados = productos.Where(x => x.marca.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }
                    if (criterioBusqueda == "Proveedor")
                    {
                        productosBuscados = productos.Where(x => x.proveedor.razonSocial.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                    }

                }
                catch (Exception)
                {


                }

            }
            else { productosBuscados = productos; }
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
    public async Task focusCodeBarString()
    {
        await js.InvokeAsync<object>("focusCodeBarString");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
