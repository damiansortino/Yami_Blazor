// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaymarClientSide.Client.Shared
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
    public partial class PaginacionComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 14 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Shared\PaginacionComp.razor"
       
    [Parameter] public int PaginaActual { get; set; } = 1;
    [Parameter] public int PaginasTotales { get; set; }
    [Parameter] public int Radio { get; set; } = 3;
    [Parameter] public EventCallback<int> PaginaSeleccionada { get; set; }
    List<PaginasModel> Enlaces = new List<PaginasModel>();

    private async Task PaginaSeleccionadaInterno(PaginasModel paginaModel)
    {
        if (paginaModel.Pagina == PaginaActual)
        {
            return;
        }

        if (!paginaModel.Habilitada)
        {
            return;
        }

        await PaginaSeleccionada.InvokeAsync(paginaModel.Pagina);
    }

    protected override void OnParametersSet()
    {
        Enlaces = new List<PaginasModel>();

        var enlaceAnteriorHabilitada = PaginaActual != 1;
        var enlaceAnterior = PaginaActual - 1;
        Enlaces.Add(new PaginasModel(enlaceAnterior, enlaceAnteriorHabilitada, "Anterior"));

        for (int i = 1; i <= PaginasTotales; i++)
        {
            if (i >= PaginaActual - Radio && i <= PaginaActual + Radio)
            {
                Enlaces.Add(new PaginasModel(i) { Activa = PaginaActual == i });
            }
        }

        var enlaceSiguienteHabilitada = PaginaActual != PaginasTotales;
        var enlaceSiguiente = PaginaActual + 1;
        Enlaces.Add(new PaginasModel(enlaceSiguiente, enlaceSiguienteHabilitada, "Siguiente"));
    }


    class PaginasModel
    {

        public PaginasModel(int pagina)
            : this(pagina, true)
        { }

        public PaginasModel(int pagina, bool habilitada)
            : this(pagina, habilitada, pagina.ToString())
        { }

        public PaginasModel(int pagina, bool habilitada, string texto)
        {
            Pagina = pagina;
            Habilitada = habilitada;
            Texto = texto;
        }

        public string Texto { get; set; }
        public int Pagina { get; set; }
        public bool Habilitada { get; set; } = true;
        public bool Activa { get; set; } = false;
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
