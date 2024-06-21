using Newtonsoft.Json;
using RestSharp;

namespace ShopFrontBackend.Systems
{
    public class FakeStoreAPI
    {
        public static List<Product> FetchProducts()
        {
            var client = new RestClient("https://fakestoreapi.com/");
            var request = new RestRequest("products");
            var response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                Console.WriteLine($"Error fetching products: {response.ErrorMessage}");
                return null; // Or handle the error as needed
            }

            try
            {
                // Deserialize json string response to a list of products
                var data = JsonConvert.DeserializeObject<List<Product>>(response.Content);
                return data;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing product data: {ex.Message}");
                return null; // Or handle the error as needed
            }
        }
    }
}