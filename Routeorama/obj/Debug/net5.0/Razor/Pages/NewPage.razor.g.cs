#pragma checksum "D:\University\SEP3\Routeorama\Routeorama\Pages\NewPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ded245eded330ca43864bda4d0be3dd67a674b"
// <auto-generated/>
#pragma warning disable 1591
namespace Routeorama.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/googlemap")]
    public partial class NewPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"map\" style=\"height: 100vh\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\University\SEP3\Routeorama\Routeorama\Pages\NewPage.razor"
       

    string src = "https://maps.googleapis.com/maps/api/js?key=AIzaSyAh258uXALauCLGnfTyJCiU98L0KSPf3Yk&callback=initMap&libraries=&v=weekly";
    // protected override async Task OnInitializedAsync()
    // {
    //     await _runtime.InvokeVoidAsync("initMap");
    // }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
       await _runtime.InvokeVoidAsync("initMap");
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _runtime { get; set; }
    }
}
#pragma warning restore 1591
