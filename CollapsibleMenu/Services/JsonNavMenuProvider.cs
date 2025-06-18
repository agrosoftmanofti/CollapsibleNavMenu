using CollapsibleNavMenu.Models;
using System.Net.Http.Json;

namespace CollapsibleNavMenu.Services
{
    public class JsonNavMenuProvider : INavMenuProvider
    {
        private readonly HttpClient _http;

        public JsonNavMenuProvider(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<NavLinkItem>> GetNavLinksAsync()
        {
            try
            {
                var links = await _http.GetFromJsonAsync<List<NavLinkItem>>("config/navlinks.json");
                return links ?? new List<NavLinkItem>();
            }
            catch
            {
                return new List<NavLinkItem>();
            }
        }
    }
}
