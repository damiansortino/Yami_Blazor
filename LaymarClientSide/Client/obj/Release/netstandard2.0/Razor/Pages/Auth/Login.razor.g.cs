#pragma checksum "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6573481ae153c9eda8f23c4dc6c9c1a8ce014763"
// <auto-generated/>
#pragma warning disable 1591
namespace LaymarClientSide.Client.Pages.Auth
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
#line 7 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 8 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
using LaymarClientSide.Client.Auth;

#line default
#line hidden
#line 10 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style type=\"text/css\">\r\n    :root {\r\n        --baseColor: #606468;\r\n    }\r\n\r\n    /* helpers/align.css */\r\n\r\n    .align {\r\n        align-items: center;\r\n        display: flex;\r\n        flex-direction: column;\r\n        justify-content: center;\r\n    }\r\n\r\n    /* helpers/grid.css */\r\n\r\n    :root {\r\n        --gridMaxWidth: 20rem;\r\n        --gridWidth: 90%;\r\n    }\r\n\r\n    .grid {\r\n        margin-left: auto;\r\n        margin-right: auto;\r\n        max-width: var(--gridMaxWidth);\r\n        width: var(--gridWidth);\r\n    }\r\n\r\n    /* helpers/hidden.css */\r\n\r\n    .hidden {\r\n        border: 0;\r\n        clip: rect(0 0 0 0);\r\n        height: 1px;\r\n        margin: -1px;\r\n        overflow: hidden;\r\n        padding: 0;\r\n        position: absolute;\r\n        width: 1px;\r\n    }\r\n\r\n    /* helpers/icon.css */\r\n\r\n    :root {\r\n        --iconFill: var(--baseColor);\r\n    }\r\n\r\n\r\n\r\n    /* layout/base.css */\r\n\r\n    :root {\r\n        --htmlFontSize: 100%;\r\n        --bodyBackgroundColor: #2c3338;\r\n        --bodyColor: var(--baseColor);\r\n        --bodyFontFamily: \'Open Sans\';\r\n        --bodyFontFamilyFallback: sans-serif;\r\n        --bodyFontSize: 0.875rem;\r\n        --bodyFontWeight: 400;\r\n        --bodyLineHeight: 1.5;\r\n    }\r\n\r\n    * {\r\n        box-sizing: inherit;\r\n    }\r\n\r\n    html {\r\n        box-sizing: border-box;\r\n        font-size: var(--htmlFontSize);\r\n        height: 100%;\r\n    }\r\n\r\n    body {\r\n        background-color: var(--bodyBackgroundColor);\r\n        color: var(--bodyColor);\r\n        font-family: var(--bodyFontFamily), var(--bodyFontFamilyFallback);\r\n        font-size: var(--bodyFontSize);\r\n        font-weight: var(--bodyFontWeight);\r\n        height: 100%;\r\n        line-height: var(--bodyLineHeight);\r\n        margin: 0;\r\n        min-height: 100vh;\r\n    }\r\n\r\n    /* modules/anchor.css */\r\n\r\n    :root {\r\n        --anchorColor: #eee;\r\n    }\r\n\r\n    a {\r\n        color: var(--anchorColor);\r\n        outline: 0;\r\n        text-decoration: none;\r\n    }\r\n\r\n        a:focus,\r\n        a:hover {\r\n            text-decoration: underline;\r\n        }\r\n\r\n    /* modules/form.css */\r\n\r\n    :root {\r\n        --formFieldMargin: 0.875rem;\r\n    }\r\n\r\n    input {\r\n        background-image: none;\r\n        border: 0;\r\n        color: inherit;\r\n        font: inherit;\r\n        margin: 0;\r\n        outline: 0;\r\n        padding: 0;\r\n        transition: background-color 0.3s;\r\n    }\r\n\r\n        input[type=\'submit\'] {\r\n            cursor: pointer;\r\n        }\r\n\r\n    .form {\r\n        margin: calc(var(--formFieldMargin) * -1);\r\n    }\r\n\r\n\r\n\r\n\r\n    /* modules/login.css */\r\n\r\n    :root {\r\n        --loginBorderRadus: 0.25rem;\r\n        --loginColor: #eee;\r\n        --loginInputBackgroundColor: #3b4148;\r\n        --loginInputHoverBackgroundColor: #434a52;\r\n        --loginLabelBackgroundColor: #363b41;\r\n        --loginSubmitBackgroundColor: #0089D5;\r\n        --loginSubmitColor: #eee;\r\n        --loginSubmitHoverBackgroundColor: #0089D5;\r\n    }\r\n\r\n    .login {\r\n        color: var(--loginColor);\r\n    }\r\n\r\n        .login label,\r\n        .login input[type=\'text\'],\r\n        .login input[type=\'password\'],\r\n        .login input[type=\'submit\'] {\r\n            border-radius: var(--loginBorderRadus);\r\n            padding: 1rem;\r\n        }\r\n\r\n        .login label {\r\n            background-color: var(--loginLabelBackgroundColor);\r\n            border-bottom-right-radius: 0;\r\n            border-top-right-radius: 0;\r\n            padding-left: 1.25rem;\r\n            padding-right: 1.25rem;\r\n        }\r\n\r\n        .login input[type=\'password\'],\r\n        .login input[type=\'text\'] {\r\n            background-color: var(--loginInputBackgroundColor);\r\n            border-bottom-left-radius: 0;\r\n            border-top-left-radius: 0;\r\n        }\r\n\r\n            .login input[type=\'password\']:focus,\r\n            .login input[type=\'password\']:hover,\r\n            .login input[type=\'text\']:focus,\r\n            .login input[type=\'text\']:hover {\r\n                background-color: var(--loginInputHoverBackgroundColor);\r\n                color: white;\r\n            }\r\n\r\n        .login input[type=\'submit\'] {\r\n            background-color: var(--loginSubmitBackgroundColor);\r\n            color: var(--loginSubmitColor);\r\n            font-weight: 700;\r\n            text-transform: uppercase;\r\n        }\r\n\r\n            .login input[type=\'submit\']:focus,\r\n            .login input[type=\'submit\']:hover {\r\n                background-color: var(--loginSubmitHoverBackgroundColor);\r\n            }\r\n\r\n    /* modules/text.css */\r\n\r\n    :root {\r\n        --paragraphMarginBottom: 1.5rem;\r\n        --paragraphMarginTop: 1.5rem;\r\n    }\r\n\r\n    p {\r\n        margin-bottom: var(--paragraphMarginBottom);\r\n        margin-top: var(--paragraphMarginTop);\r\n    }\r\n\r\n    .text--center {\r\n        text-align: center;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "col-md-3 mt-4 d-flex justify-content-left btn btn-black text-black");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 218 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                                               ()=> uriHelper.NavigateTo("/ConsultarProducto")

#line default
#line hidden
            ));
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<strong><i class=\"fas fa-search mr-2 text-info\"></i>Consultar Precios</strong>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "body");
            __builder.AddAttribute(8, "class", "align");
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "grid");
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form login");
            __builder.AddMarkupContent(15, "\r\n");
#line 226 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
             if (!bandera)
            {

#line default
#line hidden
            __builder.AddContent(16, "                ");
            __builder.AddMarkupContent(17, "<div class=\"d-flex justify-content-center mb-4 pb-4\"><h1 style=\"font-size:4rem\"><strong><span class=\"text-info text-shadow: 2px 2px 2px #FFFF;\">BIENVENIDOS...</span></strong></h1></div>\r\n");
            __builder.AddContent(18, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 230 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                 userInfo

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 230 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                          PreLoginUsuario

#line default
#line hidden
            )));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "input-group mb-2 col-md-12 mt-2");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-12");
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "input-group input-group-sm mb-1 mt-1");
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.AddMarkupContent(33, "<div class=\"input-group-prepend\">\r\n                                    <span class=\"input-group-text\" id=\"inputGroup-sizing-sm\"><i class=\"icon fas fa-user\"></i></span>\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "text");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 237 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                                userInfo.username

#line default
#line hidden
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInfo.username = __value, userInfo.username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "input-group mb-2 col-md-12  mt-2");
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-md-12");
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "input-group input-group-sm mb-1 mt-1");
                __builder2.AddMarkupContent(51, "\r\n                                ");
                __builder2.AddMarkupContent(52, "<div class=\"input-group-prepend\">\r\n                                    <span class=\"input-group-text\" id=\"inputGroup-sizing-sm\"><i class=\"fas fa-key text-warning\"></i></span>\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "password");
                __builder2.AddAttribute(55, "Class", "form-control");
                __builder2.AddAttribute(56, "autocomplete", "off");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 256 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                                    userInfo.Password

#line default
#line hidden
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInfo.Password = __value, userInfo.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    ");
                __builder2.AddMarkupContent(63, "<button type=\"submit\" class=\"btn mt-4 bg-info text-white\" style=\"width:100%\"><i class=\"fas fa-sign-out-alt mr-2\"></i>INGRESAR</button>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n");
#line 274 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
            }



            else
            {
                

#line default
#line hidden
#line 280 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                 if (sucursales.Count > 0)
                {

#line default
#line hidden
            __builder.AddContent(65, "                    ");
            __builder.OpenElement(66, "div");
            __builder.AddMarkupContent(67, "\r\n\r\n                        ");
            __builder.OpenElement(68, "h4");
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.OpenElement(70, "strong");
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.OpenElement(72, "span");
            __builder.AddAttribute(73, "class", "badge badge-info pl-4");
            __builder.AddMarkupContent(74, "\r\n                                    ");
            __builder.OpenElement(75, "strong");
            __builder.AddContent(76, "HOLA, ");
            __builder.AddContent(77, 
#line 287 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                   userInfo.username

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.AddMarkupContent(82, @"<h5>
                            <strong>
                                <span class=""badge badge-light pl-4"">
                                    <strong>ELIGE UNA SUCURSAL</strong>
                                </span>
                            </strong>
                        </h5>
                        ");
            __builder.OpenElement(83, "select");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 298 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                (async (ChangeEventArgs e) => { sucursal = sucursales.Where(x => x.SucursalId == Convert.ToInt32(e.Value.ToString())).First(); await LoginUsuario(); }) 

#line default
#line hidden
            ));
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "option");
            __builder.AddAttribute(88, "selected", true);
            __builder.AddAttribute(89, "disabled", true);
            __builder.AddContent(90, "Sucursales");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#line 300 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                             foreach (Sucursal sucursal in sucursales)
                            {

#line default
#line hidden
            __builder.AddContent(92, "                                ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", 
#line 302 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                sucursal.SucursalId

#line default
#line hidden
            );
            __builder.AddContent(95, 
#line 302 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                      sucursal.nombreSucursal

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#line 303 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                            }

#line default
#line hidden
            __builder.AddContent(97, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#line 306 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"

                }
                else
                {

#line default
#line hidden
            __builder.AddContent(100, " ");
            __builder.AddMarkupContent(101, "<h4 class=\"text-info\">NO TIENES SUCURSALES HABILITADAS... PONTE EN CONTACTO CON EL ADMINISTRADOR DEL SISTEMA =(</h4>\r\n                    ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "class", "col-md-12 mt-4 d-flex justify-content-center btn btn-info");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 310 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                                                          ()=> uriHelper.NavigateTo("/")

#line default
#line hidden
            ));
            __builder.AddContent(105, "VOLVER");
            __builder.CloseElement();
#line 310 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                                                                                                          }

#line default
#line hidden
#line 310 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
                                                                                                                                                           
            }

#line default
#line hidden
            __builder.AddContent(106, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 320 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Auth\Login.razor"
       
    private UserInfo userInfo = new UserInfo();
    public List<Sucursal> sucursales { get; set; } = new List<Sucursal>();
    public Sucursal sucursal { get; set; } = new Sucursal();
    public UserEntradas ultimaEntrada { get; set; }
    public bool bandera { get; set; } = false;

    private async Task LoginUsuario()
    {
        userInfo.Email = "";
        if (userInfo.username != "" && userInfo.username != null && userInfo.Password != "" && userInfo.Password != null)
        {
            var result = await http.PostJsonAsync<UserToken>($"api/cuentas/login/{sucursal.SucursalId}", userInfo);
            await loginService.Login(result.Token);



            uriHelper.NavigateTo("/");
        }
        else
        {
            await Alerta("top-end", "error", "Usuario o contraseña Incorrectos");

        }


    }

    private async Task PreLoginUsuario()
    {
        if (userInfo.username != "" && userInfo.username != null && userInfo.Password != "" && userInfo.Password != null)
        {
            bandera = await http.PostJsonAsync<bool>($"api/Cuentas/PreLogin", userInfo);
            if (!bandera)
            {

                await Alerta("top-end", "error", "Usuario o contraseña Incorrectos");
            }
            else
            {
                sucursales = await http.GetJsonAsync<List<Sucursal>>($"/api/Cuentas/UserSucursal/{userInfo.username}");


            }
        }
        else
        {
            await Alerta("top-end", "error", "Usuario o contraseña Incorrectos");

        }

    }

    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el producto con éxito")
    {
        await js.InvokeAsync<object>("alerta", posicion, icono, mensaje);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
