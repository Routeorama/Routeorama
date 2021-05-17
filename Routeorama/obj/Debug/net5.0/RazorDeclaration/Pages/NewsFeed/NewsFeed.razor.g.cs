// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Routeorama.Pages.NewsFeed
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
#line 17 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Pages\NewsFeed\NewsFeed.razor"
using Routeorama.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Pages\NewsFeed\NewsFeed.razor"
using Routeorama.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Pages\NewsFeed\NewsFeed.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Pages\NewsFeed\NewsFeed.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewsFeed")]
    public partial class NewsFeed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Pages\NewsFeed\NewsFeed.razor"
       
    private IList<Post>? fetchedPosts = new List<Post>();
    private IList<Post>? _filteredPosts = new List<Post>();
    
    private int userId;
    private string _errorLabel = "";
    
    protected override async Task OnInitializedAsync(){
        try
        {
            userId = ((CustomAuthenticationStateProvider) _provider).GetUserId();
            /* If we want to have location for the user in his/her area
                try
                {
                    await _runtime.InvokeVoidAsync("fetchWeather", _place.location.lat, _place.location.lng);
                }
                catch (NullReferenceException e)
                {
                    _errorLabel = "Could not fetch the weather.";
                }
            */
           
            PostContainer container = await _postService.GetPostsForNewsFeed(userId);
            
            if (container != null)
            {
                fetchedPosts = container.posts;
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
        _filteredPosts = fetchedPosts;
    }
    
    private async Task FetchMorePosts()
    {
        PostContainer container = null;
        if (_filteredPosts == null)
        {
            container = await _postService.LoadMorePostsForNewsFeed(userId, 0);
        }
        else
        {
            container = await _postService.LoadMorePostsForNewsFeed(userId, _filteredPosts.Last().postId);
        }
        if (container.posts != null)
        {
            foreach (var post in container.posts)
            {
                _filteredPosts?.Add(post);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostService _postService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _runtime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlaceService _placeService { get; set; }
    }
}
#pragma warning restore 1591
