#pragma checksum "C:\TRMO\Rider Projects\DNP\Blazor\Example\Pages\CatsOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4129f0019ac63df5d3e345ec9899b41104d9624"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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