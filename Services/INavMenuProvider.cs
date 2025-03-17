using CollapsibleNavMenu.Models;

namespace CollapsibleNavMenu.Services
{
    public interface INavMenuProvider
    {
        Task<List<NavLinkItem>> GetNavLinksAsync();
    }
}
