using SpectraUI.Views.level0;

namespace SpectraUI.ViewModels.level0
{
    public class AuthPageViewModel : BindableBase
    {
        private IRegionManager _regionManager;
        public DelegateCommand NavigateMainPageCommand { get; private set; }

        public AuthPageViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateMainPageCommand = new DelegateCommand(NavigateMainPage);
        }

        private void NavigateMainPage()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(MainPageView));
        }
    }
}
