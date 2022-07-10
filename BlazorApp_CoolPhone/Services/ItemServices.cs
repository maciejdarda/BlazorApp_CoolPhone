using BlazorApp_CoolPhone.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp_CoolPhone.Services
{
    public class ItemServices : IItemServices
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public ItemServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<IEnumerable<ItemModel>> GetReports()
        {
            var response = await _httpClient.GetAsync("reports");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var items = JsonSerializer.Deserialize<List<ItemModel>>(content, _options);
            return items;
        }
    }
}
