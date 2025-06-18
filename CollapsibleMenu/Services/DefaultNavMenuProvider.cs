using CollapsibleNavMenu.Models;

namespace CollapsibleNavMenu.Services
{
    public class DefaultNavMenuProvider : INavMenuProvider
    {
        public Task<List<NavLinkItem>> GetNavLinksAsync()
        {
            var links = new List<NavLinkItem>
            {
                new NavLinkItem { Title = "Home", Url = "/", IconClass = "oi oi-home" },
                new NavLinkItem { Title = "Dashboard", Url = "/dashboard", IconClass = "oi oi-dashboard", Roles = new() { "Admin" } },
                new NavLinkItem { Title = "Settings", Url = "/settings", IconClass = "oi oi-cog", Roles = new() { "Admin", "User" } }
            };

            return Task.FromResult(links);
        }
    }
}
