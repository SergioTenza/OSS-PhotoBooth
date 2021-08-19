using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using PhotoBooth.ViewModels;

namespace PhotoBooth.Views
{
    public sealed partial class ShootAndCountPage : Page
    {
        public ShootAndCountViewModel ViewModel { get; }

        public ShootAndCountPage()
        {
            ViewModel = Ioc.Default.GetService<ShootAndCountViewModel>();
            InitializeComponent();
        }
    }
}
