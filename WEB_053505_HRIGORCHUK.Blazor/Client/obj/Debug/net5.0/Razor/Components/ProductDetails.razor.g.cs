#pragma checksum "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c53855518c0afb60ef0c84674c3ff8d83bac847e"
// <auto-generated/>
#pragma warning disable 1591
namespace WEB_053505_HRIGORCHUK.Blazor.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using WEB_053505_HRIGORCHUK.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using WEB_053505_HRIGORCHUK.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\_Imports.razor"
using WEB_053505_HRIGORCHUK.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor"
 if (Product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "img");
            __builder.AddAttribute(1, "src", 
#nullable restore
#line 3 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor"
               imageSrc

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "img-thumbnail");
            __builder.AddAttribute(3, "width", "150");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "p");
#nullable restore
#line 5 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor"
__builder.AddContent(7, Product.ProductName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, " - ");
#nullable restore
#line 5 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor"
__builder.AddContent(9, Product.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(10, " ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "badge badge-info ");
#nullable restore
#line 5 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor"
__builder.AddContent(13, Product.Price);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, " тугриков");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\1mish\source\repos\WEB_053505_HRIGORCHUK\WEB_053505_HRIGORCHUK.Blazor\Client\Components\ProductDetails.razor"
       
    [Parameter]
    public DetailsViewModel Product { get; set; }
    [Parameter]
    public EventCallback<DetailsViewModel> ProductChanged { get; set; }
    string imageSrc
    {
        get
        {
            return $"images/{Product.Image}";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
