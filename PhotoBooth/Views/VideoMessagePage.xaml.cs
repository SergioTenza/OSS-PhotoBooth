using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using PhotoBooth.ViewModels;

namespace PhotoBooth.Views
{
    public sealed partial class VideoMessagePage : Page
    {
        public VideoMessageViewModel ViewModel { get; }

        public VideoMessagePage()
        {
            ViewModel = Ioc.Default.GetService<VideoMessageViewModel>();
            InitializeComponent();
        }
    }
}
