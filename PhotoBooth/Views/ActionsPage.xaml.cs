using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using PhotoBooth.ViewModels;

namespace PhotoBooth.Views
{
    public sealed partial class ActionsPage : Page
    {
        public ActionsViewModel ViewModel { get; }

        public ActionsPage()
        {
            ViewModel = Ioc.Default.GetService<ActionsViewModel>();
            InitializeComponent();
        }
    }
}
