#pragma checksum "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Login\LoginPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c200cea843cce7ed8283795619b9062a6c400f1"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages.Login
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
#nullable restore
#line 3 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Login\LoginPage.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LoginPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid h-100");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center align-items-center h-100");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col col-sm-6 col-md-6 col-lg-4 col-xl-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Login\LoginPage.razor"
                              userLoginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Login\LoginPage.razor"
                                                               loginProcess

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n\n                ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-control form-control-lg");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "placeholder", "User Name");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Login\LoginPage.razor"
                                        userLoginRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userLoginRequest.UserName = __value, userLoginRequest.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "class", "form-control form-control-lg");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "placeholder", "Password");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Login\LoginPage.razor"
                                        userLoginRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userLoginRequest.Password = __value, userLoginRequest.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n\n                ");
                __builder2.AddMarkupContent(30, "<div class=\"form-group\"><button class=\"btn btn-info btn-block\">Login</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\MicroService\SellingEA\src\Clients\BlazorWebApp\WebApp\Pages\Login\LoginPage.razor"
       

    [Inject]
    IIdentityService identityService { get; set; }

    [Inject]
    NavigationManager navigationManager { get; set; }

    public UserLoginRequest userLoginRequest = new UserLoginRequest("", "");

    private async Task loginProcess()
    {
        var res = await identityService.Login(userLoginRequest.UserName, userLoginRequest.Password);

        if (res)
        {
            var coll = HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);

            string returnUrl = coll.Get("returnUrl") ?? "/";

            navigationManager.NavigateTo(returnUrl);
        }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
