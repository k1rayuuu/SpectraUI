using SpectraUI.Views.level0;
using System.Windows;
using System.Windows.Input;

namespace SpectraUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRegionManager _regionManager;

        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            _regionManager = regionManager;
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var region = _regionManager.Regions["ContentRegion"];
            var navigationService = region.NavigationService;
            navigationService.RequestNavigate(new Uri(nameof(AuthPageView), UriKind.Relative));
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimiseApp_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
