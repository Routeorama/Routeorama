#pragma checksum "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae2e2c7d2897a6e76b62b0a173fc98b164925ab"
// <auto-generated/>
#pragma warning disable 1591
namespace Routeorama.Pages.Auth
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
#line 19 "D:\University\SEP3\Routeorama\Routeorama\_Imports.razor"
using Routeorama.Shared.Components.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Routeorama.Shared.Components.Nav.Nav>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "profile");
            __builder.AddAttribute(4, "b-gtde9d145a");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "profile-card");
            __builder.AddAttribute(7, "b-gtde9d145a");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "profile-card-up");
            __builder.AddAttribute(10, "b-gtde9d145a");
#nullable restore
#line 12 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
             if (_currentUser.profilePicture != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "profile-image");
            __builder.AddAttribute(13, "style", "background-image:" + " url(" + (
#nullable restore
#line 14 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                                          "data:" + _currentUser.imageType + ";base64," + Convert.ToBase64String(_currentUser.profilePicture)

#line default
#line hidden
#nullable disable
            ) + ")" + " ");
            __builder.AddAttribute(14, "b-gtde9d145a");
            __builder.AddMarkupContent(15, "<label for=\"profile-update\" b-gtde9d145a><div class=\"profile-image-inner\" b-gtde9d145a><img alt src=\"icons/image.svg\" b-gtde9d145a></div></label>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(16);
            __builder.AddAttribute(17, "id", "profile-update");
            __builder.AddAttribute(18, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 20 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                              OnFileSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "profile-image");
            __builder.AddAttribute(21, "style", "background-image: url(\'data:image/jpeg;base64,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\')");
            __builder.AddAttribute(22, "b-gtde9d145a");
            __builder.AddMarkupContent(23, "<label for=\"profile-update\" b-gtde9d145a><div class=\"profile-image-inner\" b-gtde9d145a><img alt src=\"icons/image.svg\" b-gtde9d145a></div></label>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(24);
            __builder.AddAttribute(25, "id", "profile-update");
            __builder.AddAttribute(26, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 31 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                              OnFileSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 33 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "profile-owner");
            __builder.AddAttribute(29, "b-gtde9d145a");
            __builder.AddContent(30, 
#nullable restore
#line 35 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                 _currentUser.displayName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "profile-data");
            __builder.AddAttribute(34, "b-gtde9d145a");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "profile-data-group");
            __builder.AddAttribute(37, "b-gtde9d145a");
            __builder.AddMarkupContent(38, "<img alt src=\"icons/user.svg\" b-gtde9d145a>\r\n                    ");
            __builder.AddContent(39, 
#nullable restore
#line 40 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                     _currentUser.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "profile-data-group");
            __builder.AddAttribute(43, "b-gtde9d145a");
            __builder.AddMarkupContent(44, "<img alt src=\"icons/envelope.svg\" b-gtde9d145a>\r\n                    ");
            __builder.AddContent(45, 
#nullable restore
#line 44 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                     _currentUser.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "profile-data-group");
            __builder.AddAttribute(49, "b-gtde9d145a");
            __builder.AddMarkupContent(50, "<img alt src=\"icons/birthday-cake.svg\" b-gtde9d145a>\r\n                    ");
            __builder.AddContent(51, 
#nullable restore
#line 48 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                     _currentUser.dob

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "profile-card-down");
            __builder.AddAttribute(55, "b-gtde9d145a");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "profile-edit-button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                       OpenModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "b-gtde9d145a");
            __builder.AddMarkupContent(60, "\r\n                Edit\r\n                <img alt src=\"icons/edit.svg\" b-gtde9d145a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "profile-edit-modal" + " " + (
#nullable restore
#line 60 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                _open

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "b-gtde9d145a");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "profile-edit-modal-inner");
            __builder.AddAttribute(67, "b-gtde9d145a");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "profile-edit-modal-top");
            __builder.AddAttribute(70, "b-gtde9d145a");
            __builder.AddMarkupContent(71, "<div class=\"profile-edit-modal-title\" b-gtde9d145a>\r\n                Edit profile\r\n            </div>\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "profile-edit-close-button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                             CloseModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "b-gtde9d145a");
            __builder.AddMarkupContent(76, "<img alt width=\"16\" height=\"16\" src=\"icons/close.svg\" b-gtde9d145a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "profile-edit-modal-group");
            __builder.AddAttribute(80, "b-gtde9d145a");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "profile-edit-modal-input");
            __builder.AddAttribute(83, "b-gtde9d145a");
            __builder.AddMarkupContent(84, "<div b-gtde9d145a>\r\n                    Username\r\n                </div>\r\n                ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "id", "username");
            __builder.AddAttribute(88, "placeholder", "New username..");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                                                           _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(91, "b-gtde9d145a");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "profile-edit-modal-input");
            __builder.AddAttribute(95, "b-gtde9d145a");
            __builder.AddMarkupContent(96, "<div b-gtde9d145a>\r\n                    Display name\r\n                </div>\r\n                ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "text");
            __builder.AddAttribute(99, "id", "display-name");
            __builder.AddAttribute(100, "placeholder", "New display name..");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                                                                   _displayName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _displayName = __value, _displayName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(103, "b-gtde9d145a");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "profile-edit-modal-input");
            __builder.AddAttribute(107, "b-gtde9d145a");
            __builder.AddMarkupContent(108, "<div b-gtde9d145a>\r\n                    Email\r\n                </div>\r\n                ");
            __builder.OpenElement(109, "input");
            __builder.AddAttribute(110, "type", "text");
            __builder.AddAttribute(111, "id", "email");
            __builder.AddAttribute(112, "placeholder", "New email..");
            __builder.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                                                     _email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _email = __value, _email));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(115, "b-gtde9d145a");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "profile-edit-modal-input");
            __builder.AddAttribute(119, "b-gtde9d145a");
            __builder.AddMarkupContent(120, "<div b-gtde9d145a>\r\n                    Password\r\n                </div>\r\n                ");
            __builder.OpenElement(121, "input");
            __builder.AddAttribute(122, "type", "password");
            __builder.AddAttribute(123, "id", "password");
            __builder.AddAttribute(124, "placeholder", "New password..");
            __builder.AddAttribute(125, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                                                               _password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(127, "b-gtde9d145a");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n            ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "profile-edit-modal-input");
            __builder.AddAttribute(131, "b-gtde9d145a");
            __builder.AddMarkupContent(132, "<div b-gtde9d145a>\r\n                    Date of birth\r\n                </div>\r\n                ");
            __Blazor.Routeorama.Pages.Auth.Profile.TypeInference.CreateRadzenDatePicker_0(__builder, 133, 134, "d", 135, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 99 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                                              args => OnChange(args, "DatePicker", "MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            ), 136, 
#nullable restore
#line 99 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                               _value

#line default
#line hidden
#nullable disable
            , 137, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _value = __value, _value)), 138, () => _value);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n        ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "profile-edit-modal-actions");
            __builder.AddAttribute(142, "b-gtde9d145a");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "profile-save-changes");
            __builder.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                        SaveChanges

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(146, "b-gtde9d145a");
            __builder.AddMarkupContent(147, "\r\n                Save\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n            ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "profile-cancel-changes");
            __builder.AddAttribute(151, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
                                                          CloseModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "b-gtde9d145a");
            __builder.AddMarkupContent(153, "\r\n                Cancel\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Profile.razor"
       
    private User _currentUser;
    private string _username;
    private string _password;
    private string _email;
    private string _displayName;
    private string _dateOfBirth;
    private DateTime? _value = DateTime.Now;
    private byte[] _byteArray = {};
    private string _imageType = "";
    private string _open = ".";
    private bool _isModalOpen = false;

    protected override void OnInitialized()
    {
        _currentUser = ((CustomAuthenticationStateProvider) _provider).GetUser();
    }

    private void OnChange(DateTime? args, string datepicker, string mmDdYyyy)
    {
        if (_value != null) _dateOfBirth = _value.Value.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
    }

    private async void OnFileSelection(InputFileChangeEventArgs e)
    {
        var imgFile = e.File;
        _imageType = imgFile.ContentType;
        var buffers = new byte[imgFile.Size];
        await imgFile.OpenReadStream(512000000, new CancellationToken(default)).ReadAsync(buffers);
        _byteArray = buffers;
    }

    private void OpenModal()
    {
        if (_isModalOpen) return;
        _open = "open";
        _isModalOpen = true;
    }

    private void CloseModal()
    {
        if(!_isModalOpen) return;
        _open = ".";
        _isModalOpen = false;
    }

    private async void SaveChanges()
    {
        CloseModal();
        var user = new User()
        {
            displayName = _displayName,
            dob = _dateOfBirth,
            email = _email,
            imageType = _imageType,
            password = _password,
            profilePicture = _byteArray,
            role = RoleEnum.user,
            UserId = ((CustomAuthenticationStateProvider) _provider).GetUserId(),
            username = _username
        };
        await ((CustomAuthenticationStateProvider) _provider).UpdateUser(user);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _provider { get; set; }
    }
}
namespace __Blazor.Routeorama.Pages.Auth.Profile
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Change", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
