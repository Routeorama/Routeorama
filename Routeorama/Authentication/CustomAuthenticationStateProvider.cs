using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using Routeorama.Data;
using Routeorama.Models;

namespace Routeorama.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime jsRuntime;
        private readonly IUserService userService;

        private User cachedUser;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService)
        {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (cachedUser == null) {
                string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson)) {
                    User tmp = JsonSerializer.Deserialize<User>(userAsJson);
                    ValidateLogin(tmp.username, tmp.password);
                }
                
            }
            else
            {
                identity = SetupClaimsForUser(cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }

        public async Task ValidateLogin(string username, string password)
        {
            Console.WriteLine("Validating log in...");
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password)) throw new Exception("Enter credentials");
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Enter password");

            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                User user = await userService.ValidateLogin(username, password);
                identity = SetupClaimsForUser(user);
                string serialisedData = JsonSerializer.Serialize(user);
                jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                cachedUser = user;
            }
            catch (Exception e)
            {
                throw new Exception("Wrong credentials");
            }
            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }
        public async Task Register(User user)
        {
            Console.WriteLine("Validating register...");
            if (string.IsNullOrEmpty(user.username) && string.IsNullOrEmpty(user.password) && string.IsNullOrEmpty(user.dob) && string.IsNullOrEmpty(user.displayName)) throw new Exception("Enter credentials");
            if (string.IsNullOrEmpty(user.username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(user.password)) throw new Exception("Enter password");
            if (string.IsNullOrEmpty(user.dob)) throw new Exception("Enter date of birth");
            if (string.IsNullOrEmpty(user.displayName)) throw new Exception("Enter display name");
            
            try
            {
                bool response = await userService.Register(user);
                if (!response) throw new Exception("Wrong credentials");
            }
            catch (Exception e)
            {
                throw new Exception("Wrong credentials");
            }
        }

        public void Logout() {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            //TODO logout
            //userService.Logout();
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            
            claims.Add(new Claim(ClaimTypes.Name, user.username));
            //claims.Add(new Claim("BirthYear", user.dob));
            //claims.Add(new Claim("Role", user.role.ToString()));

            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}