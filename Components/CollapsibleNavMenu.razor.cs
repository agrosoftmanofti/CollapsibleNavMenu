using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using CollapsibleNavMenu.Models;
using CollapsibleNavMenu.Services;

namespace CollapsibleNavMenu.Components
{
    public partial class CollapsibleNavMenu : ComponentBase
    {
        [Inject] 
        public INavMenuProvider NavProvider { get; set; }

        [CascadingParameter] 
        private Task<AuthenticationState> AuthStateTask { get; set; }

        protected List<NavLinkItem> NavLinks { get; set; } = new();
        protected NavLinkItem ActiveSubMenu { get; set; }

        private bool collapseNavMenu = true;
        protected string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        protected void ToggleNavMenu() => collapseNavMenu = !collapseNavMenu;

        protected void ExpandMenu(NavLinkItem parent)
        {
            ActiveSubMenu = parent;
        }

        protected void BackToParent()
        {
            ActiveSubMenu = null;
        }

        protected override async Task OnInitializedAsync()
        {
            var allLinks = await NavProvider.GetNavLinksAsync();
            var authState = await AuthStateTask;
            var user = authState.User;

            NavLinks = allLinks
                .Where(link =>
                    link.Roles == null || link.Roles.Count == 0 ||
                    link.Roles.Any(role => user.IsInRole(role)))
                .ToList();
        }
    }
}
