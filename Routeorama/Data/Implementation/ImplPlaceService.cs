using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Routeorama.Models;

namespace Routeorama.Data.Implementation
{
    public class ImplPlaceService : IPlaceService
    {
        private HttpClient _client;
        private string _placeName;

        public void SetPlaceName(string placeName)
        {
            this._placeName = placeName;
        }

        public async Task<Place> CreateNewPlace(Place place)
        {
            _client = new HttpClient();

            var placeAsJson = JsonSerializer.Serialize(place);

            var content = new StringContent(
                placeAsJson, Encoding.UTF8, "application/json"
            );

            var responseMessage = await _client.PostAsync("http://localhost:8080/auth/place", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();

            var finalPlace = JsonSerializer.Deserialize<Place>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (finalPlace == null) throw new Exception("Creating new place went wrong");
            return finalPlace;
        }
        
        public async Task<Place> FetchPlaceData()
        {
            _client = new HttpClient();

            var responseMessage =
                await _client.GetAsync($"http://localhost:8080/auth/place/{_placeName}");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();

            var finalPlace = JsonSerializer.Deserialize<Place>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (finalPlace == null) throw new Exception("Fetching place went wrong");
            return finalPlace;
        }

        public async Task<Place> FetchPlaceData(string name)
        {
            _client = new HttpClient();

            var responseMessage = await _client.GetAsync($"http://localhost:8080/auth/place/{name}");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();

            var finalPlace = JsonSerializer.Deserialize<Place>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (finalPlace == null) throw new Exception("Fetching place went wrong");
            _placeName = name;
            return finalPlace;
        }

        public async Task<List<Place>> GetPlacesInBounds(List<double> bounds)
        {
            _client = new HttpClient();

            var placeAsJson = JsonSerializer.Serialize(bounds);

            var content = new StringContent(
                placeAsJson, Encoding.UTF8, "application/json"
            );

            var responseMessage =
                await _client.PostAsync("http://localhost:8080/auth/place/bounds", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();

            var finalPlace = JsonSerializer.Deserialize<List<Place>>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (finalPlace == null) throw new Exception("Fetching bounded places did not work");
            return finalPlace;
        }

        public async Task FollowPlace(int placeId, int userId, bool action)
        {
            _client = new HttpClient();
            var array = new[] {placeId, userId};
            var body = new StringContent(JsonSerializer.Serialize(array), Encoding.UTF8, "application/json");

            if (action)
            {
                try
                {
                    await _client.PostAsync("http://localhost:8080/auth/place/follow", body);
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
                    await _client.PostAsync("http://localhost:8080/auth/place/unfollow", body);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            
        }

        public async Task<bool> GetFollowState(int placeId, int userId)
        {
            _client = new HttpClient();
            var responseMessage = new HttpResponseMessage();

            var array = new[] {placeId, userId};
            var body = new StringContent(JsonSerializer.Serialize(array), Encoding.UTF8, "application/json");
            
            try
            {
                responseMessage =
                    await _client.PostAsync($"http://localhost:8080/auth/place/isfollowed", body);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            var content = await responseMessage.Content.ReadAsStringAsync();
            var success = false;
            try
            {
                success = JsonSerializer.Deserialize<bool>(content, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return success;
        }
        public async Task<List<string>> GetMostFollowedPlaces()
        {
            _client = new HttpClient();

            var responseMessage = await _client.GetAsync("http://localhost:8080/auth/place/getmostfollowed");
            
            
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();

            var mostFollowed = JsonSerializer.Deserialize<List<string>>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (mostFollowed == null) throw new Exception("Fetching mot followed places went wrong");
            
            return mostFollowed;
        }
        public async Task<List<string>> GetMostLikedPlaces()
        {
            _client = new HttpClient();

            var responseMessage = await _client.GetAsync($"http://localhost:8080/auth/place/getmostliked");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            var responseContent = await responseMessage.Content.ReadAsStringAsync();

            var mostLiked = JsonSerializer.Deserialize<List<string>>(responseContent, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (mostLiked == null) throw new Exception("Fetching mot followed places went wrong");
            
            return mostLiked;
        }
        public async Task<List<Place>> SearchForPlaces(string filter)
        {
            _client = new HttpClient();
            var responseMessage = new HttpResponseMessage();

            var body = new StringContent(filter, Encoding.UTF8, "application/json");
            
            try
            {
                responseMessage =
                    await _client.PostAsync($"http://localhost:8080/auth/place/search", body);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            var content = await responseMessage.Content.ReadAsStringAsync();
            List<Place> success = null;
            try
            {
                success = JsonSerializer.Deserialize<List<Place>>(content, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            return success;
        }
    }
}