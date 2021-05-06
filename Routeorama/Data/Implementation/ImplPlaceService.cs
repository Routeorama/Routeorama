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
        private HttpClient client;
        private string placeName;
        
        public void SetPlaceName(string placeName)
        {
            this.placeName = placeName;
        }
        public async Task<Place> CreateNewPlace(Place place)
        {
            client = new HttpClient();

            string placeAsJson = JsonSerializer.Serialize(place);

            StringContent content = new StringContent(
                placeAsJson, Encoding.UTF8, "application/json"
            );
            
            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8080/auth/place", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            
            string responseContent = await responseMessage.Content.ReadAsStringAsync();
            
            Place finalPlace = JsonSerializer.Deserialize<Place>(responseContent, new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            if (finalPlace == null) throw new Exception("Creating new place went wrong");
            return finalPlace;
        }

        
        public async Task<Place> FetchPlaceData()
        {
            client = new HttpClient();
            
            HttpResponseMessage responseMessage = await client.GetAsync($"http://localhost:8080/auth/place/{placeName}");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            
            string responseContent = await responseMessage.Content.ReadAsStringAsync();
            
            Place finalPlace = JsonSerializer.Deserialize<Place>(responseContent, new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (finalPlace == null) throw new Exception("Fetching place went wrong");
            return finalPlace;
        }
        public async Task<List<Place>> getPlacesInBounds(List<double> bounds)
        {
            client = new HttpClient();

            string placeAsJson = JsonSerializer.Serialize(bounds);

            StringContent content = new StringContent(
            placeAsJson, Encoding.UTF8, "application/json"
            );
            
            HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8080/auth/place/bounds", content);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            
            string responseContent = await responseMessage.Content.ReadAsStringAsync();
            
            List<Place> finalPlace = JsonSerializer.Deserialize<List<Place>>(responseContent, new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            if (finalPlace == null) throw new Exception("Fetching bounded places did not work");
            return finalPlace;
        }
    }
}