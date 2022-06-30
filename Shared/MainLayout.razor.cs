using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace StudentsBlazorApp.Shared
{
    public partial class MainLayout 
    {

        [Inject]
        public ILocalStorageService  localStorage { get; set; }

        bool _drawerOpen = true;

        MudTheme _currentTheme = null;
        MudTheme defaultTheme = new MudTheme()
        {
            Palette = new Palette()
            {
                Black = "#272c34"
            }
        };

        void DarkMode()
        {
            if (_currentTheme == defaultTheme)
            {
                _currentTheme = _darkTheme;
            }
            else
            {
                _currentTheme = defaultTheme;
            }
        }


        protected override void OnInitialized()
        {
            _currentTheme = defaultTheme;
        }
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        MudTheme _darkTheme = new MudTheme()
        {
            Palette = new Palette()
            {
                Black = "#27272f",
                Background = "#32333d",
                BackgroundGrey = "#27272f",
                Surface = "#373740",
                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "rgba(255,255,255, 0.50)",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)"
            }
        };
    }
}
