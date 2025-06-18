# CollapsibleNavMenu

**CollapsibleNavMenu** is a modular, reusable, and responsive Razor Class Library (RCL) that provides a powerful, dynamic, and role-aware navigation component for Blazor WebAssembly and Blazor Server applications.

> Built for real-world production use, it supports multi-level navigation, JSON-configurable menu structures, role-based filtering, and adaptive behavior for both mobile and desktop users.

---

## 📦 Features

- ✅ Responsive layout (mobile and desktop friendly)
- ✅ Multi-level (nested) navigation with expandable submenus
- ✅ Role-based filtering using `AuthenticationState`
- ✅ JSON-based dynamic menu configuration
- ✅ Smooth slide-in/slide-out sidebar transitions
- ✅ Razor Class Library (RCL) — plug-and-play integration
- ✅ Clean architecture using Dependency Injection
- ✅ Optional admin-editable `navlinks.json` menu file

---

## 🚀 Installation

### Option 1: Via NuGet (Recommended)
```bash
dotnet add package CollapsibleNavMenu
```

### Option 2: Project Reference (for local/private use)
1. Clone or copy the `CollapsibleNavMenu` project folder.
2. Add a reference to your Blazor app:
   - **Right-click solution → Add → Existing Project**
   - **Right-click your Blazor app → Add → Project Reference → CollapsibleNavMenu**

---

## 📁 Project Structure

```
CollapsibleNavMenu/
├── Components/
│   └── CollapsibleNavMenu.razor
│   └── CollapsibleNavMenu.razor.cs
│   └── CollapsibleNavMenu.razor.css
├── Models/
│   └── NavLinkItem.cs
├── Services/
│   └── INavMenuProvider.cs
│   └── JsonNavMenuProvider.cs
│   └── DefaultNavMenuProvider.cs
├── wwwroot/
│   └── config/
│       └── navlinks.json
└── _Imports.razor
```

---

## 🧠 Usage

### 1. **Add the Component**
In your consuming app (e.g., `MainLayout.razor`):

```razor
@using CollapsibleNavMenu.Components

<CollapsibleNavMenu />
```

### 2. **Register the Navigation Provider**
In `Program.cs`:

```csharp
using CollapsibleNavMenu.Services;

builder.Services.AddScoped<INavMenuProvider, JsonNavMenuProvider>();
```

> You can swap `JsonNavMenuProvider` with `DefaultNavMenuProvider` or a custom implementation.

---

## 📄 Sample `navlinks.json`

```json
[
  {
    "title": "Home",
    "url": "/",
    "iconClass": "oi oi-home",
    "roles": []
  },
  {
    "title": "Projects",
    "iconClass": "oi oi-folder",
    "roles": ["User", "Admin"],
    "children": [
      {
        "title": "Corporate",
        "url": "/projects/corporate",
        "iconClass": "oi oi-briefcase"
      },
      {
        "title": "Personal",
        "url": "/projects/personal",
        "iconClass": "oi oi-person"
      }
    ]
  }
]
```

> ✅ Role-based filtering is automatic based on `[CascadingParameter] AuthenticationState`.

---

## 🎮 Demo Application

A sample Blazor WebAssembly project is included in the `ExampleApp` folder. This
app references the library project and shows the `CollapsibleMenuComponent` in
action. After opening the solution, set `ExampleApp` as the startup project and
run the application to explore the navigation menu.

---

## ✨ Responsive Behavior

| Device | Behavior |
|--------|----------|
| Mobile | Sidebar collapses and slides left when a submenu is opened |
| Desktop | Main menu and one submenu visible side-by-side (up to 2 panes) |
| UX Rule | “Home” menu is pinned when there are ≤2 sidebars |

---

## 🔌 Advanced Customization Road Map

- Create your own provider: implement `INavMenuProvider`
- Replace hardcoded nav items with CMS/API-driven content
- Extend `NavLinkItem` with custom metadata (e.g., icons, badges, tags)
- Add breadcrumb trail, nested collapsing, or theming support

---

## 📜 License

MIT License  
© [Evan Knight / Other Gordon Solutions]  
Feel free to use, modify, and distribute with attribution.

---

## 🌐 Repository

> [https://github.com/eodknight23/CollapsibleNavMenu](https://github.com/eodknight23/CollapsibleNavMenu)

---

## 🙌 Contributing

Pull requests and issue reports are welcome! Please follow standard Blazor component best practices and submit tests where applicable.

---

## 📬 Contact

For questions, support, or integration guidance, contact:  
📧 `eodknight23@gmail.com`

