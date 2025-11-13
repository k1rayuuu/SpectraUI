using SpectraUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectraUI.ViewModels.level0
{
    public class MainPageViewModel : BindableBase
    {
        private IRegionManager _regionManager;
        public DelegateCommand NavigateHomeCommand { get; private set; }
        public DelegateCommand NavigateWallpaperCommand { get; private set; }
        public DelegateCommand NavigateTaskBarCommand { get; private set; }
        public DelegateCommand NavigateSoundsCommand { get; private set; }
        public DelegateCommand NavigateSharePageCommand { get; private set; }
        public DelegateCommand NavigateUserPageCommand { get; private set; }

        public MainPageViewModel(IRegionManager regionManager)
        { 
            _regionManager = regionManager;
            NavigateHomeCommand = new DelegateCommand(NavigateHome);
            NavigateWallpaperCommand = new DelegateCommand(NavigateWallpaper);
            NavigateTaskBarCommand = new DelegateCommand(NavigateTaskBar);
            NavigateSoundsCommand = new DelegateCommand(NavigateSounds);
            NavigateSharePageCommand = new DelegateCommand(NavigateSharePage);
            NavigateUserPageCommand = new DelegateCommand(NavigateUserPage);
        }

        private void NavigateHome()
        {
            _regionManager.RequestNavigate("InnerContentRegion", nameof(MainView));
        }

        private void NavigateWallpaper()
        {
            _regionManager.RequestNavigate("InnerContentRegion", nameof(WallpaperView));
        }

        private void NavigateTaskBar()
        {
            _regionManager.RequestNavigate("InnerContentRegion", nameof(TaskBarView));
        }

        private void NavigateSounds()
        {
            _regionManager.RequestNavigate("InnerContentRegion", nameof(SoundsView));
        }

        private void NavigateSharePage()
        {
            _regionManager.RequestNavigate("InnerContentRegion", nameof(ShareView));
        }

        private void NavigateUserPage()
        {
            _regionManager.RequestNavigate("InnerContentRegion", nameof(UserPageView));
        }
    }
}
