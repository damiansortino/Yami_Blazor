#pragma checksum "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Configuracion\TipoMovimientoCajaComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be72e4e30fd00601e9e66e418d5a4c806b195c61"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaymarClientSide.Client.Pages.Configuracion
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client;

#line default
#line hidden
#line 7 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 9 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Helpers;

#line default
#line hidden
#line 10 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Shared;

#line default
#line hidden
#line 11 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 12 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#line 13 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#line 14 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#line 1 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Configuracion\TipoMovimientoCajaComponent.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 5 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Configuracion\TipoMovimientoCajaComponent.razor"
           [Authorize(Roles = "Configuracion, Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/tipoMovimientoCaja")]
    public partial class TipoMovimientoCajaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 197 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Configuracion\TipoMovimientoCajaComponent.razor"
       
    public bool valido { get; set; } = true;
    public string cadenaBusqueda { get; set; }
    public string cadenafiltroBusqueda { get; set; } = String.Empty;
    public string criterioBusqueda { get; set; } = "Nombre";

    public string AccionSobreTipoMovimientoCaja { get; set; } = "Detalles";
    public TipoMovimientoCaja tipoMovimientoCaja { get; set; } = new TipoMovimientoCaja();
    public List<TipoMovimientoCaja> tipoMovimientosStock { get; set; } = new List<TipoMovimientoCaja>();
    public List<TipoMovimientoCaja> tipoMovimientosStockBuscados { get; set; } = new List<TipoMovimientoCaja>();



    protected override async Task OnInitializedAsync()
    {


        await ListarTipoMovimientosStock();
        if (tipoMovimientosStock.Count > 0)
        {
            tipoMovimientoCaja = tipoMovimientosStock.Last();
            cadenaBusqueda = Convert.ToString(tipoMovimientoCaja.TipoMovimientoCajaId);
        }

    }
    protected async Task ListarTipoMovimientosStock()
    {
        tipoMovimientosStock = await http.GetJsonAsync<List<TipoMovimientoCaja>>("/api/TipoMovimientoCaja/Listar");
    }

    protected async Task BuscarTipoMovimientoCaja(string codigo)
    {
        TipoMovimientoCaja tipoMovimientoCajaEncontrado = null;
        AccionSobreTipoMovimientoCaja = "Detalles";
        try
        {
            tipoMovimientoCajaEncontrado = tipoMovimientosStock.Where(x => x.TipoMovimientoCajaId == Convert.ToInt32(codigo)).First();

        }
        catch (Exception)
        {

        }

        if (tipoMovimientoCajaEncontrado != null)
        {
            tipoMovimientoCaja = tipoMovimientoCajaEncontrado;
            valido = true;
        }
        else
        {
            cadenaBusqueda = Convert.ToString(tipoMovimientoCaja.TipoMovimientoCajaId);
            await Alerta("top-end", "error", "TipoMovimientoCaja inexistente");

        }
        await DeshabilitarFormulario();

    }

    protected async Task GuardarTipoMovimientoCaja()
    {
        

#line default
#line hidden
#line 258 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Configuracion\TipoMovimientoCajaComponent.razor"
         if (AccionSobreTipoMovimientoCaja == "Crear")
        {
            await http.PostJsonAsync("/api/TipoMovimientoCaja/Crear", tipoMovimientoCaja);
            await DeshabilitarFormulario();

            await Alerta("top-end", "success", "Se creó con éxito");
            cadenaBusqueda = Convert.ToString(tipoMovimientoCaja.TipoMovimientoCajaId);

        }

#line default
#line hidden
#line 266 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Configuracion\TipoMovimientoCajaComponent.razor"
         

        AccionSobreTipoMovimientoCaja = "Detalle";

        await ListarTipoMovimientosStock();
    }

    protected async Task CrearTipoMovimientoCaja()
    {
        AccionSobreTipoMovimientoCaja = "Crear";
        tipoMovimientoCaja = new TipoMovimientoCaja();

        valido = false;
        await HabilitarFormulario();

    }


    protected void FiltrarTipoMovimientoCaja(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            if (cadenafiltroBusqueda != "" && cadenafiltroBusqueda != string.Empty)
            {

                if (criterioBusqueda == "Nombre")
                {
                    tipoMovimientosStockBuscados = tipoMovimientosStock.Where(x => x.nombreTipoMovimientoCaja.Contains(cadenafiltroBusqueda)).ToList();
                }
                if (criterioBusqueda == "Codigo")
                {
                    tipoMovimientosStockBuscados = tipoMovimientosStock.Where(x => x.TipoMovimientoCajaId.ToString().Contains(cadenafiltroBusqueda)).ToList();
                }
            }
            else { tipoMovimientosStockBuscados = tipoMovimientosStock; }
        }
    }
    public async Task HabilitarFormulario()
    {
        await js.InvokeAsync<object>("EnabledFieldFormulario");
    }
    public async Task DeshabilitarFormulario()
    {
        await js.InvokeAsync<object>("DisabledFieldFormulario");
    }

    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el tipoMovimientoCaja con éxito")
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
