#pragma checksum "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98e3584d78da16aede621ff157c7fd51ca2e5a9"
// <auto-generated/>
#pragma warning disable 1591
namespace Routeorama.Pages.Channel
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 9 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using Routeorama.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using Routeorama.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/channel/{placeName}")]
    public partial class Channel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Routeorama.Shared.Components.Nav.Nav>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "everything-place");
            __builder.AddAttribute(4, "b-cnnkug9k5o");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "place");
            __builder.AddAttribute(7, "b-cnnkug9k5o");
            __builder.OpenElement(8, "h1");
            __builder.AddAttribute(9, "b-cnnkug9k5o");
            __builder.AddContent(10, 
#nullable restore
#line 19 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
             _place.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "h1");
            __builder.AddAttribute(13, "b-cnnkug9k5o");
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
             _place.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "errorLabel");
            __builder.AddAttribute(18, "b-cnnkug9k5o");
            __builder.AddContent(19, 
#nullable restore
#line 25 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
                             errorLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, @"
    <div class=""location"" id=""location"" b-cnnkug9k5o></div>
    <div class=""weather-description"" id=""description"" b-cnnkug9k5o></div>
    <div class=""degrees"" id=""temp"" b-cnnkug9k5o></div>
    <div class=""feels-like_degrees"" id=""feels_like"" b-cnnkug9k5o></div>
    <div class=""pressure"" id=""pressure"" b-cnnkug9k5o></div>
    <div class=""sunrise"" id=""sunrise"" b-cnnkug9k5o></div>
    <div class=""sunset"" id=""sunset"" b-cnnkug9k5o></div>");
#nullable restore
#line 34 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
     if (_authState != 0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "buttonCreatePlace");
            __builder.AddAttribute(23, "b-cnnkug9k5o");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
                                () => ShowCreatePlace(_place.name, _place.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "b-cnnkug9k5o");
            __builder.AddContent(28, "Create post");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
    }
    else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<div b-cnnkug9k5o>\r\n            Login to post\r\n        </div>");
#nullable restore
#line 43 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "feed");
            __builder.AddAttribute(33, "b-cnnkug9k5o");
#nullable restore
#line 47 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
     if (_filteredPosts != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
         foreach (var post in _filteredPosts)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Routeorama.Shared.Components.Post.PostComponent>(34);
            __builder.AddAttribute(35, "Post", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Routeorama.Models.Post.Post>(
#nullable restore
#line 51 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
                                  post

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 52 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "display: flex;justify-content: center;align-items: center;margin-bottom: 15px");
            __builder.AddAttribute(39, "b-cnnkug9k5o");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "style", "background-color: gray; color: white; cursor:pointer; padding: 15px");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
                                                                                               FetchMorePosts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "b-cnnkug9k5o");
            __builder.AddMarkupContent(44, "\r\n        Load more posts\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Gosia\RiderProjects\Routeorama\Routeorama\Pages\Channel\Channel.razor"
       
    private Place _place = new();
    private IList<Post> _posts = new List<Post>();
    private IList<Post>? _filteredPosts = new List<Post>();

    [CascadingParameter] public IModalService Modal { get; set; }
    [Parameter] public string PlaceName { get; set; }
    private int _authState;
    private string errorLabel = "";



    protected override async Task OnInitializedAsync(){
        try
        {
            _authState = ((CustomAuthenticationStateProvider) _provider).GetUserId();
            _place = await _placeService.FetchPlaceData(PlaceName);
            Console.WriteLine(PlaceName);
            try
            {
                await _runtime.InvokeVoidAsync("fetchWeather", _place.location.lat, _place.location.lng);
            }
            catch (NullReferenceException e)
            {
                errorLabel = "Could not fetch the weather.";
            }
           
            var container = await _postService.FetchPosts(_place.id, 0);
            if (container != null)
            {
                _posts = container.posts;
                Filter();
            }
            
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex);
        }
    }

    private void Filter()
    {
        _filteredPosts = _posts;
    }

    private async Task FetchMorePosts()
    {
        PostContainer container = null;
        if (_filteredPosts == null)
        {
            container = await _postService.FetchPosts(_place.id, 0);
        }
        else
        {
            container = await _postService.FetchPosts(_place.id, _filteredPosts.Last().postId);
        }
        if (container.posts == null)
        {
        }
        else
        {
            foreach (var post in container.posts)
            {
                _filteredPosts.Add(post);
            }
        }
    }
    
    void ShowCreatePlace(string placeName, int placeId)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(PostPopUp.placeName), placeName);
        parameters.Add(nameof(PostPopUp.placeId), placeId);

        var options = new ModalOptions() 
        { 
            Animation = ModalAnimation.FadeInOut(0.2),
            DisableBackgroundCancel = true
        };

        Modal.Show<PostPopUp>("Create Place", parameters, options);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment Environment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostService _postService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _runtime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlaceService _placeService { get; set; }
    }
}
#pragma warning restore 1591
