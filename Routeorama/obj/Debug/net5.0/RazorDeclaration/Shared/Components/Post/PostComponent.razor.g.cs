// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Routeorama.Shared.Components.Post
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
#line 1 "D:\University\SEP3\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using Routeorama.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\University\SEP3\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using Routeorama.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\University\SEP3\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\University\SEP3\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class PostComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "D:\University\SEP3\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
       

    [Parameter]
    public Post Post { get; set; }

    private bool _likeState = false;
    private string _likedIcon = "like.svg";
    private string _likeText = "Like";
    private string _color = "white";
    private string[] _description = new []{""};

    protected override async Task OnInitializedAsync()
    {
        try
        {
            _likeState = await _postService.GetLikeState(Post.postId, ((CustomAuthenticationStateProvider) _provider).GetUserId());
            Console.WriteLine(_likeState);
            SetLikeState();
            ParseTags(Post.content);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        SetLikeState();
    }

    private void ParseTags(string description)
    {
        // var regex = new Regex(@"#\w+");
        // var matches = regex.Matches(description);
        // foreach (var match in matches)
        // {
        //     description = description.Replace(match.ToString() ?? string.Empty, "<span>" + match + "</span>");
        // }
        // Console.WriteLine(description);
        // _description = description;

        var a = description.Split(' ');
        _description = a;
    }

    async void OnClick(RadzenSplitButtonItem item)
    {
        if (item != null)
        {
            if (int.Parse(item.Value) != 1) return;
            try
            {
                var deletePost = await _postService.DeletePost(Post.postId);
                if (deletePost)
                    _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Post failed to be deleted! " + e);
            }
        }
        else
        {
            Console.WriteLine("Clicked");
        }
    }

    async void Like()
    {
        _likeState = !_likeState;
        SetLikeState();
        var like = await _postService.LikePost(((CustomAuthenticationStateProvider) _provider).GetUserId(), Post.postId);
        _likeState = like;
        SetLikeState();
    }

    void SetLikeState()
    {
        if (_likeState)
        {
            _likedIcon = "liked.svg";
            _color = "dodgerblue";
            _likeText = "Liked";
        }
        else
        {
            _likedIcon = "like.svg";
            _color = "white";
            _likeText = "Like";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostService _postService { get; set; }
    }
}
#pragma warning restore 1591
