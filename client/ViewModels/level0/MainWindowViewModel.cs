using SpectraUI.Views.level0;

namespace SpectraUI.ViewModels.level0
{
    class MainWindowViewModel
    {
        private IRegionManager _regionManager;
        public DelegateCommand NavigateSettingsPageCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateSettingsPageCommand = new DelegateCommand(NavigateSettingsPage);
        }

        private void NavigateSettingsPage()
        {
            var region = _regionManager.Regions["ContentRegion"];
            var navigationService = region.NavigationService;
            navigationService.RequestNavigate(new Uri(nameof(SettingsPageView), UriKind.Relative));
        }
    }
}
