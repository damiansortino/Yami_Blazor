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
#line 1 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ClienteComponent.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 5 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ClienteComponent.razor"
           [Authorize(Roles = "Ventas, Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/cliente")]
    public partial class ClienteComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 286 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ClienteComponent.razor"
       
    public bool valido { get; set; } = true;
    public string cadenaBusqueda { get; set; }
    public string cadenafiltroBusqueda { get; set; } = String.Empty;
    public string criterioBusqueda { get; set; } = "Razon Social";

    public string AccionSobreCliente { get; set; } = "Detalles";
    public Cliente cliente { get; set; } = new Cliente();
    public List<Cliente> clientes { get; set; } = new List<Cliente>();
    public List<Cliente> clientesBuscados { get; set; } = new List<Cliente>();



    protected override async Task OnInitializedAsync()
    {

        await ListarClientes();

    }
    protected async Task ListarClientes()
    {
        clientes = await http.GetJsonAsync<List<Cliente>>("/api/Cliente/Listar");
        if (clientes.Count > 0)
        {
            cliente = clientes.Last();
            cadenaBusqueda = cliente.ClienteId;
        }
        else
        {
            cliente = new Cliente();
        }
    }

    protected async Task BuscarCliente(string codigo)
    {
        Cliente clienteEncontrado = null;
        AccionSobreCliente = "Detalles";
        try
        {
            clienteEncontrado = clientes.Where(x => x.ClienteId == codigo).First();

        }
        catch (Exception)
        {

        }

        if (clienteEncontrado != null)
        {
            cliente = clienteEncontrado;
            if (cliente.fechaBaja != null)
            {
                valido = false;
            }
            else { valido = true; }
        }
        else
        {
            cadenaBusqueda = cliente.ClienteId;
            await Alerta("top-end", "error", "Cliente inexistente");

        }
        await DeshabilitarFormulario();

    }

    protected async Task GuardarCliente()
    {
        

#line default
#line hidden
#line 354 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ClienteComponent.razor"
         if (AccionSobreCliente == "Crear")
        {
            await http.PostJsonAsync("/api/Cliente/Crear", cliente);
            await DeshabilitarFormulario();

            await Alerta("top-end", "success", "Se creó con éxito");
            cadenaBusqueda = cliente.ClienteId;

        }

#line default
#line hidden
#line 363 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ClienteComponent.razor"
         if (AccionSobreCliente == "Editar")
        {

            await http.PutJsonAsync($"/api/Cliente/Editar/{cliente.PersonaJuridicaId}", cliente);
            await DeshabilitarFormulario();
            await Alerta("top-end", "success", "Se editó con éxito");

        }

#line default
#line hidden
#line 370 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Pages\Ventas\ClienteComponent.razor"
         
        AccionSobreCliente = "Detalle";
        AccionSobreCliente = "Detalle";
        await ListarClientes();
    }

    protected async Task CrearCliente()
    {
        AccionSobreCliente = "Crear";
        cliente = new Cliente();
        if (clientes.Count > 0)
        {
            cliente.ClienteId = Convert.ToString(Convert.ToInt32(clientes.Last().ClienteId) + 1);

        }
        else
        {
            cliente.ClienteId = "1";

        }
        valido = false;
        await HabilitarFormulario();

    }
    protected async Task AnularCliente()
    {
        await http.DeleteAsync($"/api/Cliente/Anular/{cliente.PersonaJuridicaId}");
        await ListarClientes();
    }

    protected void FiltrarCliente(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            if (cadenafiltroBusqueda != "" && cadenafiltroBusqueda != string.Empty)
            {
                if (criterioBusqueda == "Razon Social")
                {
                    clientesBuscados = clientes.Where(x => x.razonSocial.ToLower().Contains(cadenafiltroBusqueda.ToLower())).ToList();
                }
                if (criterioBusqueda == "Cuit")
                {
                    clientesBuscados = clientes.Where(x => x.cuit.Contains(cadenafiltroBusqueda)).ToList();
                }
                if (criterioBusqueda == "Codigo")
                {
                    clientesBuscados = clientes.Where(x => x.ClienteId.Contains(cadenafiltroBusqueda)).ToList();
                }
            }
            else { clientesBuscados = clientes; }
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

    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el cliente con éxito")
    {
        await js.InvokeAsync<object>("alerta", posicion, icono, mensaje);
    }

    public async Task ModalToggle()
    {
        await js.InvokeAsync<object>("ModalToggle");
    }

    public async Task ModalConfirmToggle()
    {
        await js.InvokeAsync<object>("ModalConfirmToggle");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
