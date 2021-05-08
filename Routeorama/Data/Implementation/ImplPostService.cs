using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Routeorama.Models.Post;

namespace Routeorama.Data.Implementation
{
    public class ImplPostService : IPostService
    {
        private HttpClient client;

        public async Task<Post> CreateNewPost(Post post)
        {
            client = new HttpClient();

            string postAsJson = JsonSerializer.Serialize(post);

            StringContent content = new StringContent(
                postAsJson, Encoding.UTF8, "application/json"
            );

            HttpResponseMessage responseMessage =
                await client.PostAsync("http://localhost:8080/post/add", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();
            var returnedPost = JsonSerializer.Deserialize<Post>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return returnedPost;
        }

        public async Task<IList<Post>> FetchPosts(int placeId)
        {
            var posts = new List<Post>();
            client = new HttpClient();

            var contentAsJson = JsonSerializer.Serialize(new[] {98, 0});

            var content = new StringContent(
                contentAsJson, Encoding.UTF8, "application/json"
            );

            try
            {
                var response = await client.PostAsync("http://localhost:8080/post/getposts", content);
                var responseContent = await response.Content.ReadAsStringAsync();
                var returnedPost = JsonSerializer.Deserialize<IDictionary<bool, Post>>(responseContent,
                    new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });

                Console.WriteLine(returnedPost);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            // var response = await client.GetAsync($"http://localhost:8080/auth/post/getposts/placeId={placeId}&postId={0}");
            // Console.WriteLine(response.Content.ToString());
            // try
            // {
            //     var responseContent = await response.Content.ReadAsStringAsync();
            //     posts = JsonSerializer.Deserialize<List<Post>>(responseContent,
            //         new JsonSerializerOptions
            //         {
            //             PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            //         });
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            // }

            return posts;
        }
    }
}