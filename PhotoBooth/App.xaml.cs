using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;

using PhotoBooth.Activation;
using PhotoBooth.Contracts.Services;
using PhotoBooth.Core.Contracts.Services;
using PhotoBooth.Core.Services;
using PhotoBooth.Helpers;
using PhotoBooth.Services;
using PhotoBooth.ViewModels;
using PhotoBooth.Views;

// To learn more about WinUI3, see: https://docs.microsoft.com/windows/apps/winui/winui3/.
namespace PhotoBooth
{
    public partial class App : Application
    {
        public static Window MainWindow { get; set; } = new Window() { Title = "AppDisplayName".GetLocalized() };

        public App()
        {
            InitializeComponent();
            UnhandledException += App_UnhandledException;
            Ioc.Default.ConfigureServices(ConfigureServices());
        }

        private void App_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // TODO WTS: Please log and handle the exception as appropriate to your scenario
            // For more info see https://docs.microsoft.com/windows/winui/api/microsoft.ui.xaml.unhandledexceptioneventargs
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);
            var activationService = Ioc.Default.GetService<IActivationService>();
            await activationService.ActivateAsync(args);
        }

        private System.IServiceProvider ConfigureServices()
        {
            // TODO WTS: Register your services, viewmodels and pages here
            var services = new ServiceCollection();

            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Other Activation Handlers

            // Services
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddTransient<IWebViewService, WebViewService>();
            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Core Services
            services.AddSingleton<ISampleDataService, SampleDataService>();

            // Views and ViewModels
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainPage>();
            services.AddTransient<JuegosViewModel>();
            services.AddTransient<JuegosPage>();
            services.AddTransient<ActionsViewModel>();
            services.AddTransient<ActionsPage>();
            services.AddTransient<ActionsDetailViewModel>();
            services.AddTransient<ActionsDetailPage>();
            services.AddTransient<UserOptionsViewModel>();
            services.AddTransient<UserOptionsPage>();
            services.AddTransient<ShootAndCountViewModel>();
            services.AddTransient<ShootAndCountPage>();
            services.AddTransient<VideoMessageViewModel>();
            services.AddTransient<VideoMessagePage>();
            services.AddTransient<AlbumViewModel>();
            services.AddTransient<AlbumPage>();
            services.AddTransient<AlbumDetailViewModel>();
            services.AddTransient<AlbumDetailPage>();
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<SettingsPage>();
            return services.BuildServiceProvider();
        }
    }
}
