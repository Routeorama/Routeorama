// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Routeorama.Pages.Channel
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#nullable restore
#line 15 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Nav;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\University\SEP3\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using Routeorama.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\University\SEP3\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using Routeorama.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\University\SEP3\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\University\SEP3\Routeorama\Routeorama\Pages\Channel\Channel.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\University\SEP3\Routeorama\Routeorama\Pages\Channel\Channel.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "D:\University\SEP3\Routeorama\Routeorama\Pages\Channel\Channel.razor"
       
    [CascadingParameter] 
    public IModalService Modal { get; set; }
    
    [Parameter] 
    public string PlaceName { get; set; }
    
    private Place _place = new();
    private IList<Post> _posts = new List<Post>();
    private IList<Post>? _filteredPosts = new List<Post>();
    
    private int _authState;
    private string _errorLabel = "";
    private bool _followState;
    private string _followText = "Follow";
    private string _followColor = "#1b6ec2";

    protected override async Task OnInitializedAsync(){
        try
        {
            _authState = ((CustomAuthenticationStateProvider) _provider).GetUserId();
            _place = await _placeService.FetchPlaceData(PlaceName);
            _followState = await _placeService.GetFollowState(_place.id, ((CustomAuthenticationStateProvider) _provider).GetUserId());
            SetFollowState();
            try
            {
                await _runtime.InvokeVoidAsync("fetchWeather", _place.location.lat, _place.location.lng);
            }
            catch (NullReferenceException e)
            {
                _errorLabel = "Could not fetch the weather.";
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
                _filteredPosts?.Add(post);
            }
        }
    }
    
    void ShowCreatePlace(string placeName, int placeId)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(PostPopUp.PlaceName), placeName);
        parameters.Add(nameof(PostPopUp.PlaceId), placeId);

        var options = new ModalOptions() 
        { 
            Animation = ModalAnimation.FadeInOut(0.2),
            DisableBackgroundCancel = true
        };

        Modal.Show<PostPopUp>("Create Place", parameters, options);
    }

    async void FollowPlace()
    {
        _followState = !_followState;
        SetFollowState();
        await _placeService.FollowPlace(_place.id, ((CustomAuthenticationStateProvider) _provider).GetUserId(), _followState);
        StateHasChanged();
    }

    void SetFollowState()
    {
        if (_followState)
        {
            _followText = "Following";
            _followColor = "#ff6d41";
        }
        else
        {
            _followText = "Follow";
            _followColor = "#1b6ec2";
        }
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
