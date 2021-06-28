#pragma checksum "D:\Projects\FumariProject\FumariProject\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f76231accdcf85b246aef6dbb4da148e7bde13b"
// <auto-generated/>
#pragma warning disable 1591
namespace FumariProject.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using FumariProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using FumariProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\FumariProject\FumariProject\_Imports.razor"
using FumariProject.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\FumariProject\FumariProject\Shared\MainLayout.razor"
using FumariProject.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\FumariProject\FumariProject\Shared\MainLayout.razor"
using FumariProject.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-6sxweaup5p");
            __builder.OpenComponent<FumariProject.Pages.Confirm>(3);
            __builder.AddComponentReferenceCapture(4, (__value) => {
#nullable restore
#line 9 "D:\Projects\FumariProject\FumariProject\Shared\MainLayout.razor"
                                       YOConfirm = (FumariProject.Pages.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddAttribute(8, "b-6sxweaup5p");
            __builder.OpenElement(9, "nav");
            __builder.AddAttribute(10, "class", "d-flex navbar_fumari justify-content-around");
            __builder.AddAttribute(11, "b-6sxweaup5p");
            __builder.AddMarkupContent(12, "<a class=\"navbar-brand pl-5\" href=\"#\" b-6sxweaup5p><img width=\"50\" height=\"50\" src=\"/Images/fumarilogo.jpg\" b-6sxweaup5p></a>\r\n            ");
            __builder.AddMarkupContent(13, @"<div class=""navbar_links flex-fill d-flex justify-content-center align-items-center"" b-6sxweaup5p><a href=""#"" b-6sxweaup5p>Главная</a>
                <a href=""#"" b-6sxweaup5p>Связаться с нами</a>
                <a href=""#"" b-6sxweaup5p>Магазин</a>
                <a href=""#"" b-6sxweaup5p>Линейки</a></div>
            ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "/cart");
            __builder.AddAttribute(16, "class", "btn btn-info");
            __builder.AddAttribute(17, "b-6sxweaup5p");
            __builder.AddMarkupContent(18, "<i class=\"oi oi-cart\" b-6sxweaup5p></i>\r\n                Cart\r\n                ");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "class", "badge badge-pill badge-light");
            __builder.AddAttribute(21, "b-6sxweaup5p");
            __builder.AddContent(22, 
#nullable restore
#line 31 "D:\Projects\FumariProject\FumariProject\Shared\MainLayout.razor"
                                                            productCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        \r\n\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "merch");
            __builder.AddAttribute(26, "b-6sxweaup5p");
            __builder.AddContent(27, 
#nullable restore
#line 37 "D:\Projects\FumariProject\FumariProject\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(29);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Projects\FumariProject\FumariProject\Shared\MainLayout.razor"
      
    protected ConfirmBase YOConfirm { get; set; }
    int productCount = 0;

    private async Task<int> GetProductCount()
    {
        var cart = await LocalStorage.GetItemAsync<List<MerchModel>>("cart");
        return cart != null ? cart.Count : 0;
    }

    protected override void OnInitialized()
    {
        CartService.OnChange += StateHasChanged;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        productCount = await GetProductCount();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
