#pragma checksum "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "407ed2f5a320fa6fc56f2385691764ec9eca8efe"
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
    public partial class ListadoGenerico<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 42 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
 
    [Parameter] public List<T> listado { get; set; }
    [Parameter]

    public RenderFragment HayRegistros { get; set; }
    [Parameter]
    public RenderFragment NoHayRegistros { get; set; }


#line default
#line hidden
    }
}
#pragma warning restore 1591
