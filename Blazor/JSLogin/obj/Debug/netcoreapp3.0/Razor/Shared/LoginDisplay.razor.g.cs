#pragma checksum "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093916bb3d6f3f30fbb8c5408ac9e72a1d9b8652"
// <auto-generated/>
#pragma warning disable 1591
namespace JSLogin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using JSLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\_Imports.razor"
using JSLogin.Shared;

#line default
#line hidden
#nullable disable
    public class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        \r\n        ");
                __builder2.OpenElement(3, "a");
                __builder2.AddAttribute(4, "href", "manage");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 6 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\Shared\LoginDisplay.razor"
                                 context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "button");
                __builder2.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\Shared\LoginDisplay.razor"
                          Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "class", "nav-link btn btn-link");
                __builder2.AddContent(11, "Log out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n    ");
            }
            ));
            __builder.AddAttribute(13, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.AddMarkupContent(15, "<a href=\"register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(16, "<a href=\"login\">Login</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\TRMO\Rider Projects\DNP\Blazor\JSLogin\Shared\LoginDisplay.razor"
       
    public async Task Logout() {
        Console.WriteLine("Logout here");
        var interop = new Interop(jsRuntime);
        string antiforgerytoken = await interop.GetElementByName("__RequestVerificationToken");
        
        // Here I provide fields matching the arguments of my logout method, i.e. none. Could have a returnURL
        // see the example downloadable from here:
        // https://www.oqtane.org/Resources/Blog/PostId/527/exploring-authentication-in-blazor?fbclid=IwAR0rbQkY47cHHxs29HWCk0RggH7GHeLDx3kJ4vwmgUGMTsFU3hxpsQ9ybZo
        var fields = new {__RequestVerificationToken = antiforgerytoken};
        await interop.SubmitForm("/logoutRequester/", fields);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
