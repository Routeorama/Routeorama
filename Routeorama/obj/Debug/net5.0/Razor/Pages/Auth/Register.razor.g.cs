#pragma checksum "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cebeaf0ea20b4addcfcfce6d5bc7a7bc2a2a73"
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
#line 2 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
using Routeorama.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "registercontainer");
            __builder.AddAttribute(2, "b-c1tvx1re69");
            __builder.AddMarkupContent(3, "<h3 b-c1tvx1re69>Register</h3>\r\n\r\n    ");
            __builder.AddMarkupContent(4, "<label class=\"registerlabel\" b-c1tvx1re69>Username</label>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "username-placeholder");
            __builder.AddAttribute(7, "b-c1tvx1re69");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "placeholder", "user name");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                                                                username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(13, "b-c1tvx1re69");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.AddMarkupContent(15, "<label class=\"registerlabel\" b-c1tvx1re69>Email</label>\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "email-placeholder");
            __builder.AddAttribute(18, "b-c1tvx1re69");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "email");
            __builder.AddAttribute(21, "placeholder", "email");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                                                             email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(24, "b-c1tvx1re69");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.AddMarkupContent(26, "<label class=\"registerlabel\" b-c1tvx1re69>Password</label>\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "password-placeholder");
            __builder.AddAttribute(29, "b-c1tvx1re69");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "password");
            __builder.AddAttribute(32, "placeholder", "password");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                                                                   password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(35, "b-c1tvx1re69");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n    ");
            __builder.AddMarkupContent(37, "<label class=\"registerlabel\" b-c1tvx1re69>Repeat Password</label>\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "repeatPassword-placeholder");
            __builder.AddAttribute(40, "b-c1tvx1re69");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "password");
            __builder.AddAttribute(43, "placeholder", "repeat password");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                                                                          repeatPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => repeatPassword = __value, repeatPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(46, "b-c1tvx1re69");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n    ");
            __builder.AddMarkupContent(48, "<label class=\"registerlabel\" b-c1tvx1re69>DisplayName</label>\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "password-placeholder");
            __builder.AddAttribute(51, "b-c1tvx1re69");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "displayName");
            __builder.AddAttribute(54, "placeholder", "displayName");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                                                                         displayName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayName = __value, displayName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(57, "b-c1tvx1re69");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n    ");
            __builder.AddMarkupContent(59, "<label class=\"registerlabel\" b-c1tvx1re69>DOB</label>\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "dob-placeholder");
            __builder.AddAttribute(62, "b-c1tvx1re69");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "dobName");
            __builder.AddAttribute(65, "placeholder", "dobName");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                                                                 dateOfBirth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dateOfBirth = __value, dateOfBirth));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(68, "b-c1tvx1re69");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "button-placeholder");
            __builder.AddAttribute(72, "b-c1tvx1re69");
            __builder.OpenElement(73, "a");
            __builder.AddAttribute(74, "class", "register-button");
            __builder.AddAttribute(75, "href", "/register");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                                                              PerformRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "b-c1tvx1re69");
            __builder.AddMarkupContent(78, "\r\n            Register\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.AddMarkupContent(80, "<a class=\"goBack-button\" href=\"/\" b-c1tvx1re69>\r\n            Go back\r\n        </a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "errorLabel");
            __builder.AddAttribute(84, "b-c1tvx1re69");
            __builder.AddContent(85, 
#nullable restore
#line 48 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
                             errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\University\SEP3\Routeorama\Routeorama\Pages\Auth\Register.razor"
       
    private string username = "";
    private string password = "";
    private string repeatPassword = "";
    private string displayName = "";
    private string dateOfBirth = "";
    private string email = "";
    private string errorMessage = "";

    private async Task PerformRegister()
    {
        errorMessage = "";
        try
        {

            User registerUser = new User
            {
                displayName = displayName, dob = dateOfBirth, password = password, username = username, email = email, role = RoleEnum.user
            };

            if (!password.Equals(repeatPassword))
                throw new Exception("Password´s do not match");
            
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Register(registerUser);

            username = "";
            password = "";
            displayName = "";
            dateOfBirth = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
