using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

using PhotoBooth.ViewModels;

namespace PhotoBooth.Views
{
    public sealed partial class UserOptionsPage : Page
    {
        public UserOptionsViewModel ViewModel { get; }

        public UserOptionsPage()
        {
            ViewModel = Ioc.Default.GetService<UserOptionsViewModel>();
            InitializeComponent();
        }

        private void OnViewStateChanged(object sender, ListDetailsViewState e)
        {
            if (e == ListDetailsViewState.Both)
            {
                ViewModel.EnsureItemSelected();
            }
        }
    }
}
