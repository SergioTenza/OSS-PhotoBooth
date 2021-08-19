using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using PhotoBooth.ViewModels;

namespace PhotoBooth.Views
{
    public sealed partial class AlbumPage : Page
    {
        public AlbumViewModel ViewModel { get; }

        public AlbumPage()
        {
            ViewModel = Ioc.Default.GetService<AlbumViewModel>();
            InitializeComponent();
        }
    }
}
