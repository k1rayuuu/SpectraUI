using SpectraUI.Views.level0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _regionManager.RequestNavigate("ContentRegion", nameof(SettingsPageView));
        }
    }
}
