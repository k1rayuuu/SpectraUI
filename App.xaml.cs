using Prism.Unity;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;
using SpectraUI.ViewModels;
using SpectraUI.Views;

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

            ViewModelLocationProvider.Register<MainView, MainViewModel>();
            ViewModelLocationProvider.Register<WallpaperView, WallpaperViewModel>();
            ViewModelLocationProvider.Register<TaskBarView, TaskBarViewModel>();
            ViewModelLocationProvider.Register<SoundsView, SoundsViewModel>();
            ViewModelLocationProvider.Register<ShareView, SharePageViewModel>();
            ViewModelLocationProvider.Register<UserPageView, UserPageViewModel>();
        }
    }

}
