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
#line 19 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using Routeorama.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using Routeorama.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
#line 146 "C:\Users\karl1\RiderProjects\Routeorama\Routeorama\Shared\Components\Post\PostComponent.razor"
 
    [Parameter]
    public Post Post { get; set; }

    private int cashedUserId;
    private bool _likeState = false;
    private string _likedIcon = "like.svg";
    private string _likeText = "Like";
    private string _color = "#65676b";
    private string[] _description = new[] {""};
    private int _commentCount;

    private bool _commentComponent;
    private string _commentContent;

    private IList<Comment> _fetchedComments = new List<Comment>();
    private IList<Comment> _filteredComments = new List<Comment>();

    private CommentContainer _commentContainer;

    private bool _hasMoreComments;
    private string _errorLabel;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            cashedUserId = ((CustomAuthenticationStateProvider) _provider).GetUserId();
            _likeState = await _postService.GetLikeState(Post.postId, cashedUserId);
            _commentCount = await _postService.GetCommentCount(Post.postId);
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
        var a = description.Split(' ');
        _description = a;
    }

    async void OnClick(RadzenSplitButtonItem item)
    {
        if (item == null) return;
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

    async void Like()
    {
        _likeState = !_likeState;
        SetLikeState();
        await _postService.LikePost(Post.postId, cashedUserId, _likeState);
        StateHasChanged();
    }

    void SetLikeState()
    {
        if (_likeState)
        {
            _likedIcon = "liked.svg";
            _color = "#e57621";
            _likeText = "Liked";
        }
        else
        {
            _likedIcon = "like.svg";
            _color = "#65676b";
            _likeText = "Like";
        }
    }

    private async Task ShowCommentComponent()
    {
        if (_commentComponent)
        {
            _commentComponent = false;
        }
        else
        {
            _commentContainer = await _postService.GetCommentsForPost(Post.postId);
            if (!_commentContainer.Equals(null))
            {
                _fetchedComments = _commentContainer.comments;
                _hasMoreComments = _commentContainer.hasMoreComments;
                Filter();
            }

            _commentComponent = true;
        }
    }

    private void Filter()
    {
        _filteredComments = _fetchedComments;
    }

    private async void Comment()
    {
        Console.WriteLine(_commentContent);
        if (_commentContent.Length == 0)
        {
            _errorLabel = "Comment too short.";
        }
        else
        {
            var newComment = new Comment
            {
                userId = cashedUserId,
                displayName = ((CustomAuthenticationStateProvider) _provider).GetDisplayName(),
                postId = Post.postId,
                content = _commentContent,
                timestamp = null
            };
            await _postService.Comment(newComment);

            _commentContainer = await _postService.GetCommentsForPost(Post.postId);
            if (!_commentContainer.Equals(null))
            {
                _fetchedComments = _commentContainer.comments;
                _hasMoreComments = _commentContainer.hasMoreComments;
                Filter();
            }
            StateHasChanged();
            _commentContent = "";
        }
    }


    private async void DeleteComment(Comment comment)
    {
        await _postService.DeleteComment(comment);
        _commentContainer = await _postService.GetCommentsForPost(Post.postId);
        if (!_commentContainer.Equals(null))
        {
            _fetchedComments = _commentContainer.comments;
            _hasMoreComments = _commentContainer.hasMoreComments;
            Filter();
        }
        StateHasChanged();
    }

    private void OnChange(string args)
    {
        _commentContent = args;
        args = "";
    }

    private async void LoadMoreComments()
    {
        CommentContainer container = null;
        if (_filteredComments == null)
        {
            container = await _postService.LoadMoreComments(Post.postId, null);
        }
        else
        {
            container = await _postService.LoadMoreComments(Post.postId, _filteredComments.Last());
        }
        if (container.comments == null) return;
        foreach (var comment in container.comments)
        {
            _filteredComments?.Add(comment);
        }
        _hasMoreComments = container.hasMoreComments;
        StateHasChanged();
    }

    private void OnComment(ChangeEventArgs obj)
    {
        _commentContent = obj.Value.ToString();
        obj.Value = "";
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
