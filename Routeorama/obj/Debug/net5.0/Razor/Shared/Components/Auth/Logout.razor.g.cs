#pragma checksum "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Auth\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17dfceb80f16841f4a96049d956e0dfccd4a9b2d"
// <auto-generated/>
#pragma warning disable 1591
namespace Routeorama.Shared.Components.Auth
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
#line 16 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Auth\Logout.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", "");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Auth\Logout.razor"
                     PerformLogout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    Log out\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Auth\Logout.razor"
       
    public async Task PerformLogout()
    {
        ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
