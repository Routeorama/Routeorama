using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Routeorama.Models;

namespace Routeorama.Data.Implementation
{
    public class ImplUserService : IUserService
    {
        private User user;
        private HttpClient client;
        
        public async Task<User> ValidateLogin(string username, string password) {
            client = new HttpClient();

            User user = new()
            {
                username = username,
                password = password
            };

            string userAsJson = JsonSerializer.Serialize(user);

            StringContent content = new StringContent(
                userAsJson, Encoding.UTF8, "application/json"
            );
            
            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8080/auth/login", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            
            string responseContent = await responseMessage.Content.ReadAsStringAsync();
          

            User finalUser = JsonSerializer.Deserialize<User>(responseContent, new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase, Converters = {new JsonStringEnumConverter()}
            });
            
            if (finalUser == null) throw new Exception("Wrong credentials.");
            
            return finalUser;
        }

        public async Task<bool> Register(User user)
        {
            client = new HttpClient();

            string userAsJson = JsonSerializer.Serialize(user);

            StringContent content = new StringContent(
                userAsJson, Encoding.UTF8, "application/json"
            );
            
            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8080/auth/register", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            
            string responseContent = await responseMessage.Content.ReadAsStringAsync();

            bool finalUser = JsonSerializer.Deserialize<bool>(responseContent, new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            if (!finalUser) throw new Exception("Could not register the user.");
            
            return finalUser;
        }

        //TODO again do we need it?
        public async void Logout() {
            client = new HttpClient();
            StringContent content = new StringContent(
                "logout", Encoding.UTF8, "application/json"
            );

            HttpResponseMessage responseMessage = await client.PostAsync("Fill in URL", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            
            string responseContent = await responseMessage.Content.ReadAsStringAsync();
        }
    }
}