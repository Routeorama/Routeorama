#pragma checksum "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Shared\Components\Search\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9cccef6697eb3b56ba7340503eccc17f321f930"
// <auto-generated/>
#pragma warning disable 1591
namespace Routeorama.Shared.Components.Search
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Nav;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Shared\Components\Search\Search.razor"
using Routeorama.Data;

#line default
#line hidden
#nullable disable
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenAutoComplete>(0);
            __builder.AddAttribute(1, "Style", "background-color: transparent; padding-top: 5px;");
            __builder.AddAttribute(2, "Placeholder", "Search...");
            __builder.AddAttribute(3, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Shared\Components\Search\Search.razor"
                                                                                                           _places

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "TextProperty", "name");
            __builder.AddAttribute(5, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Shared\Components\Search\Search.razor"
                                                                                                                                                 OnLoadData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Shared\Components\Search\Search.razor"
                                                                                                                                                                     OnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Shared\Components\Search\Search.razor"
       

    private IList<Place> _places = new List<Place>();
    
    private IList<Place> _filteredPlaces = new List<Place>();

    void OnChange(object value)
    {
        foreach (var place in _places)
        {
            if(place.name.Equals(value.ToString()))
            {
                _navigationManager.NavigateTo($"/channel/{value}");
            }
        }
    }

    async void OnLoadData(LoadDataArgs args)
    {
        if (args.Filter is not (null or ""))
        {
            _places = await _placeService.SearchForPlaces(args.Filter);
        }

        if (_places.Count == 0) return;
        _filteredPlaces = _places.Where(c => c.name.Contains(args.Filter) || c.name.Contains(args.Filter)).ToList();

        await InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlaceService _placeService { get; set; }
    }
}
#pragma warning restore 1591
