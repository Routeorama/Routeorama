using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Routeorama.Models.Post;

namespace Routeorama.Data.Implementation {
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

            var array = new[] {postId, userId};
            var body = new StringContent(JsonSerializer.Serialize(array), Encoding.UTF8, "application/json");
            
            try
            {
                responseMessage = await client.PostAsync($"http://localhost:8080/post/islikedpost", body);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
                Console.WriteLine(e);
            }

            return state;
        }

        public async Task LikePost(int postId, int userId, bool action)
        {
            client = new HttpClient();
            var array = new[] {postId, userId};
            var body = new StringContent(JsonSerializer.Serialize(array), Encoding.UTF8, "application/json");
            if (action)
            {
                try
                {
                    await client.PostAsync("http://localhost:8080/post/likepost", body);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                try
                {
                    await client.PostAsync("http://localhost:8080/post/unlikethepost", body);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            
        }
        public async Task<PostContainer> GetPostsForNewsFeed(int userId)
        {
            client = new HttpClient();

            var contentAsJson = JsonSerializer.Serialize(userId);

            var content = new StringContent(contentAsJson, Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync("http://localhost:8080/post/getfeed", content);
                var responseContent = await response.Content.ReadAsStringAsync();
                var returnedPost = JsonSerializer.Deserialize<PostContainer>(responseContent, new JsonSerializerOptions
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
                Console.WriteLine("Could not fetch posts for news feed " + e);
            }
            return null;
        }
        public async Task<PostContainer> LoadMorePostsForNewsFeed(int userId, int postId)
        {
            client = new HttpClient();

            var contentAsJson = JsonSerializer.Serialize(new[] {userId, postId});

            var content = new StringContent(contentAsJson, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://localhost:8080/post/loadfeed", content);
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
                Console.WriteLine("Could not load more posts " + e);
            }

            return null;
        }

        public async Task Comment(Comment newComment)
        {
            client = new HttpClient();

            string commentAsJson = JsonSerializer.Serialize(newComment);

            StringContent content = new StringContent(
                commentAsJson, Encoding.UTF8, "application/json"
            );
            HttpResponseMessage responseMessage =
                await client.PostAsync("http://localhost:8080/post/comment", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        public async Task DeleteComment(Comment comment) {
            client = new HttpClient();

            string commentAsJson = JsonSerializer.Serialize(comment);

            StringContent content = new StringContent(
                commentAsJson, Encoding.UTF8, "application/json"
            );
            
            HttpResponseMessage responseMessage =
                await client.PostAsync("http://localhost:8080/post/deletecomment", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        }

        public async Task<CommentContainer> GetCommentsForPost(int postId)
        {
            client = new HttpClient();

            var contentAsJson = JsonSerializer.Serialize(postId);

            var content = new StringContent(contentAsJson, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://localhost:8080/post/getcommentforpost", content);
                var responseContent = await response.Content.ReadAsStringAsync();
                var returnedComments = JsonSerializer.Deserialize<CommentContainer>(responseContent, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                if (returnedComments != null)
                {
                    return returnedComments;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not fetch comments for the post " + e);
            }
            return null;
        }

        public async Task<CommentContainer> LoadMoreComments(int postId, Comment comment)
        {
            client = new HttpClient();
            
            var contentAsJson = JsonSerializer.Serialize(comment);

            var content = new StringContent(contentAsJson, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://localhost:8080/post/loadmorecomments", content);
                var responseContent = await response.Content.ReadAsStringAsync();
                var returnedComments = JsonSerializer.Deserialize<CommentContainer>(responseContent, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                if (returnedComments != null)
                {
                    return returnedComments;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not fetch more comments for the post " + e);
            }
            return null;
        }

        public async Task<int> GetCommentCount(int postId) {
            client = new HttpClient();
            var returnedCount = 0;
            var content = new StringContent(JsonSerializer.Serialize(postId), Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync("http://localhost:8080/post/commentcount", content);
                var responseContent = await response.Content.ReadAsStringAsync();
                returnedCount = JsonSerializer.Deserialize<int>(responseContent, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return returnedCount;
        }
    }
}