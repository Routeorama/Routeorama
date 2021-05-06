using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Routeorama.Models.Post;

namespace Routeorama.Data.Implementation {
    public class ImplPostService : IPostService{

        private HttpClient client;
        public async Task CreateNewPost(Post post)
        {
            client = new HttpClient();

            string postAsJson = JsonSerializer.Serialize(post);

            StringContent content = new StringContent(
            postAsJson, Encoding.UTF8, "application/json"
            );
            
            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8080/auth/channel/post", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }
    }
}