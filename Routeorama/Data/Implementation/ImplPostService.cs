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

        public async Task<PostContainer> FetchPosts(int placeId, int postId)
        {
            var posts = new List<Post>();
            client = new HttpClient();

            var contentAsJson = JsonSerializer.Serialize(new[] {placeId, postId});

            var content = new StringContent(
                contentAsJson, Encoding.UTF8, "application/json"
            );

            try
            {
                var response = await client.PostAsync("http://localhost:8080/post/getposts", content);
                var responseContent = await response.Content.ReadAsStringAsync();
                var returnedPost = JsonSerializer.Deserialize<PostContainer>(responseContent,
                    new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });

                if (returnedPost != null)
                {
                    return returnedPost;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;
        }
        public async Task<bool> DeletePost(int postID)
        {
            client = new HttpClient();

            string postAsJsonID = JsonSerializer.Serialize(postID);

            StringContent content = new StringContent(
            postAsJsonID, Encoding.UTF8, "application/json"
            );

            HttpResponseMessage responseMessage =
                await client.PostAsync("http://localhost:8080/post/delete", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();
            Boolean returnedPostResponse = JsonSerializer.Deserialize<Boolean>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return returnedPostResponse;
        }
    }
}