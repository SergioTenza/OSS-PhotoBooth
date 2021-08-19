using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using PhotoBooth.Core.Models;

namespace PhotoBooth.Views
{
    public sealed partial class UserOptionsDetailControl : UserControl
    {
        public SampleOrder ListDetailsMenuItem
        {
            get { return GetValue(ListDetailsMenuItemProperty) as SampleOrder; }
            set { SetValue(ListDetailsMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(UserOptionsDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

        public UserOptionsDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as UserOptionsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
