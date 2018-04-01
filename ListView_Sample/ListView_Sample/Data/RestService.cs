using ListView_Sample.Model;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ListView_Sample.Data
{
    public class RestService : IRestService
    {
        HttpClient client;
        public static string RestUrl = "https://jsonplaceholder.typicode.com/photos";
        public List<Item> Items { get; set; }

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<List<Item>> GetDataAsync()
        {
            Items = new List<Item>();
            //var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            var uri = new Uri(RestUrl);
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Item>>(content);
                    Debug.WriteLine("CONNECTION OK");
                }
            }
            catch (Exception ex) { Debug.WriteLine("CONNECTION ERROR " + ex.Message); }
            return Items;
        }

    }
}
