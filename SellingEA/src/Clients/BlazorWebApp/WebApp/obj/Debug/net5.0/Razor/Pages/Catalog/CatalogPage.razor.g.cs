#pragma checksum "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Catalog\CatalogPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a46dd2546fddb9a08a8bb91fc17bf0e28a14e5"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages.Catalog
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/catalog")]
    public partial class CatalogPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
#nullable restore
#line 6 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Catalog\CatalogPage.razor"
     if (model.Data != null && model.Data.Any())
	{
		foreach(var catalogItem in model.Data)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WebApp.Components.Catalog.ProductView.ProductView>(2);
            __builder.AddAttribute(3, "CatalogItem", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApp.Domain.Models.CatalogModels.CatalogItem>(
#nullable restore
#line 10 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Catalog\CatalogPage.razor"
                                                                            catalogItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Catalog\CatalogPage.razor"
                                                                                                  ()=>AddToCart(catalogItem)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Catalog\CatalogPage.razor"
		}
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Catalog\CatalogPage.razor"
       


	PaginatedItemsViewModel<CatalogItem> model = new PaginatedItemsViewModel<CatalogItem>();

	[Inject]
	ICatalogService catalogService { get; set; }

	[Inject]
	IIdentityService identityService { get; set; }

	[Inject]
    public IBasketService basketService { get; set; }

	[Inject]
    NavigationManager navigationManager { get; set; }

	[Inject]
    AppStateManager appState { get; set; }

	protected async override Task OnInitializedAsync()
	{
		model = await catalogService.GetCatalogItems();
	}


	public async Task AddToCart(CatalogItem catalogItem)
	{
		if (!identityService.IsLoggedIn)
        {
            //navigationManager.NavigateTo("login", true);
            navigationManager.NavigateTo($"login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
            return;
        }

        await basketService.AddItemToBasket(catalogItem.Id);
        appState.UpdateCart(this);
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591