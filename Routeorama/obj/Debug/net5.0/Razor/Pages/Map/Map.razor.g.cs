#pragma checksum "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12880ca4129f3e4d1c6ef90c9f6221f2ea35006"
// <auto-generated/>
#pragma warning disable 1591
namespace Routeorama.Pages.Map
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
#line 2 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
using Routeorama.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createPlace")]
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Routeorama.Shared.Components.Nav.Nav>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "content");
            __builder.AddAttribute(4, "b-aai2lqi8ku");
            __builder.AddMarkupContent(5, "<div id=\"map\" b-aai2lqi8ku></div>\r\n    ");
            __builder.OpenElement(6, "Feed");
            __builder.AddAttribute(7, "b-aai2lqi8ku");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "myModal");
            __builder.AddAttribute(11, "class", "modal");
            __builder.AddAttribute(12, "b-aai2lqi8ku");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-content");
            __builder.AddAttribute(15, "b-aai2lqi8ku");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "exit");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                                     ClearData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "b-aai2lqi8ku");
            __builder.AddContent(20, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "modal-inner-content");
            __builder.AddAttribute(24, "b-aai2lqi8ku");
            __builder.AddMarkupContent(25, "\r\n            Is this information correct?<br b-aai2lqi8ku><br b-aai2lqi8ku>\r\n            Placename:");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "class", "inner-field");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                                                               Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(30, "b-aai2lqi8ku");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "<br b-aai2lqi8ku>\r\n            Description:");
            __builder.OpenElement(32, "textarea");
            __builder.AddAttribute(33, "style", "resize: none");
            __builder.AddAttribute(34, "class", "inner-field");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                                                                                   Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(37, "b-aai2lqi8ku");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "<br b-aai2lqi8ku>\r\n            Coordinates:");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "disabled");
            __builder.AddAttribute(41, "class", "inner-field");
            __builder.AddAttribute(42, "id", "coords");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                                                                                      Coordinates

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Coordinates = __value, Coordinates));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(45, "b-aai2lqi8ku");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "<br b-aai2lqi8ku>\r\n            Country:");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "disabled");
            __builder.AddAttribute(49, "class", "inner-field");
            __builder.AddAttribute(50, "id", "country");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                                                                                   Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Country = __value, Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(53, "b-aai2lqi8ku");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "<br b-aai2lqi8ku>\r\n            City:");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "class", "inner-field");
            __builder.AddAttribute(57, "id", "city");
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                                                                    City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => City = __value, City));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(60, "b-aai2lqi8ku");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "<br b-aai2lqi8ku>\r\n            ");
            __builder.OpenElement(62, "label");
            __builder.AddAttribute(63, "b-aai2lqi8ku");
            __builder.AddContent(64, 
#nullable restore
#line 25 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                    label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "class", "create-place");
            __builder.AddAttribute(68, "id", "create-place-button");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
                                                                        CreateThePlace

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "b-aai2lqi8ku");
            __builder.AddContent(71, "Create place");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Map\Map.razor"
       

    private string Name;
    private string Description;
    private string Coordinates;
    private string Lat;
    private string Lng;
    private string Country;
    private string City;
    private string label;
    private double NELat, NELng, SWLat, SWLng;

    [JSInvokable("invokeFromJS")]
    public Task ChangeValue(double NELat, double NELng, double SWLat, double SWLng)
    {
        this.NELat = NELat;
        this.NELng = NELng;
        this.SWLat = SWLat;
        this.SWLng = SWLng;
        
        StateHasChanged();
        
        makeMarkers();
        
        return Task.CompletedTask;
    }
    
    [JSInvokable("channel")]
    public Task GoToPlace(string name)
    {
        NavigationManager.NavigateTo($"/channel/{name}");
        return Task.CompletedTask;
    }

    private async void makeMarkers()
    {
        List<double> bounds = new List<double>();
        bounds.Add(SWLng);
        bounds.Add(SWLat);
        bounds.Add(NELng);
        bounds.Add(NELat);

        List<Place> places = await PlaceService.GetPlacesInBounds(bounds);
        
        await _runtime.InvokeVoidAsync("clearMarkers");
        
        foreach (Place place in places)
        {
            await _runtime.InvokeVoidAsync("MakeMarker", place.id, place.name, place.description, place.userId, place.followCount,
                place.location.city, place.location.country, place.location.lat, place.location.lng);
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await _runtime.InvokeVoidAsync("initMap");
        await _runtime.InvokeVoidAsync("setWrapper", DotNetObjectReference.Create(this));
    }

    private async Task CreateThePlace(){  
        if (string.IsNullOrEmpty(Description) && string.IsNullOrEmpty(Name))
                 label = ("Fill out the name and description of the place.");

        else if (string.IsNullOrEmpty(Name))
            label = ("Fill out the name of the place.");

        else if (string.IsNullOrEmpty(Description))
            label = ("Fill out the description of the place.");
        
        else
        {
            if (string.IsNullOrEmpty(City))
            {
                City = await _runtime.InvokeAsync<string>("FetchCity");
            }
            if (string.IsNullOrEmpty(Country))
            {
                Country = await _runtime.InvokeAsync<string>("FetchCountry");
            }

            Coordinates = await _runtime.InvokeAsync<string>("FetchCoordinates");

            var coordinates = Coordinates.Split(", ");
            Lat = coordinates[0].TrimStart('(');
            Lng = coordinates[1].TrimEnd(')');
       
            Location location = new Location
            {
                city = City, country = Country, lat = Double.Parse(Lat), lng = Double.Parse(Lng)
            };

            int Id = ((CustomAuthenticationStateProvider) StateProvider).GetUserId();
            Place place = new Place() {
                userId = Id,
                description = Description,
                id = 0,
                location = location,
                name = Name,
                followCount = 0
            };

            try
            {
                await PlaceService.CreateNewPlace(place);
                PlaceService.SetPlaceName(Name);
                await ClearData();
                NavigationManager.NavigateTo("/channel");   
            }
            catch (Exception e)
            {
                label = "Creating the place failed, try again.";
            }
        }
    }

    private async Task ClearData(){
        Name = "";
        Description = "";
        Coordinates = "";
        Country = "";
        City = "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider StateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlaceService PlaceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _runtime { get; set; }
    }
}
#pragma warning restore 1591
