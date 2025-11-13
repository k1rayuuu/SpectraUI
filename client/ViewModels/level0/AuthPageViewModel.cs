using SpectraUI.Views;
using SpectraUI.Views.level0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
