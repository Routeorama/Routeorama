using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
                Console.WriteLine("Could not fetch posts " + e);
            }

            return null;
        }

        public async Task<bool> DeletePost(int postId)
        {
            client = new HttpClient();

            string postAsJsonId = JsonSerializer.Serialize(postId);

            StringContent content = new StringContent(
                postAsJsonId, Encoding.UTF8, "application/json"
            );

            HttpResponseMessage responseMessage =
                await client.PostAsync("http://localhost:8080/post/delete", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();
            Boolean returnedPostResponse = JsonSerializer.Deserialize<Boolean>(responseContent,
                new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            return returnedPostResponse;
        }

        public async Task<bool> GetLikeState(int postId, int userId)
        {
            client = new HttpClient();
            var responseMessage = new HttpResponseMessage();
            try
            {
                responseMessage = await client.GetAsync($"http://localhost:8080/post/likes/{postId}%20{userId}");
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }
            var responseContent = await responseMessage.Content.ReadAsStringAsync();
            var state = false;
            try
            {
                state = JsonSerializer.Deserialize<bool>(responseContent, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }

            return state;
        }

        public async Task<bool> LikePost(int postId, int userId)
        {
            client = new HttpClient();
            var array = new[] {postId, userId};

            var body = new StringContent(JsonSerializer.Serialize(array), Encoding.UTF8, "application/json");

            var responseMessage = new HttpResponseMessage();
            try
            {
                responseMessage = await client.PostAsync("http://localhost:8080/post/like", body);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }

            var content = await responseMessage.Content.ReadAsStringAsync();

            var likeState = false;
            try
            {
                likeState = JsonSerializer.Deserialize<bool>(content, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }
            
            return likeState;
        }
    }
}