using Prism.Unity;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;
using SpectraUI.Views;
using SpectraUI.ViewModels.level1;
using SpectraUI.ViewModels.level0;
using SpectraUI.Views.level0;

namespace SpectraUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
            containerRegistry.RegisterForNavigation<MainPageView>();
            containerRegistry.RegisterForNavigation<AuthPageView>();
            containerRegistry.RegisterForNavigation<SettingsPageView>();

            containerRegistry.RegisterForNavigation<MainView>();
            containerRegistry.RegisterForNavigation<WallpaperView>();
            containerRegistry.RegisterForNavigation<TaskBarView>();
            containerRegistry.RegisterForNavigation<SoundsView>();
            containerRegistry.RegisterForNavigation<ShareView>();
            containerRegistry.RegisterForNavigation<UserPageView>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<MainPageView, MainPageViewModel>();
            ViewModelLocationProvider.Register<AuthPageView, AuthPageViewModel>();
            ViewModelLocationProvider.Register<SettingsPageView, SettingsPageViewModel>();

            ViewModelLocationProvider.Register<MainView, MainViewModel>();
            ViewModelLocationProvider.Register<WallpaperView, WallpaperViewModel>();
            ViewModelLocationProvider.Register<TaskBarView, TaskBarViewModel>();
            ViewModelLocationProvider.Register<SoundsView, SoundsViewModel>();
            ViewModelLocationProvider.Register<ShareView, SharePageViewModel>();
            ViewModelLocationProvider.Register<UserPageView, UserPageViewModel>();
        }
    }

}
