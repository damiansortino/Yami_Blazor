#pragma checksum "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Shared\InputPassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f83bfcc76d655d30546ee02481f8ca562eb5b4"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class InputPassword : InputBase<string>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "password");
            __builder.AddAttribute(2, "id", 
#line 2 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Shared\InputPassword.razor"
                                                  Id

#line default
#line hidden
            );
            __builder.AddAttribute(3, "class", 
#line 2 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Shared\InputPassword.razor"
                                                              CssClass

#line default
#line hidden
            );
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 2 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Shared\InputPassword.razor"
                               CurrentValue

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 4 "D:\GIT\Yami_Blazor\LaymarClientSide\Client\Shared\InputPassword.razor"
      
    [Parameter] public string Id { get; set; }

    protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
    {
        Console.WriteLine("value:" + value);
        result = value;
        validationErrorMessage = null;
        return true;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
