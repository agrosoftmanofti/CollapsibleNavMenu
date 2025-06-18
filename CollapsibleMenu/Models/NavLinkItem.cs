namespace CollapsibleNavMenu.Models
{
    public class NavLinkItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string IconClass { get; set; }

        // Optional: Role-based access control
        public List<string> Roles { get; set; } = new();

        public List<NavLinkItem> Children { get; set; } = new();
    }
}
