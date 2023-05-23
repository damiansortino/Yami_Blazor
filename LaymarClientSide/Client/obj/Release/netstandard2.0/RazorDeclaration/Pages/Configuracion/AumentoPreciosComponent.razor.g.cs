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
