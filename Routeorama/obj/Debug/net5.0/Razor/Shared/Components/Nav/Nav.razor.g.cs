#pragma checksum "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Nav\Nav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f216f3d16366677132fdb2df10ec07520f8e7a95"
// <auto-generated/>
#pragma warning disable 1591
namespace Routeorama.Shared.Components.Nav
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Nav;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Nav\Nav.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
    public partial class Nav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navigation");
            __builder.AddAttribute(2, "b-1xueg0a0iu");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "b-1xueg0a0iu");
            __builder.AddMarkupContent(5, "<li b-1xueg0a0iu><a href=\"/\" b-1xueg0a0iu>Logo</a></li>\r\n        ");
            __builder.AddMarkupContent(6, "<li b-1xueg0a0iu><a b-1xueg0a0iu>Search bar</a></li>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(7);
            __builder.AddAttribute(8, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "li");
                __builder2.AddAttribute(10, "style", "float:right");
                __builder2.AddAttribute(11, "b-1xueg0a0iu");
                __builder2.OpenElement(12, "a");
                __builder2.AddAttribute(13, "href", "/");
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Nav\Nav.razor"
                                          PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "b-1xueg0a0iu");
                __builder2.AddMarkupContent(16, "\r\n                        Log out\r\n                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.AddMarkupContent(18, "<li style=\"float:right\" b-1xueg0a0iu><a href=\"/\" b-1xueg0a0iu>Profile</a></li>\r\n                ");
                __builder2.AddMarkupContent(19, "<li style=\"float:right\" b-1xueg0a0iu><a href=\"/createPlace\" b-1xueg0a0iu>Create a Place</a></li>");
            }
            ));
            __builder.AddAttribute(20, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "<li style=\"float:right\" b-1xueg0a0iu><a href=\"/login\" b-1xueg0a0iu>Login</a></li>\r\n                ");
                __builder2.AddMarkupContent(22, "<li style=\"float:right\" b-1xueg0a0iu><a href=\"/register\" b-1xueg0a0iu>Sign up</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Nav\Nav.razor"
       

    public async Task PerformLogout()
    {
        ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
    }
    private void NavigateToLogin()
    {
        _navigationManager.NavigateTo("/login");
    }
    private void NavigateToRegister()
    {
        _navigationManager.NavigateTo("/register");
    }
    private void NavigateToMain()
    {
        _navigationManager.NavigateTo("/");
    }
    private void CreateAPlace()
    {
        _navigationManager.NavigateTo("/createPlace");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
