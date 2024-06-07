using System.Text.Json.Nodes;
using System.Text.Json;
using RestSharp;

namespace ShopFrontBackend.Systems
{
    public class FakeStoreAPI
    {
        internal static List<Product> FetchProducts()
        {
            var client = new RestSharp.RestClient("https://fakestoreapi.com/");

            var request = new RestRequest("products");

            var response = client.Execute(request);

            // deserialize json string response to a list of products
            var data = JsonSerializer.Deserialize<List<Product>>(response.Content);

            return data;
        }
    }
}
