// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Pages.Order
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/create-order")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Order\Create.razor"
       

    [Inject]
    IBasketService basketService { get; set; }

    [Inject]
    IIdentityService identityService { get; set; }

    [Inject]
    IOrderService orderService { get; set; }

    [Inject]
    NavigationManager navigationManager { get; set; }

    [Inject]
    AppStateManager appState { get; set; }

    Order orderModel = new Order()
    {
        CardExpirationShort = "10/24",
        CardHolderName = "Salih Cantekin",
        CardNumber = "1234123412341234",
        CardSecurityNumber = "123",
        CardTypeId = 1,
        City = "İstanbul",
        Description = "Test Desc",
        Street = "Test Street",
        Country = "Turkey"
    };


    async Task OnValidSubmit()
    {
        orderModel.Buyer = identityService.GetUserName();
        var basketDto = orderService.MapOrderToBasket(orderModel);

        await basketService.Checkout(basketDto);

        appState.UpdateCart(this);

        navigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
