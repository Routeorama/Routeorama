using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Routeorama.Data.Implementation
{
    public class ImplFetchData : IFetchData
    {
        //get request
        public async Task<string> FetchLabelData()
        {
            HttpClient client = new HttpClient();

            var responseMessage = await client.GetAsync("localhost:8080/api/test");
            var content = await responseMessage.Content.ReadAsStringAsync();

             string labelText = JsonSerializer.Deserialize<string>(content, new JsonSerializerOptions
                 {
                     PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                 }
             );

            return labelText;
        }
    }
}