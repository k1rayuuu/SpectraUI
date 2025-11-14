
namespace SpectraUI.ViewModels.level0
{
    public class SettingsPageViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public DelegateCommand GoBackCommand { get; set; }

        public SettingsPageViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            GoBackCommand = new DelegateCommand(GoBack);
        }

        private void GoBack()
        {
            _regionManager.Regions["ContentRegion"].NavigationService.Journal.GoBack();
        }
    }
}
