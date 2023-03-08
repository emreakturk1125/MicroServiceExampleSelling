#pragma checksum "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe623cb048a913c8327486d45cbdbd6c1615479"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages.BasketPages
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
#nullable restore
#line 4 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
using WebApp.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/basket")]
    public partial class Basket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8 cart");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "title");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "<div class=\"col\"><h4><b>Shopping Cart</b></h4></div>\n\t\t\t\t\t");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col align-self-center text-right text-muted");
#nullable restore
#line 15 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
__builder.AddContent(13, basketModel.Items.Count);

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, " items");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
             if (basketModel.Items.Any())
			{
				foreach (var basketItem in basketModel.Items)
				{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row border-top border-bottom");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row main align-items-center");
#nullable restore
#line 25 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
                              
								string pictureUrl = "http://localhost:5004/" + basketItem.PictureUrl; 
							

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-2");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "class", "img-fluid");
            __builder.AddAttribute(23, "src", 
#nullable restore
#line 28 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
                                                                            pictureUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n\t\t\t\t\t\t\t");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row text-muted");
#nullable restore
#line 30 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
__builder.AddContent(29, basketItem.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\t\t\t\t\t\t\t");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "#");
            __builder.AddAttribute(35, "class", "border");
#nullable restore
#line 32 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
__builder.AddContent(36, basketItem.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\t\t\t\t\t\t\t");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col");
            __builder.AddMarkupContent(40, "\n\t\t\t\t\t\t\t\t$ ");
#nullable restore
#line 34 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
__builder.AddContent(41, basketItem.UnitPrice.ToString("N2"));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
                                                  async()=> await RemoveItemFromList(basketItem)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "<button type=\"button\" class=\"close\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
				}
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<div class=\"back-to-shop\"><a href=\"catalog\">&leftarrow;</a><span class=\"text-muted\">Back to shop</span></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n\n\t\t");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-4 summary");
            __builder.AddMarkupContent(50, "<div><h5><b>Summary</b></h5></div>\n\t\t\t<hr>\n\t\t\t");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col");
            __builder.AddAttribute(55, "style", "padding-left:0;");
            __builder.AddContent(56, "ITEMS ");
#nullable restore
#line 57 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
__builder.AddContent(57, basketModel.Items.Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n\t\t\t\t");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col text-right");
            __builder.AddContent(61, "$ ");
#nullable restore
#line 58 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
__builder.AddContent(62, basketModel.Items.Sum(i => i.UnitPrice * i.Quantity));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n\n\t\t\t");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "row");
            __builder.AddAttribute(66, "style", "border-top: 1px solid rgba(0,0,0,.1); padding: 2vh 0;");
            __builder.AddMarkupContent(67, "<div class=\"col\">TOTAL PRICE</div>\n\t\t\t\t");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col text-right");
            __builder.AddContent(70, "$ ");
#nullable restore
#line 63 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
__builder.AddContent(71, basketModel.Items.Sum(i => i.UnitPrice * i.Quantity));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(72, " ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
                                                   ()=>Checkout()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "CHECKOUT");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\BasketPages\Basket.razor"
 
	WebApp.Domain.Models.ViewModels.Basket basketModel = new WebApp.Domain.Models.ViewModels.Basket();

	[Inject]
	IBasketService basketService { get; set; }

	[Inject]
    AppStateManager appState { get; set; }

	[Inject]
	NavigationManager navigationManager { get; set; }

	protected async override Task OnInitializedAsync()
	{
		basketModel = await basketService.GetBasket();
	}

	void Checkout()
	{
		navigationManager.NavigateTo("/create-order");
	}

	async Task RemoveItemFromList(BasketItem item)
	{
		basketModel.Items.Remove(item);
		basketModel = await basketService.UpdateBasket(basketModel);

		appState.UpdateCart(null);
	} 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
