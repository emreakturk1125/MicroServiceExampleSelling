#pragma checksum "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "022956f2ee5f9a0edf816095f5cee71b16747764"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Application.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Domain.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Domain.Models.CatalogModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using WebApp.Application.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using WebApp.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\_Imports.razor"
using Infrastructure;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 5 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591