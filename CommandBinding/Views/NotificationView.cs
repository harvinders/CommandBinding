using BindingCommand.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CommandBinding.Views
{
    public sealed partial class NotificationView : UserControl
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(NotificationViewModel), typeof(NotificationView), new PropertyMetadata(default(NotificationViewModel)));

        public NotificationViewModel ViewModel

        {
            get { return (NotificationViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        public NotificationView()
        {
            this.InitializeComponent();
        }
    }
}
