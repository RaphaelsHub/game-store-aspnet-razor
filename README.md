# 🎮 Game Store – ASP.NET Razor Pages

An educational project to understand how ASP.NET Razor Pages work and how frontend interacts with backend logic.

## ⚙️ Technologies
- **Backend**: ASP.NET Razor Pages (.NET)
- **Frontend**: HTML, CSS, JavaScript (template-based)
- **Storage**: In-memory (no database)

## 🚀 Getting Started
1. Clone: `git clone https://github.com/RaphaelsHub/game-store-aspnet-razor.git`
2. Restore packages: `dotnet restore`
3. Run: `dotnet run`

## 🔄 Razor Page Interactions
- Use `method="get"` or `method="post"` in forms
- Navigate between pages using `asp-page="/PageName"`
- Pass parameters via route: `asp-route-id="123"`
- Trigger handlers with: `asp-page-handler="Submit"`  
  → Calls `OnPostSubmit()` or `OnGetSubmit()` in `PageModel`

This project demonstrates key concepts of Razor Pages — routing, data passing, and method handling — without a database.
