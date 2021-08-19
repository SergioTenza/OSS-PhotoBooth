using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.UI.Xaml.Controls;

using PhotoBooth.ViewModels;

namespace PhotoBooth.Views
{
    // To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/
    public sealed partial class JuegosPage : Page
    {
        public JuegosViewModel ViewModel { get; }

        public JuegosPage()
        {
            ViewModel = Ioc.Default.GetService<JuegosViewModel>();
            InitializeComponent();
            ViewModel.WebViewService.Initialize(webView);
        }
    }
}
