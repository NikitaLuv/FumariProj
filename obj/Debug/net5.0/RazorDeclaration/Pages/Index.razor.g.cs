// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FumariProject.Pages
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
#line 2 "D:\Projects\FumariProject\FumariProject\Pages\Index.razor"
using FumariProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\FumariProject\FumariProject\Pages\Index.razor"
using FumariProject.Database;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "D:\Projects\FumariProject\FumariProject\Pages\Index.razor"
      
    //    int count = 0;
    //    IList<MerchModel> merchList = new List<MerchModel>()
    //{
    //        new MerchModel{Flavour = "Арбуз", Price = 350, Image = "/Images/fumarimerch/merch1.jpg"},
    //        new MerchModel{Flavour = "Ананас груша", Price = 350, Image = "/Images/fumarimerch/merch2.jpg"},
    //        new MerchModel{Flavour = "Банана папайа", Price = 350, Image = "/Images/fumarimerch/merch3.jpg"},
    //        new MerchModel{Flavour = "Виноград алоэ", Price = 350, Image = "/Images/fumarimerch/merch4.jpg"},
    //        new MerchModel{Flavour = "Виноградный взрыв", Price = 350, Image = "/Images/fumarimerch/merch5.jpg"},
    //        new MerchModel{Flavour = "Ванильное мороженое с бананом", Price = 350, Image = "/Images/fumarimerch/merch6.jpg"},
    //    };

    private List<Product> GetProducts()
    {
        var dbContext = new FumariProjectDbContext();
        return dbContext.Products.ToList();
    }


    private async Task AddToCart(Product product)
    {

        var merchModel = new MerchModel { Flavour = product.Name, Image = product.ImagePath, Price = 350 };
        await CartService.AddToCart(merchModel);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
