#pragma checksum "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4129f0019ac63df5d3e345ec9899b41104d9624"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\TRMO\Rider Projects\DNP\Blazor\Example\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
using Example.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CatsOverview")]
    public class CatsOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>View all cats here</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
 if (cats == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddAttribute(6, "style", "width:700px");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Race</th>\r\n            <th>Image</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 23 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
         foreach (var c in cats)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "width", "33%");
            __builder.AddContent(16, 
#nullable restore
#line 26 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
                                 c.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "width", "33%");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
                                 c.Race

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "width", "33%");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 28 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
                                           c.ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "height", "200");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 30 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 33 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor"
       
    List<Cat> cats { get; set; }

    protected override async Task OnInitializedAsync() {
        Task<List<Cat>> listAsync = catContext.Cats.ToListAsync();
        cats = listAsync.GetAwaiter().GetResult();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Example.DataAccess.CatContext catContext { get; set; }
    }
}
#pragma warning restore 1591